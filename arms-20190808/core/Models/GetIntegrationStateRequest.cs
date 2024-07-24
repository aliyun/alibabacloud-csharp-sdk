// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetIntegrationStateRequest : TeaModel {
        /// <summary>
        /// The ID of the Container Service for Kubernetes (ACK) cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The abbreviation of the software that is supported by ARMS. Valid values (case-insensitive): `ASM`, `IoT`, and `Flink`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Integration")]
        [Validation(Required=false)]
        public string Integration { get; set; }

        /// <summary>
        /// The ID of the region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
