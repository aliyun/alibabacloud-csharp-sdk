// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1*****</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>An array consisting of the Enhanced Monitoring metrics that are enabled for the instance.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceMetricsResponseBodyItems> Items { get; set; }
        public class DescribeDBInstanceMetricsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The description of the enhanced monitoring metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OS CPU utilization, equal to the number of OS-consumed CPUs divided by the total number of CPUs</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The category of the enhanced monitoring metric. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>os</b>: OS metric</description></item>
            /// <item><description><b>db</b>: database metric</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>os</para>
            /// </summary>
            [NameInMap("Dimension")]
            [Validation(Required=false)]
            public string Dimension { get; set; }

            /// <summary>
            /// <para>The key of the group to which the enhanced monitoring metric belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>os.cpu_usage</para>
            /// </summary>
            [NameInMap("GroupKey")]
            [Validation(Required=false)]
            public string GroupKey { get; set; }

            /// <summary>
            /// <para>The name of the group to which the enhanced monitoring metric belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CPU Utilization Rate</para>
            /// </summary>
            [NameInMap("GroupKeyType")]
            [Validation(Required=false)]
            public string GroupKeyType { get; set; }

            /// <summary>
            /// <para>The method that is used to aggregate the monitoring data of the enhanced monitoring metric. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>avg</b>: The system calculates the average value of the enhanced monitoring metric.</description></item>
            /// <item><description><b>min</b>: The system calculates the minimum value of the enhanced monitoring metric.</description></item>
            /// <item><description><b>max</b>: The system calculates the maximum value of the enhanced monitoring metric.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>avg</para>
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <para>The key of the enhanced monitoring metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>os.cpu_usage.sys.avg</para>
            /// </summary>
            [NameInMap("MetricsKey")]
            [Validation(Required=false)]
            public string MetricsKey { get; set; }

            /// <summary>
            /// <para>The alias of the enhanced monitoring metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>os.cpu_usage.sys</para>
            /// </summary>
            [NameInMap("MetricsKeyAlias")]
            [Validation(Required=false)]
            public string MetricsKeyAlias { get; set; }

            /// <summary>
            /// <para>The serial number of the enhanced monitoring metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SortRule")]
            [Validation(Required=false)]
            public int? SortRule { get; set; }

            /// <summary>
            /// <para>The unit of the enhanced monitoring metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>%</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>318C3754-F6D0-54BB-A55C-23EAA04708B7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of enhanced monitoring metrics that are enabled for the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
