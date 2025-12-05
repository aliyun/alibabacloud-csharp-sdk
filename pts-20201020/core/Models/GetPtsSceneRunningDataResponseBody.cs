// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetPtsSceneRunningDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The location information of stress testers.</para>
        /// </summary>
        [NameInMap("AgentLocation")]
        [Validation(Required=false)]
        public List<GetPtsSceneRunningDataResponseBodyAgentLocation> AgentLocation { get; set; }
        public class GetPtsSceneRunningDataResponseBodyAgentLocation : TeaModel {
            /// <summary>
            /// <para>The number of stress testers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The provider of the stress tester.</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <para>The province in which the stress tester resides.</para>
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            /// <summary>
            /// <para>The region in which the stress tester resides.</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        /// <summary>
        /// <para>The number of healthy engines.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AliveAgents")]
        [Validation(Required=false)]
        public int? AliveAgents { get; set; }

        /// <summary>
        /// <para>The average RT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45</para>
        /// </summary>
        [NameInMap("AverageRt")]
        [Validation(Required=false)]
        public long? AverageRt { get; set; }

        /// <summary>
        /// <para>The start time of the stress testing that is displayed as a timestamp. Unit: ms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1651895518339</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>The stress testing details of the GetPtsSceneRunningData operation.</para>
        /// </summary>
        [NameInMap("ChainMonitorDataList")]
        [Validation(Required=false)]
        public List<GetPtsSceneRunningDataResponseBodyChainMonitorDataList> ChainMonitorDataList { get; set; }
        public class GetPtsSceneRunningDataResponseBodyChainMonitorDataList : TeaModel {
            /// <summary>
            /// <para>The API ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ANBDC8B</para>
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public string ApiId { get; set; }

            /// <summary>
            /// <para>The API name.</para>
            /// </summary>
            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <summary>
            /// <para>The average RT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>46</para>
            /// </summary>
            [NameInMap("AverageRt")]
            [Validation(Required=false)]
            public int? AverageRt { get; set; }

            /// <summary>
            /// <para>The check point results.</para>
            /// </summary>
            [NameInMap("CheckPointResult")]
            [Validation(Required=false)]
            public GetPtsSceneRunningDataResponseBodyChainMonitorDataListCheckPointResult CheckPointResult { get; set; }
            public class GetPtsSceneRunningDataResponseBodyChainMonitorDataListCheckPointResult : TeaModel {
                /// <summary>
                /// <para>The number of failed businesses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("FailedBusinessCount")]
                [Validation(Required=false)]
                public long? FailedBusinessCount { get; set; }

                /// <summary>
                /// <para>The RPS of failed businesses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>78</para>
                /// </summary>
                [NameInMap("FailedBusinessQps")]
                [Validation(Required=false)]
                public float? FailedBusinessQps { get; set; }

                /// <summary>
                /// <para>The number of successful businesses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>908</para>
                /// </summary>
                [NameInMap("SucceedBusinessCount")]
                [Validation(Required=false)]
                public long? SucceedBusinessCount { get; set; }

                /// <summary>
                /// <para>The RPS of the successful businesses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>89</para>
                /// </summary>
                [NameInMap("SucceedBusinessQps")]
                [Validation(Required=false)]
                public float? SucceedBusinessQps { get; set; }

            }

            /// <summary>
            /// <para>The concurrency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Concurrency")]
            [Validation(Required=false)]
            public float? Concurrency { get; set; }

            /// <summary>
            /// <para>The RPS of successful and failed requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>78</para>
            /// </summary>
            [NameInMap("ConfigQps")]
            [Validation(Required=false)]
            public int? ConfigQps { get; set; }

            /// <summary>
            /// <para>The number of successful requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7890</para>
            /// </summary>
            [NameInMap("Count2XX")]
            [Validation(Required=false)]
            public long? Count2XX { get; set; }

            /// <summary>
            /// <para>The total number of failed requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>456</para>
            /// </summary>
            [NameInMap("FailedCount")]
            [Validation(Required=false)]
            public long? FailedCount { get; set; }

            /// <summary>
            /// <para>The RPS of failed requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("FailedQps")]
            [Validation(Required=false)]
            public float? FailedQps { get; set; }

            /// <summary>
            /// <para>The maximum RT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>56</para>
            /// </summary>
            [NameInMap("MaxRt")]
            [Validation(Required=false)]
            public int? MaxRt { get; set; }

            /// <summary>
            /// <para>The minimum RT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("MinRt")]
            [Validation(Required=false)]
            public int? MinRt { get; set; }

            /// <summary>
            /// <para>The API ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>78509</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            /// <summary>
            /// <para>The Requests Per Second (RPS) of successful requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>78</para>
            /// </summary>
            [NameInMap("Qps2XX")]
            [Validation(Required=false)]
            public float? Qps2XX { get; set; }

            /// <summary>
            /// <para>The actual RPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("RealQps")]
            [Validation(Required=false)]
            public float? RealQps { get; set; }

            /// <summary>
            /// <para>The point in time at which the stress testing is performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1278908899</para>
            /// </summary>
            [NameInMap("TimePoint")]
            [Validation(Required=false)]
            public long? TimePoint { get; set; }

        }

        /// <summary>
        /// <para>The system status code. If the request was successful, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4001</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The total concurrency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Concurrency")]
        [Validation(Required=false)]
        public int? Concurrency { get; set; }

        /// <summary>
        /// <para>The maximum concurrency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ConcurrencyLimit")]
        [Validation(Required=false)]
        public int? ConcurrencyLimit { get; set; }

        /// <summary>
        /// <para>The total number of failed businesses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78</para>
        /// </summary>
        [NameInMap("FailedBusinessCount")]
        [Validation(Required=false)]
        public long? FailedBusinessCount { get; set; }

        /// <summary>
        /// <para>The number of failed requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("FailedRequestCount")]
        [Validation(Required=false)]
        public long? FailedRequestCount { get; set; }

        /// <summary>
        /// <para>Indicates whether a report is generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasReport")]
        [Validation(Required=false)]
        public bool? HasReport { get; set; }

        /// <summary>
        /// <para>The HTTP status code. If the request was successful, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message. If the request was successful, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>no message</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The size of the request body.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89kb</para>
        /// </summary>
        [NameInMap("RequestBps")]
        [Validation(Required=false)]
        public string RequestBps { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC4E3177-6745-4925-B423-4E89VV34221A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The size of the response body.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8kb</para>
        /// </summary>
        [NameInMap("ResponseBps")]
        [Validation(Required=false)]
        public string ResponseBps { get; set; }

        /// <summary>
        /// <para>The 90th percentile of reaction time (RT).</para>
        /// 
        /// <b>Example:</b>
        /// <para>45</para>
        /// </summary>
        [NameInMap("Seg90Rt")]
        [Validation(Required=false)]
        public long? Seg90Rt { get; set; }

        /// <summary>
        /// <para>The scenario status. The default parameter value is 7.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

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

        /// <summary>
        /// <para>The total number of stress testers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalAgents")]
        [Validation(Required=false)]
        public int? TotalAgents { get; set; }

        /// <summary>
        /// <para>The total number of queries per second (QPS).</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalRealQps")]
        [Validation(Required=false)]
        public int? TotalRealQps { get; set; }

        /// <summary>
        /// <para>The total number of requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8900</para>
        /// </summary>
        [NameInMap("TotalRequestCount")]
        [Validation(Required=false)]
        public long? TotalRequestCount { get; set; }

        /// <summary>
        /// <para>The maximum transactions per second (TPS).</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("TpsLimit")]
        [Validation(Required=false)]
        public int? TpsLimit { get; set; }

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

}
