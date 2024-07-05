// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ModifyRenderingInstanceBandwidthRequest : TeaModel {
        [NameInMap("MaxEgressBandwidth")]
        [Validation(Required=false)]
        public int? MaxEgressBandwidth { get; set; }

        [NameInMap("MaxIngressBandwidth")]
        [Validation(Required=false)]
        public int? MaxIngressBandwidth { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

    }

}
