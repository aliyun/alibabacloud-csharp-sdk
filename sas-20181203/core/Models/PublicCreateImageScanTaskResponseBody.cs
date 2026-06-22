// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class PublicCreateImageScanTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned when the operation is successful.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PublicCreateImageScanTaskResponseBodyData Data { get; set; }
        public class PublicCreateImageScanTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether more scan tasks can be created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: More scan tasks can be created.</description></item>
            /// <item><description><b>false</b>: No more scan tasks can be created.</description></item>
            /// </list>
            /// <remarks>
            /// <para>By default, up to 10 scan tasks can exist at the same time. If the number of scan tasks exceeds 10, creating a scan task by calling this operation fails. Wait until an existing scan task is completed before creating a new scan task.</para>
            /// </remarks>
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
            /// <para>The number of images that have been scanned.</para>
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
            /// <item><description><b>SUCCESS</b>: The scan task succeeded.</description></item>
            /// <item><description><b>TASK_NOT_SUPPORT_REGION</b>: The image is in a region that does not support scanning.</description></item>
            /// </list>
            /// <remarks>
            /// <para>For the regions that support image security scanning, see the table of supported regions after the response parameters table in this topic.</para>
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
            /// <item><description><b>SUCCESS</b>: Succeeded.</description></item>
            /// <item><description><b>FAIL</b>: Failed.</description></item>
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
            /// <para>a410bb3e68c217a3368bc0238c66886d</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The total number of images to scan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each request. You can use the request ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F9353221-40F4-5F98-B73C-2803DC804033</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
