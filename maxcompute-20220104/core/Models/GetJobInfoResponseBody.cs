// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetJobInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetJobInfoResponseBodyData Data { get; set; }
        public class GetJobInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>CPU usage of the job at the snapshot time. Unit: Core.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("cuUsage")]
            [Validation(Required=false)]
            public long? CuUsage { get; set; }

            /// <summary>
            /// <para>The time when the job was finished.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1672112913</para>
            /// </summary>
            [NameInMap("endAtTime")]
            [Validation(Required=false)]
            public long? EndAtTime { get; set; }

            /// <summary>
            /// <para>The ID of the upstream node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>node_4</para>
            /// </summary>
            [NameInMap("extNodeId")]
            [Validation(Required=false)]
            public string ExtNodeId { get; set; }

            /// <summary>
            /// <para>The account ID of the task owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>duty_2</para>
            /// </summary>
            [NameInMap("extNodeOnDuty")]
            [Validation(Required=false)]
            public string ExtNodeOnDuty { get; set; }

            /// <summary>
            /// <para>The upstream platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>platform_3</para>
            /// </summary>
            [NameInMap("extPlantFrom")]
            [Validation(Required=false)]
            public string ExtPlantFrom { get; set; }

            /// <summary>
            /// <para>The amount of scanned data for the job. Unit: byte.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("inputBytes")]
            [Validation(Required=false)]
            public double? InputBytes { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20230410****60gg</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The account that commits the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN$7632***@aliyun.com</para>
            /// </summary>
            [NameInMap("jobOwner")]
            [Validation(Required=false)]
            public string JobOwner { get; set; }

            /// <summary>
            /// <para>The list of sub-status of the job.</para>
            /// </summary>
            [NameInMap("jobSubStatusList")]
            [Validation(Required=false)]
            public List<GetJobInfoResponseBodyDataJobSubStatusList> JobSubStatusList { get; set; }
            public class GetJobInfoResponseBodyDataJobSubStatusList : TeaModel {
                /// <summary>
                /// <para>The code of the sub-status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1010</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                /// <summary>
                /// <para>The description of the sub-status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Waiting for scheduling</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The start time of the sub-status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-03-05 00:04:15.717364 +0800</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <para>The type of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SQL</para>
            /// </summary>
            [NameInMap("jobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <para>Memory usage of the job at the snapshot time. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("memoryUsage")]
            [Validation(Required=false)]
            public long? MemoryUsage { get; set; }

            /// <summary>
            /// <para>The priority of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            /// <summary>
            /// <para>The name of the project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dp_cdm_prod</para>
            /// </summary>
            [NameInMap("project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>The nickname of the computing Quota used by the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>os_bigdata</para>
            /// </summary>
            [NameInMap("quotaNickname")]
            [Validation(Required=false)]
            public string QuotaNickname { get; set; }

            /// <summary>
            /// <para>The type of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>subscription</para>
            /// </summary>
            [NameInMap("quotaType")]
            [Validation(Required=false)]
            public string QuotaType { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The start time of the job.</para>
            /// <remarks>
            /// <para>The time when the job received the first batch of computing resources.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1672112113</para>
            /// </summary>
            [NameInMap("runningAtTime")]
            [Validation(Required=false)]
            public long? RunningAtTime { get; set; }

            /// <summary>
            /// <para>The running duration, which is the duration from the runningAtTime to the snapshotTime of the job. Unit: seconds (s).</para>
            /// 
            /// <b>Example:</b>
            /// <para>800</para>
            /// </summary>
            [NameInMap("runningTime")]
            [Validation(Required=false)]
            public long? RunningTime { get; set; }

            /// <summary>
            /// <para>The intelligent diagnostics results.</para>
            /// </summary>
            [NameInMap("sceneResults")]
            [Validation(Required=false)]
            public List<GetJobInfoResponseBodyDataSceneResults> SceneResults { get; set; }
            public class GetJobInfoResponseBodyDataSceneResults : TeaModel {
                /// <summary>
                /// <para>The intelligent diagnostics result description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This job uses annual and monthly computing resources. It may be that the job is waiting for resources due to the large amount of overall job running data, many resources requested, and low job priority. Please go to Resource Consumption to view the specific situation. You can also go to Cost Optimization to see if you need to adjust resource configuration.</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Information about the nodes where data skew or data expansion is detected. This parameter is returned only when the diagnostics scenario is data skew or data expansion.</para>
                /// </summary>
                [NameInMap("params")]
                [Validation(Required=false)]
                public Dictionary<string, string> Params { get; set; }

                /// <summary>
                /// <para>The intelligent diagnostics result scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LackResource</para>
                /// </summary>
                [NameInMap("scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <para>The intelligent diagnostics result tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SubscriptionLackResource</para>
                /// </summary>
                [NameInMap("sceneTag")]
                [Validation(Required=false)]
                public string SceneTag { get; set; }

                /// <summary>
                /// <para>The intelligent diagnostics result summary.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Insufficient computing resources available for the job. Click to view details.</para>
                /// </summary>
                [NameInMap("summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// <para>The intelligent diagnostics result type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>warning</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The signature of the SQL job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20c1efb4a7caca1865f4aa784bb500efae74af04</para>
            /// </summary>
            [NameInMap("signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

            /// <summary>
            /// <para>The status of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the job was committed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1672112013</para>
            /// </summary>
            [NameInMap("submittedAtTime")]
            [Validation(Required=false)]
            public long? SubmittedAtTime { get; set; }

            /// <summary>
            /// <para>The tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4784****5249</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The interval from the time when the job was submitted to the snapshotTime .Unit: seconds (s).</para>
            /// 
            /// <b>Example:</b>
            /// <para>900</para>
            /// </summary>
            [NameInMap("totalTime")]
            [Validation(Required=false)]
            public long? TotalTime { get; set; }

            /// <summary>
            /// <para>The duration from the time the job is submitted to the time the job starts to run. Unit: seconds (s).</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("waitingTime")]
            [Validation(Required=false)]
            public long? WaitingTime { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OBJECT_NOT_EXIST</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This object does not exist.</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description>1xx: informational response. The request is received and is being processed.</description></item>
        /// <item><description>2xx: success. The request is successfully received, understood, and accepted by the server.</description></item>
        /// <item><description>3xx: redirection. The request is redirected, and further actions are required to complete the request.</description></item>
        /// <item><description>4xx: client error. The request contains invalid request parameters and syntaxes, or specific request conditions cannot be met.</description></item>
        /// <item><description>5xx: server error. The server cannot meet requirements due to other reasons.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0be3e0bb16654558425251398e27a9</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
