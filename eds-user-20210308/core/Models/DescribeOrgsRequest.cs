// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeOrgsRequest : TeaModel {
        /// <summary>
        /// The maximum number of entries to return. Valid values: 1 to 100.\\
        /// Default value: 100.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the query. The return value is the value of the NextToken response parameter that was returned last time the DescribeOrgs operation was called.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The name of the organization.
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

}
