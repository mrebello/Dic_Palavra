global using static HotLoja.Database.SQL;

namespace HotLoja.Database {
    public class BDs : BD_simples {
        public BDs() : base(null) {
        }
        public BD_simples Loja = new BD_simples("HotPDV");
    }

    public static class SQL {
        public static BDs BD = new BDs();
    }
}