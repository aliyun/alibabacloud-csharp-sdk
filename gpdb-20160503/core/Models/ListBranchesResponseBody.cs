// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListBranchesResponseBody : TeaModel {
        [NameInMap("Branches")]
        [Validation(Required=false)]
        public ListBranchesResponseBodyBranches Branches { get; set; }
        public class ListBranchesResponseBodyBranches : TeaModel {
            [NameInMap("Branch")]
            [Validation(Required=false)]
            public List<ListBranchesResponseBodyBranchesBranch> Branch { get; set; }
            public class ListBranchesResponseBodyBranchesBranch : TeaModel {
                [NameInMap("BranchId")]
                [Validation(Required=false)]
                public string BranchId { get; set; }

                [NameInMap("BranchName")]
                [Validation(Required=false)]
                public string BranchName { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ExpiresAt")]
                [Validation(Required=false)]
                public string ExpiresAt { get; set; }

                [NameInMap("InitSource")]
                [Validation(Required=false)]
                public string InitSource { get; set; }

                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                [NameInMap("ParentBranchId")]
                [Validation(Required=false)]
                public string ParentBranchId { get; set; }

                [NameInMap("ParentBranchName")]
                [Validation(Required=false)]
                public string ParentBranchName { get; set; }

                [NameInMap("ParentLSN")]
                [Validation(Required=false)]
                public string ParentLSN { get; set; }

                [NameInMap("ParentTimestamp")]
                [Validation(Required=false)]
                public string ParentTimestamp { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                [NameInMap("Protected")]
                [Validation(Required=false)]
                public bool? Protected { get; set; }

                [NameInMap("ServiceType")]
                [Validation(Required=false)]
                public string ServiceType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public ListBranchesResponseBodyBranchesBranchTags Tags { get; set; }
                public class ListBranchesResponseBodyBranchesBranchTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<ListBranchesResponseBodyBranchesBranchTagsTag> Tag { get; set; }
                    public class ListBranchesResponseBodyBranchesBranchTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The maximum number of records returned in this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. It is not required for the first query. For subsequent queries, use the NextToken returned from the previous query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than 0. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>10</description></item>
        /// <item><description>20</description></item>
        /// <item><description>50</description></item>
        /// <item><description>100</description></item>
        /// </list>
        /// <para>Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of branches that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
