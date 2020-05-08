using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;

namespace Project.Networking 
{
    public class NetworkClient : SocketIOComponent 
    {
    
        // Start is called before the first frame update
        public override void Start() 
        {
            base.Start();
            setupEvents();
        }

        // Update is called once per frame
        public virtual void Update() 
        {
            base.Update();        
        }

        private void setupEvents() 
        {
            On("open", (E) => 
            {
                Debug.Log("Connection made to the server");
            }); 
		}
    }
}