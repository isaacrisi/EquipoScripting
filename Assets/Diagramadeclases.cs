+------------------+        +------------------+        +------------------+
|      Player      |        |      Enemy       |        |      Platform    |
+------------------+        +------------------+        +------------------+
| +int Vida        |        | +string Posicion |        | +string Posicion |
| +string Posicion |        | +int Danio       |        | +string Tipo     |
| +float Velocidad |        | +string PatronMov|        +------------------+
| +bool DobleSalto |        +------------------+        | +Interactuar()   |
| +float JetPackT  |        | +Mover()         |        +------------------+
+------------------+        | +HacerDano()     |               ^
| +Mover()         |        +------------------+               |
| +Saltar()        |                 ^                         |
| +DobleSaltar()   |                 |            +------------+------------+
| +UsarJetPack()   |                 |            |            |            |
| +EmpujarObjeto() |        +--------+-------+    |            |            |
| +RecibirDano()   |        |                |    |            |            |
| +RecogerPowerUp()|        |                |    |            |            |
+------------------+        |                |    |            |            |
         ^                  |                |    |            |            |
         |                  |                |    |            |            |
         |           +------+------+  +------+------+  +------+------+
+--------+-------+   |MovingPlatform|  |FallingPlatfm|  |PushablePlatf|
|   GameManager  |   +-------------+  +-------------+  +-------------+
+----------------+   |+string Direcc|  |+float TiempoR|  |+float Peso   |
|+DetectarGameOv |   |+float Velocid|  +-------------+  +-------------+
|+ReaparecerJug  |   +-------------+
|+GuardarProgreso|
+----------------+
                          +------------------+
                          |       Item       |
                          +------------------+
                          | +string Posicion |
                          +------------------+
                                   ^
                                   |
                  +----------------+----------------+
                  |                |                |
          +-------+------+  +------+------+  +------+------+
          |   PowerUp    |  |    Coin     |  |     Key     |
          +--------------+  +-------------+  +-------------+
          |+float Duracion|  |+int Valor   |  |+string IdPu |
          +--------------+  +-------------+  +-------------+


                  +------------------+
                  |      Level       |
                  +------------------+
                  | +int NumeroNivel |
                  | +List<str> Obst  |
                  | +List<Enemy> Enem|
                  | +List<str> Puntos|
                  +------------------+
                  | +Iniciar()       |
                  | +Reiniciar()     |
                  | +CargarSigNivel()|
                  +------------------+
                          |
                          v
                  +------------------+
                  |      Enemy       |
                  +------------------+
