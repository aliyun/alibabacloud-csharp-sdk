// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeMetricListRequest : TeaModel {
        /// <summary>
        /// <para>For instance-level monitoring, enter a list of Cloud Phone instance IDs.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>For matrix-level monitoring, enter a list of matrix IDs.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIds")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIds { get; set; }

        /// <summary>
        /// <para>The end time for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-31 11:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>A list of instance IDs.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page for a paged query.</para>
        /// <para>Default value: 1000. This means that 1000 monitoring data records are returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public string Length { get; set; }

        /// <summary>
        /// <para>The monitoring metrics.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MetricNames")]
        [Validation(Required=false)]
        public List<string> MetricNames { get; set; }

        /// <summary>
        /// <para>A token that marks the position from which the query starts. Leave it empty to start from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kw9dGL5jves2FS9RLq****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The statistic period of the monitoring data.</para>
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
        /// <para>A list of process monitoring metrics.</para>
        /// </summary>
        [NameInMap("ProcessInfos")]
        [Validation(Required=false)]
        public List<DescribeMetricListRequestProcessInfos> ProcessInfos { get; set; }
        public class DescribeMetricListRequestProcessInfos : TeaModel {
            /// <summary>
            /// <para>A list of process IDs.</para>
            /// </summary>
            [NameInMap("ProcessIds")]
            [Validation(Required=false)]
            public List<int?> ProcessIds { get; set; }

            /// <summary>
            /// <para>The process name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>php-fpm</para>
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

        }

        /// <summary>
        /// <para>The start time for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-31 10:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
