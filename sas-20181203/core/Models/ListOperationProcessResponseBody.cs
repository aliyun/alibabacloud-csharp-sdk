// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListOperationProcessResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListOperationProcessResponseBodyPageInfo PageInfo { get; set; }
        public class ListOperationProcessResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page to display in a paged query. This parameter is used for paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>263</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The list of operation task information.</para>
        /// </summary>
        [NameInMap("Processes")]
        [Validation(Required=false)]
        public List<ListOperationProcessResponseBodyProcesses> Processes { get; set; }
        public class ListOperationProcessResponseBodyProcesses : TeaModel {
            /// <summary>
            /// <para>The creation time of the task. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1674388824000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The number of completed subtasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("DetailTaskReadyCount")]
            [Validation(Required=false)]
            public int? DetailTaskReadyCount { get; set; }

            /// <summary>
            /// <para>The total number of subtasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DetailTaskTotalCount")]
            [Validation(Required=false)]
            public int? DetailTaskTotalCount { get; set; }

            /// <summary>
            /// <para>The end time of the task. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1705467559000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The number of completed items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>197</para>
            /// </summary>
            [NameInMap("FinishCount")]
            [Validation(Required=false)]
            public int? FinishCount { get; set; }

            /// <summary>
            /// <para>The start time of the task. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1705457102000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The check task status code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: not started.</description></item>
            /// <item><description>1: checking.</description></item>
            /// <item><description>2: check completed.</description></item>
            /// <item><description>3: timed out.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public int? StatusCode { get; set; }

            /// <summary>
            /// <para>The ID of the operation task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3d7a1b68-599f-4e16-9b45-e920a183b***</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>YAO_CHI</b>: ApsaraDB.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>YAO_CHI</para>
            /// </summary>
            [NameInMap("TaskSource")]
            [Validation(Required=false)]
            public string TaskSource { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CHECK_ALL: full check.</description></item>
            /// <item><description>CHECK_POLICY: check performed based on check items in the configured policy.</description></item>
            /// <item><description>CHECK_SCHEDULE: scheduled check.</description></item>
            /// <item><description>CHECK_ITEM: check performed based on specified check items.</description></item>
            /// <item><description>CHECK_INSTANCE: check performed based on specified check items and instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CHECK_POLICY</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>337</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8B6F758-BCD4-597A-8A2C-DA5A552C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
