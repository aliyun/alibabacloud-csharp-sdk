// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyConsumerGroupPasswordRequest : TeaModel {
        /// <summary>
        /// The ID of the Alibaba Cloud account. You do not need to specify this parameter because this parameter will be removed in the future.
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The ID of the consumer group.
        /// 
        /// You can call the [DescribeConsumerGroup](https://help.aliyun.com/document_detail/122886.html) operation to query the consumer group ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConsumerGroupID")]
        [Validation(Required=false)]
        public string ConsumerGroupID { get; set; }

        /// <summary>
        /// The name of the consumer group. You can call the [DescribeConsumerGroup](https://help.aliyun.com/document_detail/122886.html) operation to query the consumer group name.
        /// </summary>
        [NameInMap("ConsumerGroupName")]
        [Validation(Required=false)]
        public string ConsumerGroupName { get; set; }

        /// <summary>
        /// The current password of the consumer group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConsumerGroupPassword")]
        [Validation(Required=false)]
        public string ConsumerGroupPassword { get; set; }

        /// <summary>
        /// The username of the consumer group. You can call the [DescribeConsumerGroup](https://help.aliyun.com/document_detail/122886.html) operation to query the username.
        /// </summary>
        [NameInMap("ConsumerGroupUserName")]
        [Validation(Required=false)]
        public string ConsumerGroupUserName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the change tracking instance. You can call the DescribeSubscriptionInstances operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SubscriptionInstanceId")]
        [Validation(Required=false)]
        public string SubscriptionInstanceId { get; set; }

        /// <summary>
        /// The new password of the consumer group.
        /// 
        /// *   A password must contain two or more of the following characters: uppercase letters, lowercase letters, digits, and special characters.
        /// *   A password must be 8 to 32 characters in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("consumerGroupNewPassword")]
        [Validation(Required=false)]
        public string ConsumerGroupNewPassword { get; set; }

    }

}
