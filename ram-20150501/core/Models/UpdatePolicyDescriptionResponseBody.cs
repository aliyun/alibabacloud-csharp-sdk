// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class UpdatePolicyDescriptionResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the policy.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public UpdatePolicyDescriptionResponseBodyPolicy Policy { get; set; }
        public class UpdatePolicyDescriptionResponseBodyPolicy : TeaModel {
            /// <summary>
            /// <para>The time when the policy was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-28T07:04:15Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The version of the policy. Default value: v1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("DefaultVersion")]
            [Validation(Required=false)]
            public string DefaultVersion { get; set; }

            /// <summary>
            /// <para>The description of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a test policy.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestPolicy</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The type of the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Custom</description></item>
            /// <item><description>System</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// <para>The time when the policy was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-28T07:05:37Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7572DEBD-0ECE-518E-8682-D8CB82F8FE8E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
