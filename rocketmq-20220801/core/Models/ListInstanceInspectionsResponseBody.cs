// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListInstanceInspectionsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListInstanceInspectionsResponseBodyData> Data { get; set; }
        public class ListInstanceInspectionsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public ListInstanceInspectionsResponseBodyDataConfig Config { get; set; }
            public class ListInstanceInspectionsResponseBodyDataConfig : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;templateCode&quot;:&quot;rmq.consumer-health&quot;,&quot;parameters&quot;:{&quot;lookback&quot;:&quot;1h&quot;}},{&quot;templateCode&quot;:&quot;rmq.traffic-capacity&quot;,&quot;parameters&quot;:{&quot;lookback&quot;:&quot;6h&quot;}}]</para>
                /// </summary>
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<ListInstanceInspectionsResponseBodyDataConfigItems> Items { get; set; }
                public class ListInstanceInspectionsResponseBodyDataConfigItems : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;lookback&quot;:&quot;1h&quot;,&quot;consumerDelayThresholdSeconds&quot;:600}</para>
                    /// </summary>
                    [NameInMap("parameters")]
                    [Validation(Required=false)]
                    public object Parameters { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rmq.consumer-health</para>
                    /// </summary>
                    [NameInMap("templateCode")]
                    [Validation(Required=false)]
                    public string TemplateCode { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;mode&quot;:&quot;All&quot;}</para>
                /// </summary>
                [NameInMap("resourceScope")]
                [Validation(Required=false)]
                public ListInstanceInspectionsResponseBodyDataConfigResourceScope ResourceScope { get; set; }
                public class ListInstanceInspectionsResponseBodyDataConfigResourceScope : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>[&quot;orders-g1&quot;]</para>
                    /// </summary>
                    [NameInMap("consumerGroups")]
                    [Validation(Required=false)]
                    public List<string> ConsumerGroups { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>All</para>
                    /// </summary>
                    [NameInMap("mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>[&quot;orders&quot;]</para>
                    /// </summary>
                    [NameInMap("topics")]
                    [Validation(Required=false)]
                    public List<string> Topics { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;enabled&quot;:true,&quot;cron&quot;:&quot;0 3 * * *&quot;}</para>
                /// </summary>
                [NameInMap("schedule")]
                [Validation(Required=false)]
                public ListInstanceInspectionsResponseBodyDataConfigSchedule Schedule { get; set; }
                public class ListInstanceInspectionsResponseBodyDataConfigSchedule : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0 3 * * *</para>
                    /// </summary>
                    [NameInMap("cron")]
                    [Validation(Required=false)]
                    public string Cron { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("configured")]
            [Validation(Required=false)]
            public bool? Configured { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rmq-cn-example</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListInstanceInspectionsResponseBodyDataItems> Items { get; set; }
            public class ListInstanceInspectionsResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>检查消费延迟和消费健康度</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>消费健康巡检</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("resourceCount")]
                [Validation(Required=false)]
                public long? ResourceCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[&quot;ConsumerGroup&quot;]</para>
                /// </summary>
                [NameInMap("resourceTypes")]
                [Validation(Required=false)]
                public List<string> ResourceTypes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rmq.consumer-health</para>
                /// </summary>
                [NameInMap("templateCode")]
                [Validation(Required=false)]
                public string TemplateCode { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-09-09T03:00:00+08:00</para>
            /// </summary>
            [NameInMap("nextRunAt")]
            [Validation(Required=false)]
            public string NextRunAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("revision")]
            [Validation(Required=false)]
            public long? Revision { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
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

    }

}
