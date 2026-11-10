// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeUserLoginPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of policies.</para>
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribeUserLoginPoliciesResponseBodyPolicies> Policies { get; set; }
        public class DescribeUserLoginPoliciesResponseBodyPolicies : TeaModel {
            /// <summary>
            /// <para>The policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deveoper-policy</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>up-89unlabdl****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The associated user group information.</para>
            /// </summary>
            [NameInMap("UserGroups")]
            [Validation(Required=false)]
            public List<DescribeUserLoginPoliciesResponseBodyPoliciesUserGroups> UserGroups { get; set; }
            public class DescribeUserLoginPoliciesResponseBodyPoliciesUserGroups : TeaModel {
                /// <summary>
                /// <para>The user group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ug-ilu90mhsduf****</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The user group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Developers</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
