// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOnceTaskResultInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the task was executed.</para>
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
        /// <para>47</para>
        /// </summary>
        [NameInMap("FinishCount")]
        [Validation(Required=false)]
        public int? FinishCount { get; set; }

        /// <summary>
        /// <para>The ID of the request. This uniquely identifies the request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE500770-42D3-442E-9DDD-156E0F9F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the one-time task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e7b70a4b030db086db52231f1b58****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>Details of the task.</para>
        /// </summary>
        [NameInMap("TaskInfo")]
        [Validation(Required=false)]
        public GetOnceTaskResultInfoResponseBodyTaskInfo TaskInfo { get; set; }
        public class GetOnceTaskResultInfoResponseBodyTaskInfo : TeaModel {
            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>INIT</b>: The task is pending start.</para>
            /// </description></item>
            /// <item><description><para><b>START</b>: The task is running.</para>
            /// </description></item>
            /// <item><description><para><b>SUCCESS</b>: The task is completed.</para>
            /// </description></item>
            /// <item><description><para><b>TIMEOUT</b>: The task has timed out.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>START</para>
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
