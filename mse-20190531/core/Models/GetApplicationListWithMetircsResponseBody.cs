// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetApplicationListWithMetircsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetApplicationListWithMetircsResponseBodyData Data { get; set; }
        public class GetApplicationListWithMetircsResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<GetApplicationListWithMetircsResponseBodyDataResult> Result { get; set; }
            public class GetApplicationListWithMetircsResponseBodyDataResult : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("CurMetrics")]
                [Validation(Required=false)]
                public List<GetApplicationListWithMetircsResponseBodyDataResultCurMetrics> CurMetrics { get; set; }
                public class GetApplicationListWithMetircsResponseBodyDataResultCurMetrics : TeaModel {
                    [NameInMap("BlockQps")]
                    [Validation(Required=false)]
                    public double? BlockQps { get; set; }

                    [NameInMap("ExpQps")]
                    [Validation(Required=false)]
                    public double? ExpQps { get; set; }

                    [NameInMap("PassQps")]
                    [Validation(Required=false)]
                    public double? PassQps { get; set; }

                    [NameInMap("Qps")]
                    [Validation(Required=false)]
                    public double? Qps { get; set; }

                    /// <summary>
                    /// Rt。
                    /// </summary>
                    [NameInMap("Rt")]
                    [Validation(Required=false)]
                    public double? Rt { get; set; }

                    [NameInMap("Thread")]
                    [Validation(Required=false)]
                    public double? Thread { get; set; }

                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                }

                [NameInMap("CurMetricsFm")]
                [Validation(Required=false)]
                public GetApplicationListWithMetircsResponseBodyDataResultCurMetricsFm CurMetricsFm { get; set; }
                public class GetApplicationListWithMetircsResponseBodyDataResultCurMetricsFm : TeaModel {
                    [NameInMap("BlockQps")]
                    [Validation(Required=false)]
                    public double? BlockQps { get; set; }

                    [NameInMap("ExpQps")]
                    [Validation(Required=false)]
                    public double? ExpQps { get; set; }

                    [NameInMap("PassQps")]
                    [Validation(Required=false)]
                    public double? PassQps { get; set; }

                    /// <summary>
                    /// QPS。
                    /// </summary>
                    [NameInMap("Qps")]
                    [Validation(Required=false)]
                    public double? Qps { get; set; }

                    /// <summary>
                    /// Rt。
                    /// </summary>
                    [NameInMap("Rt")]
                    [Validation(Required=false)]
                    public double? Rt { get; set; }

                    [NameInMap("Thread")]
                    [Validation(Required=false)]
                    public double? Thread { get; set; }

                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                }

                [NameInMap("ExtraInfo")]
                [Validation(Required=false)]
                public string ExtraInfo { get; set; }

                [NameInMap("InstancesNumber")]
                [Validation(Required=false)]
                public int? InstancesNumber { get; set; }

                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                [NameInMap("LicenseKey")]
                [Validation(Required=false)]
                public string LicenseKey { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
