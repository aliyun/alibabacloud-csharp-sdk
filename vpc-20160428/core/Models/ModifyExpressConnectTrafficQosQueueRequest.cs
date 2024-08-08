// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyExpressConnectTrafficQosQueueRequest : TeaModel {
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
        /// You can use the client to generate the value, but you must ensure that the value is unique among all requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, the system uses **RequestId** as **ClientToken**. **RequestId** might be different for each API request.
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
        /// The description must be 0 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("QueueDescription")]
        [Validation(Required=false)]
        public string QueueDescription { get; set; }

        /// <summary>
        /// The ID of the QoS queue.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("QueueId")]
        [Validation(Required=false)]
        public string QueueId { get; set; }

        /// <summary>
        /// The name of the QoS queue.
        /// 
        /// The name must be 0 to 128 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

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
