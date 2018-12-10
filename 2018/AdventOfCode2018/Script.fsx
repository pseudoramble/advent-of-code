#load "Day01.fs"
#load "Day02.fs"
#load "Day03.fs"
#load "Day04.fs"
#load "Logger.fs"

open System.IO
open AdventOfCode2018
open AdventOfCode2018.Day01
open AdventOfCode2018.Day02
open AdventOfCode2018.Day03
open AdventOfCode2018.Day04

let dayOne () =
  let logger = new LoggingBuilder("Day One\n-------------")

  logger {
    let! freq = frequency [| -12; -6; -12; 1; 3; 3; -1; 10; -8; -9; -11; -2; -7; 15; 16; 14; -2; -5; 11; -8; -5; -1; -19; -14; 6; -16; -8; -13; -19; -11; 3; -19; 3; -19; 9; -15; -11; 18; -9; 13; -17; -16; -13; -16; 19; 17; -18; -8; -5; 6; 9; 8; -7; -8; 2; -9; 2; -9; -5; -3; 4; -13; -5; 11; 14; 5; 17; -1; 9; 6; 14; -9; 4; -3; -13; -5; 13; -2; -10; -18; -12; 4; 13; -10; -11; -10; -17; -13; 12; -19; -7; -13; 5; -8; -11; 5; 7; 17; -14; 22; 14; 7; -8; 7; -19; 14; -20; 16; 12; 3; 5; 1; -8; 1; 15; 3; -6; -8; 9; 3; -19; -19; -19; 1; -16; -13; 5; -13; 2; -15; -15; -4; 12; 1; -10; -5; -11; -9; -11; -7; 10; -18; 16; -12; -19; -17; -18; 2; 15; 11; 9; -17; 4; 9; -18; -6; -1; -1; -18; -15; -18; -7; 16; 18; 18; -2; -4; 1; 15; 16; 18; 7; -18; 6; 8; 15; -8; -16; -3; 11; 9; 1; 4; -18; 3; -16; -14; -18; -10; 6; -12; -12; -2; -8; 1; -3; -11; 1; -5; -4; -5; 8; 8; -4; -10; 16; -1; 3; 9; 6; 24; 12; -2; 11; -1; -9; 21; -15; 12; 19; -3; 21; 20; 16; -4; 15; 9; 13; -16; 13; -1; -16; 13; 19; 14; 19; 14; -17; 18; 1; 11; 18; 18; 22; -8; 18; -1; 19; -11; -20; 11; 8; -11; 25; 13; 3; -1; -3; 17; 15; 7; 19; -7; 19; -1; -12; -14; 17; -15; -1; -18; 9; 14; -19; 10; -9; -11; 7; 20; 20; -1; 19; 1; 7; -19; -15; 3; 1; 17; 11; -7; 15; -7; -10; 13; -24; -21; -4; -4; -14; 6; 3; -25; 9; -7; 15; 12; 14; 20; -11; -11; -15; -14; -9; -2; -2; -3; -1; -18; -2; 6; 17; 9; -1; 18; 20; 21; 27; -17; -11; -4; -18; 24; 33; 4; 12; 8; 8; -1; -17; 6; -18; 16; 4; 1; 6; -1; -11; 18; 15; 17; -4; 13; 1; -20; 18; 3; -16; -4; -12; -10; 8; -18; 22; 21; 12; 1; 6; -24; 7; 1; 11; 14; 20; -5; -2; 4; 9; -20; 60; 15; 18; 14; -19; 13; 3; 7; 8; 5; -14; -13; 20; 5; -1; -15; 29; 14; -19; 7; -10; 13; 3; -7; -2; -19; 8; -15; -13; -13; -1; -9; -14; 10; -9; 18; -3; -12; -7; 21; 2; 7; 7; 10; -15; -16; -6; -8; -18; 11; 13; 7; 10; -14; -14; 17; 22; 23; 15; -4; 32; 7; -5; -3; -10; -14; 9; 12; 10; -12; 17; 1; -19; 16; 14; -2; 1; -7; 17; 16; -8; -15; 18; 19; 14; 52; 8; -22; -2; -2; 13; 6; -4; 2; 20; -14; -73; 119; 20; 26; 4; 9; 14; -42; -18; 44; 18; -23; 77; -11; 15; 52; 29; -7; -11; 31; -29; 5; -20; 435; 15; -156; 71279; -19; -2; 11; -4; -1; -15; 8; 14; 19; -16; -13; 19; 3; -7; -1; -12; -15; -14; -2; 14; 8; -1; -1; -7; -2; -4; -8; -8; 7; 10; -14; -2; -13; -1; 8; -14; -9; 1; 17; -11; -13; 10; 9; 17; -18; -1; 10; -7; 11; -3; 10; 1; 8; -7; 26; 17; -16; -12; 22; -16; 9; -17; -7; 3; 13; -18; 8; 6; 15; 19; 7; 7; -18; 15; 14; 3; 10; -3; 2; 8; 9; -6; 10; 1; 15; -3; -11; 5; -8; -15; 11; -3; -19; -15; -10; 12; -8; 7; 2; 8; 3; -18; 3; -2; -5; -7; 21; 4; -6; 1; 3; 15; -16; 24; 15; -16; -2; -11; 10; -11; 17; 15; 8; 11; 21; 5; 12; 13; -15; -16; -14; 2; -11; 14; -13; 12; -17; 6; -13; 9; -1; 20; -18; -18; -21; -6; 21; 13; -12; -15; -5; 39; 20; 13; 6; -1; 12; 1; -3; 14; -5; -3; 17; 12; -13; 18; 16; -12; -16; -9; 5; -7; -1; -17; -4; -8; 5; -13; 9; -19; 15; 13; -19; -15; -2; 14; -2; -8; 2; 15; -5; -13; 19; 21; 3; 11; -17; 12; 17; 19; -16; 17; 5; -10; 13; 3; -8; 18; -8; -9; -11; 5; -11; -10; -19; 7; -3; -7; -11; 26; -10; 16; 13; -10; 5; 7; -16; 22; -9; -6; 40; -13; 7; -9; 20; 7; 8; -6; 3; -10; -14; 10; -2; 15; -3; 2; 17; 4; 3; 13; 15; -8; 16; 9; -10; 7; 4; 9; -4; 1; -13; -1; 10; -19; 20; -8; -9; -6; -15; -8; 11; 17; 9; -7; -17; -7; 9; 4; -7; 6; 9; -13; -5; -8; 6; -2; -16; 10; -15; 7; 4; 3; -2; 6; -14; -12; -10; 11; -10; 2; -15; -6; 8; -6; -4; 22; -6; 17; 8; 6; -8; -4; -21; -7; 2; 9; -26; -6; 5; -20; -38; -4; -45; -15; 14; -3; -12; 22; 12; -15; 29; -95; -15; -3; 1; -31; -22; -17; -7; -15; -5; 2; -3; 15; 12; -5; -10; 1; 7; -6; 17; 2; 2; -19; -7; 15; -6; -7; -1; 7; -12; -6; -18; -14; 6; -4; -16; -13; 5; -13; 4; 16; -8; 13; 11; -2; -7; -5; -8; 1; 9; 6; -2; 19; -4; 5; 10; 2; -9; 10; -15; 7; 11; 6; -14; -11; -6; 3; -16; -19; -6; -3; -3; -11; 19; 16; -10; 14; 15; 2; 15; 21; 15; 7; 19; 2; 52; 13; 24; -32; -126; -18; 1; -17; -14; -14; 3; -19; -17; 13; 17; -20; -1; 17; 2; 14; -7; -8; 12; -1; -14; 1; 26; -14; -17; 3; -17; 13; -3; 5; -7; 20; -2; 24; 20; -13; -19; -22; -19; 12; 35; 5; 34; 8; 2; 11; -2; -1; 13; -9; -7; -2; -28; -33; -71491 |]
    let! repeatFreq = repeat [| -12; -6; -12; 1; 3; 3; -1; 10; -8; -9; -11; -2; -7; 15; 16; 14; -2; -5; 11; -8; -5; -1; -19; -14; 6; -16; -8; -13; -19; -11; 3; -19; 3; -19; 9; -15; -11; 18; -9; 13; -17; -16; -13; -16; 19; 17; -18; -8; -5; 6; 9; 8; -7; -8; 2; -9; 2; -9; -5; -3; 4; -13; -5; 11; 14; 5; 17; -1; 9; 6; 14; -9; 4; -3; -13; -5; 13; -2; -10; -18; -12; 4; 13; -10; -11; -10; -17; -13; 12; -19; -7; -13; 5; -8; -11; 5; 7; 17; -14; 22; 14; 7; -8; 7; -19; 14; -20; 16; 12; 3; 5; 1; -8; 1; 15; 3; -6; -8; 9; 3; -19; -19; -19; 1; -16; -13; 5; -13; 2; -15; -15; -4; 12; 1; -10; -5; -11; -9; -11; -7; 10; -18; 16; -12; -19; -17; -18; 2; 15; 11; 9; -17; 4; 9; -18; -6; -1; -1; -18; -15; -18; -7; 16; 18; 18; -2; -4; 1; 15; 16; 18; 7; -18; 6; 8; 15; -8; -16; -3; 11; 9; 1; 4; -18; 3; -16; -14; -18; -10; 6; -12; -12; -2; -8; 1; -3; -11; 1; -5; -4; -5; 8; 8; -4; -10; 16; -1; 3; 9; 6; 24; 12; -2; 11; -1; -9; 21; -15; 12; 19; -3; 21; 20; 16; -4; 15; 9; 13; -16; 13; -1; -16; 13; 19; 14; 19; 14; -17; 18; 1; 11; 18; 18; 22; -8; 18; -1; 19; -11; -20; 11; 8; -11; 25; 13; 3; -1; -3; 17; 15; 7; 19; -7; 19; -1; -12; -14; 17; -15; -1; -18; 9; 14; -19; 10; -9; -11; 7; 20; 20; -1; 19; 1; 7; -19; -15; 3; 1; 17; 11; -7; 15; -7; -10; 13; -24; -21; -4; -4; -14; 6; 3; -25; 9; -7; 15; 12; 14; 20; -11; -11; -15; -14; -9; -2; -2; -3; -1; -18; -2; 6; 17; 9; -1; 18; 20; 21; 27; -17; -11; -4; -18; 24; 33; 4; 12; 8; 8; -1; -17; 6; -18; 16; 4; 1; 6; -1; -11; 18; 15; 17; -4; 13; 1; -20; 18; 3; -16; -4; -12; -10; 8; -18; 22; 21; 12; 1; 6; -24; 7; 1; 11; 14; 20; -5; -2; 4; 9; -20; 60; 15; 18; 14; -19; 13; 3; 7; 8; 5; -14; -13; 20; 5; -1; -15; 29; 14; -19; 7; -10; 13; 3; -7; -2; -19; 8; -15; -13; -13; -1; -9; -14; 10; -9; 18; -3; -12; -7; 21; 2; 7; 7; 10; -15; -16; -6; -8; -18; 11; 13; 7; 10; -14; -14; 17; 22; 23; 15; -4; 32; 7; -5; -3; -10; -14; 9; 12; 10; -12; 17; 1; -19; 16; 14; -2; 1; -7; 17; 16; -8; -15; 18; 19; 14; 52; 8; -22; -2; -2; 13; 6; -4; 2; 20; -14; -73; 119; 20; 26; 4; 9; 14; -42; -18; 44; 18; -23; 77; -11; 15; 52; 29; -7; -11; 31; -29; 5; -20; 435; 15; -156; 71279; -19; -2; 11; -4; -1; -15; 8; 14; 19; -16; -13; 19; 3; -7; -1; -12; -15; -14; -2; 14; 8; -1; -1; -7; -2; -4; -8; -8; 7; 10; -14; -2; -13; -1; 8; -14; -9; 1; 17; -11; -13; 10; 9; 17; -18; -1; 10; -7; 11; -3; 10; 1; 8; -7; 26; 17; -16; -12; 22; -16; 9; -17; -7; 3; 13; -18; 8; 6; 15; 19; 7; 7; -18; 15; 14; 3; 10; -3; 2; 8; 9; -6; 10; 1; 15; -3; -11; 5; -8; -15; 11; -3; -19; -15; -10; 12; -8; 7; 2; 8; 3; -18; 3; -2; -5; -7; 21; 4; -6; 1; 3; 15; -16; 24; 15; -16; -2; -11; 10; -11; 17; 15; 8; 11; 21; 5; 12; 13; -15; -16; -14; 2; -11; 14; -13; 12; -17; 6; -13; 9; -1; 20; -18; -18; -21; -6; 21; 13; -12; -15; -5; 39; 20; 13; 6; -1; 12; 1; -3; 14; -5; -3; 17; 12; -13; 18; 16; -12; -16; -9; 5; -7; -1; -17; -4; -8; 5; -13; 9; -19; 15; 13; -19; -15; -2; 14; -2; -8; 2; 15; -5; -13; 19; 21; 3; 11; -17; 12; 17; 19; -16; 17; 5; -10; 13; 3; -8; 18; -8; -9; -11; 5; -11; -10; -19; 7; -3; -7; -11; 26; -10; 16; 13; -10; 5; 7; -16; 22; -9; -6; 40; -13; 7; -9; 20; 7; 8; -6; 3; -10; -14; 10; -2; 15; -3; 2; 17; 4; 3; 13; 15; -8; 16; 9; -10; 7; 4; 9; -4; 1; -13; -1; 10; -19; 20; -8; -9; -6; -15; -8; 11; 17; 9; -7; -17; -7; 9; 4; -7; 6; 9; -13; -5; -8; 6; -2; -16; 10; -15; 7; 4; 3; -2; 6; -14; -12; -10; 11; -10; 2; -15; -6; 8; -6; -4; 22; -6; 17; 8; 6; -8; -4; -21; -7; 2; 9; -26; -6; 5; -20; -38; -4; -45; -15; 14; -3; -12; 22; 12; -15; 29; -95; -15; -3; 1; -31; -22; -17; -7; -15; -5; 2; -3; 15; 12; -5; -10; 1; 7; -6; 17; 2; 2; -19; -7; 15; -6; -7; -1; 7; -12; -6; -18; -14; 6; -4; -16; -13; 5; -13; 4; 16; -8; 13; 11; -2; -7; -5; -8; 1; 9; 6; -2; 19; -4; 5; 10; 2; -9; 10; -15; 7; 11; 6; -14; -11; -6; 3; -16; -19; -6; -3; -3; -11; 19; 16; -10; 14; 15; 2; 15; 21; 15; 7; 19; 2; 52; 13; 24; -32; -126; -18; 1; -17; -14; -14; 3; -19; -17; 13; 17; -20; -1; 17; 2; 14; -7; -8; 12; -1; -14; 1; 26; -14; -17; 3; -17; 13; -3; 5; -7; 20; -2; 24; 20; -13; -19; -22; -19; 12; 35; 5; 34; 8; 2; 11; -2; -1; 13; -9; -7; -2; -28; -33; -71491 |]
    return (freq, repeatFreq)
  }

