// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeOrgsResponseBody : TeaModel {
        /// <summary>
        /// The token that determines the start point of the query. The return value is the value of the NextToken response parameter that was returned last time the DescribeOrgs operation was called.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The organizations.
        /// </summary>
        [NameInMap("Orgs")]
        [Validation(Required=false)]
        public List<DescribeOrgsResponseBodyOrgs> Orgs { get; set; }
        public class DescribeOrgsResponseBodyOrgs : TeaModel {
            /// <summary>
            /// The organization ID.
            /// </summary>
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            /// <summary>
            /// The name of the organizational unit.
            /// </summary>
            [NameInMap("OrgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            /// <summary>
            /// The parent organization ID.
            /// </summary>
            [NameInMap("ParentOrgId")]
            [Validation(Required=false)]
            public string ParentOrgId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
