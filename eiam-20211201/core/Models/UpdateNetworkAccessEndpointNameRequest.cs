// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateNetworkAccessEndpointNameRequest : TeaModel {
        /// <summary>
        /// IDaaS EIAM实例的ID。
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 专属网络端点ID。
        /// </summary>
        [NameInMap("NetworkAccessEndpointId")]
        [Validation(Required=false)]
        public string NetworkAccessEndpointId { get; set; }

        /// <summary>
        /// 专属网络端点名称。
        /// </summary>
        [NameInMap("NetworkAccessEndpointName")]
        [Validation(Required=false)]
        public string NetworkAccessEndpointName { get; set; }

    }

}
