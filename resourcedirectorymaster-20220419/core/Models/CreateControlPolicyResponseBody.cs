// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class CreateControlPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access control policy.</para>
        /// </summary>
        [NameInMap("ControlPolicy")]
        [Validation(Required=false)]
        public CreateControlPolicyResponseBodyControlPolicy ControlPolicy { get; set; }
        public class CreateControlPolicyResponseBodyControlPolicy : TeaModel {
            /// <summary>
            /// <para>The number of times that the access control policy is referenced.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AttachmentCount")]
            [Validation(Required=false)]
            public string AttachmentCount { get; set; }

            /// <summary>
            /// <para>The time when the access control policy was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-18T09:24:19Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The description of the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ExampleControlPolicy</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The effective scope of the access control policy.</para>
            /// <para>The value RAM indicates that the access control policy takes effect only for RAM users and RAM roles.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RAM</para>
            /// </summary>
            [NameInMap("EffectScope")]
            [Validation(Required=false)]
            public string EffectScope { get; set; }

            /// <summary>
            /// <para>The ID of the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cp-jExXAqIYkwHN****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The name of the access control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ExampleControlPolicy</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The type of the access control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>System: system access control policy</description></item>
            /// <item><description>Custom: custom access control policy</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// <para>The time when the access control policy was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-18T09:24:19Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>776B05B3-A0B0-464B-A191-F4E1119A94B2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
