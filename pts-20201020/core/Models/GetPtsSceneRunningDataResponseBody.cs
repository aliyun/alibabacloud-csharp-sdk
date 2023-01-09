// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetPtsSceneRunningDataResponseBody : TeaModel {
        [NameInMap("AgentLocation")]
        [Validation(Required=false)]
        public List<GetPtsSceneRunningDataResponseBodyAgentLocation> AgentLocation { get; set; }
        public class GetPtsSceneRunningDataResponseBodyAgentLocation : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        [NameInMap("AliveAgents")]
        [Validation(Required=false)]
        public int? AliveAgents { get; set; }

        [NameInMap("AverageRt")]
        [Validation(Required=false)]
        public long? AverageRt { get; set; }

        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        [NameInMap("ChainMonitorDataList")]
        [Validation(Required=false)]
        public List<GetPtsSceneRunningDataResponseBodyChainMonitorDataList> ChainMonitorDataList { get; set; }
        public class GetPtsSceneRunningDataResponseBodyChainMonitorDataList : TeaModel {
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public string ApiId { get; set; }

            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            [NameInMap("AverageRt")]
            [Validation(Required=false)]
            public int? AverageRt { get; set; }

            [NameInMap("CheckPointResult")]
            [Validation(Required=false)]
            public GetPtsSceneRunningDataResponseBodyChainMonitorDataListCheckPointResult CheckPointResult { get; set; }
            public class GetPtsSceneRunningDataResponseBodyChainMonitorDataListCheckPointResult : TeaModel {
                [NameInMap("FailedBusinessCount")]
                [Validation(Required=false)]
                public long? FailedBusinessCount { get; set; }

                [NameInMap("FailedBusinessQps")]
                [Validation(Required=false)]
                public float? FailedBusinessQps { get; set; }

                [NameInMap("SucceedBusinessCount")]
                [Validation(Required=false)]
                public long? SucceedBusinessCount { get; set; }

                [NameInMap("SucceedBusinessQps")]
                [Validation(Required=false)]
                public float? SucceedBusinessQps { get; set; }

            }

            [NameInMap("Concurrency")]
            [Validation(Required=false)]
            public float? Concurrency { get; set; }

            [NameInMap("ConfigQps")]
            [Validation(Required=false)]
            public int? ConfigQps { get; set; }

            [NameInMap("Count2XX")]
            [Validation(Required=false)]
            public long? Count2XX { get; set; }

            [NameInMap("FailedCount")]
            [Validation(Required=false)]
            public long? FailedCount { get; set; }

            [NameInMap("FailedQps")]
            [Validation(Required=false)]
            public float? FailedQps { get; set; }

            [NameInMap("MaxRt")]
            [Validation(Required=false)]
            public int? MaxRt { get; set; }

            [NameInMap("MinRt")]
            [Validation(Required=false)]
            public int? MinRt { get; set; }

            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            [NameInMap("Qps2XX")]
            [Validation(Required=false)]
            public float? Qps2XX { get; set; }

            [NameInMap("RealQps")]
            [Validation(Required=false)]
            public float? RealQps { get; set; }

            [NameInMap("TimePoint")]
            [Validation(Required=false)]
            public long? TimePoint { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Concurrency")]
        [Validation(Required=false)]
        public int? Concurrency { get; set; }

        [NameInMap("ConcurrencyLimit")]
        [Validation(Required=false)]
        public int? ConcurrencyLimit { get; set; }

        [NameInMap("FailedBusinessCount")]
        [Validation(Required=false)]
        public long? FailedBusinessCount { get; set; }

        [NameInMap("FailedRequestCount")]
        [Validation(Required=false)]
        public long? FailedRequestCount { get; set; }

        [NameInMap("HasReport")]
        [Validation(Required=false)]
        public bool? HasReport { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestBps")]
        [Validation(Required=false)]
        public string RequestBps { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResponseBps")]
        [Validation(Required=false)]
        public string ResponseBps { get; set; }

        [NameInMap("Seg90Rt")]
        [Validation(Required=false)]
        public long? Seg90Rt { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalAgents")]
        [Validation(Required=false)]
        public int? TotalAgents { get; set; }

        [NameInMap("TotalRealQps")]
        [Validation(Required=false)]
        public int? TotalRealQps { get; set; }

        [NameInMap("TotalRequestCount")]
        [Validation(Required=false)]
        public long? TotalRequestCount { get; set; }

        [NameInMap("TpsLimit")]
        [Validation(Required=false)]
        public int? TpsLimit { get; set; }

        [NameInMap("Vum")]
        [Validation(Required=false)]
        public long? Vum { get; set; }

    }

}
