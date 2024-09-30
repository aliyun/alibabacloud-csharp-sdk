// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class GetPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the tag policy.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public GetPolicyResponseBodyPolicy Policy { get; set; }
        public class GetPolicyResponseBodyPolicy : TeaModel {
            /// <summary>
            /// <para>The document of the tag policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;tags\&quot;:{\&quot;CostCenter\&quot;:{\&quot;tag_value\&quot;:{\&quot;@@assign\&quot;:[\&quot;Beijing\&quot;,\&quot;Shanghai\&quot;]},\&quot;tag_key\&quot;:{\&quot;@@assign\&quot;:\&quot;CostCenter\&quot;}}}}</para>
            /// </summary>
            [NameInMap("PolicyContent")]
            [Validation(Required=false)]
            public string PolicyContent { get; set; }

            /// <summary>
            /// <para>The description of the tag policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a tag policy example.</para>
            /// </summary>
            [NameInMap("PolicyDesc")]
            [Validation(Required=false)]
            public string PolicyDesc { get; set; }

            /// <summary>
            /// <para>The name of the tag policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The mode of the Tag Policy feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>USER: single-account mode</description></item>
            /// <item><description>RD: multi-account mode</description></item>
            /// </list>
            /// <para>For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1E7A4802-AB57-570A-9860-F15B60E1586B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
