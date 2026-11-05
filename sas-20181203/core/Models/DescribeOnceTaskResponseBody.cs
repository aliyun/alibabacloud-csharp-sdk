// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeOnceTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeOnceTaskResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeOnceTaskResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of client tasks displayed on the current page for paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page for paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of client tasks per page for paging. Default value: <b>20</b>, which indicates that each page contains 20 client tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of client tasks returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E0618A9-D5EF-4220-9471-C42B5E92719F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of returned information for the client task query.</para>
        /// </summary>
        [NameInMap("TaskManageResponseList")]
        [Validation(Required=false)]
        public List<DescribeOnceTaskResponseBodyTaskManageResponseList> TaskManageResponseList { get; set; }
        public class DescribeOnceTaskResponseBodyTaskManageResponseList : TeaModel {
            /// <summary>
            /// <para>The task execution details. This parameter is in JSON format.</para>
            /// <list type="bullet">
            /// <item><description><b>causeCode</b>: The return code for the troubleshooting cause.</description></item>
            /// <item><description><b>causeMsg</b>: The return message for the troubleshooting cause.</description></item>
            /// <item><description><b>resCode</b>: The troubleshooting return code.</description></item>
            /// <item><description><b>resMsg</b>: The troubleshooting return message.</description></item>
            /// <item><description><b>problemType</b>: The problem type.</description></item>
            /// <item><description><b>dispatchType</b>: The task dispatch method.</description></item>
            /// <item><description><b>uuid</b>: The server UUID.</description></item>
            /// <item><description><b>instanceId</b>: The server instance ID.</description></item>
            /// <item><description><b>internetIp</b>: The public IP address of the server.</description></item>
            /// <item><description><b>intranetIp</b>: The private IP address of the server.</description></item>
            /// <item><description><b>instanceName</b>: The server instance name.</description></item>
            /// <item><description><b>url</b>: The download link for the troubleshooting log.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[
            ///       {
            ///             &quot;dispatchType&quot;: &quot;manual&quot;,
            ///             &quot;causeMsg&quot;: [],
            ///             &quot;causeCode&quot;: [],
            ///             &quot;resCode&quot;: [
            ///                   &quot;1003&quot;
            ///             ],
            ///             &quot;resMsg&quot;: [
            ///                   &quot;powershell -executionpolicy bypass -c \&quot;(New-Object Net.WebClient).DownloadFile(\&quot;<a href="http://aegis.alicdn.com/download/aegis_client_self_check/win32/aegis_checker.exe%5C%5C">http://aegis.alicdn.com/download/aegis_client_self_check/win32/aegis_checker.exe\\</a>&quot;, $ExecutionContext.SessionState.Path.GetUnresolvedProviderPathFromPSPath(\&quot;.\\\\aegis_checker.exe\&quot;))\&quot;; \&quot;./aegis_checker.exe -b eyJtb2RlIjoxLCJqc3J2X2RvbWFpbiI6W10sImlzc3VlIjoib2ZmbGluZSIsInVwZGF0ZV9kb21haW4iOltdLCJ1dWlkIjoiaW5ldC1lYWUwNDg2Ny0wMDJmLTQyM2QtYWYwMC1jNzJjZDYyOWIyNDgiLCJjbWRfaWR4IjoiNDRjZThiZWI3ZGYyYTQxMjQ1NGM4ZDc5OTE1ODI1MzMifQ==\&quot;&quot;
            ///             ],
            ///             &quot;problemType&quot;: &quot;offline&quot;,
            ///             &quot;uuid&quot;: &quot;inet-eae04867-002f-423d-af00-c72cd629****&quot;
            ///       }
            /// ]</para>
            /// </summary>
            [NameInMap("DetailData")]
            [Validation(Required=false)]
            public string DetailData { get; set; }

            /// <summary>
            /// <para>The number of failed tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            /// <summary>
            /// <para>The task progress. Unit: percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10%</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The task execution result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>successful</para>
            /// </summary>
            [NameInMap("ResultInfo")]
            [Validation(Required=false)]
            public string ResultInfo { get; set; }

            /// <summary>
            /// <para>The number of successfully executed tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

            /// <summary>
            /// <para>The timestamp when the task actually ends. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1650267989000</para>
            /// </summary>
            [NameInMap("TaskEndTime")]
            [Validation(Required=false)]
            public long? TaskEndTime { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e900f528f5a6229bb640ca27cb44c98e</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CLIENT_PROBLEM_CHECK</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The timestamp when the task actually starts. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649732012000</para>
            /// </summary>
            [NameInMap("TaskStartTime")]
            [Validation(Required=false)]
            public long? TaskStartTime { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Started.</description></item>
            /// <item><description><b>2</b>: Completed.</description></item>
            /// <item><description><b>3</b>: Failed.</description></item>
            /// <item><description><b>4</b>: Timed out.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            /// <summary>
            /// <para>The text object of the task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: Pending.</description></item>
            /// <item><description><b>START</b>: Started.</description></item>
            /// <item><description><b>DISPATCH</b>: Self-check command issued.</description></item>
            /// <item><description><b>SUCCESS</b>: Self-check completed.</description></item>
            /// <item><description><b>FAIL</b>: Execution failed.</description></item>
            /// <item><description><b>TIMEOUT</b>: Timed out.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INIT</para>
            /// </summary>
            [NameInMap("TaskStatusText")]
            [Validation(Required=false)]
            public string TaskStatusText { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CLIENT_PROBLEM_CHECK</b>: client task</description></item>
            /// <item><description><b>CLIENT_DEV_OPS</b>: cloud O&amp;M task</description></item>
            /// <item><description><b>ASSET_SECURITY_CHECK</b>: asset collection task</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CLIENT_PROBLEM_CHECK</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

    }

}
