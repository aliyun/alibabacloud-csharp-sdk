// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyRCDiskSpecRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): Automatic payment is enabled. Make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b>: Only an order is generated, and no payment is made.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the balance of your payment method is insufficient, you can change the Settings of the parameter AutoPay to false. An unpaid order is generated. You can logon to the ApsaraDB RDS console to complete the payment.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The new category of the cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_essd</b> (default): ESSD cloud disk.</description></item>
        /// <item><description><b>cloud_auto</b>: ESSD AutoPL cloud disk.</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// <para>The ID of the cloud disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rcd-wz9f3peueu5npsl****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for this operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: A dry run is performed, and the modification is not executed. The check items include request parameters, request format, business limits, and inventory.</description></item>
        /// <item><description><b>false</b> (default): A normal request is sent, and the modification is executed after the check is passed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The new performance level (PL) of the ESSD cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PL1</b> (default): A single disk delivers up to 50,000 random read/write IOPS.</para>
        /// </description></item>
        /// <item><description><para><b>PL2</b>: A single disk delivers up to 100,000 random read/write IOPS.</para>
        /// </description></item>
        /// <item><description><para><b>PL3</b>: A single disk delivers up to 1,000,000 random read/write IOPS.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PL2</para>
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
