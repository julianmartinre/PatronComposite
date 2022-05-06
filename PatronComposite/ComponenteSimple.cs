using System.Collections.Generic;

namespace PatronComposite
{
    public class ComponenteSimple : Componente
    {
        public override IList<Componente> Hijos
        {
            get
            {
                return new List<Componente>();
            }
        }

        public override void AgregarHijo(Componente c)
        {

        }

        public override void VaciarHijos()
        {

        }
    }
}
