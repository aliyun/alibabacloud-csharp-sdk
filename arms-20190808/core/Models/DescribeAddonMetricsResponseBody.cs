// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeAddonMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The metric details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAddonMetricsResponseBodyData> Data { get; set; }
        public class DescribeAddonMetricsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The metric group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Common</para>
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<DescribeAddonMetricsResponseBodyDataLabels> Labels { get; set; }
            public class DescribeAddonMetricsResponseBodyDataLabels : TeaModel {
                /// <summary>
                /// <para>The description of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The number of times a B-tree page of size PAGE_SIZE was successfully compressed.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>page_size</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The source of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>db</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

            }

            /// <summary>
            /// <para>The metrics.</para>
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public List<DescribeAddonMetricsResponseBodyDataMetrics> Metrics { get; set; }
            public class DescribeAddonMetricsResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// <para>The description of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The number of times a B-tree page of size PAGE_SIZE was successfully compressed.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The tags.</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public List<DescribeAddonMetricsResponseBodyDataMetricsLabels> Labels { get; set; }
                public class DescribeAddonMetricsResponseBodyDataMetricsLabels : TeaModel {
                    /// <summary>
                    /// <para>The description of the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PAGE_SIZE</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>page_size</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The source of the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>db</para>
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                }

                /// <summary>
                /// <para>The metric name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql_exporter_collector_duration_seconds</para>
                /// </summary>
                [NameInMap("Metric")]
                [Validation(Required=false)]
                public string Metric { get; set; }

                /// <summary>
                /// <para>The type of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GAUGE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The unit of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bytes</para>
                /// </summary>
                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6A00968-82A8-4F14-9D1B-B53827DB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
