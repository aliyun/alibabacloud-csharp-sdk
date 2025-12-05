// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetJMeterSceneRunningDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The system status code. If the request was successful, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The URL that is used to access the document.</para>
        /// </summary>
        [NameInMap("DocumentUrl")]
        [Validation(Required=false)]
        public string DocumentUrl { get; set; }

        /// <summary>
        /// <para>The HTTP status code. If the request was successful, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message. If the request was successful, this parameter is not returned.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A8E16480-15C1-555A-922F-B736A005E52D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The running data.</para>
        /// </summary>
        [NameInMap("RunningData")]
        [Validation(Required=false)]
        public GetJMeterSceneRunningDataResponseBodyRunningData RunningData { get; set; }
        public class GetJMeterSceneRunningDataResponseBodyRunningData : TeaModel {
            /// <summary>
            /// <para>The number of stress testing engines.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AgentCount")]
            [Validation(Required=false)]
            public int? AgentCount { get; set; }

            /// <summary>
            /// <para>The stress testing engines.</para>
            /// </summary>
            [NameInMap("AgentIdList")]
            [Validation(Required=false)]
            public List<string> AgentIdList { get; set; }

            /// <summary>
            /// <para>The sampling status of the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;failTps&quot;:0,&quot;successRtAvg&quot;:33,&quot;successRtMin&quot;:29,&quot;successRtSum&quot;:99407,         &quot;rtAvg&quot;:33.459104678559406,&quot;rtMin&quot;:29,&quot;failRtMax&quot;:0,&quot;duration&quot;:997,         &quot;samplerId&quot;:-1, &quot;successRtMax&quot;:133,&quot;fullStat&quot;:{       &quot;requestBytesSum&quot;:629926,&quot;successRtAvg&quot;:33,&quot;successRtMin&quot;:29,&quot;successRtSum&quot;:174551,&quot;count&quot;:5206,&quot;rtSeg99&quot;:53, &quot;successTps&quot;:2397.9732842008293,&quot;rtSeg90&quot;:36, &quot;rtSeg50&quot;:32,            &quot;rtSeg99Sum&quot;:53,&quot;rtAvg&quot;:33.528812908182864, &quot;rtMin&quot;:29,             &quot;failRtMax&quot;:0,&quot;duration&quot;:2171, &quot;successCount&quot;:5206,            &quot;rtSegStatCount&quot;:1,&quot;tps&quot;:2397.9732842008293 }, &quot;successCount&quot;:2971, &quot;failRtSum&quot;:0,&quot;failCount&quot;:0,&quot;count&quot;:2971,&quot;concurrency&quot;:100, &quot;successTps&quot;:2979.939819458375,&quot;tps&quot;:2979.939819458375,&quot;failRtAvg&quot;:0,         &quot;failRtMin&quot;:0,  &quot;rtMax&quot;:133}</para>
            /// </summary>
            [NameInMap("AllSampleStat")]
            [Validation(Required=false)]
            public Dictionary<string, object> AllSampleStat { get; set; }

            /// <summary>
            /// <para>The concurrency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Concurrency")]
            [Validation(Required=false)]
            public int? Concurrency { get; set; }

            /// <summary>
            /// <para>The error message returned for the stress testing process. If the request was successful, this parameter is not returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Engine lease failed.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>Indicates whether an error occurs in the stress testing process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasError")]
            [Validation(Required=false)]
            public bool? HasError { get; set; }

            /// <summary>
            /// <para>Indicates whether the report is generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasReport")]
            [Validation(Required=false)]
            public bool? HasReport { get; set; }

            /// <summary>
            /// <para>The duration of the stress testing plan. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("HoldFor")]
            [Validation(Required=false)]
            public int? HoldFor { get; set; }

            /// <summary>
            /// <para>Indicates whether a debugging is performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDebugging")]
            [Validation(Required=false)]
            public bool? IsDebugging { get; set; }

            /// <summary>
            /// <para>The stress testing task ID. This ID also means the report ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DYYPLDKS</para>
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <para>The status of samplers.</para>
            /// </summary>
            [NameInMap("SampleStatList")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> SampleStatList { get; set; }

            /// <summary>
            /// <para>The scenario ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DYYPZIH</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// <para>The scenario name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>The current stage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>任务执行</para>
            /// </summary>
            [NameInMap("StageName")]
            [Validation(Required=false)]
            public string StageName { get; set; }

            /// <summary>
            /// <para>The timestamp when the stress testing is scheduled to start. Unit: ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639970040000</para>
            /// </summary>
            [NameInMap("StartTimeTS")]
            [Validation(Required=false)]
            public long? StartTimeTS { get; set; }

            /// <summary>
            /// <para>The stress testing status of the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The consumed Virtual User Minutes (VUM).</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Vum")]
            [Validation(Required=false)]
            public long? Vum { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
