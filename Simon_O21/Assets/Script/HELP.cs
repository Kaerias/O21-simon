/*
Ce document vous servira de bible pour ce tuto :


Tutoriel :

premièrement voud devrez créer votre plateaux de jeux de VOTRE Simon
	il sera constituer de 4 GameObjet de couleurs reposant sur socle.
	Rajouter sur GameObjet servant de bouton de couleur le composent : "Light", désactive-le mais activer sa case "Draw Halo".
je compte sur votre imagination pour la construction.
(pour créer des objet 3D sur Unity, faites clic droit sur votre "Hierarchy" et "objet3D"

puis créer un "Canvas" constituer de 2 boutons et 1 texte.
(pareille, clic droit sur votre "Hierarchy" puis choisissez -> UI) 

Après avoir fait votre plateaux de jeu, commençons la partie intéressante
	Vous devez réparer les différents script (désolé, le stagiaire les a cassé) pour pouvoir réaliser votre but ultime, jouer a votre jeu.
	Pour cela vous devrez utiliser les différentes aide ci-dessous.

Vous touchez au but maintenant,
	dernière étape : remplir les cases.
	mettez les quatre "Script" : EndGame, LightController, Player et Timer sur un GameObject Vide !! et appellais le "GameBoard".
	le Script Button sur tout vos buttons de couleurs.
	maintenant vous pouvez remarquer que dans votre "Hierarchy" certaines cases dans vos objets sont vident et attendent d'être remplient par différents "GameObject" ou "Script"
	Remplisez-les.

Normalement si tout ce passe bien votre jeu devrais fonctionner maintenant.

vous devez savoir diverse choses avant de commencer

vous allez utiliser 2 types de variables :
	- le "int" -> représentant un nombre;
	- le "bool" -> Variable pouvant prendre 2 états : true, false;

valeurs par défaut :
	- pour le "int" ça valeur par défaut sera 0;
	- pour le "bool" ça valeur par défaut sera false;

Opérateur pour les conditions :
	- = -> le égale
	- == -> permet de comparaître 2 variables de même type
	- <= -> inférieur ou égale
	- >= -> supérieure ou égale
	- != -> différent de

opérateur de "liaison"
	- && -> correspond au ET, permet de dire "si ma première condition ET (&&) ma deuxième sont juste)
	- || -> correspond au OU, permet de dire "si ma première condition OU (||) ma deuxième sont juste)

les Conditions :
	- le "for" -> prototype for(ma variable + initialisation; condition; augmenter ma variable créé)
	- le "if" -> prototype if (variable opérateurs variable)
	- le "while" -> prototype while (variable opérateur variable)

Prototype d'une Fonction :
	- type NomDeLaFonction(arguments) { }

Appelle d'une Fonction :
	- NomDeLaFonction(arguments);

pour activer un composant : .enable = bool;

pour chercher un composant : GetComponent<NomDucComposent>();

pour réalisez de l'aléatoire :
	- Random.Range(variableMin, VariableMax);

pour changer un texte :
	- text.text = "Votre Text";
 */