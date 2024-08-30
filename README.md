# Bonjour Pascal et aux autres intéressés (Bobby, Danielle, etc.),

#### NOTE : Afin de ne pas perdre cette fenêtre lorsque tu cliqueras sur un lien, tu peux appuyer sur Ctrl avant de cliquer. Je pensais qu'en mettant target="_blank" au tag <a>, cela aurait suffi... mais non.

### Voici le GitHub <a href="https://github.com/CharlesNathalie/" target="_blank">https://github.com/CharlesNathalie/</a> où se trouveront plusieurs petits projets qui te guideront dans diverses tâches liées à la production de différents types d'applications (Backend et Frontend).

### Le premier projet est PascalTraining, qui est tout simplement une application Blazor Web App, combinant une application web avec Frontend et un serveur Backend.

### Cette application sera disponible en tout temps et deviendra de plus en plus complète au fur et à mesure que j'aurai le temps et l'énergie de l'améliorer. Voici l'adresse web : <a href="https://pascaltraining.azurewebsites.net/" target="_blank">https://pascaltraining.azurewebsites.net/</a>. Pour accéder au code sauvegardé sur GitHub et consulter les ressources utilisées dans Azure, il faudra que je t'y donne accès une fois que tu t'es enregistré sur GitHub et Azure, comme expliqué plus en détail ci-dessous.

### Mon objectif avec tout cela est que mes connaissances ne disparaissent pas sans que quelqu'un en profite. Au début, tu trouveras peut-être qu'il y a beaucoup d'informations qui semblent compliquées. Mais il s'agit simplement d'apprendre le vocabulaire, et tout deviendra compréhensible et facile à suivre. De mon côté, j'ai tout le temps nécessaire, sachant qu'il y aura des moments où je ne serai pas très efficace, étant donné ma condition. Mais, j'encourage Bobby et Danielle à t'aider dans ta démarche. Il se peut qu'ils soient en mesure de contribuer à cette application et de faire en sorte qu'elle devienne une référence pour tous les participants au projet.

### L'objectif principal est d'utiliser le développement d'applications de divers genres pour apprendre plus rapidement et davantage sur des sujets qui ne te seraient pas présentés autrement. L'apprentissage est plus rapide et permanent en travaillant sur des projets un peu simples mais bien réels. Le but n'est pas de vouloir vendre le produit final, mais plutôt de s'amuser en apprenant.

## Voici quatre projets qui pourraient t'intéresser

### Boulette — âge cible : 12-99 ans

#### Ce projet se jouerait comme le jeu de boulette en papier. Ce site web et/ou application permettrait simplement d'entrer le nom des équipes (2 ou plus) et de recevoir les mots de chaque personne participante. Ces mots seraient ensuite utilisés pour les afficher, soit après un petit calcul simple ou autre chose. Il faudra décider de plusieurs aspects comme : est-ce que ça se joue sur un seul téléphone ou chacun avec son propre téléphone, etc.

### CalculoMath --- âge cible : 8-14 ans

#### Une reproduction de l’application de calcul rapide utilisée lorsque les enfants étaient plus jeunes : addition, soustraction, multiplication et division, avec sauvegarde des temps, nombre de calculs, bonnes et mauvaises réponses. Il faudra également décider de plusieurs aspects ici, comme les paramètres, et choisir entre une version desktop, mobile, ou les deux etc.

### BrainSpeed --- âge cible : 12-99 ans

#### Une application qui poserait des questions sur différents pays et provinces, couvrant divers sujets (culture, musique, histoire, politique, etc.) avec des choix multiples. L’utilisateur répondrait aussi rapidement que possible, et l’application enregistrerait le temps, ainsi que les bonnes et mauvaises réponses. Cette application pourrait ressembler à des outils comme Duolingo, que ta mère utilise pour apprendre l'espagnol, ou à d'autres applications que je n'ai peut-être pas vues, mais dont vous êtes au courant. L'important ici est de sauvegarder les performances des utilisateurs afin qu'ils puissent se comparer avec d'autres personnes de leur âge, sexe, région, etc. J'ai déjà effectué quelques tests pour vérifier si ChatGPT-4 pourrait générer tout ce dont nous avons besoin pour formuler des questions, créer plusieurs choix multiples avec une bonne réponse, et oui, c'est possible.

