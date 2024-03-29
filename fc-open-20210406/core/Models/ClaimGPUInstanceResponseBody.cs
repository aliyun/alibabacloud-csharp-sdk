// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ClaimGPUInstanceResponseBody : TeaModel {
        /// <summary>
        /// The time when the product instance is created.
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// The ID of the instance that you query.
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The public IP address of the server.
        /// </summary>
        [NameInMap("publicIp")]
        [Validation(Required=false)]
        public string PublicIp { get; set; }

    }

}
