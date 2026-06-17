// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeApplicationPerformanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The ID of the consumer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-xxxxxxx</para>
        /// </summary>
        [NameInMap("Consumer")]
        [Validation(Required=false)]
        public string Consumer { get; set; }

        /// <summary>
        /// <para>The ID of the consumer group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg-xxxxxx</para>
        /// </summary>
        [NameInMap("ConsumerGroup")]
        [Validation(Required=false)]
        public string ConsumerGroup { get; set; }

        /// <summary>
        /// <para>The end time for the query. Specify the time in UTC in the <c>yyyy-MM-ddTHH:mmZ</c> format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-09-23T01:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The granularity of the performance data, in seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>5</para>
        /// </description></item>
        /// <item><description><para>30</para>
        /// </description></item>
        /// <item><description><para>60</para>
        /// </description></item>
        /// <item><description><para>600</para>
        /// </description></item>
        /// <item><description><para>1800</para>
        /// </description></item>
        /// <item><description><para>3600</para>
        /// </description></item>
        /// <item><description><para>86400</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The performance metrics to query. Separate multiple metrics with commas (,).<br>You can specify up to five performance metrics.<br></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PolarDBSupabaseMemUsage</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The ID of the model service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ms-xxxxxx</para>
        /// </summary>
        [NameInMap("ModelService")]
        [Validation(Required=false)]
        public string ModelService { get; set; }

        /// <summary>
        /// <para>The start time for the query. Specify the time in UTC in the <c>yyyy-MM-ddTHH:mmZ</c> format.</para>
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
