// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class CreateConsumerGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the Alibaba Cloud account. You do not need to specify this parameter because this parameter will be removed in the future.
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The name of the consumer group. The name cannot exceed 128 characters in length. We recommend that you use an informative name for easy identification.
        /// </summary>
        [NameInMap("ConsumerGroupName")]
        [Validation(Required=false)]
        public string ConsumerGroupName { get; set; }

        /// <summary>
        /// The password that corresponds to the username of the consumer group.
        /// 
        /// *   A password must contain two or more of the following characters: uppercase letters, lowercase letters, digits, and special characters.
        /// *   A password must be 8 to 32 characters in length.
        /// </summary>
        [NameInMap("ConsumerGroupPassword")]
        [Validation(Required=false)]
        public string ConsumerGroupPassword { get; set; }

        /// <summary>
        /// The username of the consumer group.
        /// 
        /// *   A username must contain one or more of the following characters: uppercase letters, lowercase letters, digits, and underscores (\_).
        /// *   A username cannot exceed 16 characters in length.
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

        /// <summary>
        /// The ID of the change tracking instance. You can call the DescribeSubscriptionInstances operation to query the instance ID.
        /// </summary>
        [NameInMap("SubscriptionInstanceId")]
        [Validation(Required=false)]
        public string SubscriptionInstanceId { get; set; }

    }

}