let dayTwo () =
  let logger = new LoggingBuilder("Day Two\n-------------")
  let actualInput = [| "pbopcmjeizuhxlqnwasfgtycdm"; "pjokrmjeizuhxlqnfasfguycdv"; "pbokrpjejkuhxlqnwasfgtycdv"; "sbokrmjeizuhxaqnwastgtycdv"; "pbokrmjeizuhxljnnasfgtycnv"; "pbokrqjeizuhxbqndasfgtycdv"; "bbokrmjeizuhxlqnwasfgtycfj"; "pbokrmjeisuhxlqnwasfzdycdv"; "pbokrmjefxuhxlqnwasfptycdv"; "pqokrmjenzuhxlqnwasfgtygdv"; "pbokrmjeizunklqnwassgtycdv"; "pbokrmjeizghxvqnkasfgtycdv"; "lboirmjeizuhxlqnwfsfgtycdv"; "pbofrmjeizuhalqnwasfgtyddv"; "pbokrmjeiguhplqcwasfgtycdv"; "pbokrmjeizzhxlqnwavfgtyctv"; "pbokrmjeizuhxlqnwaefgtycaj"; "pbokzmjedzuhxlqnwasfgtlcdv"; "pnokrmjegzuhxlbnwasfgtycdv"; "pbojrmjeizuhtlqniasfgtycdv"; "pbokxmiefzuhxlqnwasfgtycdv"; "pbokrmoeizuhxlqnpasngtycdv"; "abokrmjeezuhxlqnwasfdtycdv"; "pbokrmyeizugxlqnwasfgtycda"; "pbokdmjeizuhxlqnuatfgtycdv"; "psokrmjeiauhxlqnwasxgtycdv"; "pbokrmjeizuhxlqzwasfgtyzdy"; "pboktmjeizuhxnqndasfgtycdv"; "pbodrrjeizuhxlqnwasfgtycdb"; "pbokrmjekzuhxljnwasfgtycuv"; "pbokrmjnizuhllqnwawfgtycdv"; "prmkrmjeiwuhxlqnwasfgtycdv"; "pbokrmjeizkhxlenwajfgtycdv"; "pbofrmjeizuixlqnwasfgoycdv"; "gbhkrmjeizuhclqnwasfgtycdv"; "pbokrmweizuwxlqnwasfgtycyv"; "pbukrmjeizuhxlqnwasfgqhcdv"; "pbokxmjeizuhxlqnwasfgtecdu"; "pbokomjeizuhrlqnfasfgtycdv"; "bbokymjeizuhxlqnpasfgtycdv"; "pbodrmjeizuhxlqnwadfgtgcdv"; "zbokrljeipuhxlqnwasfgtycdv"; "pboermjeizuxxlqnwasfgtpcdv"; "pqbkrmjeizuhxlqnjasfgtycdv"; "pbokrmfeizuhxvqgwasfgtycdv"; "pbokrmjeizuhzlqnjasfdtycdv"; "rbofrmjeizkhxlqnwasfgtycdv"; "pbokrmseizubxlqnwasfgtycdy"; "pbocrmjeizuhxaqnwasfgtycda"; "pbokrmjeizuhxlqndakfgtscdv"; "pbokrrjeizuhxlqnwgshgtycdv"; "pbokrajeizuhxpqnwasrgtycdv"; "pbokrbjeizubxlqnwssfgtycdv"; "pbokemjhizuhxlqnwazfgtycdv"; "pbokrmjeizuhxlqntisfgtyrdv"; "pbokrmjwinuhxlqnwasfgkycdv"; "pypkrmjeizuhxlqtwasfgtycdv"; "pbokrmjeizuhxlqniasfrpycdv"; "pbokomjeizuhxlqnwasfgtgcdw"; "pbokrmjeizusplqnwxsfgtycdv"; "pbodrmueizxhxlqnwasfgtycdv"; "pbokwmjeizurxlqnwasfgtycdi"; "pbohrmjejzuhxlqnwasfgtycgv"; "pbokrmtqizuhxlqnwasfitycdv"; "ptozrmjeizuhylqnwasfgtycdv"; "pbokrmjtizuhxlqfwasfgtykdv"; "pbokrmpeizuhxnqmwasfgtycdv"; "pbokrmjeizujxlynwtsfgtycdv"; "dbokrmjeizuhxlqnwasngticdv"; "pbskrmjeizuhxlqnrasfttycdv"; "pbwkrmjerzuhxlqnwaslgtycdv"; "pboyrmceizuhxlqnwssfgtycdv"; "pbokpmjeizchxlqngasfgtycdv"; "pbokrmjenzuhxlqnwcsfgxycdv"; "pbxkrmjeizuhxlqnwadfgtyckv"; "pbqkrmjeizuhxlqnwasdgdycdv"; "pbokrmoeizdhxlqnwasfgtycqv"; "pbokrmjejzuhxlqnwksfgtycwv"; "pbfkrmjeieuhxlnnwasfgtycdv"; "pbokrmjeiuuhxlqnpalfgtycdv"; "pbokrmjeizunxyqnwasfgtdcdv"; "pbokrmjeazuhxrqnwasogtycdv"; "pbmkrmjeizuhxlqnwaufgtycdj"; "xbskrmjeipuhxlqnwasfgtycdv"; 
  "tbokrujlizuhxlqnwasfgtycdv"; "xbokvmjeizuhxyqnwasfgtycdv"; "pbnhrmheizuhxlqnwasfgtycdv"; "pboorajrizuhxlqnwasfgtycdv"; "pbokrmjeizuhxminwusfgtycdv"; "pboqrmjeizuhxlqnwaslgtscdv"; "pgokrdjeizuhxlnnwasfgtycdv"; "pbokrmjeizuhxiqnwasvttycdv"; "pbokrmwnizuhzlqnwasfgtycdv"; "pbokrmjlizmhjlqnwasfgtycdv"; "pbwkrmjeizohxlqnwasfgtyzdv"; "pbykrmjmizwhxlqnmasfgtycdv"; "pbokrmjzizuhxeqnwasfgtpcdv"; "pbokrmjewzuhxzqnwasfgtybdv"; "pbokrmjeimupxlonwasfgtycdv"; "pbokrmjvizuhxlqnuasfgtycqv"; "pbokrmjeizjdxlqnwasfetycdv"; "pbofrmjeizurxlqnwasfztycdv"; "pbozrmjeizuhxxqpwasfgtycdv"; "pbovtmjeizuhxlqnwapfgtycdv"; "prokrmjeuzuhxlqnwasfgtycqv"; "ubokrmjeizuhxljnwasfgtdcdv"; "pboknmjepzuhxlqnwasogtycdv"; "pbokrmjaizuaxljnwasfgtycdv"; "pbdkrcjeizuhxlqnwasfgtvcdv"; "pbokymjeizuhxlqnwaxfgtyfdv"; "pbokrmjaizuhxlqnfasfgtyodv"; "pdekrmmeizuhxlqnwasfgtycdv"; "rbokrmjeizuuxlqnwasfgtycdj"; "pbokrmneifuhxlqiwasfgtycdv"; "pbokrmjeizlbxlunwasfgtycdv"; "pbokrmjewzuhxxqnwasfgoycdv"; "pbokrmjeizuhxlqtwasfgtzcdo"; "pbokrmkeizzhxlqnwasfgtycmv"; "pbokrmjeiquhxlqnywsfgtycdv"; "xbokrmjeizjhxlqdwasfgtycdv"; "pbokrmjeizahxzqnzasfgtycdv"; "pbokrmjeizuhxmqmwasfgtytdv"; "pbokrmheiluhxlqnwasfgoycdv"; "rbokrmjeizuhxlqnwaslgtycqv"; "pbbkzmjeizuhxvqnwasfgtycdv"; "pbokrmjeizudxlznwgsfgtycdv"; "pbokemjeizuhxlqnwascgtysdv"; "pbokrmjdizuexlgnwasfgtycdv"; "pbokzmjeizuhxlqnwnsfggycdv"; "pbokrmjeizuhxtqnwasfgiycdy"; "bbokrmjeizuhclunwasfgtycdv"; "pbtkrmjeieuhxlqnwasfgtycrv"; "pbokrmjeizutxlbnwasngtycdv"; "pbokrmjevzumxlqnwasfgtyydv"; "pbokrmjsizuhxlqowasfgtycyv"; "pbssrmjeizuhxlqbwasfgtycdv"; "pbokrmjeizuhflqnwxsfstycdv"; "pbokimjeizuhxlqnwasfgtywdm"; "pbokrmjbizuhxlqdwasfgtygdv"; "pbokrmheizuhxlqxwasfgtycnv"; "poakrmjeizuhylqnwasfgtycdv"; "vbrkrmjeizuhxlqnwaszgtycdv"; "pbokrmjeizuhxiqnudsfgtycdv"; "pbokrldeizuhxlqnwasjgtycdv"; "pbokrmjeizjhflqnwasfgtymdv"; "pbokrmjeizuhxliawasfgtvcdv"; "pbokrmjeisuhtoqnwasfgtycdv"; "nbokrijeizuhxlqnwasfgtycdh"; "pbokrmjeizrhxlqnwxsfztycdv"; "pbotrmjeizuhxlcnwasfgtyvdv"; "pbokrmjewzuhxlquwasfgtjcdv"; "pbosrmjeipuhxlqnwasfgtvcdv"; "pbokrmjebzurxlunwasfgtycdv"; "pbogimieizuhxlqnwasfgtycdv"; "pbokrmjeizihxlqnwasagtyzdv"; "pbokrmjeizuoxlqnausfgtycdv"; "pbokrmjeizuhxlqnwashgbjcdv"; "pbokrdjeizuhxlnnwasfgoycdv"; "pbokrzjtizlhxlqnwasfgtycdv"; "peokrmjexzuhxlqnwasfgoycdv"; "cboprmjeizuhxlqnwasfgfycdv"; "pbitrmjeizjhxlqnwasfgtycdv"; "pbourmjeizuhxldnwjsfgtycdv"; "pboivmjeizuhxlqnwasvgtycdv"; "pbokrmjeiduhxaqnqasfgtycdv"; "pbokicjeiwuhxlqnwasfgtycdv"; "pbokrmmeizulxlqnwasfgtyvdv"; "pbokrmjeieuhxlqnaapfgtycdv"; "pbokxmjeiuuhxlqnwasfgtyqdv";
  "pbokrmjeizuhxgqniaslgtycdv"; "pbokrmjeizuuxlqnwisfgtyckv"; "pbovlmjepzuhxlqnwasfgtycdv"; "pbokrmjeizuhxlqdwaqfgtycdj"; "pbztrvjeizuhxlqnwasfgtycdv"; "pbokrmjeizuholunwasfptycdv"; "pbokrmjeizudxlqnwusfgtycqv"; "nbokrmjzizmhxlqnwasfgtycdv"; "pbokrmjeypunxlqnwasfgtycdv"; "pbokrjjxizuhxlqnwasfgtyddv"; "pbokrmjeizuhilqnwiufgtycdv"; "pbokrmjeizuhxtqowasfgfycdv"; "qbokrgjeizuhxlqnwasfgtycdx"; "pvoarmjeizuhxlqnwasfgtfcdv"; "pbokrmjjizuhxlqnwasfggyczv"; "pbtkrmjeizuhnlqncasfgtycdv"; "pbokrmjeizuzxlqnwasfgtyjnv"; "jmokrmzeizuhxlqnwasfgtycdv"; "pbykrmjmizwhxlqnwasfgtycdv"; "nbokrmjeizlhxlqnwasfgtecdv"; "pbokrmjeizuhxlqhwasrgrycdv"; "pbokrmjeiruhxlqnwasfgtnedv"; "pbokrmjeizohxlznwasfgtycuv"; "paokrmjdizuhxlqnwasfktycdv"; "pbokrmjetzutxlqnwasfntycdv"; "pboyrmjeizuhxlqnwasfgtetdv"; "pbokgujeizuhxlqwwasfgtycdv"; "pbokrifeizshxlqnwasfgtycdv"; "sbokrmjeizfhxlqnaasfgtycdv"; "pbokrmjeizuhxlqpwrsfgfycdv"; "pbokxmjeikuhxlqnwasfctycdv"; "fbokrmjhizuhxlqnmasfgtycdv"; "pbekamjeizuhxlqnwaxfgtycdv"; "pboksmpeizuhxlqnwasfgtyclv"; "pbokrmjeizrhxdqnwasfgzycdv"; "pbogrmxeizurxlqnwasfgtycdv"; "pbokrmjeieuhxlqnwqsfgtychv"; "vbokrmjeizuhxlqnwabfgtycdq"; "lbokrmjeizupxlqvwasfgtycdv"; "pbokrmjeizuhglqnuasfgtucdv"; "hbokrmjeizuhelqnwasfgtrcdv"; "pbokrmweizuhxlqnwhsfgtyvdv"; "pbokrmjeizuhxrqnwasfvtccdv"; "pbokrmneizuhxlwnyasfgtycdv"; "ybokymjeqzuhxlqnwasfgtycdv"; "pbousmjeizuhxlqswasfgtycdv"; "pblkimjeizuhxlqnwacfgtycdv"; "psokrmjeizuhxlqnwasfgbpcdv"; "peokrwjeizghxlqnwasfgtycdv"; "pbokrmjeizudxlqnwzsfrtycdv"; "pbotrmjezzxhxlqnwasfgtycdv"; "pkokrmjezzuhxlqnwasfgtycdh"; "pbokrmleizuhxlnnwasfgtyndv"; "pboxwmjeituhxlqnwasfgtycdv"; "pbokrmjeizoczlqnwasfgtycdv"; "pbokomjeizuhxlqnwhsfgtybdv"; "pbhwrmjeizuhxlqnwasfgpycdv"; "pbwkrmjeizuhxeqnwasfgtyidv"; "pbokrmjeizuhxlqnjasfgmicdv"; "tbokrgjeizuhxlqhwasfgtycdv"; "pbolrqjeizuhxlqnhasfgtycdv"; "pbogrhjeizbhxlqnwasfgtycdv"; "pbokrmjeizghxlqnwashgtycdx"; "pbokrmjeizuhrlqnwasfgthcrv"; "pbokrmjeizuhxlqnwfsngtacdv"; "pbokrmxeizuhxlqnwasfotyctv"; "pbokrmjeizuhxlqnwcsfgnocdv"; "pnokbmjeizuhxlqnwasfgtscdv"; "pbowrmjeuzuhxlqnwasfgtycdw"; "pbokrmjeiyuhxlqnwasqgtvcdv"; "pbokrmjeivuhxkpnwasfgtycdv"; "pbokomjeizuhxlqnwasfgtylav"; "pbdkrmjeizuhxlgnwjsfgtycdv"; "pbokrmjeizuaxxqnwasfytycdv"; "pbokrmjerzuhxlqnwasfgtscdk"; "pbokrmzerzuhxlqnwasfntycdv"; "pbokrmjeizumxdqnwasfgtyckv"; "pbtkrmjeizrhxlqnwasfgtjcdv"; "pbmkrmjuizuhxlqnwasfgtytdv"; "pbokpmjeizuhxlqnwastgtzcdv"; "kbokrmjeizuhxlqnwasfgzjcdv" |]

  logger {
    let! samplePartOne = simpleChecksum [| "abcdef"; "bababc"; "abbcde"; "abcccd"; "aabcdd"; "abcdee"; "ababab" |]
    let! actualPartOne = simpleChecksum actualInput

    let! samplePartTwo = similar [| "abcdef"; "fghij"; "klmno"; "pqrst"; "fguij"; "axcye"; "wvxyz" |]
    let! actualPartTwo = similar actualInput
    
    return (actualPartOne, actualPartTwo)
  }

