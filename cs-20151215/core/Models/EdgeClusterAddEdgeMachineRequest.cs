// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class EdgeClusterAddEdgeMachineRequest : TeaModel {
        /// <summary>
        /// expired
        /// </summary>
        [NameInMap("expired")]
        [Validation(Required=false)]
        public long? Expired { get; set; }

        /// <summary>
        /// nodepool_id
        /// </summary>
        [NameInMap("nodepool_id")]
        [Validation(Required=false)]
        public string NodepoolId { get; set; }

        /// <summary>
        /// options
        /// </summary>
        [NameInMap("options")]
        [Validation(Required=false)]
        public string Options { get; set; }

    }

}
