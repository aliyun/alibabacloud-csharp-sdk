// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListVirusScanTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned virus scan tasks.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListVirusScanTaskResponseBodyList> List { get; set; }
        public class ListVirusScanTaskResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The timestamp when the virus scan task ended. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1662343860051</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The name of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sql-test-0****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.210.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.25.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The progress of the task in percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>62</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>The information about the file that is scanned.</para>
            /// </summary>
            [NameInMap("ScanPath")]
            [Validation(Required=false)]
            public List<string> ScanPath { get; set; }

            /// <summary>
            /// <para>The type of the virus scan task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>system</b>: automatic scan task</description></item>
            /// <item><description><b>user</b>: custom scan task</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("ScanType")]
            [Validation(Required=false)]
            public string ScanType { get; set; }

            /// <summary>
            /// <para>The timestamp when the virus scan task started. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1651290987000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The status of the virus scan task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: running</description></item>
            /// <item><description><b>2</b>: complete</description></item>
            /// <item><description><b>3</b>: failed</description></item>
            /// <item><description><b>4</b>: timed out</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The ID of the virus scan task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2e75557bfa570381f5c516cad9b6xxxx</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The name of the virus scan task.</para>
            /// <list type="bullet">
            /// <item><description>The value is fixed as <b>VIRUS_VUL_SCHEDULE_SCAN</b>, which indicates a virus scan task.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VIRUS_VUL_SCHEDULE_SCAN</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49e25e0f-bb51-4a5a-a1b3-13a4ddaa****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListVirusScanTaskResponseBodyPageInfo PageInfo { get; set; }
        public class ListVirusScanTaskResponseBodyPageInfo : TeaModel {
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
            /// <para>The number of entries per page.</para>
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
            /// <para>224</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4EB8B1C-1DEC-5E18-BCD0-D1BBB3936FA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
