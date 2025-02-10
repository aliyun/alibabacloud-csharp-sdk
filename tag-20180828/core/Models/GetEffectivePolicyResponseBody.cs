// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class GetEffectivePolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The effective tag policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;tags\&quot;:{\&quot;costcenter\&quot;:{\&quot;tag_value\&quot;:[\&quot;Beijing\&quot;,\&quot;Shanghai\&quot;],\&quot;tag_key\&quot;:\&quot;CostCenter\&quot;}}}</para>
        /// </summary>
        [NameInMap("EffectivePolicy")]
        [Validation(Required=false)]
        public string EffectivePolicy { get; set; }

        [NameInMap("PolicyAttachments")]
        [Validation(Required=false)]
        public List<GetEffectivePolicyResponseBodyPolicyAttachments> PolicyAttachments { get; set; }
        public class GetEffectivePolicyResponseBodyPolicyAttachments : TeaModel {
            [NameInMap("PolicyList")]
            [Validation(Required=false)]
            public List<GetEffectivePolicyResponseBodyPolicyAttachmentsPolicyList> PolicyList { get; set; }
            public class GetEffectivePolicyResponseBodyPolicyAttachmentsPolicyList : TeaModel {
                [NameInMap("AttachSeq")]
                [Validation(Required=false)]
                public int? AttachSeq { get; set; }

                [NameInMap("AttachTime")]
                [Validation(Required=false)]
                public string AttachTime { get; set; }

                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public string PolicyId { get; set; }

                [NameInMap("PolicyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public string TargetId { get; set; }

                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BB532282-94F5-5F56-877F-32D5E2A04F3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
