// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class DescribeExportTasksRequest : TeaModel {
        /// <summary>
        /// <para>The page number for paging. Pages start from 1. If this parameter is not specified or is set to a value less than 1, the first page is returned. The query results are sorted in descending order of task creation time, with the most recently created tasks listed first. When polling a single task by TaskId, we recommend that you explicitly set this parameter to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of tasks to return on each page. Default value: 200. If this parameter is set to a value less than 1, the value 10 is used. When polling a single task by TaskId, set this parameter to 1 to avoid returning redundant tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filters export tasks by task ID. The value is the TaskId returned by CreateExportTask, which is a 32-character UUID string without hyphens. This parameter requires an exact match and does not support fuzzy queries. If this parameter is not specified, all tasks under the current account that meet other conditions are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8119078c29e948dba2e0a9917995332a</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>Filters export tasks by task type. The value is case-sensitive and must be one of the following valid values:</para>
        /// <list type="bullet">
        /// <item><description>WUYING_SERVER_LIST: Wuying host list.</description></item>
        /// <item><description>USER_USAGE_REPORT: User usage report.</description></item>
        /// <item><description>BROWSER_BOOKMARK_LIST: Cloud browser bookmark list.</description></item>
        /// <item><description>BROWSER_RESTRICTED_URL_LIST: Cloud browser URL whitelist.</description></item>
        /// </list>
        /// <para>If this parameter is not specified, tasks are not filtered by type, and all tasks under the current account that meet other conditions are returned. If an unrecognized value is passed, the server does not return a parameter error but cancels the type filter. Therefore, you must pass the exact valid values listed above. When querying a single task by TaskId, omit this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WUYING_SERVER_LIST</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
