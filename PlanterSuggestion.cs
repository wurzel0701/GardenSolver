using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenSolver
{
    internal class PlanterSuggestion
    {
        public Planter Planter => m_planter;

        private Planter m_planter;

        public string PlantType => m_plantTypeName;

        private string m_plantTypeName;

        public bool IsInternal => m_target == null;

        private Planter? m_target;

        public bool ShouldAdd => m_shouldAdd;

        private bool m_shouldAdd;

        public float Rating => m_rating;

        private float m_rating;


        public PlanterSuggestion(Planter planter, string plantTypeName, float rating) 
        {
            m_planter = planter;
            m_target = null;
            m_plantTypeName = plantTypeName;
            m_rating = rating;
        }

        public PlanterSuggestion(Planter from, Planter to, string plantTypeName, float rating) 
        {
            m_planter = from;
            m_plantTypeName = plantTypeName;
            m_target= to;
            m_rating = rating;
        }
    }
}
