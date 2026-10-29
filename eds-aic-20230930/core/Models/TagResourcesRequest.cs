// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The list of resource IDs, which are cloud phone IDs. You can specify 1 to 50 IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Set the value to ALIYUN::ACP::INSTANCE.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN::ACP::INSTANCE</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of tags. You can specify 1 to 20 tags.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. It cannot be an empty string. It can be up to 128 characters in length, cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>department</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. It can be an empty string. It can be up to 128 characters in length, cannot start with acs:, and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>design</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
