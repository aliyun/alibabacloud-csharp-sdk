// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSyncAssetTaskListResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeSyncAssetTaskListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeSyncAssetTaskListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of IDC scan tasks on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
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
            /// <para>The number of IDC scan tasks per page. Default value: 20. If you leave this parameter empty, 20 IDC scan tasks are returned on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of IDC scan tasks returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>110</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A20733-10A0-4AF6-BE6B-E3322413BB68</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The IDC scan tasks.</para>
        /// </summary>
        [NameInMap("TaskRecords")]
        [Validation(Required=false)]
        public List<DescribeSyncAssetTaskListResponseBodyTaskRecords> TaskRecords { get; set; }
        public class DescribeSyncAssetTaskListResponseBodyTaskRecords : TeaModel {
            /// <summary>
            /// <para>The number of assets that are detected by the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("AssetCount")]
            [Validation(Required=false)]
            public int? AssetCount { get; set; }

            /// <summary>
            /// <para>The CIDR blocks that are used for scanning. Multiple CIDR blocks are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1/24,1.1.1.1/24</para>
            /// </summary>
            [NameInMap("IpSegments")]
            [Validation(Required=false)]
            public string IpSegments { get; set; }

            /// <summary>
            /// <para>The progress of the task, in percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ProcessRate")]
            [Validation(Required=false)]
            public int? ProcessRate { get; set; }

            /// <summary>
            /// <para>The ID of the root task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>73c392f9c505129a257472a3f911d65d</para>
            /// </summary>
            [NameInMap("RootTaskId")]
            [Validation(Required=false)]
            public string RootTaskId { get; set; }

            /// <summary>
            /// <para>The timestamp when the task ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1653965680000</para>
            /// </summary>
            [NameInMap("TaskEndTime")]
            [Validation(Required=false)]
            public long? TaskEndTime { get; set; }

            /// <summary>
            /// <para>The name of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IDC_PROBE_SCAN-1.1.1..124-lse_ubuntu_test1</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The timestamp when the task started. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1633746651715</para>
            /// </summary>
            [NameInMap("TaskStartTime")]
            [Validation(Required=false)]
            public long? TaskStartTime { get; set; }

            /// <summary>
            /// <para>The status of the IDC scan task. Valid Values:</para>
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
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <para>The type of the task. The value is fixed as <b>IDC_PROBE_SCAN</b>, which indicates an IDC scan task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IDC_PROBE_SCAN</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

    }

}
