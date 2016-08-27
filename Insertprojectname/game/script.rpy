# You can place the script of your game in this file.

# Declare images below this line, using the image statement.
# eg. image eileen happy = "eileen_happy.png"
#everything after the word image is the name you will use in the script to call this image,you can call it whatever you want
#if you are testing art assets,make sure they are in the game or their respective folder before declaring them here
#you don't need to declare music and can call it at anytime with play,same for sound effect,just make sure they are in the game folder



# Declare characters used by this game.
#Color use HEX color code to be called,here is the color table if you need:https://en.wikipedia.org/wiki/List_of_colors:_A%E2%80%93F
#to add a char use define whateverletteryouwanthere = Character('Name',color="#whatevercode")
#to make the char talk during the game,simply put the letter you use and "text"
define e = Character('Eileen', color="#c8ffc8")
define n = Character('Noevain', color="#c8ffc8")


# The game starts here.
#if you are here to test to change the background use scene backgrounddeclaredname
#if you want to test characters art use show characterimagename
#by default they are centered,to change that simply add at place after the show function
#example:show lmao at left
#will show a picture called lmao but instead of it being at the center it will be at the left of the screen
#renpy come with a tutorial if you want to learn how to do other stuff,but what is taught in those comments should be enough
#to test your assets in-game
label start:

    e "You've created a new Ren'Py game."

    e "Once you add a story, pictures, and music, you can release it to the world!"
    n "Ayy lmao"

    return
