using System;
using System.Collections.Generic;
using System.Text;

namespace NEAT
{
    class Genome
    {
        int populationSize;

        public Genome(int populationSize)
        {
            this.populationSize = populationSize;
            List<NodeGene> Genome = new List<NodeGene>();
        }

        public void findInnovationNum()
        {
            //Checks if there is a Genome that has an innovation num
        }
        public void addNode()
        {
            //Adds a node and creates new connections in the hidden layer
            //Adds the new node with connections at the end of the array of nodes
        }

        public void addConnection()
        {
            //Adds a connection during mutation
            //Adds the connection to the end of the array of connections
        }

        public void removeConnection(NodeGene gene1, NodeGene gene2)
        {
            //Removes the connction between two genes
        }
    }
}
