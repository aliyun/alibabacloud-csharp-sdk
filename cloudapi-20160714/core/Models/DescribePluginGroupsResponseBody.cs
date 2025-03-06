// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribePluginGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>Collection of group information</para>
        /// </summary>
        [NameInMap("GroupSummarys")]
        [Validation(Required=false)]
        public DescribePluginGroupsResponseBodyGroupSummarys GroupSummarys { get; set; }
        public class DescribePluginGroupsResponseBodyGroupSummarys : TeaModel {
            [NameInMap("GroupPluginSummary")]
            [Validation(Required=false)]
            public List<DescribePluginGroupsResponseBodyGroupSummarysGroupPluginSummary> GroupPluginSummary { get; set; }
            public class DescribePluginGroupsResponseBodyGroupSummarysGroupPluginSummary : TeaModel {
                /// <summary>
                /// <para>API root path</para>
                /// 
                /// <b>Example:</b>
                /// <para>/rpew</para>
                /// </summary>
                [NameInMap("BasePath")]
                [Validation(Required=false)]
                public string BasePath { get; set; }

                /// <summary>
                /// <para>Description</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>API group ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>4ed31575e2de43de8c51eb1217a1f56b</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>API group name</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECP_API</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>Region ID where the API group is located</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Stage name Alias</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEV</para>
                /// </summary>
                [NameInMap("StageAlias")]
                [Validation(Required=false)]
                public string StageAlias { get; set; }

                /// <summary>
                /// <para>Environment name, possible values:</para>
                /// <list type="bullet">
                /// <item><description><b>RELEASE</b>: Production</description></item>
                /// <item><description><b>PRE</b>: Pre-release</description></item>
                /// <item><description><b>TEST</b>: Testing</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RELEASE</para>
                /// </summary>
                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

            }

        }

        /// <summary>
        /// <para>Pagination parameter: current page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Pagination parameter: number of items per page, default value 10</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>765BC99E-F583-5A80-9A42-42AC125C2CDC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of returned results</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
