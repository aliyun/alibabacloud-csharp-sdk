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
        /// <item><description><b>true (default)</b>: automatically completes the payment. Make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b>: does not automatically complete the payment. An unpaid order is generated.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If your account balance is insufficient, you can set the AutoPay parameter to false. In this case, an unpaid order is generated. You can complete the payment in the Expenses and Costs console.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The new disk type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_essd</b>: ESSD.</description></item>
        /// <item><description><b>cloud_auto</b>: ESSD AutoPL disk</description></item>
        /// </list>
        /// <para>This parameter is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// <para>The cloud disk ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rcd-wz9f3peueu5npsl****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values: Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run and does not perform the actual request. The system checks the request parameters, request syntax, limits, and available resources.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The PL of the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PL1</b> (default): A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
        /// <item><description><b>PL2</b>: A single ESSD delivers up to 100,000 random read/write IOPS.</description></item>
        /// <item><description><b>PL3</b>: A single ESSD delivers up to 1,000,000 random read/write IOPS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PL2</para>
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
