// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribePriceShrinkRequest : TeaModel {
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<DescribePriceShrinkRequestDataDisk> DataDisk { get; set; }
        public class DescribePriceShrinkRequestDataDisk : TeaModel {
            /// <summary>
            /// <para>The size of the data cloud disk. Unit: GB. If this field is not empty, it takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public DescribePriceShrinkRequestSystemDisk SystemDisk { get; set; }
        public class DescribePriceShrinkRequestSystemDisk : TeaModel {
            /// <summary>
            /// <para>The size of the system cloud disk. Unit: GB.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <para>The data cloud disks. If DataDisk.1.Size is empty and this field is not empty, this field takes precedence.</para>
        /// </summary>
        [NameInMap("DataDisks")]
        [Validation(Required=false)]
        public string DataDisksShrink { get; set; }

        /// <summary>
        /// <para>The edge zone ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-unicom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ens.sn1.tiny</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The Billable methods for ENS bandwidth. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BandwidthByDay: daily peak bandwidth.</description></item>
        /// <item><description>95BandwidthByMonth: monthly 95th percentile bandwidth.</description></item>
        /// <item><description>PayByBandwidth4thMonth: monthly fourth peak bandwidth.</description></item>
        /// <item><description>PayByBandwidth: bandwidth with defined specifications.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95BandwidthByMonth</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The subscription duration of the resource.</para>
        /// <list type="bullet">
        /// <item><description>If PeriodUnit is not specified, the default billing cycle is month. Only Day and Month are supported.</description></item>
        /// <item><description>If PeriodUnit is set to Day, Period can only be set to 3.</description></item>
        /// <item><description>If PeriodUnit is set to Month, Period can be set to 1 to 9 or 12.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The billing cycle for querying the prices of ENS resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month (default): monthly billing cycle.</description></item>
        /// <item><description>Day: daily billing cycle.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The quantity.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

    }

}
