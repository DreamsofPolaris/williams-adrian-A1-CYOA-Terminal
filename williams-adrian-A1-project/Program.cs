// Story In
using System.ComponentModel.Design;

Console.WriteLine("Witchcarter: \"Welcome, Ebyss. I am delighted my divine prediction of your arrival was correct." +
    " My name is Serena Witchcarter, and I have summoned you because I require your aid with a daunting task.\"" +
    "\n\n\" I received a scroll from a party of travelling heroes that details their daunting journey and encounter with the wicked Queen Libra." +
    " They unfortunately never returned from their travels...but that's now where you come in!" +
    " Queen Libra is determined to steal all of the magic in Erebus, and I humbly request that you put an end to her tyranny." +
    " My protege, Umbri Wickerton, will accompany you. She will assist you on your journey.\"" +
    "\n\n\"You will go to Erebus Castle, confront Queen Libra and defeat her to bring peace back to Erebus." +
    " I would go myself, but I myself am under Queen Libra's command if she ever comes into contact with me." +
    " You and Umbri are both immune to her power. Only you two can defeat her and save Erebus from her greed for magic." +
    " I have two available routes for you two to take to Erebus Castle. Best of luck, Ebyss. Umbri, keep them safe.\"" +
    "\n\n\n\nUmbri: \"Based on the routes Serena highlighted on this list, we have two quick options to reach the castle." +
    " We can either go through Erebus Mountains, or we can continue straight, through Limbo Town." +
    " I'll leave the choice up to you. You're the almighty reality-creating god here after all.\"");
string playerInput = Console.ReadLine();

if (playerInput == "Erebus Mountains")
{
    Console.WriteLine("Umbri: \"Well that took longer than expected." +
        " We've reached the mountains now. This cliffside path should take us all the way to Erebus Castle. Let's get moving.\"" +
        "\n\n\nSuddenly, a wild bobcat jumps out from the bushes and blocks the path!" +
        "\n\n\nUmbri: \"Just when I thought this would be an easy trip." +
        " Bobcats in Erebus are usually rather tame. It must be Libra's magic at work." +
        " The poor thing. It's being controlled. Libra must have corrupted it to stop us from reaching her. What a vile woman." +
        " Well, I can either put it to sleep with a spell, or we can try to outrun it. What should we do, Ebyss?\"");
    if (playerInput == "Sleep Spell")
    {
        Console.WriteLine("Umbri casts a sleep spell on the bobcat, sending it into a peaceful slumber." +
            " The bobcat begins purring as it sleeps soundly, allowing Ebyss and Umbri to sneak past and continue onward");

    }
}
else if (playerInput == "Limbo Town")
{
    Console.WriteLine("Umbri: \"We've arrived. Welcome to Limbo Town." +
        " I actually grew up here you know." +
        " When Libra invaded with her demonic army, she started draining the magic from any magical being she could find." +
        " And in Erebus, there are plenty of magical creatures. Witches, unicorns, griffins, you name it." +
        " You may have noticed the barrier by now." +
        " Limbo Town is one of the few parts of Erebus that are safe from Libra's prying eyes, and this barrier is why." +
        " It's made with a very advanced cloaking spell, which keeps it hidden from Libra's minions.\"" +
        "\n\n\nSuddenly, a group of demonic soldiers jump out from the alleyways and block the path!" +
        "\n\n\nUmbri: \"Spoke too soon." +
        " If we want to progress, we have to do something about these guys." +
        "I've dealt with Libra's guards before. We can either fight them or we can use this potion to sneak past them." +
        "What do you think we should do? \"");
}

