using System.Collections.Generic;
using System.Linq;

namespace PatronComposite
{
    public class ComponenteCompuesto : Componente
    {
        private IList<Componente> _hijos;
        public ComponenteCompuesto()
        {
            _hijos = new List<Componente>();
        }

        public override IList<Componente> Hijos
        {
            get
            {
                return _hijos.ToArray();
            }

        }
        public override void VaciarHijos()
        {
            _hijos = new List<Componente>();
        }
        public override void AgregarHijo(Componente c)
        {
            _hijos.Add(c);
        }
    }
}
