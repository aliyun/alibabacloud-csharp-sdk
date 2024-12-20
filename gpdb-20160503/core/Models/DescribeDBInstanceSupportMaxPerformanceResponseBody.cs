// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceSupportMaxPerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp***************</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The queried performance metric.</para>
        /// </summary>
        [NameInMap("Performances")]
        [Validation(Required=false)]
        public DescribeDBInstanceSupportMaxPerformanceResponseBodyPerformances Performances { get; set; }
        public class DescribeDBInstanceSupportMaxPerformanceResponseBodyPerformances : TeaModel {
            [NameInMap("Performance")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceSupportMaxPerformanceResponseBodyPerformancesPerformance> Performance { get; set; }
            public class DescribeDBInstanceSupportMaxPerformanceResponseBodyPerformancesPerformance : TeaModel {
                /// <summary>
                /// <para>The performance bottleneck type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs or disk</para>
                /// </summary>
                [NameInMap("Bottleneck")]
                [Validation(Required=false)]
                public string Bottleneck { get; set; }

                /// <summary>
                /// <para>The name of the performance metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>adbpg_status,adbpg_disk_status,adbpg_connection_status,adbgp_segment_disk_usage_percent_max,adbpg_master_disk_usage_percent_max,adbpg_disk_usage_percent</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The unit of the performance metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>%</para>
                /// </summary>
                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                /// <summary>
                /// <para>The value of the performance metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
