// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsGroupListRequest : TeaModel {
        /// <summary>
        /// This parameter is required only when you query specific consumer groups by using the fuzzy query method. If this parameter is not configured, the system queries all consumer groups that can be accessed by the current account.
        /// 
        /// If you set this parameter to GID_ABC, the information about the consumer groups whose IDs contain GID_ABC is returned. For example, the information about the GID_test_GID_ABC\_123 and GID_ABC\_356 consumer groups is returned.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The protocol over which the queried consumer groups consume messages. All clients in a consumer group communicate with the Message Queue for Apache RocketMQ broker over the same protocol. A consumer group cannot contain TCP clients and HTTP clients at the same time. You must create different consumer groups for TCP clients and HTTP clients. Valid values:
        /// 
        /// *   **tcp**: specifies the consumer groups that consume messages over TCP. This is the default value.
        /// *   **http**: indicates that the consumer group consumes messages over HTTP.
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// The ID of the instance to which the consumer group you want to query belongs.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The list of tags that are attached to the consumer group. A maximum of 20 tags can be included in the list.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<OnsGroupListRequestTag> Tag { get; set; }
        public class OnsGroupListRequestTag : TeaModel {
            /// <summary>
            /// The key of a tag that is attached to the consumer group. This parameter is not required. If you configure this parameter, you must configure the **Tag.N.Value** parameter.**** If you configure both the Tag.N.Key and Tag.N.Value parameters, the group IDs are filtered based on the specified tag. If you do not configure these parameters, all group IDs are queried.
            /// 
            /// *   The value of this parameter cannot be an empty string.
            /// *   The tag key can be up to 128 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag that is attached to the group. This parameter is not required. If you configure this parameter, you must configure the **Tag.N.Value** parameter.**** If you configure both the Tag.N.Key and Tag.N.Value parameters, the group IDs are filtered based on the specified tag. If you do not configure these parameters, all group IDs are queried.
            /// 
            /// *   The value of this parameter can be an empty string.
            /// *   The tag key can be up to 128 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
