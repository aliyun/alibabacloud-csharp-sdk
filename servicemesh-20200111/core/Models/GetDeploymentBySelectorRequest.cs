// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetDeploymentBySelectorRequest : TeaModel {
        /// <summary>
        /// The name of the cluster.
        /// </summary>
        [NameInMap("GuestCluster")]
        [Validation(Required=false)]
        public string GuestCluster { get; set; }

        /// <summary>
        /// The label selector information.
        /// </summary>
        [NameInMap("LabelSelector")]
        [Validation(Required=false)]
        public Dictionary<string, string> LabelSelector { get; set; }

        /// <summary>
        /// The maximum number of returned data entries.
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// The marker of data queried last time.
        /// </summary>
        [NameInMap("Mark")]
        [Validation(Required=false)]
        public string Mark { get; set; }

        /// <summary>
        /// The namespace.
        /// </summary>
        [NameInMap("NameSpace")]
        [Validation(Required=false)]
        public string NameSpace { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud Service Mesh (ASM) instance.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
