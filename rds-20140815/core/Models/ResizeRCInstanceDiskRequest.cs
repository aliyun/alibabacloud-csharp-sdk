// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ResizeRCInstanceDiskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the automatic payment feature for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): enables the feature. Make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b>: disables the feature. An unpaid order is generated.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If your account balance is insufficient, you can set AutoPay to false. In this case, an unpaid order is generated. You can complete the payment in the Expenses and Costs console.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, service limits, and insufficient inventory errors.</description></item>
        /// <item><description><b>false</b>: performs a dry run and performs the actual request. If the request passes the dry run, the instance is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf62br2491p5l****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The new disk size. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("NewSize")]
        [Validation(Required=false)]
        public long? NewSize { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The method that you want to use to resize the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>offline</b> (default): resizes disks offline. After you resize a disk offline, you must restart the instance for the resizing operation to take effect.</description></item>
        /// <item><description><b>online</b>: resizes disks online. After you resize a disk online, the resizing operation takes effect immediately and you do not need to restart the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