let dayThree () =
  let logger = new LoggingBuilder("Day Three\n--------------")
  let inputs = Seq.map rectOfClaim <| File.ReadAllLines "./2018/AdventOfCode2018/day-03-input"

  logger {
    return overlapArea inputs
  }

let dayFour () =
  let logger = new LoggingBuilder("Day Four\n--------------")
  let inputs = 
    Seq.map parseGuardLog <| File.ReadAllLines "./2018/AdventOfCode2018/inputs/day-04"
    |> Seq.sortBy (fun log -> log.dateTime)
  let guards = guardsOfGuardLogs inputs

  let sleepiestGuard = Guard.sleepiestGuard guards
  let sleepySchedules = 
    Guard.sleepySchedules guards
    |> Seq.map (fun (id, schedule) -> (id, Seq.maxBy snd schedule))
  let maxMinuteSlept = Seq.maxBy (fun (_, minute) -> snd minute) sleepySchedules

  let partOne = (sleepiestGuard, sleepiestGuard |> fst |> Guard.sleepiestMinute)
  let partTwo = Seq.filter (fun (_, minute) -> minute = snd maxMinuteSlept) sleepySchedules

  (partOne, partTwo)

let dayFive () =
  let logger = new LoggingBuilder("Day Five\n--------------")
  let input = File.ReadAllText "./2018/AdventOfCode2018/inputs/day-05"

  let unitPair (polymer: string) currentUnit =
    if String.length polymer > 0
    then
      let recentUnit = polymer.Substring(polymer.Length - 1).Chars(0)
      if (abs ((int recentUnit) - (int currentUnit))) = 32
      then Some (recentUnit, currentUnit)
      else None
    else None    

  let collapseUnitPairs polymer currentUnit =
    match unitPair polymer currentUnit with
    | Some (a, b) -> polymer.Substring(0, polymer.Length - 1)
    | None -> polymer + currentUnit.ToString()


  logger {
    let! collapsedPolymer = Seq.fold collapseUnitPairs "" (input.Trim().ToCharArray())
    let! len = String.length collapsedPolymer
    return (collapsedPolymer, len)
  }

// dayOne ()
// dayTwo ()
// dayThree ()
// dayFour () 
dayFive () 