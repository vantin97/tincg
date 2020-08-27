using System;
using System.Collections.Generic;
using System.Linq;

namespace ToKhaiYTe.Models
{
    public class GateRepository : IGateRepository
    {
        private List<Gate> gates;
        public Gate Create(Gate gate)
        {
            gate.id = gates.Max(g => g.id) + 1;
            gates.Add(gate);
            return gate;
        }

        public Gate Edit(Gate gate)
        {
            var editGate = Get(gate.id);
            editGate.name = gate.name;
            editGate.IsDeleted = gate.IsDeleted;
            editGate.IsPublished = gate.IsPublished;
            return editGate;
        }

        public Gate Get(int id)
        {
            return gates.FirstOrDefault(g => g.id == id);
        }

        public IEnumerable<Gate> Gets()
        {
            return gates;
        }

        public bool IsDeleted(int id)
        {
            var delGate = Get(id);
            if(delGate != null)
            {
                gates.Remove(delGate);
                return true;
            }
            return false;
        }

        public bool IsPublished(int id)
        {
            var pubGate = Get(id);
            if(pubGate != null)
            {
                gates.up
            }
        }
    }
}
