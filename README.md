# BaigiamasisDarbasSilvija
 ## [Vinted.lt](https:www.vinted.lt)

  1. Scenario.Get information "Registruojantis panaudojau neteisingą el. pašto adresą" (Precondition: Website is open)
     1. Saving the created search
     2. Click "Registruotis|Prisijungti" button
     3. Click  "el.paštu" button
     4. Fill "El.paštas arba vartotojo vardas"
     5. Fill "Slaptažodis"
     6. Click "Tęsti" button
     7. Click "Reikia pagalbos?"
     8. Click "Registruojantis panaudojau neteisingą el. pašto adresą"
     9. Click button "Susisiek su mumis"
     10. *Assert* that vissible button "Problemos aprašymas"
 2. Scenario. Login (Precondition : Website is open)
     1. Login with existing user name
        1. Click "Registruotis|Prisijungti" button
        2. Click "el.paštu" button
        3. Fill " El.paštas arba vartotojo vardas" with "demo141488"
        4. Fill "Slaptažodis" with "Demo881414"
        5. Click "Tęsti" button
        6. *Assert* that "Mano paskyra" button is visible
    1. Login with non-existing user name
        1. Click "Registruotis|Prisijungti" button
        2. Click "el.paštu" button
        3. Fill " El.paštas arba vartotojo vardas" with "demo"
        4. Fill "Slaptažodis" with "Demo"
        5. Click "Tęsti" button
        6. *Assert* that error message "Neteisingas prisijungimo vardas arba slaptažodis " is displayed

 
3. Scenario.Favourited items(Precondition: Website is open and you have to be login)
     1. Favourited items enabling and disabling
        1. Click button "Vaikams"
        2. Click "Kūdykių ir vaikų priežiūra"
        3. Click "Kūdykių nešynės, vaikjuostės"
        4. Click "Prek.ženklas"
        5. Select "Tricot"
        7. Click to order
        8. Click "Pažymėti"
        6. *Assert* that heart icon is red 
    1. Favourited items disabling (Precondition:order heart icon is red )
        1. Click heart icon
        2. *Assert* that heart icon is non-red

4. Scenario.Adding the order  (Precondition: Website is open and you have to be login)
     1. Favourited items enabling and disabling
        1. Click button "Vaikams"
        2. Click "Kūdykių ir vaikų priežiūra"
        3. Click "Kūdykių nešynės, vaikjuostės"
        4. Click "Prek.ženklas"
        5. Select "Tricot"
        7. Click  to order
        8. Click "Pirkti"
        6. *Assert* "Mokėti dabar" is vissible
5. Scenario.Saving search (Precondition: Website is open and you have to be login)
     1. Saving the created search
        1. Click button "Vaikams"
        2. Click "Kūdykių ir vaikų priežiūra"
        3. Click "Kūdykių nešynės, vaikjuostės"
        4. Click "Prek.ženklas"
        5. Select "Tricot"
        7. Click to order
        8. Click "Išsaugoti paiešką"
        6. *Assert* that "Ištrinti paiešką" is vissible 
    1. Delete saving search (Precondition: "Ištrinti paiešką" is vissible)
        1. Click "Ištrinti paiešką"
        2. *Assert* "Išsaugoti paiešką"






