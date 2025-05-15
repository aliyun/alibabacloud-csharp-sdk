// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class GetExperimentResultDataResponseBody : TeaModel {
        /// <summary>
        /// <para>Access Denied Details</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetExperimentResultDataResponseBodyData> Data { get; set; }
        public class GetExperimentResultDataResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Number of GPUs</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("GpuNum")]
            [Validation(Required=false)]
            public string GpuNum { get; set; }

            /// <summary>
            /// <para>Host IP</para>
            /// 
            /// <b>Example:</b>
            /// <para>p-jt-waf-app1</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>List of Metrics Information</para>
            /// </summary>
            [NameInMap("MetricsInfos")]
            [Validation(Required=false)]
            public List<GetExperimentResultDataResponseBodyDataMetricsInfos> MetricsInfos { get; set; }
            public class GetExperimentResultDataResponseBodyDataMetricsInfos : TeaModel {
                /// <summary>
                /// <para>GPU</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("Gpu_num")]
                [Validation(Required=false)]
                public string GpuNum { get; set; }

                /// <summary>
                /// <para>Iteration</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Iteration")]
                [Validation(Required=false)]
                public long? Iteration { get; set; }

                /// <summary>
                /// <para>TFLOPS</para>
                /// 
                /// <b>Example:</b>
                /// <para>43</para>
                /// </summary>
                [NameInMap("Tflops")]
                [Validation(Required=false)]
                public double? Tflops { get; set; }

                /// <summary>
                /// <para>Operation Timestamp</para>
                /// 
                /// <b>Example:</b>
                /// <para>1715393860</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>Metric Value</para>
                /// 
                /// <b>Example:</b>
                /// <para>126</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public double? Value { get; set; }

            }

            /// <summary>
            /// <para>Pod Name</para>
            /// 
            /// <b>Example:</b>
            /// <para>hzs-forge-sdxl-online-7ff4d86444-pc95h</para>
            /// </summary>
            [NameInMap("PodName")]
            [Validation(Required=false)]
            public string PodName { get; set; }

        }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>C1D34EC2-AB13-56F4-8322-F15AE563EA04</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total Count of Queries</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
