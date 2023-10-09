// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreateConsumerGroupRequest : TeaModel {
        /// <summary>
        /// The name of the consumer group.
        /// 
        /// *   The value can contain only letters, digits, hyphens (-), and underscores (\_), and the value must contain at least one letter or digit.
        /// *   The value must be 3 to 128 characters in length. If the value that you specify contains more than 128 characters, the system automatically truncates the value to 128 characters.
        /// *   After a consumer group is created, you cannot change the name of the consumer group.
        /// </summary>
        [NameInMap("ConsumerId")]
        [Validation(Required=false)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The description of the consumer group.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateConsumerGroupRequestTag> Tag { get; set; }
        public class CreateConsumerGroupRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N.
            /// 
            /// *   Valid values of N: 1 to 20.
            /// *   You must specify this parameter.
            /// *   The tag key can be up to 128 characters in length and cannot contain [http:// or https://](http://https://。). The tag key cannot start with acs: or aliyun.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N.
            /// 
            /// *   Valid values of N: 1 to 20.
            /// *   You can leave this parameter empty.
            /// *   The tag value can be 1 to 128 characters in length and cannot start with acs: or aliyun or contain [http:// or https://.](http://https://。)
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
