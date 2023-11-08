// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeCensResponseBody : TeaModel {
        /// <summary>
        /// The list of Kubernetes clusters that are added to the same ASM instance but are in different VPCs and are not connected by using a Cloud Enterprise Network (CEN) instance.
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<string> Clusters { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
