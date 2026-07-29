// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ScaleInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The cold storage space of the instance. Unit: GB.</para>
        /// <remarks>
        /// <para>This parameter is ignored for pay-as-you-go instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000G</para>
        /// </summary>
        [NameInMap("coldStorageSize")]
        [Validation(Required=false)]
        public long? ColdStorageSize { get; set; }

        /// <summary>
        /// <para>The instance specifications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>16</c>: 16 vCPUs and 64 GB of memory (1 compute node)</para>
        /// </description></item>
        /// <item><description><para><c>32</c>: 32 vCPUs and 128 GB of memory (2 compute nodes)</para>
        /// </description></item>
        /// <item><description><para><c>64</c>: 64 vCPUs and 256 GB of memory (4 compute nodes)</para>
        /// </description></item>
        /// <item><description><para><c>96</c>: 96 vCPUs and 384 GB memory (6 compute nodes)</para>
        /// </description></item>
        /// <item><description><para><c>128</c>: 128 vCPUs and 512 GB memory (8 compute nodes)</para>
        /// </description></item>
        /// <item><description><para>and so on.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Specify the number of vCPUs.</para>
        /// </description></item>
        /// <item><description><para>To purchase an instance type with more than 1024 vCPUs, submit a ticket.</para>
        /// </description></item>
        /// <item><description><para>Skip this parameter for shared instances.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public long? Cpu { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Serverless Computing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableServerlessComputing")]
        [Validation(Required=false)]
        public bool? EnableServerlessComputing { get; set; }

        /// <summary>
        /// <para>The number of gateways. Valid values: [2, 50].</para>
        /// <remarks>
        /// <para>This parameter applies only to virtual warehouse instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("gatewayCount")]
        [Validation(Required=false)]
        public long? GatewayCount { get; set; }

        /// <summary>
        /// <para>The scaling type.</para>
        /// <list type="bullet">
        /// <item><description><para>UPGRADE: Upgrades the instance.</para>
        /// </description></item>
        /// <item><description><para>DOWNGRADE: Downgrades the instance.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para><b>Upgrade an instance:</b> New specifications must be equal to or greater than original specifications. Leaving a parameter empty retains its original specification. At least one specification must be increased.</para>
        /// </description></item>
        /// <item><description><para><b>Downgrade an instance:</b> New specifications must be equal to or less than original specifications. Leaving a parameter empty retains its original specification. At least one specification must be decreased.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UPGRADE</para>
        /// </summary>
        [NameInMap("scaleType")]
        [Validation(Required=false)]
        public string ScaleType { get; set; }

        /// <summary>
        /// <para>The standard storage space of the instance. Unit: GB.</para>
        /// <remarks>
        /// <para>This parameter is ignored for pay-as-you-go instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000G</para>
        /// </summary>
        [NameInMap("storageSize")]
        [Validation(Required=false)]
        public long? StorageSize { get; set; }

    }

}
