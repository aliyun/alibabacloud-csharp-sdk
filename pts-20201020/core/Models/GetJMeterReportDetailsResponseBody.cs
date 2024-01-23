// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetJMeterReportDetailsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CodeKey")]
        [Validation(Required=false)]
        public string CodeKey { get; set; }

        [NameInMap("DocumentUrl")]
        [Validation(Required=false)]
        public string DocumentUrl { get; set; }

        [NameInMap("DynamicCtx")]
        [Validation(Required=false)]
        public string DynamicCtx { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ReportOverView")]
        [Validation(Required=false)]
        public GetJMeterReportDetailsResponseBodyReportOverView ReportOverView { get; set; }
        public class GetJMeterReportDetailsResponseBodyReportOverView : TeaModel {
            [NameInMap("AgentCount")]
            [Validation(Required=false)]
            public int? AgentCount { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            [NameInMap("ReportName")]
            [Validation(Required=false)]
            public string ReportName { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Vum")]
            [Validation(Required=false)]
            public long? Vum { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SamplerMetricsList")]
        [Validation(Required=false)]
        public List<GetJMeterReportDetailsResponseBodySamplerMetricsList> SamplerMetricsList { get; set; }
        public class GetJMeterReportDetailsResponseBodySamplerMetricsList : TeaModel {
            [NameInMap("AllCount")]
            [Validation(Required=false)]
            public long? AllCount { get; set; }

            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            [NameInMap("AvgRt")]
            [Validation(Required=false)]
            public double? AvgRt { get; set; }

            [NameInMap("AvgTps")]
            [Validation(Required=false)]
            public double? AvgTps { get; set; }

            [NameInMap("FailCountReq")]
            [Validation(Required=false)]
            public long? FailCountReq { get; set; }

            [NameInMap("MaxRt")]
            [Validation(Required=false)]
            public double? MaxRt { get; set; }

            [NameInMap("MinRt")]
            [Validation(Required=false)]
            public double? MinRt { get; set; }

            [NameInMap("Seg75Rt")]
            [Validation(Required=false)]
            public double? Seg75Rt { get; set; }

            [NameInMap("Seg90Rt")]
            [Validation(Required=false)]
            public double? Seg90Rt { get; set; }

            [NameInMap("Seg99Rt")]
            [Validation(Required=false)]
            public double? Seg99Rt { get; set; }

            [NameInMap("SuccessRateReq")]
            [Validation(Required=false)]
            public double? SuccessRateReq { get; set; }

        }

        [NameInMap("SceneMetrics")]
        [Validation(Required=false)]
        public GetJMeterReportDetailsResponseBodySceneMetrics SceneMetrics { get; set; }
        public class GetJMeterReportDetailsResponseBodySceneMetrics : TeaModel {
            [NameInMap("AllCount")]
            [Validation(Required=false)]
            public long? AllCount { get; set; }

            [NameInMap("AvgRt")]
            [Validation(Required=false)]
            public double? AvgRt { get; set; }

            [NameInMap("AvgTps")]
            [Validation(Required=false)]
            public double? AvgTps { get; set; }

            [NameInMap("FailCountReq")]
            [Validation(Required=false)]
            public long? FailCountReq { get; set; }

            [NameInMap("Seg90Rt")]
            [Validation(Required=false)]
            public double? Seg90Rt { get; set; }

            [NameInMap("Seg99Rt")]
            [Validation(Required=false)]
            public double? Seg99Rt { get; set; }

            [NameInMap("SuccessRateReq")]
            [Validation(Required=false)]
            public double? SuccessRateReq { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
