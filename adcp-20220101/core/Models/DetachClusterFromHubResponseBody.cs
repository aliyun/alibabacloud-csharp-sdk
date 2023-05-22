// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DetachClusterFromHubResponseBody : TeaModel {
        /// <summary>
        /// Zhishi
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ManagedClusterIds")]
        [Validation(Required=false)]
        public List<string> ManagedClusterIds { get; set; }

        /// <summary>
        /// You can call the DetachClusterFromHub operation to disassociate clusters from a master instance.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
