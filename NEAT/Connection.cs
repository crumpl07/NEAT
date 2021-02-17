using System;
using System.Collections.Generic;
using System.Text;

namespace NEAT
{

    class Connection
    {
        List<int> inConnections;
        List<int> outConnections;
        float weight = 0;
        bool isEnabled = true;
        int innovationNum = 0;
        public Connection()
        {
            inConnections = new List<int>();
            outConnections = new List<int>();
            weight = 0;
            isEnabled = true;
            innovationNum = 0;
        }

        public Connection(int weight, int innovationNum)
        {
            this.weight = weight;
            isEnabled = true;
            this.innovationNum = innovationNum;
        }

        public void setWeight(int weight)
        {
            this.weight = weight;
        }

        public float getWeight(Connection connection)
        {
            return connection.weight;
        }

        public void disableConnection()
        {
            isEnabled = false;
        }

        public void enableConnection()
        {
            isEnabled = true;
        }

        public void setInnovationNum(int i)
        {
            innovationNum = i;
        }

        public int getInnovationNum(Connection connection)
        {
            return connection.innovationNum;
        }
    }
}
