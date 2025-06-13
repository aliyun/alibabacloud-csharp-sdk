// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListUserPrivateAccessPoliciesResponseBody : TeaModel {
        [NameInMap("Polices")]
        [Validation(Required=false)]
        public List<ListUserPrivateAccessPoliciesResponseBodyPolices> Polices { get; set; }
        public class ListUserPrivateAccessPoliciesResponseBodyPolices : TeaModel {
            [NameInMap("CustomUserAttributes")]
            [Validation(Required=false)]
            public List<ListUserPrivateAccessPoliciesResponseBodyPolicesCustomUserAttributes> CustomUserAttributes { get; set; }
            public class ListUserPrivateAccessPoliciesResponseBodyPolicesCustomUserAttributes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("IdpId")]
                [Validation(Required=false)]
                public int? IdpId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Equal</para>
                /// </summary>
                [NameInMap("Relation")]
                [Validation(Required=false)]
                public string Relation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>department</para>
                /// </summary>
                [NameInMap("UserGroupType")]
                [Validation(Required=false)]
                public string UserGroupType { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>device_attribute_name</para>
            /// </summary>
            [NameInMap("DeviceAttributeName")]
            [Validation(Required=false)]
            public string DeviceAttributeName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user_group_name</para>
            /// </summary>
            [NameInMap("MatchedUserGroup")]
            [Validation(Required=false)]
            public string MatchedUserGroup { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>private_access_policy_name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Allow</para>
            /// </summary>
            [NameInMap("PolicyAction")]
            [Validation(Required=false)]
            public string PolicyAction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pa-policy-1b0d0e8b4bcf****</para>
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
            public long? Priority { get; set; }

            [NameInMap("TrustedProcessGroupIds")]
            [Validation(Required=false)]
            public List<string> TrustedProcessGroupIds { get; set; }

            [NameInMap("TrustedSoftwareIds")]
            [Validation(Required=false)]
            public List<string> TrustedSoftwareIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("UserGroupMode")]
            [Validation(Required=false)]
            public string UserGroupMode { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9D852F87-AFB5-51B8-AACD-F7D0EFB8277D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
