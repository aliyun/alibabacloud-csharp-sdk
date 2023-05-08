// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeGuestClusterPodsResponseBody : TeaModel {
        /// <summary>
        /// The names of the queried pods.
        /// </summary>
        [NameInMap("PodList")]
        [Validation(Required=false)]
        public List<string> PodList { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
