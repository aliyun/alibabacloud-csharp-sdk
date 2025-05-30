// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListJobInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListJobInfosResponseBodyData Data { get; set; }
        public class ListJobInfosResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about the jobs.</para>
            /// </summary>
            [NameInMap("jobInfoList")]
            [Validation(Required=false)]
            public List<ListJobInfosResponseBodyDataJobInfoList> JobInfoList { get; set; }
            public class ListJobInfosResponseBodyDataJobInfoList : TeaModel {
                /// <summary>
                /// <para>The cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AY20A</para>
                /// </summary>
                [NameInMap("cluster")]
                [Validation(Required=false)]
                public string Cluster { get; set; }

                /// <summary>
                /// <para>The CU snapshot proportion of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.48</para>
                /// </summary>
                [NameInMap("cuSnapshot")]
                [Validation(Required=false)]
                public double? CuSnapshot { get; set; }

                /// <summary>
                /// <para>The amount of resources consumed by the job. This parameter is returned only for jobs that are complete.Unit: 100\*Core\*s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("cuUsage")]
                [Validation(Required=false)]
                public long? CuUsage { get; set; }

                /// <summary>
                /// <para>The time when the job stops running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("endAtTime")]
                [Validation(Required=false)]
                public long? EndAtTime { get; set; }

                /// <summary>
                /// <para>The node ID of DataWorks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>node_4</para>
                /// </summary>
                [NameInMap("extNodeId")]
                [Validation(Required=false)]
                public string ExtNodeId { get; set; }

                /// <summary>
                /// <para>The account of the node owner.</para>
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
                /// <para>20230410050036549gfmsdwf60gg</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The account that commits the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN$<a href="mailto:xxx@test.aliyunid.com">xxx@test.aliyunid.com</a></para>
                /// </summary>
                [NameInMap("jobOwner")]
                [Validation(Required=false)]
                public string JobOwner { get; set; }

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
                /// <para>The memory snapshot proportion of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.42</para>
                /// </summary>
                [NameInMap("memorySnapshot")]
                [Validation(Required=false)]
                public double? MemorySnapshot { get; set; }

                /// <summary>
                /// <para>The number of memory consumed by the job. This parameter is returned only for jobs that are complete.Unit: MB\*s.</para>
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
                /// <para>The name of the MaxCompute project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>openrec_new</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The nickname of the quota that is used by the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my_quota</para>
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
                /// <para>The time when the job starts to run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1672112113</para>
                /// </summary>
                [NameInMap("runningAtTime")]
                [Validation(Required=false)]
                public long? RunningAtTime { get; set; }

                /// <summary>
                /// <para>The period for which the job runs.</para>
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
                public List<ListJobInfosResponseBodyDataJobInfoListSceneResults> SceneResults { get; set; }
                public class ListJobInfosResponseBodyDataJobInfoListSceneResults : TeaModel {
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
                /// <para>i094KijGrN3kOXZ74kbexB77XQY=</para>
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
                /// <para>The status of the snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("statusSnapshot")]
                [Validation(Required=false)]
                public string StatusSnapshot { get; set; }

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
                /// <para>The tags.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// <para>The tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>213065738244354</para>
                /// </summary>
                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>The total period for which the job runs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>900</para>
                /// </summary>
                [NameInMap("totalTime")]
                [Validation(Required=false)]
                public long? TotalTime { get; set; }

                /// <summary>
                /// <para>The duration for which the job waits to start.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("waitingTime")]
                [Validation(Required=false)]
                public long? WaitingTime { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. If this parameter was not empty and the value of this parameter was not 200, the request failed.</para>
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
        /// <para>0bc13a9516807484336515320e38f5</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
