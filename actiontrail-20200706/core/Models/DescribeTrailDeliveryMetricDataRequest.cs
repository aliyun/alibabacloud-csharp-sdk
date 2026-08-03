// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class DescribeTrailDeliveryMetricDataRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time window for the query. Specify the time in ISO 8601 format: \&quot;YYYY-MM-DDThh:mm:ssZ\&quot;. The \&quot;Z\&quot; indicates UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-10T01:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The name of the delivery monitoring metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>delivery_sls_success_count</c>: The number of logs successfully delivered to SLS.</para>
        /// </description></item>
        /// <item><description><para><c>delivery_sls_fail_count</c>: The number of logs that failed to be delivered to SLS.</para>
        /// </description></item>
        /// <item><description><para><c>delivery_oss_success_count</c>: The number of logs successfully delivered to OSS.</para>
        /// </description></item>
        /// <item><description><para><c>delivery_oss_fail_count</c>: The number of logs that failed to be delivered to OSS.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>delivery_sls_success_count</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The statistical period for the metric data, in seconds. The value must be 60 or a multiple of 60.</para>
        /// <para>Recommended values: 60, 900, and 3600.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// <para>The start of the time window for the query. Specify the time in ISO 8601 format: \&quot;YYYY-MM-DDThh:mm:ssZ\&quot;. The \&quot;Z\&quot; indicates UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-09T01:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the trail.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trail-name</para>
        /// </summary>
        [NameInMap("TrailName")]
        [Validation(Required=false)]
        public string TrailName { get; set; }

    }

}
