// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetLastOnceTaskInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The time at which the task was run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1671184531000</para>
        /// </summary>
        [NameInMap("CollectTime")]
        [Validation(Required=false)]
        public long? CollectTime { get; set; }

        /// <summary>
        /// <para>The number of tasks that have been completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67</para>
        /// </summary>
        [NameInMap("FinishCount")]
        [Validation(Required=false)]
        public int? FinishCount { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE120DAB-F4E7-4C53-ADC3-A97578AB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the latest scan task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f65e1f1bb13118891a889d569a3****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>The information about the latest task.</para>
        /// </summary>
        [NameInMap("TaskInfo")]
        [Validation(Required=false)]
        public GetLastOnceTaskInfoResponseBodyTaskInfo TaskInfo { get; set; }
        public class GetLastOnceTaskInfoResponseBodyTaskInfo : TeaModel {
            /// <summary>
            /// <para>The progress of the task in percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>The result of the scan task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SUCCESS</b>: The task is successful.</description></item>
            /// <item><description><b>TASK_NOT_SUPPORT_REGION</b>: The images are deployed in a region that is not supported by container image scan.</description></item>
            /// <item><description><b>TASK_NOT_EXISTS</b>: The task does not exist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: The task is not started.</description></item>
            /// <item><description><b>START</b>: The task is started.</description></item>
            /// <item><description><b>SUCCESS</b>: The task is complete.</description></item>
            /// <item><description><b>TIMEOUT</b>: The task timed out.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
