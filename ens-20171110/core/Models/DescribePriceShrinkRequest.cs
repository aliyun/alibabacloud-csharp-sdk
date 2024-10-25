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
            /// <para>The size of the data disk. Unit: GB. If you specify this parameter, this parameter takes precedence over the Size property in DataDisks.</para>
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
            /// <para>The size of the system disk. Unit: GB.</para>
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
        /// <para>If you leave DataDisk.1.Size empty, the value that you specified for this parameter is used.</para>
        /// </summary>
        [NameInMap("DataDisks")]
        [Validation(Required=false)]
        public string DataDisksShrink { get; set; }

        /// <summary>
        /// <para>The ID of the ENS node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-unicom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The specifications of instances.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ens.sn1.tiny</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The bandwidth metering method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BandwidthByDay: Pay by daily peak bandwidth</description></item>
        /// <item><description>95BandwidthByMonth: Pay by monthly 95th percentile bandwidth</description></item>
        /// <item><description>PayByBandwidth4thMonth: Pay by monthly fourth peak bandwidth</description></item>
        /// <item><description>PayByBandwidth: Pay by fixed bandwidth</description></item>
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
        /// <para>The subscription duration of the instance.</para>
        /// <list type="bullet">
        /// <item><description>If you leave the PeriodUnit parameter empty, the instance is purchased on a monthly basis. Valid values: Day and Month.</description></item>
        /// <item><description>If you set PeriodUnit to Day, you can set Period only to 3.</description></item>
        /// <item><description>If you set PeriodUnit to Month, you can set Period to a number from 1 to 9, or set Period to 12.</description></item>
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
        /// <para>The billing cycle of the ENS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month (default):</description></item>
        /// <item><description>Day</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The number of instances.</para>
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
