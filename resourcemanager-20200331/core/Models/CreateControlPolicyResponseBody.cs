// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreateControlPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the control policy.</para>
        /// </summary>
        [NameInMap("ControlPolicy")]
        [Validation(Required=false)]
        public CreateControlPolicyResponseBodyControlPolicy ControlPolicy { get; set; }
        public class CreateControlPolicyResponseBodyControlPolicy : TeaModel {
            /// <summary>
            /// <para>The number of times the control policy is referenced.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AttachmentCount")]
            [Validation(Required=false)]
            public string AttachmentCount { get; set; }

            /// <summary>
            /// <para>The time when the control policy was created. The time is displayed in UTC in RFC 3339 format, with Z indicating UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-18T09:24:19Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The description of the control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ExampleControlPolicy</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The effective scope of the control policy.</para>
            /// <para>Valid values: RAM, which indicates that the control policy takes effect only for Resource Access Management (RAM) users or RAM roles.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RAM</para>
            /// </summary>
            [NameInMap("EffectScope")]
            [Validation(Required=false)]
            public string EffectScope { get; set; }

            /// <summary>
            /// <para>The ID of the control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cp-jExXAqIYkwHN****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The Policy Name of the control policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ExampleControlPolicy</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The type of the control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>System: system control policy.</description></item>
            /// <item><description>Custom: custom control policy.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// <para>The time when the control policy was last updated. The time is displayed in UTC in RFC 3339 format, with Z indicating UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-18T09:24:19Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>776B05B3-A0B0-464B-A191-F4E1119A94B2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
