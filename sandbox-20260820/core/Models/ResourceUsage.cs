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
        /// <para>The grouping keys used for this query. This is an empty array if no grouping is applied.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;teamID&quot;]</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public List<string> GroupBy { get; set; }

        /// <summary>
        /// <para>The usage for each group. If no grouping is applied, the usage is aggregated across the entire query range. An empty array is returned if no matching groups are found.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;dimensions&quot;:{&quot;teamID&quot;:&quot;70d1c834-0333-58d8-97ac-5336eb9179eb&quot;},&quot;items&quot;:[{&quot;usageName&quot;:&quot;activeVCPU&quot;,&quot;unit&quot;:&quot;CoreSecond&quot;,&quot;total&quot;:5400,&quot;buckets&quot;:[{&quot;startTime&quot;:&quot;2026-11-05T00:00:00Z&quot;,&quot;endTime&quot;:&quot;2026-11-05T01:00:00Z&quot;,&quot;quantity&quot;:3600},{&quot;startTime&quot;:&quot;2026-11-05T01:00:00Z&quot;,&quot;endTime&quot;:&quot;2026-11-05T02:00:00Z&quot;,&quot;quantity&quot;:1800}]}]}]</para>
        /// </summary>
        [NameInMap("groups")]
        [Validation(Required=false)]
        public List<ResourceUsageGroups> Groups { get; set; }
        public class ResourceUsageGroups : TeaModel {
            /// <summary>
            /// <para>The team, template, snapshot, or sandbox version corresponding to the usage in this group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;teamID&quot;:&quot;70d1c834-0333-58d8-97ac-5336eb9179eb&quot;}</para>
            /// </summary>
            [NameInMap("dimensions")]
            [Validation(Required=false)]
            public Dictionary<string, string> Dimensions { get; set; }

            /// <summary>
            /// <para>The query results for each requested usage item in this group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;usageName&quot;:&quot;activeVCPU&quot;,&quot;unit&quot;:&quot;CoreSecond&quot;,&quot;total&quot;:5400,&quot;buckets&quot;:[{&quot;startTime&quot;:&quot;2026-11-05T00:00:00Z&quot;,&quot;endTime&quot;:&quot;2026-11-05T01:00:00Z&quot;,&quot;quantity&quot;:3600},{&quot;startTime&quot;:&quot;2026-11-05T01:00:00Z&quot;,&quot;endTime&quot;:&quot;2026-11-05T02:00:00Z&quot;,&quot;quantity&quot;:1800}]}]</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ResourceUsageGroupsItems> Items { get; set; }
            public class ResourceUsageGroupsItems : TeaModel {
                /// <summary>
                /// <para>The hourly or daily time buckets with usage data, returned in chronological order. An empty array is returned if no buckets are available. This field is omitted if the granularity is All.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;startTime&quot;:&quot;2026-11-05T00:00:00Z&quot;,&quot;endTime&quot;:&quot;2026-11-05T01:00:00Z&quot;,&quot;quantity&quot;:3600},{&quot;startTime&quot;:&quot;2026-11-05T01:00:00Z&quot;,&quot;endTime&quot;:&quot;2026-11-05T02:00:00Z&quot;,&quot;quantity&quot;:1800}]</para>
                /// </summary>
                [NameInMap("buckets")]
                [Validation(Required=false)]
                public List<ResourceUsageGroupsItemsBuckets> Buckets { get; set; }
                public class ResourceUsageGroupsItemsBuckets : TeaModel {
                    /// <summary>
                    /// <para>The end time of the usage statistics for this bucket, exclusive.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-11-05T01:00:00Z</para>
                    /// </summary>
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The accumulated usage during this time bucket. The unit is specified in the unit field.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3600</para>
                    /// </summary>
                    [NameInMap("quantity")]
                    [Validation(Required=false)]
                    public double? Quantity { get; set; }

                    /// <summary>
                    /// <para>The start time of the usage statistics for this bucket, inclusive.</para>
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
                /// <para>The accumulated usage for the entire query interval. This field is omitted if no accumulated value is available. A value of 0 indicates that the accumulated usage is zero.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5400</para>
                /// </summary>
                [NameInMap("total")]
                [Validation(Required=false)]
                public double? Total { get; set; }

                /// <summary>
                /// <para>The unit of usage. The unit is CoreSecond for CPU, and GiBSecond for memory and disks.</para>
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
                /// <para>activeVCPU</para>
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
