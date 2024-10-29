// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListRegistrationPoliciesForUserGroupResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>58D6B23E-E5DA-5418-8F61-51A3B5A30049</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserGroups")]
        [Validation(Required=false)]
        public List<ListRegistrationPoliciesForUserGroupResponseBodyUserGroups> UserGroups { get; set; }
        public class ListRegistrationPoliciesForUserGroupResponseBodyUserGroups : TeaModel {
            [NameInMap("Policies")]
            [Validation(Required=false)]
            public List<ListRegistrationPoliciesForUserGroupResponseBodyUserGroupsPolicies> Policies { get; set; }
            public class ListRegistrationPoliciesForUserGroupResponseBodyUserGroupsPolicies : TeaModel {
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
                public List<ListRegistrationPoliciesForUserGroupResponseBodyUserGroupsPoliciesLimitDetail> LimitDetail { get; set; }
                public class ListRegistrationPoliciesForUserGroupResponseBodyUserGroupsPoliciesLimitDetail : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Company</para>
                    /// </summary>
                    [NameInMap("DeviceBelong")]
                    [Validation(Required=false)]
                    public string DeviceBelong { get; set; }

                    [NameInMap("LimitCount")]
                    [Validation(Required=false)]
                    public ListRegistrationPoliciesForUserGroupResponseBodyUserGroupsPoliciesLimitDetailLimitCount LimitCount { get; set; }
                    public class ListRegistrationPoliciesForUserGroupResponseBodyUserGroupsPoliciesLimitDetailLimitCount : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("All")]
                        [Validation(Required=false)]
                        public string All { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Mobile")]
                        [Validation(Required=false)]
                        public string Mobile { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("PC")]
                        [Validation(Required=false)]
                        public string PC { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>LimitAll</para>
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
                public long? Priority { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Whitelist")]
                [Validation(Required=false)]
                public List<string> Whitelist { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>usergroup-6f1ef2fc56b6****</para>
            /// </summary>
            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

        }

    }

}
