// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetApplicationListWithMetircsResponseBody : TeaModel {
        /// <summary>
        /// The response code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetApplicationListWithMetircsResponseBodyData Data { get; set; }
        public class GetApplicationListWithMetircsResponseBodyData : TeaModel {
            /// <summary>
            /// The number of the page to return.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The returned information.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<GetApplicationListWithMetircsResponseBodyDataResult> Result { get; set; }
            public class GetApplicationListWithMetircsResponseBodyDataResult : TeaModel {
                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The name of the application.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// The current metrics.
                /// </summary>
                [NameInMap("CurMetrics")]
                [Validation(Required=false)]
                public List<GetApplicationListWithMetircsResponseBodyDataResultCurMetrics> CurMetrics { get; set; }
                public class GetApplicationListWithMetircsResponseBodyDataResultCurMetrics : TeaModel {
                    /// <summary>
                    /// The number of blocked QPS.
                    /// </summary>
                    [NameInMap("BlockQps")]
                    [Validation(Required=false)]
                    public double? BlockQps { get; set; }

                    /// <summary>
                    /// The abnormal QPS.
                    /// </summary>
                    [NameInMap("ExpQps")]
                    [Validation(Required=false)]
                    public double? ExpQps { get; set; }

                    /// <summary>
                    /// The number of passed QPS.
                    /// </summary>
                    [NameInMap("PassQps")]
                    [Validation(Required=false)]
                    public double? PassQps { get; set; }

                    /// <summary>
                    /// The queries per second (QPS).
                    /// </summary>
                    [NameInMap("Qps")]
                    [Validation(Required=false)]
                    public double? Qps { get; set; }

                    /// <summary>
                    /// The response time (RT).
                    /// </summary>
                    [NameInMap("Rt")]
                    [Validation(Required=false)]
                    public double? Rt { get; set; }

                    /// <summary>
                    /// The number of threads.
                    /// </summary>
                    [NameInMap("Thread")]
                    [Validation(Required=false)]
                    public double? Thread { get; set; }

                    /// <summary>
                    /// The timestamp.
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                }

                /// <summary>
                /// The sum of metrics about the application.
                /// </summary>
                [NameInMap("CurMetricsFm")]
                [Validation(Required=false)]
                public GetApplicationListWithMetircsResponseBodyDataResultCurMetricsFm CurMetricsFm { get; set; }
                public class GetApplicationListWithMetircsResponseBodyDataResultCurMetricsFm : TeaModel {
                    /// <summary>
                    /// The number of blocked QPS.
                    /// </summary>
                    [NameInMap("BlockQps")]
                    [Validation(Required=false)]
                    public double? BlockQps { get; set; }

                    /// <summary>
                    /// The abnormal QPS.
                    /// </summary>
                    [NameInMap("ExpQps")]
                    [Validation(Required=false)]
                    public double? ExpQps { get; set; }

                    /// <summary>
                    /// The number of passed QPS.
                    /// </summary>
                    [NameInMap("PassQps")]
                    [Validation(Required=false)]
                    public double? PassQps { get; set; }

                    /// <summary>
                    /// The QPS.
                    /// </summary>
                    [NameInMap("Qps")]
                    [Validation(Required=false)]
                    public double? Qps { get; set; }

                    /// <summary>
                    /// The RT.
                    /// </summary>
                    [NameInMap("Rt")]
                    [Validation(Required=false)]
                    public double? Rt { get; set; }

                    /// <summary>
                    /// The number of concurrent threads.
                    /// </summary>
                    [NameInMap("Thread")]
                    [Validation(Required=false)]
                    public double? Thread { get; set; }

                    /// <summary>
                    /// The timestamp.
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                }

                /// <summary>
                /// The additional information.
                /// </summary>
                [NameInMap("ExtraInfo")]
                [Validation(Required=false)]
                public string ExtraInfo { get; set; }

                /// <summary>
                /// The number of instances.
                /// </summary>
                [NameInMap("InstancesNumber")]
                [Validation(Required=false)]
                public int? InstancesNumber { get; set; }

                /// <summary>
                /// The programming language of the application.
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// The license key in use.
                /// </summary>
                [NameInMap("LicenseKey")]
                [Validation(Required=false)]
                public string LicenseKey { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The source.
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// The status.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// The tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

                /// <summary>
                /// The ID of the user.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
