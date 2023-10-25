Episodio ep1 = new(2, "Teste11", 45);
ep1.AdicionarConvidados("Madu");
ep1.AdicionarConvidados("Cadu");
ep1.AdicionarConvidados("Livia");

Episodio ep2 = new(1, "Teste22", 67);
ep2.AdicionarConvidados("Carlos");
ep2.AdicionarConvidados("Matheus");
ep2.AdicionarConvidados("Roberto");

Podcast podcast = new("Podcast especial", "Edu");
podcast.AdicionarEpisodios(ep1);
podcast.AdicionarEpisodios(ep2);
podcast.ExibirDetalhes();