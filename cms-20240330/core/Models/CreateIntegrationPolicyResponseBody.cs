// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateIntegrationPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>Whether it was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("created")]
        [Validation(Required=false)]
        public bool? Created { get; set; }

        /// <summary>
        /// <para>Uploaded policy.</para>
        /// </summary>
        [NameInMap("policy")]
        [Validation(Required=false)]
        public CreateIntegrationPolicyResponseBodyPolicy Policy { get; set; }
        public class CreateIntegrationPolicyResponseBodyPolicy : TeaModel {
            /// <summary>
            /// <para>Entity group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eg-b79f65d11fb94e779867cf937c3a3002</para>
            /// </summary>
            [NameInMap("entityGroupId")]
            [Validation(Required=false)]
            public string EntityGroupId { get; set; }

            /// <summary>
            /// <para>Policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>policy-14c8e9a29b0a46da843f8781471062ff</para>
            /// </summary>
            [NameInMap("policyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>Policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>metrics-inner-manage</para>
            /// </summary>
            [NameInMap("policyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>Policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CS</para>
            /// </summary>
            [NameInMap("policyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// <para>Region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-heyuan</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>User ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>u1234567</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The workspace where the Policy resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prometheus</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD8BA7D6-995D-578D-9941-78B0FECD14B5</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
