// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPolicesForPrivateAccessApplicationResponseBody : TeaModel {
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListPolicesForPrivateAccessApplicationResponseBodyApplications> Applications { get; set; }
        public class ListPolicesForPrivateAccessApplicationResponseBodyApplications : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>pa-application-b927baf3e592****</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            [NameInMap("Policies")]
            [Validation(Required=false)]
            public List<ListPolicesForPrivateAccessApplicationResponseBodyApplicationsPolicies> Policies { get; set; }
            public class ListPolicesForPrivateAccessApplicationResponseBodyApplicationsPolicies : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Application</para>
                /// </summary>
                [NameInMap("ApplicationType")]
                [Validation(Required=false)]
                public string ApplicationType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-09-27 18:10:25</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CustomUserAttributes")]
                [Validation(Required=false)]
                public List<ListPolicesForPrivateAccessApplicationResponseBodyApplicationsPoliciesCustomUserAttributes> CustomUserAttributes { get; set; }
                public class ListPolicesForPrivateAccessApplicationResponseBodyApplicationsPoliciesCustomUserAttributes : TeaModel {
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

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

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
                /// <para>pa-policy-867ef4007c8a****</para>
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
                public int? Priority { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("UserGroupType")]
                [Validation(Required=false)]
                public string UserGroupType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4AB972E2-D702-5464-B132-B1911498B8BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
