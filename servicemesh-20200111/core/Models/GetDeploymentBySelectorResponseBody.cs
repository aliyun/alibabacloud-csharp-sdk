// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetDeploymentBySelectorResponseBody : TeaModel {
        /// <summary>
        /// The queried workloads.
        /// </summary>
        [NameInMap("DeploymentNameList")]
        [Validation(Required=false)]
        public List<byte[]> DeploymentNameList { get; set; }

        /// <summary>
        /// The end-of-data marker.
        /// </summary>
        [NameInMap("Mark")]
        [Validation(Required=false)]
        public string Mark { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
