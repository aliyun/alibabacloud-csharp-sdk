// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateContainerScanTaskByAppNameResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned when the call is successful.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateContainerScanTaskByAppNameResponseBodyData Data { get; set; }
        public class CreateContainerScanTaskByAppNameResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether more scan tasks can be created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: More scan tasks can be created.</description></item>
            /// <item><description><b>false</b>: No more scan tasks can be created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanCreate")]
            [Validation(Required=false)]
            public bool? CanCreate { get; set; }

            /// <summary>
            /// <para>The timestamp when image information was collected, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1644286364150</para>
            /// </summary>
            [NameInMap("CollectTime")]
            [Validation(Required=false)]
            public long? CollectTime { get; set; }

            /// <summary>
            /// <para>The timestamp when the scan task started running, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1644286364150</para>
            /// </summary>
            [NameInMap("ExecTime")]
            [Validation(Required=false)]
            public long? ExecTime { get; set; }

            /// <summary>
            /// <para>The number of containers that have been scanned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("FinishCount")]
            [Validation(Required=false)]
            public int? FinishCount { get; set; }

            /// <summary>
            /// <para>The progress percentage of the scan task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>The execution result of the scan task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SUCCESS</b>: The scan task was executed successfully.</description></item>
            /// <item><description><b>TASK_NOT_SUPPORT_REGION</b>: The image is in a region that does not support scanning.</description></item>
            /// </list>
            /// <remarks>
            /// <para>For the regions that support image security scanning, refer to the table of supported regions after the response parameters table in this document.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The status of the scan task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: Initializing.</description></item>
            /// <item><description><b>PRE_ANALYZER</b>: Pre-analyzing.</description></item>
            /// <item><description><b>SUCCESS</b>: Execution succeeded.</description></item>
            /// <item><description><b>FAIL</b>: Execution failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the scan task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fc98d58eb56f699d49bf7ebbd6d7****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The total number of containers to scan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1EE7B150-D67E-53FD-A52D-3E8E669A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
