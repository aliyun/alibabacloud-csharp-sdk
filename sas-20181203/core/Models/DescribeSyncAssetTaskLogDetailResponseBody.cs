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
            /// <para>The number of IDC scan task details returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page during paging in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of IDC scan node details returned on each page during paging in a paged query. Default value: 20, which indicates that 20 IDC scan node details are returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of IDC scan task details returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B48AB3C-84FC-424D-A01D-B9270EF46038</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of task details.</para>
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
            /// <para>The region where the IDC server is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hangzhou, Zhejiang</para>
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
            /// <item><description><b>INIT</b>: Pending.</description></item>
            /// <item><description><b>START</b>: Started.</description></item>
            /// <item><description><b>MESSAGE_SEND</b>: Command issued.</description></item>
            /// <item><description><b>SUCCESS</b>: Completed.</description></item>
            /// <item><description><b>FAIL</b>: Failed.</description></item>
            /// <item><description><b>TIMEOUT</b>: Timed out.</description></item>
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
            /// <para>The timestamp when the task was reported.</para>
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
