// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the next query is required.</para>
        /// <list type="bullet">
        /// <item><description>If the value of this parameter is empty (<c>&quot;NextToken&quot;: &quot;&quot;</c>), all results are returned, and the next query is not required.</description></item>
        /// <item><description>If the value of this parameter is not empty, the next query is required, and the value is the token used to start the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The tag policies.</para>
        /// </summary>
        [NameInMap("PolicyList")]
        [Validation(Required=false)]
        public List<ListPoliciesResponseBodyPolicyList> PolicyList { get; set; }
        public class ListPoliciesResponseBodyPolicyList : TeaModel {
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
            /// <para>The ID of the tag policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p-de62a0bf400e4b69****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The name of the tag policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
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
        /// <para>72477CFF-5B24-5E30-9861-3DD9C4BD46E5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
