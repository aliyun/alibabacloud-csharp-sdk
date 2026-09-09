// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListComputeMetricsBySignatureResponseBody : TeaModel {
        /// <summary>
        /// <para>The data payload of the response.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListComputeMetricsBySignatureResponseBodyData Data { get; set; }
        public class ListComputeMetricsBySignatureResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>An array containing the compute metrics for each signature.</para>
            /// </summary>
            [NameInMap("signatureComputeMetrics")]
            [Validation(Required=false)]
            public List<ListComputeMetricsBySignatureResponseBodyDataSignatureComputeMetrics> SignatureComputeMetrics { get; set; }
            public class ListComputeMetricsBySignatureResponseBodyDataSignatureComputeMetrics : TeaModel {
                /// <summary>
                /// <para>A list of instances.</para>
                /// </summary>
                [NameInMap("instances")]
                [Validation(Required=false)]
                public List<ListComputeMetricsBySignatureResponseBodyDataSignatureComputeMetricsInstances> Instances { get; set; }
                public class ListComputeMetricsBySignatureResponseBodyDataSignatureComputeMetricsInstances : TeaModel {
                    /// <summary>
                    /// <para>The end time of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1766780295000</para>
                    /// </summary>
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20260124052241299gdxd3wveqsj</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The start time of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1765765291000</para>
                    /// </summary>
                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                }

                /// <summary>
                /// <para>A list of project names.</para>
                /// </summary>
                [NameInMap("projectNames")]
                [Validation(Required=false)]
                public List<string> ProjectNames { get; set; }

                /// <summary>
                /// <para>The signature of the SQL job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>YF3JMiEXEvZVmGzUXz6G4MtWVJk=</para>
                /// </summary>
                [NameInMap("signature")]
                [Validation(Required=false)]
                public string Signature { get; set; }

                /// <summary>
                /// <para>The unit of compute usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GBCplx</para>
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                /// <summary>
                /// <para>The compute usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32.67767215706408</para>
                /// </summary>
                [NameInMap("usage")]
                [Validation(Required=false)]
                public double? Usage { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries that match the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description><para><c>1xx</c>: Informational - The server has received the request and is processing it.</para>
        /// </description></item>
        /// <item><description><para><c>2xx</c>: Success - The server successfully received, understood, and accepted the request.</para>
        /// </description></item>
        /// <item><description><para><c>3xx</c>: Redirection - Further action is required to complete the request.</para>
        /// </description></item>
        /// <item><description><para><c>4xx</c>: Client Error - The request contains invalid syntax or cannot be fulfilled.</para>
        /// </description></item>
        /// <item><description><para><c>5xx</c>: Server Error - The server failed to fulfill a valid request.</para>
        /// </description></item>
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
        /// <para>0a06dc0a17495216593736061e45a3</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
