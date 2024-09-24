// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSyncAssetTaskLogDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeSyncAssetTaskLogDetailResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeSyncAssetTaskLogDetailResponseBodyPageInfo : TeaModel {
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
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B48AB3C-84FC-424D-A01D-B9270EF46038</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the tasks.</para>
        /// </summary>
        [NameInMap("TaskRecordDetails")]
        [Validation(Required=false)]
        public List<DescribeSyncAssetTaskLogDetailResponseBodyTaskRecordDetails> TaskRecordDetails { get; set; }
        public class DescribeSyncAssetTaskLogDetailResponseBodyTaskRecordDetails : TeaModel {
            /// <summary>
            /// <para>The total number of assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("AssetCount")]
            [Validation(Required=false)]
            public int? AssetCount { get; set; }

            /// <summary>
            /// <para>The region of the server in the data center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("IdcRegion")]
            [Validation(Required=false)]
            public string IdcRegion { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6c4e4c36ffc3e5919120b405c2b3****</para>
            /// </summary>
            [NameInMap("LeafTaskId")]
            [Validation(Required=false)]
            public string LeafTaskId { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: The task is not started.</description></item>
            /// <item><description><b>START</b>: The task is started.</description></item>
            /// <item><description><b>MESSAGE_SEND</b>: The command is sent.</description></item>
            /// <item><description><b>SUCCESS</b>: The task is complete.</description></item>
            /// <item><description><b>FAIL</b>: The task failed.</description></item>
            /// <item><description><b>TIMEOUT</b>: The task timed out.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INIT</para>
            /// </summary>
            [NameInMap("LeafTaskStatus")]
            [Validation(Required=false)]
            public string LeafTaskStatus { get; set; }

            /// <summary>
            /// <para>The description of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>unknown reason</para>
            /// </summary>
            [NameInMap("TaskMsg")]
            [Validation(Required=false)]
            public string TaskMsg { get; set; }

            /// <summary>
            /// <para>The timestamp when the task results were reported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1671614217000</para>
            /// </summary>
            [NameInMap("TaskReportTime")]
            [Validation(Required=false)]
            public long? TaskReportTime { get; set; }

            /// <summary>
            /// <para>The number of unprotected assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("UnprotectedAssetCount")]
            [Validation(Required=false)]
            public int? UnprotectedAssetCount { get; set; }

        }

    }

}
