// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListControlPolicyAttachmentsForTargetResponseBody : TeaModel {
        /// <summary>
        /// <para>The attached access control policies.</para>
        /// </summary>
        [NameInMap("ControlPolicyAttachments")]
        [Validation(Required=false)]
        public ListControlPolicyAttachmentsForTargetResponseBodyControlPolicyAttachments ControlPolicyAttachments { get; set; }
        public class ListControlPolicyAttachmentsForTargetResponseBodyControlPolicyAttachments : TeaModel {
            [NameInMap("ControlPolicyAttachment")]
            [Validation(Required=false)]
            public List<ListControlPolicyAttachmentsForTargetResponseBodyControlPolicyAttachmentsControlPolicyAttachment> ControlPolicyAttachment { get; set; }
            public class ListControlPolicyAttachmentsForTargetResponseBodyControlPolicyAttachmentsControlPolicyAttachment : TeaModel {
                /// <summary>
                /// <para>The time when the access control policy was attached.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-19T02:56:24Z</para>
                /// </summary>
                [NameInMap("AttachDate")]
                [Validation(Required=false)]
                public string AttachDate { get; set; }

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
                /// <para>The effective scope of the access control policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>All: The access control policy is in effect for Alibaba Cloud accounts, RAM users, and RAM roles.</description></item>
                /// <item><description>RAM: The access control policy is in effect only for RAM users and RAM roles.</description></item>
                /// </list>
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

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C276B600-7B7A-49E8-938C-E16CFA955A82</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
