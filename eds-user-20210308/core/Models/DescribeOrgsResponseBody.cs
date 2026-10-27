// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeOrgsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination token. Set the value to the NextToken parameter returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of organizations.</para>
        /// </summary>
        [NameInMap("Orgs")]
        [Validation(Required=false)]
        public List<DescribeOrgsResponseBodyOrgs> Orgs { get; set; }
        public class DescribeOrgsResponseBodyOrgs : TeaModel {
            /// <summary>
            /// <para>The access type of the organization node. A value of MANAGEABLE indicates a manageable node. A value of PATH_ONLY indicates that the node is used only to display the full path to the root organization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MANAGEABLE</para>
            /// </summary>
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <para>The organization ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>org-1mox****</para>
            /// </summary>
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            /// <summary>
            /// <para>The name of the organization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Design Department****</para>
            /// </summary>
            [NameInMap("OrgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            /// <summary>
            /// <para>The name path from the root organization to the current organization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Product Department/Design Department</para>
            /// </summary>
            [NameInMap("OrgNamePath")]
            [Validation(Required=false)]
            public string OrgNamePath { get; set; }

            /// <summary>
            /// <para>The ID of the parent organization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>org-ezqr****</para>
            /// </summary>
            [NameInMap("ParentOrgId")]
            [Validation(Required=false)]
            public string ParentOrgId { get; set; }

            /// <summary>
            /// <para>The list of resource policies associated with the organization.</para>
            /// </summary>
            [NameInMap("ResourcePolicyList")]
            [Validation(Required=false)]
            public List<DescribeOrgsResponseBodyOrgsResourcePolicyList> ResourcePolicyList { get; set; }
            public class DescribeOrgsResponseBodyOrgsResourcePolicyList : TeaModel {
                /// <summary>
                /// <para>The resource policy ID.</para>
                /// </summary>
                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public string PolicyId { get; set; }

                /// <summary>
                /// <para>The Policy Name.</para>
                /// </summary>
                [NameInMap("PolicyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B4BB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
