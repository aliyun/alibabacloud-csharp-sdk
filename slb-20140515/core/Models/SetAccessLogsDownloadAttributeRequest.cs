// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class SetAccessLogsDownloadAttributeRequest : TeaModel {
        /// <summary>
        /// The ID of the CLB instance.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The access log forwarding rule. Parameters:
        /// 
        /// *   **LogProject**: the name of the project.
        /// *   **LogStore**: the name of the Logstore.
        /// *   **LoadBalancerId**: the ID of the CLB instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LogsDownloadAttributes")]
        [Validation(Required=false)]
        public string LogsDownloadAttributes { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the CLB instance is deployed.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/27584.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The tags that are added to the CLB instance. The tags must be key-value pairs that are contained in a JSON dictionary.
        /// 
        /// You can specify up to 10 tags in each call.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
