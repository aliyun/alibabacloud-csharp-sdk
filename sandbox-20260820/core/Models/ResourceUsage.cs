// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class ResourceUsage : TeaModel {
        /// <summary>
        /// <para>The end time of the requested interval, exclusive.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T02:00:00Z</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The aggregation granularity used for this query. Valid values: All, Hour, and Day.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hour</para>
        /// </summary>
        [NameInMap("granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>The grouping key used for this query. An empty array is returned when no grouping is applied.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;teamID&quot;]</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public List<string> GroupBy { get; set; }

        /// <summary>
        /// <para>The usage for each group. If no grouping is applied, the usage for the entire query range is returned. An empty array is returned if there are no usage records within the query range.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;dimensions&quot;:{&quot;teamID&quot;:&quot;70d1c834-0333-58d8-97ac-5336eb9179eb&quot;},&quot;items&quot;:[{&quot;usageName&quot;:&quot;cpuActive&quot;,&quot;unit&quot;:&quot;CoreSecond&quot;,&quot;total&quot;:5400,&quot;buckets&quot;:[{&quot;startTime&quot;:&quot;2026-11-05T00:00:00Z&quot;,&quot;endTime&quot;:&quot;2026-11-05T01:00:00Z&quot;,&quot;quantity&quot;:3600},{&quot;startTime&quot;:&quot;2026-11-05T01:00:00Z&quot;,&quot;endTime&quot;:&quot;2026-11-05T02:00:00Z&quot;,&quot;quantity&quot;:1800}]}]}]</para>
        /// </summary>
        [NameInMap("groups")]
        [Validation(Required=false)]
        public List<ResourceUsageGroups> Groups { get; set; }
        public class ResourceUsageGroups : TeaModel {
            /// <summary>
            /// <para>The team, template, or sandbox version corresponding to the usage of this group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;teamID&quot;:&quot;70d1c834-0333-58d8-97ac-5336eb9179eb&quot;}</para>
            /// </summary>
            [NameInMap("dimensions")]
            [Validation(Required=false)]
            public Dictionary<string, string> Dimensions { get; set; }

            /// <summary>
            /// <para>The query result for each requested usage item in this group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;usageName&quot;:&quot;cpuActive&quot;,&quot;unit&quot;:&quot;CoreSecond&quot;,&quot;total&quot;:5400,&quot;buckets&quot;:[{&quot;startTime&quot;:&quot;2026-11-05T00:00:00Z&quot;,&quot;endTime&quot;:&quot;2026-11-05T01:00:00Z&quot;,&quot;quantity&quot;:3600},{&quot;startTime&quot;:&quot;2026-11-05T01:00:00Z&quot;,&quot;endTime&quot;:&quot;2026-11-05T02:00:00Z&quot;,&quot;quantity&quot;:1800}]}]</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ResourceUsageGroupsItems> Items { get; set; }
            public class ResourceUsageGroupsItems : TeaModel {
                /// <summary>
                /// <para>The hourly or daily usage arranged in chronological order. Only time periods with records are returned. This field is omitted when granularity is set to All.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;startTime&quot;:&quot;2026-11-05T00:00:00Z&quot;,&quot;endTime&quot;:&quot;2026-11-05T01:00:00Z&quot;,&quot;quantity&quot;:3600},{&quot;startTime&quot;:&quot;2026-11-05T01:00:00Z&quot;,&quot;endTime&quot;:&quot;2026-11-05T02:00:00Z&quot;,&quot;quantity&quot;:1800}]</para>
                /// </summary>
                [NameInMap("buckets")]
                [Validation(Required=false)]
                public List<ResourceUsageGroupsItemsBuckets> Buckets { get; set; }
                public class ResourceUsageGroupsItemsBuckets : TeaModel {
                    /// <summary>
                    /// <para>The end time of this usage statistics period, exclusive.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-11-05T01:00:00Z</para>
                    /// </summary>
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The cumulative usage within this time period. The unit is specified by unit.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3600</para>
                    /// </summary>
                    [NameInMap("quantity")]
                    [Validation(Required=false)]
                    public double? Quantity { get; set; }

                    /// <summary>
                    /// <para>The start time of this usage statistics period, inclusive.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-11-05T00:00:00Z</para>
                    /// </summary>
                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                }

                /// <summary>
                /// <para>The cumulative usage of this usage item over the entire query interval. This field is omitted if there are no usage records for the item within the interval.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5400</para>
                /// </summary>
                [NameInMap("total")]
                [Validation(Required=false)]
                public double? Total { get; set; }

                /// <summary>
                /// <para>The unit of usage. The unit is CoreSecond for CPU, and GiBSecond for memory and cloud disks.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CoreSecond</para>
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                /// <summary>
                /// <para>The name of the usage item specified in the request.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cpuActive</para>
                /// </summary>
                [NameInMap("usageName")]
                [Validation(Required=false)]
                public string UsageName { get; set; }

            }

        }

        /// <summary>
        /// <para>The start time of the requested interval, inclusive.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T00:00:00Z</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
