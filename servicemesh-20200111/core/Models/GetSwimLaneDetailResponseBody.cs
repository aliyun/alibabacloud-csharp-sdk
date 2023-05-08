// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetSwimLaneDetailResponseBody : TeaModel {
        /// <summary>
        /// The traffic routing rule that routes traffic to the lane by using the ingress gateway. The traffic routing rule contains one or more custom routes.
        /// </summary>
        [NameInMap("IngressRule")]
        [Validation(Required=false)]
        public string IngressRule { get; set; }

        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("IngressService")]
        [Validation(Required=false)]
        public string IngressService { get; set; }

        /// <summary>
        /// Fixed value: **ASM_TRAFFIC_TAG**.
        /// </summary>
        [NameInMap("LabelSelectorKey")]
        [Validation(Required=false)]
        public string LabelSelectorKey { get; set; }

        /// <summary>
        /// The value of ASM_TRAFFIC_TAG.
        /// </summary>
        [NameInMap("LabelSelectorValue")]
        [Validation(Required=false)]
        public string LabelSelectorValue { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// A list of services associated with the lane.
        /// </summary>
        [NameInMap("ServicesList")]
        [Validation(Required=false)]
        public string ServicesList { get; set; }

    }

}
