using AutoMapper;
using desafioKw.Data;
using desafioKw.Dtos;
using desafioKw.Models;
using Microsoft.AspNetCore.Mvc;

namespace desafioKw.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public TarefaController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost]
        public IActionResult AdicionarCard([FromBody] CartaoDto cartaoDto)
        {
            Cartao cartao = _mapper.Map<Cartao>(cartaoDto);
            _context.cartoes.Add(cartao);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaCartaoPorId), new { Id = cartao.Id }, cartao);
        }


        [HttpGet]
        public IEnumerable<Cartao> RecuperarCartoes()
        {
            return _context.cartoes;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaCartaoPorId(int id)
        {
            Cartao cartao = _context.cartoes.FirstOrDefault(cartao => cartao.Id == id);
            if (cartao != null)
            {
                return Ok(cartao);
            }
            return NotFound();
        }

        [HttpGet("{posicaoVertical}/{posicaoHorizontal}")]
        public IEnumerable<Cartao> RecuperaCartaoPorColunaAndPosicao(int posicaoVertical, int posicaoHorizontal)
        {
            List<Cartao> cartoes = _context.cartoes.Where(cartao => cartao.posicaoVertical.Equals(posicaoVertical)).ToList();
            return cartoes.Where(cartao => cartao.posicaoHorizontal.Equals(posicaoHorizontal)).ToList();
        }

    }
}
