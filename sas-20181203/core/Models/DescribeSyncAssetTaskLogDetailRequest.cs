// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSyncAssetTaskLogDetailRequest : TeaModel {
        /// <summary>
        /// <para>The page number from which to start displaying query results. Default value: 1, which indicates that query results are displayed starting from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The timestamp of the end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1668064495000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to display on each page when you perform a paginated query. Default value: 20. If the PageSize parameter is left empty, 20 entries are returned by default.</para>
        /// <remarks>
        /// <para>We recommend that you do not leave PageSize empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the IDC scan task that you want to query. You can call the <a href="https://help.aliyun.com/document_detail/141932.html">DescribeSyncAssetTaskList</a> operation to obtain the ID of an abnormal task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7e9565f537146fdf6bfb4e01f6f08818</para>
        /// </summary>
        [NameInMap("RootTaskId")]
        [Validation(Required=false)]
        public string RootTaskId { get; set; }

        /// <summary>
        /// <para>The timestamp of the start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1644027670</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IDC_PROBE_SCAN-TEST_001</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
