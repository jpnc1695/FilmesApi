﻿using System.ComponentModel.DataAnnotations;


namespace FilmesApi.Data.Dtos
{
    public class CreateCinemaDto
    {

        [Required(ErrorMessage = "O nome do cinema é obrigatório.")]
        public string Nome { get; set; }
        public int EnderecoId {  get; set; }

    }
}
