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
        /// <para>rm-bp1****</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The list of enhanced monitoring metrics that are enabled for the instance.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceMetricsResponseBodyItems> Items { get; set; }
        public class DescribeDBInstanceMetricsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The description of the enhanced monitoring metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sys cpu使用率，sys cpu使用量 / cpu总量</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The category of the enhanced monitoring metric. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>os</b>: operating system metric.</description></item>
            /// <item><description><b>db</b>: database metric.</description></item>
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
            /// <para>CPU使用率</para>
            /// </summary>
            [NameInMap("GroupKeyType")]
            [Validation(Required=false)]
            public string GroupKeyType { get; set; }

            /// <summary>
            /// <para>The statistical method of the enhanced monitoring metric. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>avg</b>: average value.</description></item>
            /// <item><description><b>min</b>: minimum value.</description></item>
            /// <item><description><b>max</b>: maximum value.</description></item>
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
            /// <para>The sequence number of the enhanced monitoring metric.</para>
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
        /// <para>The request ID.</para>
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
