// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListEnvironmentMetricTargetsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListEnvironmentMetricTargetsResponseBodyData Data { get; set; }
        public class ListEnvironmentMetricTargetsResponseBodyData : TeaModel {
            [NameInMap("ActiveTargets")]
            [Validation(Required=false)]
            public List<ListEnvironmentMetricTargetsResponseBodyDataActiveTargets> ActiveTargets { get; set; }
            public class ListEnvironmentMetricTargetsResponseBodyDataActiveTargets : TeaModel {
                [NameInMap("DiscoveredLabels")]
                [Validation(Required=false)]
                public Dictionary<string, string> DiscoveredLabels { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://xxx">http://xxx</a></para>
                /// </summary>
                [NameInMap("GlobalUrl")]
                [Validation(Required=false)]
                public string GlobalUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>up</para>
                /// </summary>
                [NameInMap("Health")]
                [Validation(Required=false)]
                public string Health { get; set; }

                [NameInMap("Labels")]
                [Validation(Required=false)]
                public Dictionary<string, string> Labels { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Get \&quot;<a href="http://172.16.0.86:9104/metrics%5C%5C">http://172.16.0.86:9104/metrics\\</a>&quot;: dial tcp 172.16.0.86:9104: connect: connection refused</para>
                /// </summary>
                [NameInMap("LastError")]
                [Validation(Required=false)]
                public string LastError { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-10-12T07:15:47.306691514Z</para>
                /// </summary>
                [NameInMap("LastScrape")]
                [Validation(Required=false)]
                public string LastScrape { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.00127593</para>
                /// </summary>
                [NameInMap("LastScrapeDuration")]
                [Validation(Required=false)]
                public double? LastScrapeDuration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>122</para>
                /// </summary>
                [NameInMap("LastScrapeSeries")]
                [Validation(Required=false)]
                public long? LastScrapeSeries { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>arms-prom/mysql-exporter-mysql-1694429267986-sm/0&quot;</para>
                /// </summary>
                [NameInMap("ScrapePool")]
                [Validation(Required=false)]
                public string ScrapePool { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://xxxx">http://xxxx</a></para>
                /// </summary>
                [NameInMap("ScrapeUrl")]
                [Validation(Required=false)]
                public string ScrapeUrl { get; set; }

            }

            [NameInMap("DroppedTargets")]
            [Validation(Required=false)]
            public List<ListEnvironmentMetricTargetsResponseBodyDataDroppedTargets> DroppedTargets { get; set; }
            public class ListEnvironmentMetricTargetsResponseBodyDataDroppedTargets : TeaModel {
                [NameInMap("DiscoveredLabels")]
                [Validation(Required=false)]
                public Dictionary<string, string> DiscoveredLabels { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://xxx">http://xxx</a></para>
                /// </summary>
                [NameInMap("GlobalUrl")]
                [Validation(Required=false)]
                public string GlobalUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>up</para>
                /// </summary>
                [NameInMap("Health")]
                [Validation(Required=false)]
                public string Health { get; set; }

                [NameInMap("Labels")]
                [Validation(Required=false)]
                public Dictionary<string, string> Labels { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Get \&quot;<a href="http://172.16.0.86:9104/metrics%5C%5C">http://172.16.0.86:9104/metrics\\</a>&quot;: dial tcp 172.16.0.86:9104: connect: connection refused</para>
                /// </summary>
                [NameInMap("LastError")]
                [Validation(Required=false)]
                public string LastError { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-10-12T07:15:47.306691514Z</para>
                /// </summary>
                [NameInMap("LastScrape")]
                [Validation(Required=false)]
                public string LastScrape { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.00127593</para>
                /// </summary>
                [NameInMap("LastScrapeDuration")]
                [Validation(Required=false)]
                public double? LastScrapeDuration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>122</para>
                /// </summary>
                [NameInMap("LastScrapeSeries")]
                [Validation(Required=false)]
                public long? LastScrapeSeries { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>arms-prom/mysql-exporter-mysql-1694429267986-sm/0&quot;</para>
                /// </summary>
                [NameInMap("ScrapePool")]
                [Validation(Required=false)]
                public string ScrapePool { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://xxxx">http://xxxx</a></para>
                /// </summary>
                [NameInMap("ScrapeUrl")]
                [Validation(Required=false)]
                public string ScrapeUrl { get; set; }

            }

        }

        /// <summary>
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
        /// <para>16AF921B-8187-489F-9913-43C808B4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
