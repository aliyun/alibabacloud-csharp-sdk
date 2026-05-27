// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListComputeMetricsBySignatureResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListComputeMetricsBySignatureResponseBodyData Data { get; set; }
        public class ListComputeMetricsBySignatureResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("signatureComputeMetrics")]
            [Validation(Required=false)]
            public List<ListComputeMetricsBySignatureResponseBodyDataSignatureComputeMetrics> SignatureComputeMetrics { get; set; }
            public class ListComputeMetricsBySignatureResponseBodyDataSignatureComputeMetrics : TeaModel {
                [NameInMap("instances")]
                [Validation(Required=false)]
                public List<ListComputeMetricsBySignatureResponseBodyDataSignatureComputeMetricsInstances> Instances { get; set; }
                public class ListComputeMetricsBySignatureResponseBodyDataSignatureComputeMetricsInstances : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1770886999000</para>
                    /// </summary>
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20250910185415772gu7vl8vwk22</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1762946698000</para>
                    /// </summary>
                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                }

                [NameInMap("projectNames")]
                [Validation(Required=false)]
                public List<string> ProjectNames { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oC0HkG5aTRscH3BDrttrLwHf8XA=</para>
                /// </summary>
                [NameInMap("signature")]
                [Validation(Required=false)]
                public string Signature { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>GBCplx</para>
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("usage")]
                [Validation(Required=false)]
                public double? Usage { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>57</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0adbef0f17600626304764284d0001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
