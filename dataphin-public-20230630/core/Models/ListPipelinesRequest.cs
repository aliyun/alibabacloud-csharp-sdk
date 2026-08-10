// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListPipelinesRequest : TeaModel {
        /// <summary>
        /// <para>The request context.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public ListPipelinesRequestContext Context { get; set; }
        public class ListPipelinesRequestContext : TeaModel {
            /// <summary>
            /// <para>The environment identifier. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DEV: development environment.</description></item>
            /// <item><description>PROD: production environment.</description></item>
            /// </list>
            /// <para>Default value: PROD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROD</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7128268454335680</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

        /// <summary>
        /// <para>The query parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListCommand")]
        [Validation(Required=false)]
        public ListPipelinesRequestListCommand ListCommand { get; set; }
        public class ListPipelinesRequestListCommand : TeaModel {
            /// <summary>
            /// <para>The list of creator user IDs for filtering. If left empty, no filtering is applied. Multiple values have an OR relationship.</para>
            /// </summary>
            [NameInMap("CreatorList")]
            [Validation(Required=false)]
            public List<string> CreatorList { get; set; }

            /// <summary>
            /// <para>The list of development owner user IDs for filtering. If left empty, no filtering is applied. Multiple values have an OR relationship.</para>
            /// </summary>
            [NameInMap("DevelopOwnerList")]
            [Validation(Required=false)]
            public List<string> DevelopOwnerList { get; set; }

            /// <summary>
            /// <para>The list of full folder paths to query. If left empty, the root folder is queried.</para>
            /// </summary>
            [NameInMap("Directories")]
            [Validation(Required=false)]
            public List<string> Directories { get; set; }

            /// <summary>
            /// <para>Specifies whether to use exact match for node names. Default value: false.</para>
            /// </summary>
            [NameInMap("ExactMatch")]
            [Validation(Required=false)]
            public bool? ExactMatch { get; set; }

            /// <summary>
            /// <para>The list of node name keywords. This parameter is optional. If left empty, no filtering by name is applied. For exact match, this is a list of full names. For fuzzy match, this is a list of keywords. Multiple values have an OR relationship.</para>
            /// </summary>
            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public List<string> Keywords { get; set; }

            /// <summary>
            /// <para>The cursor-based pagination parameter (an opaque cursor that callers do not need to interpret). This parameter is optional. If not specified, the request is treated as a first-page request and returns the actual total count. If specified, the request is treated as a subsequent-page request. Pass the NextCursor value from the previous page response as-is. The SQL layer automatically filters by incrementing ID to query the next page without re-querying the total count. No OFFSET is used throughout, which avoids performance degradation in deep paging scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("NextCursor")]
            [Validation(Required=false)]
            public long? NextCursor { get; set; }

            /// <summary>
            /// <para>The list of O&amp;M owner user IDs for filtering. If left empty, no filtering is applied. Multiple values have an OR relationship.</para>
            /// </summary>
            [NameInMap("OpsOwnerList")]
            [Validation(Required=false)]
            public List<string> OpsOwnerList { get; set; }

            /// <summary>
            /// <para>The page number. Default value: 1. Starts from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The list of node types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: offline integration.</description></item>
            /// <item><description>1: real-time integration.</description></item>
            /// <item><description>13: data aggregation.</description></item>
            /// <item><description>14: offline unstructured workflow.</description></item>
            /// <item><description>15: real-time unstructured workflow.</description></item>
            /// <item><description>16: online unstructured workflow.</description></item>
            /// </list>
            /// <para>Default value: [0]. If null or an empty list is passed, the default value [0] is used.</para>
            /// </summary>
            [NameInMap("PipelineTypeList")]
            [Validation(Required=false)]
            public List<int?> PipelineTypeList { get; set; }

            /// <summary>
            /// <para>Specifies whether to recursively query subfolders. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Recursive")]
            [Validation(Required=false)]
            public bool? Recursive { get; set; }

            /// <summary>
            /// <para>The list of scheduling types for filtering. If left empty, no filtering is applied. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: periodic scheduling.</description></item>
            /// <item><description>3: manual scheduling.</description></item>
            /// <item><description>5: real-time scheduling.</description></item>
            /// <item><description>7: online workflow.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ScheduleTypeList")]
            [Validation(Required=false)]
            public List<int?> ScheduleTypeList { get; set; }

            /// <summary>
            /// <para>The list of submit statuses for filtering. If left empty, no filtering is applied. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DRAFT: draft.</description></item>
            /// <item><description>SUBMITTING: submitting.</description></item>
            /// <item><description>SUBMITTED: submitted.</description></item>
            /// <item><description>PUBLISHED: published.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("SubmitStatusList")]
            [Validation(Required=false)]
            public List<string> SubmitStatusList { get; set; }

            /// <summary>
            /// <para>The list of label names for filtering. If left empty, no filtering is applied. Multiple values have an OR relationship.</para>
            /// </summary>
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<string> TagList { get; set; }

            /// <summary>
            /// <para>The total number of records for cursor-based pagination. This parameter is optional and takes effect only when NextCursor is not empty. After the first-page request returns the actual total count, pass this value back as-is for subsequent pages. The server does not re-query the total count and directly returns this value, which avoids redundant count overhead. If not specified, the system falls back to querying one extra record to determine whether a next page exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1233</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
