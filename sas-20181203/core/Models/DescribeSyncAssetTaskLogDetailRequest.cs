// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSyncAssetTaskLogDetailRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the page number of the page to return. Default value: 1.</para>
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
        /// <para>Specifies the maximum number of entries to return on each page during paging in a paged query. The default number of entries per page is 20. If the PageSize parameter is left empty, 20 entries are returned by default. Do not leave PageSize empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the IDC scan task to query. You can call the <a href="https://help.aliyun.com/document_detail/141932.html">DescribeSyncAssetTaskList</a> operation to obtain the task ID.</para>
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
        /// <para>The name of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IDC_PROBE_SCAN-TEST_001</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
