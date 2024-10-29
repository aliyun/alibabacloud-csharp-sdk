// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateRegistrationPolicyResponseBody : TeaModel {
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public CreateRegistrationPolicyResponseBodyPolicy Policy { get; set; }
        public class CreateRegistrationPolicyResponseBodyPolicy : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-05-16 17:18:46</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("LimitDetail")]
            [Validation(Required=false)]
            public List<CreateRegistrationPolicyResponseBodyPolicyLimitDetail> LimitDetail { get; set; }
            public class CreateRegistrationPolicyResponseBodyPolicyLimitDetail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Company</para>
                /// </summary>
                [NameInMap("DeviceBelong")]
                [Validation(Required=false)]
                public string DeviceBelong { get; set; }

                [NameInMap("LimitCount")]
                [Validation(Required=false)]
                public CreateRegistrationPolicyResponseBodyPolicyLimitDetailLimitCount LimitCount { get; set; }
                public class CreateRegistrationPolicyResponseBodyPolicyLimitDetailLimitCount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("All")]
                    [Validation(Required=false)]
                    public int? All { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Mobile")]
                    [Validation(Required=false)]
                    public int? Mobile { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("PC")]
                    [Validation(Required=false)]
                    public int? PC { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>LimitDiff</para>
                /// </summary>
                [NameInMap("LimitType")]
                [Validation(Required=false)]
                public string LimitType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UserGroupNormal</para>
            /// </summary>
            [NameInMap("MatchMode")]
            [Validation(Required=false)]
            public string MatchMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>registration_policy_name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>reg-policy-dcbfd33cb004****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UserGroupIds")]
            [Validation(Required=false)]
            public List<string> UserGroupIds { get; set; }

            [NameInMap("Whitelist")]
            [Validation(Required=false)]
            public List<string> Whitelist { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FEF1144C-95D1-5F7C-81EF-9DB70EA49FCE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
