

using System;

using Niantic.ARDK.Networking;
using Niantic.ARDK.Networking.HLAPI.Data;
using Niantic.ARDK.Networking.HLAPI.Object.Unity;

using UnityEngine;


  [RequireComponent(typeof(AuthBehaviour))]
  public class playerbehaviour: NetworkedBehaviour
  {

    protected override void SetupSession
    (
      out Action initializer,
      out int order
    )
    {
      initializer = () =>
      {
        var auth = GetComponent<AuthBehaviour>();

        new UnreliableBroadcastTransformPacker
        (
          "netTransform",
          transform,
          auth.AuthorityToObserverDescriptor(TransportType.UnreliableUnordered),
          TransformPiece.Position,
          Owner.Group
        );
      };

      order = 0;
    }
  }

