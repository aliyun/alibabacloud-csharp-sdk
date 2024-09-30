// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListTargetsForPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the object belongs to the resource directory. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The object belongs to the resource directory. This value is available if you use the Tag Policy feature in multi-account mode.</description></item>
        /// <item><description>false: The object does not belong to the resource directory. This value is available if you use the Tag Policy feature in single-account mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsRd")]
        [Validation(Required=false)]
        public bool? IsRd { get; set; }

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
        /// <para>The ID of the resource directory.</para>
        /// <remarks>
        /// <para> This parameter is returned only if you use the Tag Policy feature in multi-account mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rd-3G****</para>
        /// </summary>
        [NameInMap("RdId")]
        [Validation(Required=false)]
        public string RdId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2EE71C8D-6DB8-56AC-8B05-3D4C0116E6A1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The objects to which the tag policy is attached.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<ListTargetsForPolicyResponseBodyTargets> Targets { get; set; }
        public class ListTargetsForPolicyResponseBodyTargets : TeaModel {
            /// <summary>
            /// <para>The ID of the object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>195320939469****</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The type of the object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>USER: the current logon account. This value is available if you use the Tag Policy feature in single-account mode.</description></item>
            /// <item><description>ROOT: the Root folder in the resource directory. This value is available if you use the Tag Policy feature in multi-account mode.</description></item>
            /// <item><description>FOLDER: a folder other than the Root folder in the resource directory. This value is available if you use the Tag Policy feature in multi-account mode.</description></item>
            /// <item><description>ACCOUNT: a member in the resource directory. This value is available if you use the Tag Policy feature in multi-account mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACCOUNT</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public int? TargetType { get; set; }

        }

    }

}
