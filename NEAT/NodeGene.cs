using System;
using System.Collections.Generic;
using System.Text;

namespace NEAT
{
    class NodeGene
    {
        int nodeType;
        bool enabled;
        int inConnection;
        int outConnection;
        float weight;
        int innovationNum;//https://stackoverflow.com/questions/41985169/neuroevolution-neat-algorithm-innovation-numbers
        //Sigmoid function

        public NodeGene(int nodeType, bool enabled, int inConnection, int outConnection, float weight, int innovationNum)
        {
            this.nodeType = nodeType;
            this.enabled = enabled; 
            this.inConnection = inConnection;
            this.outConnection = outConnection;
            this.weight = weight;
            this.innovationNum = innovationNum;
        }

        public void disableNode(NodeGene gene)
        {
            gene.enabled = false;
        }

        public void enableNode(NodeGene gene)
        {
            gene.enabled = true;
        }

        public int getInnovationNum(NodeGene gene)
        {
            return gene.innovationNum;
        }

        public void setWeight(NodeGene gene, float weight)
        {
            gene.weight = weight;
        }
    }
}
