// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeOrgsResponseBody : TeaModel {
        /// <summary>
        /// <para>The token used to retrieve the next page of results. If this parameter is not empty, more results are available. To retrieve the next page, pass this value in the <c>NextToken</c> parameter of a subsequent request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The organization list.</para>
        /// </summary>
        [NameInMap("Orgs")]
        [Validation(Required=false)]
        public List<DescribeOrgsResponseBodyOrgs> Orgs { get; set; }
        public class DescribeOrgsResponseBodyOrgs : TeaModel {
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
            /// <para>The organization name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>设计部****</para>
            /// </summary>
            [NameInMap("OrgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            [NameInMap("OrgNamePath")]
            [Validation(Required=false)]
            public string OrgNamePath { get; set; }

            /// <summary>
            /// <para>The parent organization ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>org-ezqr****</para>
            /// </summary>
            [NameInMap("ParentOrgId")]
            [Validation(Required=false)]
            public string ParentOrgId { get; set; }

            [NameInMap("ResourcePolicyList")]
            [Validation(Required=false)]
            public List<DescribeOrgsResponseBodyOrgsResourcePolicyList> ResourcePolicyList { get; set; }
            public class DescribeOrgsResponseBodyOrgsResourcePolicyList : TeaModel {
                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public string PolicyId { get; set; }

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
