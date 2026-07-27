// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeApplicationPerformanceRequest : TeaModel {
        /// <summary>
        /// <para>The application cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-xxxxxxx</para>
        /// </summary>
        [NameInMap("Consumer")]
        [Validation(Required=false)]
        public string Consumer { get; set; }

        /// <summary>
        /// <para>The user group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg-xxxxxx</para>
        /// </summary>
        [NameInMap("ConsumerGroup")]
        [Validation(Required=false)]
        public string ConsumerGroup { get; set; }

        /// <summary>
        /// <para>The downsampling policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>raw_sample</para>
        /// </summary>
        [NameInMap("Downsample")]
        [Validation(Required=false)]
        public string Downsample { get; set; }

        /// <summary>
        /// <para>The end step number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("EndStep")]
        [Validation(Required=false)]
        public long? EndStep { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the yyyy-MM-ddTHH:mmZ format (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-09-23T01:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The data granularity of performance data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5</description></item>
        /// <item><description>30</description></item>
        /// <item><description>60</description></item>
        /// <item><description>600</description></item>
        /// <item><description>1800</description></item>
        /// <item><description>3600</description></item>
        /// <item><description>86400</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The performance metrics to query. Separate multiple values with commas (,).</para>
        /// <remarks>
        /// <para><b>Note</b> You can specify up to 5 performance metrics.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PolarDBSupabaseMemUsage</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The maximum number of data points to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxPoints")]
        [Validation(Required=false)]
        public int? MaxPoints { get; set; }

        /// <summary>
        /// <para>The model service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ms-xxxxxx</para>
        /// </summary>
        [NameInMap("ModelService")]
        [Validation(Required=false)]
        public string ModelService { get; set; }

        /// <summary>
        /// <para>The start step number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("StartStep")]
        [Validation(Required=false)]
        public long? StartStep { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the yyyy-MM-ddTHH:mmZ format (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-09-23T01:01Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
