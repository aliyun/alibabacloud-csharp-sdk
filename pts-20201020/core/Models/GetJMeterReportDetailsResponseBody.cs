// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetJMeterReportDetailsResponseBody : TeaModel {
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
        /// <para>The code key that corresponds to the key in Medusa. If no code key is available, or if the content corresponding to the code key fails to be obtained or is empty, the returned message is displayed as the default information.</para>
        /// </summary>
        [NameInMap("CodeKey")]
        [Validation(Required=false)]
        public string CodeKey { get; set; }

        /// <summary>
        /// <para>The URL used to access the document.</para>
        /// </summary>
        [NameInMap("DocumentUrl")]
        [Validation(Required=false)]
        public string DocumentUrl { get; set; }

        /// <summary>
        /// <para>The returned dynamic contents that are separated by the &amp;&amp; operator.</para>
        /// </summary>
        [NameInMap("DynamicCtx")]
        [Validation(Required=false)]
        public string DynamicCtx { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
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
        /// <para>The details of the report.</para>
        /// </summary>
        [NameInMap("ReportOverView")]
        [Validation(Required=false)]
        public GetJMeterReportDetailsResponseBodyReportOverView ReportOverView { get; set; }
        public class GetJMeterReportDetailsResponseBodyReportOverView : TeaModel {
            /// <summary>
            /// <para>The number of used engines.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AgentCount")]
            [Validation(Required=false)]
            public int? AgentCount { get; set; }

            /// <summary>
            /// <para>The end of the queried time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-03 10:45:11</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The report ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GHB56VD</para>
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <para>The report name.</para>
            /// </summary>
            [NameInMap("ReportName")]
            [Validation(Required=false)]
            public string ReportName { get; set; }

            /// <summary>
            /// <para>The beginning of the queried time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-03 10:35:11</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The consumed Virtual User Minutes (VUM).</para>
            /// 
            /// <b>Example:</b>
            /// <para>4452</para>
            /// </summary>
            [NameInMap("Vum")]
            [Validation(Required=false)]
            public long? Vum { get; set; }

        }

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
        /// <para>The dimensions of APIs.</para>
        /// </summary>
        [NameInMap("SamplerMetricsList")]
        [Validation(Required=false)]
        public List<GetJMeterReportDetailsResponseBodySamplerMetricsList> SamplerMetricsList { get; set; }
        public class GetJMeterReportDetailsResponseBodySamplerMetricsList : TeaModel {
            /// <summary>
            /// <para>The total number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>731</para>
            /// </summary>
            [NameInMap("AllCount")]
            [Validation(Required=false)]
            public long? AllCount { get; set; }

            /// <summary>
            /// <para>The API name.</para>
            /// </summary>
            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <summary>
            /// <para>The average RT. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>44.2</para>
            /// </summary>
            [NameInMap("AvgRt")]
            [Validation(Required=false)]
            public double? AvgRt { get; set; }

            /// <summary>
            /// <para>The average TPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("AvgTps")]
            [Validation(Required=false)]
            public double? AvgTps { get; set; }

            /// <summary>
            /// <para>The request failure rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("FailCountReq")]
            [Validation(Required=false)]
            public long? FailCountReq { get; set; }

            /// <summary>
            /// <para>The maximum RT. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>78</para>
            /// </summary>
            [NameInMap("MaxRt")]
            [Validation(Required=false)]
            public double? MaxRt { get; set; }

            /// <summary>
            /// <para>The minimum RT. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("MinRt")]
            [Validation(Required=false)]
            public double? MinRt { get; set; }

            /// <summary>
            /// <para>The 75th percentile of RT. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22.4</para>
            /// </summary>
            [NameInMap("Seg75Rt")]
            [Validation(Required=false)]
            public double? Seg75Rt { get; set; }

            /// <summary>
            /// <para>The 90th percentile of RT. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65</para>
            /// </summary>
            [NameInMap("Seg90Rt")]
            [Validation(Required=false)]
            public double? Seg90Rt { get; set; }

            /// <summary>
            /// <para>The 99th percentile of RT. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>77</para>
            /// </summary>
            [NameInMap("Seg99Rt")]
            [Validation(Required=false)]
            public double? Seg99Rt { get; set; }

            /// <summary>
            /// <para>The request success rate. The parameter value must be a non-negative number less than or equal to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SuccessRateReq")]
            [Validation(Required=false)]
            public double? SuccessRateReq { get; set; }

        }

        /// <summary>
        /// <para>The dimensions of the whole scenario.</para>
        /// </summary>
        [NameInMap("SceneMetrics")]
        [Validation(Required=false)]
        public GetJMeterReportDetailsResponseBodySceneMetrics SceneMetrics { get; set; }
        public class GetJMeterReportDetailsResponseBodySceneMetrics : TeaModel {
            /// <summary>
            /// <para>The total number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>717</para>
            /// </summary>
            [NameInMap("AllCount")]
            [Validation(Required=false)]
            public long? AllCount { get; set; }

            /// <summary>
            /// <para>The average response time (RT). Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("AvgRt")]
            [Validation(Required=false)]
            public double? AvgRt { get; set; }

            /// <summary>
            /// <para>The average transactions per second (TPS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>78</para>
            /// </summary>
            [NameInMap("AvgTps")]
            [Validation(Required=false)]
            public double? AvgTps { get; set; }

            /// <summary>
            /// <para>The request failure rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>34</para>
            /// </summary>
            [NameInMap("FailCountReq")]
            [Validation(Required=false)]
            public long? FailCountReq { get; set; }

            /// <summary>
            /// <para>The 90th percentile of RT. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>35</para>
            /// </summary>
            [NameInMap("Seg90Rt")]
            [Validation(Required=false)]
            public double? Seg90Rt { get; set; }

            /// <summary>
            /// <para>The 99th percentile of RT. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>56</para>
            /// </summary>
            [NameInMap("Seg99Rt")]
            [Validation(Required=false)]
            public double? Seg99Rt { get; set; }

            /// <summary>
            /// <para>The request success rate. The parameter value must be a non-negative number less than or equal to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.99</para>
            /// </summary>
            [NameInMap("SuccessRateReq")]
            [Validation(Required=false)]
            public double? SuccessRateReq { get; set; }

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
