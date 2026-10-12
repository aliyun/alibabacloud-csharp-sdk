// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeMetricLastRequest : TeaModel {
        /// <summary>
        /// <para>The list of cloud phone instance IDs for instance-level monitoring.
        /// &lt;props=&quot;china&quot;&gt;The list of matrix IDs for matrix-level monitoring.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIds")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIds { get; set; }

        /// <summary>
        /// <para>The end time for querying the monitoring metric. The time format is YYYY-MM-DD HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-31 11:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The list of instance IDs.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The page size of the returned monitoring data, used for paged query.</para>
        /// <para>Default value: 1000, indicating 1,000 monitoring data entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public string Length { get; set; }

        /// <summary>
        /// <para>The list of monitoring metrics.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MetricNames")]
        [Validation(Required=false)]
        public List<string> MetricNames { get; set; }

        /// <summary>
        /// <para>The token that marks the position from which to start reading. An empty value indicates that the query starts from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6l5V9uONHqPtDLM2U8s****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The statistical period for the monitoring data.</para>
        /// <para>Valid values: 60, 900, and 3600.</para>
        /// <para>Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The start time for querying the monitoring metric. The time format is YYYY-MM-DD HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-31 10:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
