// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListInspectionTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListInspectionTemplatesResponseBodyData> Data { get; set; }
        public class ListInspectionTemplatesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;timeWindow&quot;:{&quot;defaultLookback&quot;:&quot;1h&quot;,&quot;maxLookbackSeconds&quot;:3888000},&quot;thresholds&quot;:[]}</para>
            /// </summary>
            [NameInMap("configuration")]
            [Validation(Required=false)]
            public ListInspectionTemplatesResponseBodyDataConfiguration Configuration { get; set; }
            public class ListInspectionTemplatesResponseBodyDataConfiguration : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public List<ListInspectionTemplatesResponseBodyDataConfigurationParameters> Parameters { get; set; }
                public class ListInspectionTemplatesResponseBodyDataConfigurationParameters : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;1h&quot;</para>
                    /// </summary>
                    [NameInMap("default")]
                    [Validation(Required=false)]
                    public object Default { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>[&quot;all&quot;,&quot;active&quot;]</para>
                    /// </summary>
                    [NameInMap("enum")]
                    [Validation(Required=false)]
                    public List<string> Enum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>duration</para>
                    /// </summary>
                    [NameInMap("format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>lookback</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3888000</para>
                    /// </summary>
                    [NameInMap("maxLookbackSeconds")]
                    [Validation(Required=false)]
                    public long? MaxLookbackSeconds { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>86400</para>
                    /// </summary>
                    [NameInMap("maximum")]
                    [Validation(Required=false)]
                    public double? Maximum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minimum")]
                    [Validation(Required=false)]
                    public double? Minimum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>回看时间</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>string</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>seconds</para>
                    /// </summary>
                    [NameInMap("unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("wholeDays")]
                    [Validation(Required=false)]
                    public bool? WholeDays { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>检查消息堆积和消费健康度</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>队列健康巡检</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("params")]
            [Validation(Required=false)]
            public object Params { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Instance</para>
            /// </summary>
            [NameInMap("scopeType")]
            [Validation(Required=false)]
            public string ScopeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>queue-health</para>
            /// </summary>
            [NameInMap("templateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJvZmZzZXQiOjIwfQ</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
