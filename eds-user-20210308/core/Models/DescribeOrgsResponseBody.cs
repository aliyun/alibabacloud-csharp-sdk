// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeOrgsResponseBody : TeaModel {
        /// <summary>
        /// <para>The token that determines the start point of the query. The return value is the value of the NextToken response parameter that was returned last time the DescribeOrgs operation was called.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The organizations.</para>
        /// </summary>
        [NameInMap("Orgs")]
        [Validation(Required=false)]
        public List<DescribeOrgsResponseBodyOrgs> Orgs { get; set; }
        public class DescribeOrgsResponseBodyOrgs : TeaModel {
            /// <summary>
            /// <para>The organization ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>org-****</para>
            /// </summary>
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            /// <summary>
            /// <para>The name of the organizational unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>org****</para>
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
            /// <para>org-****</para>
            /// </summary>
            [NameInMap("ParentOrgId")]
            [Validation(Required=false)]
            public string ParentOrgId { get; set; }

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
