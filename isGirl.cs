﻿using System;
/**
 * Version 1.0
 * Author Fogh
 * andfogh@gmail.com
 * 
 * Check if name is a girls name.
 * All names is from the danish list of approved girl names
 */

public abstract class isGirl
{
	private const string[] femaleNames = {
        "abbelone","abbie","abeline","abelone","abigael","abigail","achena","ada","adalena","adalina","adane","adda","addie","addy","adea","adela","adelaide","adele","adèle","adeleine","adelena","adelfine","adelgunde","adelheid","adelhejd","adelina","adeline","adi","adia","adie","adina","adine","adolfine","adolphine","adriana","adriane","adrielle","adrienne","ady","agate","agatha","agathe","agda","agga","aggi","agna","agnes","agnès","agneta","agnete","agnetha","agnethe","agny","aia","aicha","aida","aija","aila","aili","aima","aimée","aimi","aimy","aina","aino","aisha","aishah","aja","ajatsa","ajo","akeleje","akita","akseline","aksinja","alaia","alaine","alba","albantine","alberta","alberte","albertha","alberthe","alberthine","albertina","albertine","albina","albine","aleia","aleksandra","aleksandrine","aleksia","alessandra","aleta","alett","alette","alexa","alexandra","alexandria","alexandrina","alexandrine","alexia","alexie","alezia","alfa","alfhild","alfrede","alfrida","alfride","alfrieda","alfriede","algea","alia","alice","alicia","alida","aliena","alikka","alina","aline","alis","alisa","alise","alison","alissa","alita","alitha","alitta","alitza","aliz","allaine","allette","allice","allida","allie","allis","ally","allydia","alma","almine","almira","aloisia","alona","alryda","althea","alva","alvild","alvilda","alvilde","alvina","alvine","alvira","alwine","amalia","amalie","amanda","ambrosia","amelia","amelie","amélie","amia","amilia","amilla","amina","aminah","amine","amira","amola","amy","ana","anaia","anasia","anastaja","anastasia","anastasija","anastasja","anastassia","anastazia","anaya","ancia","andersine","andrea","andrée","andriette","andrine","ane","anée","anegrete","anegrethe","aneka","aneline","anelise","anella","anelle","anemarie","anemette","anemone","anet","anete","anethe","anett","anetta","anette","angela","angèle","angelica","angelie","angelika","angelina","angeline","angelique","angélique","angelita","angla","ani","ania","aniara","anica","anicha","anick","anie","aniela","aniella","aniet","anika","aniki","anikka","anilla","anina","anine","aninja","aninna","aniqa","anisa","anise","anisette","anissa","anita","anitha","anitta","anja","anje","anjelica","anjila","anka","anke","ankie","anli","anline","ann","anna","annabell","annabella","annabelle","annabeth","annagrete","annagrethe","annakarin","annali","annaline","annalis","annalisa","annalise","annamaria","annamarie","annamary","annamay","annamette","annamie","annasofie","annastasia","annbeth","annbrit","annbritt","anne","annebell","annebelle","annebet","annebeth","annebirgitte","annegerd","annegitte","annegrete","annegrethe","anneke","anneken","annelene","anneli","annelie","anneliese","anneline","annelis","annelisa","annelise","annella","annelouise","annemai","annemari","annemarie","annemette","annemie","annemona","annemone","annesette","annesisse","annesofie","annet","annete","anneth","annethe","annett","annette","anngrethe","anni","annia","annica","annie","annielle","annik","annika","annike","annikki","annina","annine","annisette","annita","annitta","annizette","annjeanett","annli","annlil","annlisa","annlise","annmari","annmarie","annmette","annsofi","annsofie","annsophie","anny","anouk","ansine","anthonia","anthonie","antine","antje","antoinetta","antoinette","antomine","antonella","antonelle","antonette","antonia","antonie","antonina","antonine","any","anya","apollonia","aprilia","arabella","aranka","arendse","arense","arenze","ariane","arielle","arina","arise","arla","arlette","arletty","armgard","arna","asa","asdis","asfrid","asgerd","asja","asla","aslaug","asløg","asmine","asmira","asra","assia","assika","asta","astrid","atalia","atalie","athalia","athalie","athena","athene","athina","atla","atlanta","aud","audrey","augusta","auguste","augustina","augustine","aukje","aurelia","aurica","aurora","ava","avgusta","aviaja","aviaya","axeline","aya","aye","aylil","ayma","ayna","ayo","ayoe","ayse","aziza","babette","bagga","barba","barbara","barbel","barbette","barbra","barbro","bartholine","batseba","bea","beaneth","beata","beate","beatha","beathe","beatrice","beatrix","beatriz","bebbie","bebe","bebiane","becca","becky","begitta","begitte","beinta","belenda","belene","belinda","belinde","beline","belise","bell","bella","belle","bellis","benda","bende","bendie","bendine","bendte","bene","benedichte","benedicta","benedicte","benedikte","benete","bengerd","bengta","bengte","bengtha","benita","benitta","benja","benna","bennie","benta","bente","bentha","benthe","benthine","bentina","bentine","berbel","berengaria","berete","bereth","bergitte","bergliot","bergljot","berit","berith","beritt","berna","bernadette","bernhardine","bernice","berrit","berta","berte","berteline","bertha","berthe","berthine","bertina","bertine","beryl","bess","bessie","beth","bethina","betina","betine","betinna","betje","betri","betricia","betsy","bett","bette","bettie","bettina","bettine","betty","betzy","bia","biana","bianca","bianka","bianna","biba","bibba","bibbi","bibi","bibiana","bibiane","bibiann","bidda","biddy","bina","bine","binette","binie","bintha","birde","birdie","birgit","birgita","birgith","birgitha","birgithe","birgitt","birgitta","birgitte","birgitthe","birit","birita","birith","birka","birla","birna","birrit","birta","birte","birtha","birthe","birthine","birtine","bit","bitta","bitten","biørde","bjanca","bjanka","bjarka","bjarta","bjørg","bjørgit","blanca","blanche","blanka","blenda","blia","blimunda","boa","boanna","bodil","boejana","boel","boeline","bojanna","bolethe","bolette","boline","bondie","bonita","bonna","bonnie","borghild","borgny","botelle","bothilda","bothilde","bothilia","bothilla","botilda","botilde","botilla","botille","brenda","bria","brianette","brianna","brianne","briddie","bridget","brigitt","brigitta","brigitte","brina","brinette","brinnie","brisa","brit","brita","brith","britha","britt","britta","brunhild","brunhilde","brynhild","brynild","brynja","bärbel","cabrina","caia","caja","calina","calla","camelia","camelie","cameline","camila","camilla","camille","camitta","camma","cammilla","cana","candie","canja","canna","cannie","capella","caren","caria","carin","carina","carine","caris","carita","caritas","carla","carli","carlina","carlotta","carmen","carmina","carna","carol","carola","carole","carolina","caroline","caroll","carolyn","carrie","cassandra","catalina","catarina","catarine","cate","caterina","catharin","catharina","catharine","cathe","catherin","catherina","catherine","cathia","cathie","cathinca","cathinka","cathja","cathleen","cathlin","cathrin","cathrina","cathrine","cathy","catia","catina","catinka","catja","catrin","catrina","catrine","catriona","cattia","caya","cebina","cebrina","cebrine","cecilia","cecilie","cecilla","cecillia","cecillie","cecily","celena","celene","celeste","celestine","celia","celica","celie","celina","celinda","celine","cellina","cenette","cenia","cenobia","centa","chabrina","chalina","chaline","chalotte","chamilla","chanel","chanell","chanella","chanelle","chanet","chanett","chanette","chanice","chanie","channe","channette","channie","chantal","charina","charita","charite","charlene","charlin","charline","charlot","charlott","charlotta","charlotte","charmaine","chastina","chastine","chatarina","chathrine","chatrine","cheanne","cheila","chelina","chenet","chenett","chenette","cheri","cherie","cherina","cherstin","chia","chili","chinette","chloe","chresta","chrestina","chrestine","christa","christabel","christel","christell","christelle","christence","christense","christiane","christianne","christie","christin","christina","christine","christinna","christl","cia","cianna","cianne","cicely","cicilia","cicilie","ciela","cilia","ciliane","cilie","cilja","cilje","cilla","cille","cimmie","cinda","cindi","cindie","cindy","cinna","cinne","cira","cirkeline","cisse","cissel","cissie","cissy","cita","citha","claire","clara","claramilla","clare","clari","clarie","clarina","clarissa","clarisse","claudette","claudia","claudine","clausine","clea","clementine","clennie","cleo","cloe","clotilde","coco","colette","columbine","concha","conja","conni","connie","conny","conradine","constance","constantia","constantine","cora","cordelia","cordula","corina","corinn","corinna","corinne","corintha","corna","cornelia","cornelie","corrie","corrina","cosima","cresta","crista","cristel","cristina","cristine","cunilla","cynthia","cæcilia","cæcilie","dacia","dafne","dagmar","dagny","dahlia","dahlya","daiana","daimi","daisi","daisy","dalila","damaris","damila","dana","dania","danica","daniela","daniele","daniella","danielle","danila","danilla","danina","danine","danita","danja","danna","danniella","danuta","daphne","darina","darlene","dawn","dea","deanie","deanna","deanne","debbie","debora","deborah","debra","dee","deirdre","delia","deliane","delicia","delilah","delphine","dena","denezia","denia","denice","denise","denize","denja","dennie","désirée","deva","dia","dian","diana","diane","dianna","dianne","diannie","diantha","dicte","dida","didda","diddan","didde","diddi","dido","dikte","dina","dinah","dineke","dinna","dinne","dinnie","diona","disa","distelle","dita","ditta","ditte","dittemarie","djamilla","dodo","dolly","dolores","donna","donnie","dora","dorathea","dorde","doreen","dorella","dorete","dorethe","dorette","dori","doria","doriane","dorin","dorina","dorine","doris","dorit","dorita","dorith","dorotea","dorotha","dorothea","dorothy","dorris","dorrit","dorrith","dorte","dortea","dorthe","dorthea","dorthie","dorthy","dot","dotta","drea","drine","drude","druna","dua","dunia","dunja","durita","dusina","dusine","dyveke","ea","ebba","eda","edda","edel","edele","edeltraut","edit","edita","edith","edla","edle","edly","edma","edmée","edna","edua","edvardine","edvia","edy","effie","ega","egidia","egina","eia","eibrit","eibrith","eibritt","eike","eila","eileen","eina","einette","eireen","eisa","eivor","eja","ejbrit","ejbrith","ejbritt","ejla","ejna","ejsa","ekatarina","ela","elaina","elaine","eleana","eleanor","electra","elena","elene","eleni","elenna","elenora","eleonora","eleonore","eleta","elfi","elfrede","elfrida","elfride","elfrieda","elfriede","elga","elia","eliana","eliane","elice","elida","elie","elin","elina","eline","elinor","elisa","elisabet","elisabeth","elisabetta","elise","elissa","elita","elitha","elitta","eliza","elizabeth","elka","elke","ella","elle","ellen","elli","ellice","ellida","ellie","elline","ellinor","elly","elma","elmine","elmira","elmy","elna","elny","elouise","elsa","elsabet","elsabeth","elsbet","elsbeth","else","elsebet","elsebeth","elsemarie","elsia","elsie","elsine","elva","elvi","elvilda","elvina","elvine","elvira","elvire","emanuela","emanuella","embla","emeli","emelia","emelie","emely","emili","emilia","emilie","emiline","emily","emine","emma","emmaline","emmeli","emmelie","emmeline","emmely","emmerence","emmy","ena","ene","enge","engeline","engelke","enid","enja","ennike","enrica","enya","eponine","erena","erene","eri","eria","erica","erika","erikka","erikke","erita","eritza","erla","erminia","erna","ernestine","erni","ernstine","esgerd","esmaralda","esmeralda","esta","estell","estella","estelle","ester","estha","esther","estrella","estrid","eta","etel","ethel","ethla","ethly","etla","etly","etta","ettie","etty","eufemia","eugenia","eugenie","eulalia","eunice","eunike","euphemia","eva","evalina","evaline","evalotte","evangeline","eve","eveleen","evelin","evelina","eveline","evely","evelyn","evi","evian","evita","evy","ewa","ewy","eya","eza","fabienne","fabiola","fabrina","faith","falka","fanny","farah","farida","farina","fatima","fay","felia","felicia","felina","feline","felizia","fenja","feodora","fernanda","fernande","fia","fie","filine","filippa","fillis","fiona","fleur","flora","florence","florentine","floria","franca","france","frances","francette","francie","francine","francisca","franciska","francoise","frandsine","franja","franka","fransine","fransiska","franziska","frauke","freda","frederikke","freja","frejdis","freya","fria","frida","fridbjørg","fride","frieda","friede","friederike","friederikke","frigg","frigga","fritsa","fritse","fritza","fritze","fritzie","fro","fry","frøydis","fylla","gabi","gabriela","gabriele","gabriella","gabrielle","gaby","gaia","gaiga","gail","gaja","galina","ganja","gaya","gedske","geira","gela","gelika","gemma","gena","geneviève","genia","genny","geogina","georgette","georgia","georgiana","georgina","georgine","géraldine","gerd","gerda","gerdi","gerlinde","gerly","germaine","gersemi","gerta","gertha","gerti","gertie","gertrud","gertrude","geske","gete","gethe","ghita","gia","giannina","giannula","gida","gidda","gigi","gila","gilda","gilla","gillian","gina","gine","ginette","ginia","ginie","ginna","ginne","ginnie","giorgia","giovanna","gisa","gisela","gisèle","giselle","gisla","git","gita","gith","githa","githe","gitt","gitta","gitte","gittel","gitten","giulia","gjertrud","gladis","gladys","glenda","glenna","glennie","gloria","grace","grazia","graziella","greta","gretchen","grete","gretel","gretha","grethe","griet","grit","grith","gritt","gro","groa","grusje","gry","gudda","gudrun","guldborg","gull","gull-mai","gull-maj","gulla","gullan","gullbrith","gulli","gullis","gullvig","gulnare","gun","gunda","gundborg","gunde","gunhild","gunhilda","gunhilde","gunild","gunilde","gunilla","gunløg","gunn","gunna","gunne","gunnel","gunnild","gunta","gunva","gunvar","gunver","gunvor","guri","gurli","gurly","gustava","gwen","gwennie","gy","gya","gyda","gylla","gynna","gynthia","gyrild","gyrit","gyrita","gyrite","gyritha","gyrithe","gyta","gytha","gythe","gytta","gytte","halina","haline","halla","hallie","hanna","hannah","hanne","hannele","hannelene","hannelore","hanni","hanny","hansa","hansigne","hansine","haralda","haraldine","harda","hariet","harriet","hasel","hazel","heather","hebe","heda","hedda","heddi","heddy","hedevig","hedi","hedvig","hedwig","hedy","heide","heidel","heidi","heidie","heidl","heika","heike","heina","hejdi","hejdie","hela","helda","helen","helena","helene","helfred","helfried","helga","helia","hella","helle","hellen","hellith","helma","heloise","helvig","hendricke","hendrika","henna","henni","hennie","henny","henriett","henrietta","henriette","henrijette","henrika","henrike","henrikka","henrikke","hensia","hera","herdis","herla","herle","herma","hermanda","hermandine","hermine","herta","hertha","hilborg","hilda","hilde","hildeborg","hildegard","hildegerd","hildegunn","hildur","hilleborg","hilma","hinna","hjørdis","hlif","holga","holly","honey","hope","hortense","hortensia","hulda","hyben","hydda","hylleborg","iane","iani","ianne","iantha","ibbe","iben","ibi","ibina","ida","idaline","ide","idun","idunn","ifigenia","ika","ila","ilana","ilanna","ilena","ilene","ilia","ilian","ilina","illa","illiana","illianna","illona","illya","ilona","ilone","ilsa","ilsabet","ilsabeth","ilse","ilsebet","ilsebeth","ilsebil","ilselil","ily","ilya","ima","imke","imoa","imone","ina","inanna","india","indiane","ine","ineke","ines","inès","inez","inèz","inga","ingalil","ingard","ingbritt","inge","ingebeth","ingebjørg","ingeborg","ingebrit","ingebritt","ingeburg","ingefred","ingegerd","ingela","ingelene","ingelil","ingeline","ingelis","ingelise","ingemarie","ingemerete","ingemette","inger","ingerbeth","ingerd","ingerid","ingerlil","ingerlise","ingfred","ingjerd","ingred","ingrid","ingse","ingun","inia","inie","inken","inna","inneke","io","ioanna","ira","irbit","irela","iren","irena","irene","irina","iris","irit","irith","irja","irka","irke","irlin","irma","irmelin","irmgard","irna","isa","isabel","isabell","isabella","isabelle","isalena","isel","iselin","isidora","isja","isodora","isolde","iva","ivalo","ivana","ivara","ivonn","ivonne","ivy","iza","izabella","izette","jacinta","jacoba","jacobe","jacobina","jacobine","jacqueline","jade","jael","jakoba","jakobe","jakobine","jamila","jamilla","jamina","jana","jane","janeke","janet","janett","janette","janey","jani","jania","janice","janie","janika","janina","janine","janis","janna","janne","janneke","jannet","janni","janniche","jannicka","jannicke","jannie","jannika","jannike","jannit","janny","jansine","jantie","jaqueline","jardine","jasmin","jasmina","jasmine","javanna","javette","jayne","jea","jean","jeana","jeanelle","jeanet","jeaneth","jeanett","jeanette","jeanica","jeanie","jeanina","jeanine","jeanita","jeanna","jeanne","jeannelle","jeannet","jeannett","jeannette","jeanni","jeannie","jeannine","jeanny","jeddy","jekaterina","jelena","jelina","jelona","jeltje","jelva","jemina","jena","jenda","jenna","jenni","jennie","jennifer","jenny","jensigne","jensine","jensmine","jenssine","jerika","jerilee","jesine","jessia","jessica","jessie","jessika","jessine","jette","jilian","jill","jillie","jing","jinga","jinnie","jirina","jo","joa","joan","joanina","joann","joanna","joanne","jodie","joelina","joelle","johane","johanna","johanne","johna","johnna","johnnie","jolanda","jolande","jolanta","jolantha","jolina","joline","jona","jonie","jonina","jonine","jonna","jonne","jonnhild","jonnie","jorid","jorie","joronn","jorun","jorunn","josa","josefa","joseffa","josefia","josefin","josefina","josefine","joseline","josepha","josephin","josephina","josephine","josette","josia","josina","josine","jostina","josue","jova","joy","joyce","joye","jozefina","jozette","jua","juana","juanita","juanitta","juanna","judi","judie","judit","judite","judith","juditha","judithe","judy","juki","julia","juliana","juliane","julianna","julica","julie","juliet","juliette","juline","julla","jullie","juna","june","junette","junia","junie","junni","junnie","justa","justina","justine","juta","jutha","jutta","jyta","jytta","jytte","jørdis","jørga","jørgie","jørgine","jørli","jørna","jørrie","kadia","kadja","kadla","kaia","kaisa","kaja","kajsa","kalinka","kamilla","kamille","kamma","kammy","kanja","kanna","kanya","kara","karen","karenlene","karenlise","kari","karia","karianne","karima","karin","karina","karine","karis","karit","karitas","karitha","karitta","karitte","karla","karli","karlina","karline","karma","karna","karnelia","karola","karole","karolina","karoline","karrie","kasandra","kasmira","kassandra","kassia","kata","katalin","katarina","katarine","katcha","katchen","kate","katerina","katha","katharina","katharine","kathe","katherina","katherine","kathia","kathina","kathinka","kathja","kathleen","kathlin","kathrin","kathrina","kathrine","kathy","kathya","katia","katie","katina","katinka","katja","katjanna","katje","katka","katrin","katrina","katrine","katriona","katrione","katryn","kattia","kattie","katty","katy","katya","kaya","kea","kecia","kekkie","kellie","keren","kerensa","kerit","kerrye","kersten","kersti","kerstin","kerstine","kertrin","ket","keth","kett","ketta","kette","ketti","ketty","kezia","kia","kianna","kiara","kichka","kicka","kickan","kicki","kickie","kiddie","kie","kiea","kierstine","kika","kiki","kikki","kimberley","kimberly","kimi","kimie","kimma","kimmi","kimmie","kinna","kinne","kinnie","kira","kiri","kirit","kirja","kirsa","kirse","kirsten","kirsti","kirstin","kirstina","kirstine","kirta","kis","kisa","kiss","kisser","kissy","kista","kit","kita","kith","kitha","kitna","kitsa","kitsie","kitt","kitta","kitte","kitten","kitti","kittie","kitty","kitza","kiva","kiwa","kizzie","kjersten","kjersti","kjerstin","kjerstine","kjesten","kjestine","klara","klare","klarissa","klarisse","klaudia","klaudine","klausine","klea","klennie","kleo","klio","klotilde","knuddine","knudine","knudsine","konja","konni","konnie","konny","konradine","konstance","konstancia","kora","korna","kornelia","kornelie","kraka","kresta","krestiane","krestina","krestine","krista","kristan","kristel","kristella","kristence","kristense","kristiane","kristin","kristina","kristine","kristinna","kyra","kæthe","käte","käthe","kätty","laica","laide","laika","laila","lailah","laina","laisa","laise","lajka","lajla","lalla","lana","lane","lani","lara","larisa","larissa","larna","larsigne","larsine","latifa","laura","laure","laureen","laurence","laurense","laurentia","laurentine","laurette","laurikke","laurina","laurine","lavinia","lavra","lavrina","lavrine","layla","lea","leah","leana","leane","leanette","leanne","lecia","leda","ledna","lee-ann","leena","leenette","lehna","leia","leika","leila","leis","leisa","leisbeth","leise","leisje","lejla","lela","lena","lenda","lene","lenea","lenette","leni","lenia","lenie","lenike","lenina","lenja","lenka","lenna","lennie","lennore","lenore","leona","leone","leonia","leonie","leonora","leonore","leontina","leontine","leopoldine","lethe","leticia","lette","lettie","leyla","lezanne","li","lia","liana","liane","liani","liann","lianna","lianne","liat","liba","lica","lican","licia","licie","licken","lida","lidda","lidden","liddi","liddie","liddy","lidi","lidia","lidy","lie","lienette","liesel","lieselotte","lif","liff","liis","liisa","lil","lila","lilah","lilan","lili","lilia","lilian","liliana","liliane","lilie","lilina","liline","lilith","lilja","liljan","lilje","lill","lilla","lillah","lillan","lillemor","lillene","lilli","lillia","lillian","lilliane","lillibeth","lillie","lillien","lilliken","lillis","lillith","lilly","lilse","lily","lilyan","lilyann","lin","lina","linda","lindi","lindis","lindsay","line","linea","linet","linett","linetta","linette","linika","linka","linn","linna","linnea","lis","lisa","lisabell","lisabeth","lisan","lisanette","lisann","lisanne","lisbet","lisbeth","lisbett","lischen","lise","lisel","liselotte","liset","lisetta","lisette","lisi","lisie","lisl","liss","lissa","lisse","lisselotte","lissen","lissi","lissia","lissie","lissy","lista","lisy","lita","liten","lith","litha","lithen","liticia","litka","litta","litte","litten","litza","litzi","litzia","litzie","litzien","litzy","liv","liva","livia","liw","liz","liza","lizanette","lizanne","lizbet","lizbeth","lizell","lizet","lizeth","lizett","lizetta","lizette","lizi","lizie","lizl","lizza","lizzette","lizzi","lizzia","lizzie","lizzy","lo","loa","lola","lolan","lolita","lolo","lona","lone","loney","loni","lonia","lonna","lonni","lonnie","lonny","lora","lore","lorea","lorena","lorene","lorentze","lorenze","loretta","lori","lorita","lorna","lorraine","lotta","lotte","lotti","lottie","lotty","lotus","lou","louann","louisa","louise","louiza","loulou","lousin","lova","lovisa","lovise","luana","luane","luann","lu-ann","luanne","lucca","lucette","lucia","luciana","lucie","lucienne","lucille","lucina","lucinda","lucinde","lucretia","lucy","ludmilla","ludovica","ludovika","ludvikka","ludwiga","luisa","luise","lula","lull","lulla","lulle","lulu","luna","lusy","luth","lya","lycie","lydia","lykka","lykke","lyna","lynett","lynette","lynn","lynne","lys","lyzet","lyzette","lænna","lærke","løkke","lønne","mabel","macaela","madalena","maddalena","madeleine","madelene","madeline","madelon","madja","madorma","madsine","magda","magdalena","magdalene","magdaline","magdalone","magdelone","magga","maggi","maggie","magna","magnella","magnhild","magnina","magny","mai","maia","maibrit","maibrith","maibritt","maichen","maidis","maien","maigen","maiica","maija","maika","maike","maiken","maikie","maila","mailill","maina","maise","maitchen","maite","maj","maja","majbrit","majbrith","majbritt","maje","majka","majke","majken","majli","majlis","majsa","majse","majvi","majvor","makaya","makie","malaika","malena","malene","malfrid","malhild","malia","malie","malika","malin","malina","malinda","maline","malinka","malla","malle","mallie","malou","malue","malvina","malvine","mamie","manda","maneth","manett","manette","manitha","manja","manna","manola","manon","manuela","manuella","mara","marcella","marcelle","marcelline","marchella","marchelle","marchen","marcia","maren","marena","marenta","marente","marentine","marese","maretha","marethe","marga","margaret","margareta","margarete","margaretha","margarethe","margarit","margarita","margaritha","margie","margit","margith","margithe","margitta","margot","margret","margreta","margrete","margretha","margrethe","margriet","margrit","margrith","margritt","marguerita","marguerite","margueritha","marguerithe","mari","maria","mariah","mariam","marian","mariana","mariane","mariann","marianna","marianne","maribel","marie","mariella","marielle","marienta","marietta","mariette","marija","marijanne","marika","marike","marikka","marikke","marilena","marilene","marilia","marilina","marilyn","marin","marina","marine","marinella","marinetta","marinette","mariolla","marion","marisa","marisha","marissa","marit","marita","maritha","maritta","maritza","marja","marjanna","marjanne","marjorie","marjun","marka","marken","marketta","markhild","marlea","marleen","marlena","marlene","marlice","marlie","marlies","marlis","marlise","marlit","marna","marne","marnie","marquerite","marrit","marry","marsha","marta","marte","martha","marthe","marthea","marthina","marthine","martina","martine","martinette","martinna","mary","marya","maryam","maryan","maryann","maryanna","maryanne","maryette","marylou","marzella","mascha","masha","masja","mathea","mathia","mathilda","mathilde","mathina","mathine","matie","matilda","matilde","matina","matine","maud","maureen","maxine","may","maya","maybrit","maybrith","maybritt","mayken","mea","mean","mechela","mecka","medea","medina","medine","meeri","meg","megan","mei","meike","meiken","mejken","mejse","melaine","melani","melanie","melannie","melene","melie","melika","melike","melina","melinda","meline","melisa","melissa","melisse","melita","melitta","mellanie","menika","menja","merab","mercedes","merci","mercy","mereta","merete","meretha","merethe","meri","merian","merika","merita","merith","merle","merly","merri","merrit","merry","merte","mery","meta","metea","metha","methea","methine","metia","metina","metine","metta","mette","mettea","mettelene","metteline","mettemarie","metthea","metthine","mettine","metty","mey","mi","mia","miamaja","miamaya","mian","mianna","mianne","mica","micaela","micala","micalla","micella","micha","michaela","michala","michalina","michela","michele","michèle","micheline","michella","michelle","michellie","michilina","micka","midde","mie","mieke","mignon","mija","mika","mikaela","mikaella","mikala","mikela","mikie","mikka","mikkala","mikkela","mikkeline","mila","milanka","milda","mildred","mildrid","milena","milene","milia","milka","milla","mille","millie","millika","milly","milma","milred","milrid","mimi","mimmi","mina","minda","mine","minea","minella","minelle","minette","mini","minika","minja","minka","minna","minne","minni","minnie","minnika","minona","mira","mirabelle","miranda","mireille","mirella","miri","miria","miriam","mirian","miriem","mirijam","mirijana","mirja","mirjam","mirjana","mirka","mirla","mirna","mirra","mirsa","mirza","mischa","misha","misja","miska","mitra","mitta","mitte","mitzi","mitzie","mitzy","moira","molise","mollie","molly","mona","monalisa","monalise","mone","monette","moni","monia","monica","monice","monika","monike","monique","monja","monna","monnie","morgana","mortine","mounia","mouritza","mouritze","mowita","muriel","murielle","musette","musse","my","mya","myanne","mylia","mylise","myra","myriam","myrna","myrtha","myrthel","myrtle","märta","märth","nada","nadia","nadija","nadine","nadja","nadjie","naia","naija","naila","naima","naja","nakita","nan","nana","nancie","nancy","nanda","nane","nanet","nanett","nanette","nanida","nanina","nanine","naninja","naninna","nanja","nann","nanna","nanne","nannett","nanni","nannie","nannina","nanny","nanzie","naomi","naranja","nastacha","nastasia","natacha","natali","natalia","natalie","natalina","natallia","natascha","natasha","natashia","natasia","natasja","natazja","nathali","nathalia","nathalie","nathasja","nathia","nathja","nauja","naya","nazia","nedda","nedja","neel","neela","neema","neia","neija","neika","nel","nele","nelie","nell","nella","nelle","nelli","nellie","nelly","nen","nena","nene","nenna","nessie","neta","nete","nethe","netta","nette","netti","nettie","netty","nezita","nia","niccie","nicha","nichole","nicholine","nicka","nickeline","nickie","nicla","nicola","nicolaia","nicole","nicolett","nicoletta","nicolette","nicolina","nicoline","nidia","niela","nielda","niella","nielle","nielsigne","nielsine","nienke","nikka","nikkie","nikola","nikole","nikolette","nikolina","nikoline","nilda","nile","nilla","nille","nilsine","nima","nina","nine","ninea","ninel","ninell","ninet","ninett","ninette","nini","ninia","niniane","ninja","ninka","ninkie","ninna","ninne","ninni","ninnie","ninon","niobe","nissine","nita","nitta","nivi","nizita","noa","noelle","noëlle","noemi","nolita","nomi","nona","nonie","nonni","nonny","noomi","nora","nore","noreen","norma","nuka","nya","nynne","nøk","nøks","nønne","octavia","oda","odette","odile","odine","ofelia","ofelie","oktavia","olava","olavia","olea","olefine","olga","olina","oline","olise","oliva","olive","olivia","olla","olu","oluffa","olufine","olympia","ona","oona","ophelia","osa","othenia","othilde","othilia","othilie","othine","otilia","otilie","otine","otta","ottella","otthilie","ottilia","ottilie","ottine","ottoline","ottomine","ova","ovine","owa","paja","palma","pam","pamela","pansy","paola","paprika","parilla","parmona","pascale","patricia","patrizia","patti","paula","paulette","paulina","pauline","paulowa","payana","pearl","peggy","peja","penelope","penille","pennie","penny","perline","pernelle","pernilla","pernille","peta","petina","petra","petrea","petrine","petronella","petronelle","philipa","philippa","philippine","phillippa","phoebe","phyllis","pi","pia","pialone","pian","pianna","pierette","pietta","piia","pil","pilar","pina","pipaluk","pipi","pippi","pirette","piyanna","polenka","poline","polly","poula","poulina","pouline","povla","povline","primula","prisca","priscilla","priska","prudence","puk","pusle","queenie","quinnie","rachel","ragna","ragnhild","raja","rakel","ramona","randa","randi","randy","rania","ranja","ranva","ranveig","raquel","rasmine","raymonde","rebecca","rebecka","rebekka","rebekke","regina","regine","regisse","regitse","regitta","regitza","regitze","reidun","reila","rena","renata","renate","renathe","renee","renée","reni","renie","rennette","reta","rhea","rhina","rhoda","ria","riborg","ricka","rie","rieke","rienette","rigborg","rigmor","riitta","rikka","rikke","rikkie","rilla","rima","rina","rinda","rine","rinette","rinie","rinna","rinnie","risa","rise","rit","rita","rith","ritha","ritt","ritta","ritte","ritva","ritza","roberta","rola","roma","rona","ronia","ronja","ronnie","rosa","rosalia","rosalie","rosalil","rosalina","rosalind","rosalinda","rosalinde","rosamunda","rosann","rosanna","rosanne","rosaura","rose","rosea","roseanna","roseanne","roselil","roselille","roseline","rosemarie","rosemary","rosette","rosie","rosina","rosine","rosita","rositha","rositta","roska","rota","rovena","rowena","roxanna","roxanne","rozetta","rubi","rubina","ruby","ruddie","runa","runna","rusla","rut","ruth","rya","ryle","røskva","sabbie","sabina","sabine","sabrina","sabrine","sacha","sadia","sadie","safie","safina","safira","saga","sagara","sahra","saida","saima","saisa","sakina","salca","salina","salka","salli","sallie","sally","saloma","salome","samanda","samantha","samara","samia","samilla","samina","samira","sana","sandie","sandra","sandrine","sane","sangita","sania","sanina","sanita","sanja","sanna","sannah","sanne","sanni","sannie","sara","sarah","sardia","sari","sarina","sarsa","sasa","sascha","sasha","sashia","sasia","sasja","saskia","sassia","sava","savanna","savannah","scarlet","scarlett","schanne","schannie","scharlett","schastine","sebina","sebora","sebrina","sebrine","sedsel","seia","seija","sekita","selana","selene","selina","selinda","seline","sella","selma","semina","semine","senia","senna","sennella","sennet","senta","sera","serena","serina","serine","sesil","sesilie","sessa","sesse","sessel","sessie","sette","severina","severine","shaila","shandie","shanice","shanna","shannet","shannie","shanny","shanta","sharin","sharon","sheba","sheena","sheila","shelly","shessa","shila","shilla","shirian","shirinja","shirley","shiva","sia","sibille","sibyl","sibylla","sibylle","sickan","sidonia","sidonie","sidse","sidsel","siemona","sif","siff","sifka","sigborg","sigbrit","sigbrith","sigbritt","sigga","signa","signe","signi","signild","signy","sigrid","sigrun","sigrunn","sigyn","sika","sikita","sikka","sila","silja","silje","silke","silla","sille","silpa","silva","silvana","silvania","silvia","simikka","simona","simone","simonia","simonie","sina","sindet","sine","sinette","sinika","sinikka","sinja","sinna","sinne","sinned","sinnet","sinnika","sira","sire","siri","siria","sirid","sirikit","sisan","sisell","sisi","sisie","siska","sissa","sissan","sisse","sissel","sissi","sissie","sita","sitia","sitta","siv","siva","siw","smila","smilla","snerle","snæja","soffi","soffie","soffy","sofia","sofie","sofja","sol","solbjørg","solbritt","solfred","solfrid","solfrida","solfried","solgerd","solrun","solvei","solveig","solvej","solvejg","solvig","solweig","sonia","sonja","sonna","sophia","sophie","sophy","soraya","sorcha","sorella","stasia","stasie","steena","stefani","stefania","stefanie","steffani","steffanie","steffannie","steffenie","steffi","steffie","steffy","stefine","steinbjørg","stella","stence","stends","stenia","stenja","stenna","stens","stense","stenze","stephani","stephania","stephanie","stephenie","stephie","stiane","stina","stine","stinna","stinne","sue","sulaima","sulajma","suleima","sulejma","suna","sunette","sunie","sunita","sunn","sunna","sunniva","sunny","sunrid","sus","susan","susana","susann","susanna","susannah","susanne","susette","susi","susia","susie","sussan","sussanne","susse","susser","sussi","sussie","sussy","susy","suzan","suzana","suzann","suzanna","suzannah","suzanne","suzett","suzette","suzi","suzie","suzy","svala","svanhild","svava","svea","sybilla","sybille","sylva","sylvette","sylvia","sylvie","synne","synned","synnøve","syrena","syrene","sys","syssan","sysse","syster","syzett","sølva","sølve","sølvi","sølvig","sørina","sørine","søs","søsser","søster","tabia","tabina","tabine","tabita","tabitha","tabithe","tabitta","tacha","tadea","tagea","tahira","taia","taija","taila","taimi","taina","taja","tajanna","talena","talia","talita","talli","tama","tamar","tamara","tami","tamira","tammie","tamra","tana","tania","tanita","tanja","tanna","tanne","tanni","tannia","tannie","tanya","tara","tarita","tascha","tasha","tashina","tasia","tasja","tassa","tatania","tatiana","tatiane","tatjana","tatyana","tea","tebina","tecla","teda","teela","teena","teia","tekla","telena","telma","telse","tena","tene","tenja","tenna","tennie","tenya","teodora","teresa","terese","teresia","terja","terka","terna","terne","tescha","tess","tessa","tessie","tetina","thala","thalia","thamara","thania","thanja","thara","thaya","thea","theana","thecla","theila","thekla","thelma","thelse","thenna","theodora","theona","theone","theresa","therese","theresia","therna","thessa","thia","thilda","thilde","thilla","thina","thine","thinka","thinne","thit","thoma","thomasine","thomassine","thomina","thomine","thora","thorbjørg","thorborg","thordis","thorgerd","thorgun","thorhild","thorid","thorny","thorun","thorunn","thrine","thuri","thurid","thusnelda","thyra","thyre","tia","tiana","tiane","tida","tienna","tiffanie","tiffany","tiina","tika","tila","tilda","tilde","tilia","tilka","tilla","tille","tillie","tillike","tilse","timia","timian","timie","tina","tine","tinea","tineke","tinella","tinemarie","tinie","tinja","tinka","tinna","tinne","tinnie","tira","tirsa","tirza","tirzah","titica","titika","titina","titta","titte","titti","tjana","toa","tola","tolva","toma","tomasine","tomassine","tomine","tona","tone","tonie","tonika","tonita","tonja","tonje","tonnie","tonya","tora","torbjørg","torborg","tordis","torgerd","torgun","torhild","torid","toril","torny","torun","torunn","tova","tove","tracey","traute","trein","trice","tricia","trille","trina","trine","trineke","trinka","trinke","trude","trudi","tua","tudi","tudlik","tula","tulla","tullia","tullik","tuna","turi","turid","tusnelda","tut","tutt","tutta","tutte","tuula","tyra","tyre","tytte","ula","ulfhild","ulja","ulla","ulrica","ulricca","ulricha","ulrika","ulrike","ulrikka","ulrikke","una","unn","unna","unni","unnie","urd","ursa","ursula","uta","ute","utrilla","vagna","vaike","valborg","valentina","valentine","valeria","valerie","valgerd","valgerda","valinka","valli","vallie","vally","vanda","vanessa","vanja","varinka","varla","varna","vava","vebina","vega","veinta","vejdi","vela","venca","venche","vencke","vendela","vendele","vendla","venessa","venetia","veni","venia","venke","vera","verena","verna","vernie","vernill","veronica","veronika","veronique","vesla","vesta","vetsera","via","viana","vianna","vianne","vibe","vibecke","vibeka","vibeke","vibekka","vibekke","viben","vibs","vibse","vica","vicha","vicki","vickie","vicky","victoria","vigdis","vigga","vika","viki","vikie","vikka","vikke","vikki","viktoria","viktorine","vilda","vilhelma","vilhelmina","vilhelmine","vilia","vilja","vilma","vilna","vina","vinca","vincentia","vindie","vineke","vini","vinie","vinifred","vinja","vinka","vinna","vinni","vinnie","vinnifred","viol","viola","violet","violetta","violette","vips","vipsen","vira","virginia","vita","vitha","vitta","viva","vivan","viveca","viveth","vivette","vivi","vivia","vivian","viviane","viviann","vivianna","vivianne","vivica","vivie","vivien","vivienne","vivika","vogelia","vonnie","vår","wagna","walborg","walentine","waleria","walli","wally","wanda","wanja","warla","warna","weena","wela","wenche","wencke","wendie","wendy","wenja","wera","werna","wibeke","wicki","wickie","wicky","wigga","wiki","wiktoria","wilda","wilhelma","wilhelmina","wilhelmine","wilja","wilma","wina","wini","winie","winifred","winna","winni","winnie","winnifred","winona","wiola","wita","witha","witta","wivan","wiveca","wivi","wivian","wivianne","wiwi","wiwica","wyrna","xana","xandra","xenia","xina","yade","yael","yana","yanina","yasmin","yasmina","yazmin","yda","ydun","yelva","yessica","ylva","ynette","yngva","yolanda","yoma","yonna","yrsa","ysette","ytta","ytte","yvette","yvon","yvonn","yvonna","yvonne","zabina","zabrina","zahra","zaina","zakia","zalina","zana","zandra","zanette","zanna","zanne","zannie","zanny","zanya","zara","zarah","zarifa","zarina","zascha","zaza","zazia","zebina","zebora","zelia","zelina","zeline","zella","zelma","zema","zena","zenia","zenika","zenja","zenna","zennia","zennie","zenobia","zenta","zerafine","zerina","zerlina","zessa","zia","zickan","zida","ziga","ziggie","zilla","zille","zina","zinaida","zindy","zinita","zira","ziska","zissi","zita","zitha","zitta","zoe","zofia","zofie","zofja","zophia","zophie","zosia","zusanne","zuzan","zuzanne","zuzette","ågot","aagot","åsa","aasa","åse","aase"
    };

    public static bool isGirl(String name)
    {
        name = name.ToLower;
        for (int i = 0; i < femaleNames[i]; i++)
        {
            if (name.Equals(femaleNames[i]))
            {
                return true;
            }
        }
        return false;
    }
}
