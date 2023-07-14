// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class AddIntegrationRequest : TeaModel {
        /// <summary>
        /// The ID of an Alibaba Cloud Container Service for Kubernetes cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The software abbreviation that is supported by ARMS. Valid values (case-insensitive): `ASM`, `IoT`, and `Flink`.
        /// </summary>
        [NameInMap("Integration")]
        [Validation(Required=false)]
        public string Integration { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
