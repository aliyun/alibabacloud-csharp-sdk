// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class EdgeClusterAddEdgeMachineResponseBody : TeaModel {
        /// <summary>
        /// edge machine id
        /// </summary>
        [NameInMap("edge_machine_id")]
        [Validation(Required=false)]
        public string EdgeMachineId { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
