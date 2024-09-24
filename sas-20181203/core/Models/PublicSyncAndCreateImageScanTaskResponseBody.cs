// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class PublicSyncAndCreateImageScanTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned if the call is successful.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PublicSyncAndCreateImageScanTaskResponseBodyData Data { get; set; }
        public class PublicSyncAndCreateImageScanTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether you can create more image scan tasks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// <remarks>
            /// <para> By default, a maximum of 10 image scan tasks can be running at the same time. If 10 image scan tasks are running, you cannot create an image scan task by calling this operation. You must wait for at least one of the 10 existing image scan tasks to complete before you can create an image scan task.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanCreate")]
            [Validation(Required=false)]
            public bool? CanCreate { get; set; }

            /// <summary>
            /// <para>The timestamp when the image information was collected. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1644286364150</para>
            /// </summary>
            [NameInMap("CollectTime")]
            [Validation(Required=false)]
            public long? CollectTime { get; set; }

            /// <summary>
            /// <para>The timestamp when the image scan task started to run. Unit: milliseconds.</para>
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
            /// <para>The progress of the image scan task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>The result of the image scan task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SUCCESS</b>: The task is successful.</description></item>
            /// <item><description><b>TASK_NOT_SUPPORT_REGION</b>: The image is deployed in a region that is not supported by container image scan.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The status of the image scan task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: The task is being initialized.</description></item>
            /// <item><description><b>PRE_ANALYZER</b>: The task is being pre-processed.</description></item>
            /// <item><description><b>SUCCESS</b>: The task is successful.</description></item>
            /// <item><description><b>FAIL</b>: The task failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the image scan task.</para>
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
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F9353221-40F4-5F98-B73C-2803DC804033</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