### HVACApp — ciblée pour employés et employeurs HVAC

#### Une application destinée aux employés et employeurs du secteur HVAC. L'objectif de cette application serait de permettre aux techniciens de ne pas avoir à écrire un seul mot lors de leur travail. Le développement de cette application serait un bon exercice pour apprendre à développer une application en utilisant tous les outils d'intelligence artificielle (IA) possibles, pour se familiariser avec les nouvelles technologies IA et comprendre comment créer des applications avec cette technologie qui sera omniprésente dans les années à venir.

#### Les squelettes de ces projets seront créés prochainement et sauvegardés sur GitHub en tant que projets privés, utilisant des applications Blazor et des bases de données sur Azure. Le seul projet qui sera public est celui-ci, qui sera développé au fur et à mesure de notre progression.

### Cela dit, il y a des outils de base dont tu vas avoir besoin pour pouvoir consulter les projets et participer à leur développement.

1. Crée-toi un compte GitHub (gratuit) <a href="https://github.com/" target="_blank">https://github.com/</a>. Il y a un bouton en haut à droite (sign up). Suis simplement les instructions.

2. Crée-toi un compte Azure (gratuit) <a href="https://portal.azure.com/" target="_blank">https://portal.azure.com/</a>. Ils te demanderont de créer un compte directement, car il est impossible d'accéder à ce portail sans avoir un compte. Tu peux aussi commencer par le site <a href="https://azure.com/">https://azure.com/</a>, où tu trouveras un bouton (Sign in) qui te dirigera vers une page de connexion ou de création de compte.

3. Installe Microsoft Visual Studio 2022 Community (gratuit) <a href="https://visualstudio.microsoft.com/downloads/" target="_blank">https://visualstudio.microsoft.com/downloads/</a). Clique sur le bouton "Free Download" sous Community. Ici, je pars du principe que Danielle t'a déjà fait installer VS Code, qui peut accomplir tout ce que je vais te présenter en termes d'utilisation et d'information avec VS 2022. Je laisse Danielle te montrer VS Code; moi, je vais me concentrer sur VS 2022. Pour certaines tâches, il est préférable d'utiliser VS Code, et pour d'autres, VS 2022. Par exemple, ce document a été produit en utilisant VS Code, qui est mieux adapté pour la production de documents de type (.md).

4. Installe Microsoft SQL Server Management Studio (SSMS) (gratuit et optionnel) <a href="https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16" target="_blank">https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16</a>. Fais défiler la page vers le bas et tu verras "Download SSMS". Le téléchargement se trouve directement en dessous.

5. GitHub Copilot ($10 / mois). Une fois que tu as installé VS 2022, tu devrais voir GitHub Copilot en haut à droite. Tu auras des options en cliquant dessus. N'essaie pas de faire sans cet outil. Tu apprendras beaucoup plus vite avec cet outil en lui posant des questions sur comment faire certaines choses et en lui demandant d'expliquer ce qui se passe dans le code. De plus, il peut t'aider à trouver certains bugs et te suggérer comment les corriger. Il peut aussi écrire la majorité de ton code une fois que tu sais comment lui demander exactement ce que tu veux sous forme de texte.

6. ChatGPT, version gratuite ou à $20 / mois pour cinq fois plus de requêtes <a href="https://openai.com">https://openai.com</a>. Clique sur ChatGPT, puis sur "Start now", et enfin sur "Stay logged out". Tu verras la version mini de ChatGPT 4, qui peut être utilisée, mais sans sauvegarde des discussions. Pour avoir une version plus avancée qui sauvegardera tes discussions, il faudra créer un compte et choisir la version complète de ChatGPT 4. La version mini pourrait te suffire pour l'instant. Il n'y a pas d'urgence.


