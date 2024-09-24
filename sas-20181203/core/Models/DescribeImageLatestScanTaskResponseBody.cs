// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageLatestScanTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B48AB3C-84FC-424D-A01D-B9270EF4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the information about the task.</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public List<DescribeImageLatestScanTaskResponseBodyTask> Task { get; set; }
        public class DescribeImageLatestScanTaskResponseBodyTask : TeaModel {
            /// <summary>
            /// <para>The time when the task was created. The time is in the yyyy-MM-dd HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-20 11:59:05</para>
            /// </summary>
            [NameInMap("Create")]
            [Validation(Required=false)]
            public string Create { get; set; }

            /// <summary>
            /// <para>The number of images that are scanned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Finish")]
            [Validation(Required=false)]
            public int? Finish { get; set; }

            /// <summary>
            /// <para>The end time of the task. A value is returned only when the task is in the Finished state. Otherwise, the returned value is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1669693430977</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9755662</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The time when the task was last modified. The time is in the yyyy-MM-dd HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-20 12:00:05</para>
            /// </summary>
            [NameInMap("Modified")]
            [Validation(Required=false)]
            public string Modified { get; set; }

            /// <summary>
            /// <para>The name of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IMAGE_SCAN</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The method in which the task was created. A task can be created in the Security Center console or by calling an API operation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>console_batch</b>: The task was created in the Security Center console.</description></item>
            /// <item><description><b>openapi</b>: The task was created by calling an API operation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>console_batch</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The start time of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1668614400000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><b>PROCESSING</b>: The task is running.</description></item>
            /// <item><description><b>START</b>: The task is being started.</description></item>
            /// <item><description><b>MESSAGE_SEND</b>: The scan task is sent.</description></item>
            /// <item><description><b>PRE_ANALYZER</b>: The image is in precheck.</description></item>
            /// <item><description><b>SUCCESS</b>: The task was successful.</description></item>
            /// <item><description><b>FAIL</b>: The task failed.</description></item>
            /// <item><description><b>TIMOUT</b>: The task timed out.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The digest value of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8f0fbdb41d3d1ade4ffdf21558443f4c03342010563bb8c43ccc09594d50****</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>The type of the scanned asset. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><b>IMAGE</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IMAGE</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The ID of the scan task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0a960b9a48b788a8689154b032bf****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The type of the task. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><b>IMAGE_SCAN</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IMAGE_SCAN</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

    }

}
