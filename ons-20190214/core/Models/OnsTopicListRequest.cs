// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTopicListRequest : TeaModel {
        /// <summary>
        /// The ID of the instance that contains the topics you want to query.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The list of tags that are attached to the topic. A maximum of 20 tags can be included in the list.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<OnsTopicListRequestTag> Tag { get; set; }
        public class OnsTopicListRequestTag : TeaModel {
            /// <summary>
            /// The key of a tag that is attached to the topics you want to query. This parameter is not required. If you configure this parameter, you must also configure the **Tag.N.Value** parameter.**** If you include the Key and Value parameters in a request, this operation queries only the topics that use the specified tags. If you do not include these parameters in a request, this operation queries all topics that you can access.
            /// 
            /// *   The value of this parameter cannot be an empty string.
            /// *   The tag value can be up to 128 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of a tag that is attached to the topics you want to query. This parameter is not required. If you configure this parameter, you must also configure the **Tag.N.Key** parameter.**** If you include the Key and Value parameters in a request, this operation queries only the topics that use the specified tags. If you do not include these parameters in a request, this operation queries all topics that you can access.
            /// 
            /// *   The value of this parameter can be an empty string.
            /// *   The tag value can be up to 128 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The name of the topic that you want to query. This parameter is required when you want to query a specific topic. If you do not include this parameter in a request, all topics that you can access are queried.
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
