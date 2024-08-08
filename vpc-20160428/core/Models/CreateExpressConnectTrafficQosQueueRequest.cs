// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateExpressConnectTrafficQosQueueRequest : TeaModel {
        /// <summary>
        /// The percentage of bandwidth allocated to the QoS queue.
        /// 
        /// *   If QueueType is set to **Medium**, this parameter is required. Valid values: 1 to 100.
        /// *   If QueueType is set to **Default**, a value of - is returned.
        /// </summary>
        [NameInMap("BandwidthPercent")]
        [Validation(Required=false)]
        public string BandwidthPercent { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among all requests. ClientToken can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the QoS policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("QosId")]
        [Validation(Required=false)]
        public string QosId { get; set; }

        /// <summary>
        /// The description of the QoS queue.
        /// 
        /// It must be 0 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("QueueDescription")]
        [Validation(Required=false)]
        public string QueueDescription { get; set; }

        /// <summary>
        /// The name of the QoS queue.
        /// 
        /// It must be 0 to 128 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        /// <summary>
        /// The priority of the QoS queue. Valid values:
        /// 
        /// *   **High**
        /// *   **Medium**
        /// *   **Default**: default queue.
        /// 
        /// > You cannot create a QoS queue of the default priority.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("QueueType")]
        [Validation(Required=false)]
        public string QueueType { get; set; }

        /// <summary>
        /// The region ID of the QoS policy.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

    }

}
