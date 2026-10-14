// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetGpuClusterListAlarmRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The value is &quot;Success&quot; or &quot;Sysom.ServerError&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success or Sysom.ServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of alert data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetGpuClusterListAlarmRecordResponseBodyData> Data { get; set; }
        public class GetGpuClusterListAlarmRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cluster where the alert was triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster1</para>
            /// </summary>
            [NameInMap("alarmCluster")]
            [Validation(Required=false)]
            public string AlarmCluster { get; set; }

            /// <summary>
            /// <para>The additional information about the alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            /// error_node_gpu, 
            /// error_pod,<br>task_pod_list, 
            /// error_type, 
            /// kernel,<br>}</para>
            /// </summary>
            [NameInMap("alarmExtInfo")]
            [Validation(Required=false)]
            public object AlarmExtInfo { get; set; }

            /// <summary>
            /// <para>The unique ID of the alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>746d13f8-9662-4441-b76b-a8ed8d485195</para>
            /// </summary>
            [NameInMap("alarmId")]
            [Validation(Required=false)]
            public string AlarmId { get; set; }

            /// <summary>
            /// <para>The event log associated with the alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cuda OOM：xxxxx</para>
            /// </summary>
            [NameInMap("alarmLog")]
            [Validation(Required=false)]
            public string AlarmLog { get; set; }

            /// <summary>
            /// <para>The ID of the task where the anomaly occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task job id</para>
            /// </summary>
            [NameInMap("alarmTask")]
            [Validation(Required=false)]
            public string AlarmTask { get; set; }

            /// <summary>
            /// <para>The date and time when the alert was triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-22 18:16:25</para>
            /// </summary>
            [NameInMap("alarmTime")]
            [Validation(Required=false)]
            public string AlarmTime { get; set; }

            /// <summary>
            /// <para>The topology snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>topology data，e.g.
            ///       &quot;alarmTopology&quot;: {
            ///         &quot;nodes&quot;: [
            ///           {
            ///             &quot;gpu_list&quot;: [
            ///               {
            ///                 &quot;values&quot;: {
            ///                   &quot;Basic&quot;: [
            ///                     {
            ///                       &quot;value&quot;: &quot;1&quot;,
            ///                       &quot;key&quot;: &quot;Gpu Number\n&quot;
            ///                     }
            ///                   ],
            ///                   &quot;Metric&quot;: [
            ///                     {
            ///                       &quot;value&quot;: &quot;50&quot;,
            ///                       &quot;key&quot;: &quot;gpu_util(%)\n&quot;
            ///                     }
            ///                   ],
            ///                   &quot;Exception&quot;: [
            ///                     {
            ///                       &quot;value&quot;: &quot;NCCL HANG&quot;,
            ///                       &quot;key&quot;: &quot;error0&quot;
            ///                     }
            ///                   ]
            ///                 },
            ///                 &quot;name&quot;: &quot;GPU1&quot;,
            ///                 &quot;style&quot;: {
            ///                   &quot;fill&quot;: &quot;#e94242\n&quot;,
            ///                   &quot;opacity&quot;: &quot;0.1&quot;
            ///                 },
            ///                 &quot;id&quot;: &quot;6cc37fbc&quot;
            ///               }
            ///             ],
            ///             &quot;values&quot;: {
            ///               &quot;Basic&quot;: [
            ///                 {
            ///                   &quot;value&quot;: &quot;i-xxxxxx&quot;,
            ///                   &quot;key&quot;: &quot;instance&quot;
            ///                 }
            ///               ],
            ///               &quot;Metric&quot;: [
            ///                 {
            ///                   &quot;value&quot;: &quot;value of metrics 1&quot;,
            ///                   &quot;key&quot;: &quot;name of metric 1&quot;
            ///                 }
            ///               ],
            ///               &quot;Exception&quot;: [
            ///                 {
            ///                   &quot;value&quot;: &quot;NCCL HANG&quot;,
            ///                   &quot;key&quot;: &quot;error0&quot;
            ///                 }
            ///               ]
            ///             },
            ///             &quot;name&quot;: &quot;i-xxxxxx\n&quot;,
            ///             &quot;style&quot;: {
            ///               &quot;fillOpacity&quot;: &quot;0.5&quot;,
            ///               &quot;fill&quot;: &quot;#e94242\n&quot;
            ///             },
            ///             &quot;id&quot;: &quot;975fbcb0&quot;
            ///           }
            ///         ],
            ///         &quot;edges&quot;: [
            ///           {
            ///             &quot;src_id&quot;: &quot;00534a88&quot;,
            ///             &quot;values&quot;: {
            ///               &quot;Basic&quot;: [
            ///                 {
            ///                   &quot;value&quot;: &quot;v2.22.3\n&quot;,
            ///                   &quot;key&quot;: &quot;NCCL Version\n&quot;
            ///                 }
            ///               ],
            ///               &quot;Metric&quot;: [
            ///                 {
            ///                   &quot;value&quot;: &quot;10000&quot;,
            ///                   &quot;key&quot;: &quot;Recv Msg Count&quot;
            ///                 }
            ///               ],
            ///               &quot;Exception&quot;: [
            ///                 {
            ///                   &quot;value&quot;: &quot;NCCL HANG&quot;,
            ///                   &quot;key&quot;: &quot;error0&quot;
            ///                 }
            ///               ]
            ///             },
            ///             &quot;dst_id&quot;: &quot;260525e9&quot;,
            ///             &quot;style&quot;: {
            ///               &quot;opacity&quot;: &quot;0.1&quot;,
            ///               &quot;lineWidth&quot;: &quot;1&quot;,
            ///               &quot;selectedStyle&quot;: &quot;\&quot;{\\\&quot;opacity\\\&quot;: 1, \\\&quot;lineWidth\\\&quot;: 1}\&quot;\n&quot;,
            ///               &quot;stroke&quot;: &quot;#e94242&quot;
            ///             },
            ///             &quot;type&quot;: &quot;GPU&quot;
            ///           }
            ///         ]
            ///       },</para>
            /// </summary>
            [NameInMap("alarmTopology")]
            [Validation(Required=false)]
            public object AlarmTopology { get; set; }

            /// <summary>
            /// <para>The Alarm Metric for alerting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cuda OOM</para>
            /// </summary>
            [NameInMap("alarmType")]
            [Validation(Required=false)]
            public string AlarmType { get; set; }

            /// <summary>
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>running、blocking、restart、exited、failed</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The UUID of the cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234123412352311</para>
            /// </summary>
            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// <para>When code is not &quot;Success&quot;, message contains the error information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>server error</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>real request ID</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
