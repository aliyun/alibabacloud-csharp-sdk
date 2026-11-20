// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ScaleInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The infrequent access storage space of the instance. Unit: GB.</para>
        /// <remarks>
        /// <para>This parameter is ignored for pay-as-you-go instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("coldStorageSize")]
        [Validation(Required=false)]
        public long? ColdStorageSize { get; set; }

        /// <summary>
        /// <para>The instance specifications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>16 cores, 64 GB (Number of compute nodes: 1)</description></item>
        /// <item><description>32 cores, 128 GB (Number of compute nodes: 2)</description></item>
        /// <item><description>64 cores, 256 GB (Number of compute nodes: 4)</description></item>
        /// <item><description>96 cores, 384 GB (Number of compute nodes: 6)</description></item>
        /// <item><description>128 cores, 512 GB (Number of compute nodes: 8)</description></item>
        /// <item><description>More</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Specify only the number of cores.</description></item>
        /// <item><description>To purchase specifications with more than 1,024 cores, submit a ticket.</description></item>
        /// <item><description>You do not need to specify the specifications for shared instances.</description></item>
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
        /// <para>Specifies whether to enable serverless computing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableServerlessComputing")]
        [Validation(Required=false)]
        public bool? EnableServerlessComputing { get; set; }

        /// <summary>
        /// <para>The number of gateways. Valid values: 2 to 50.</para>
        /// <remarks>
        /// <para>This parameter is required only for the Warehouse type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("gatewayCount")]
        [Validation(Required=false)]
        public long? GatewayCount { get; set; }

        /// <summary>
        /// <para>The type of the specification change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>UPGRADE: upgrades the specifications.</description></item>
        /// <item><description>DOWNGRADE: downgrades the specifications.<remarks>
        /// <list type="bullet">
        /// <item><description>When you upgrade the specifications, the new specifications cannot be lower than the original specifications. An empty field indicates that the original specifications remain unchanged. At least one specification must be higher than the original specification.</description></item>
        /// <item><description>When you downgrade the specifications, the new specifications cannot be higher than the original specifications. An empty field indicates that the original specifications remain unchanged. At least one specification must be lower than the original specification.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
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
        /// <para>1000</para>
        /// </summary>
        [NameInMap("storageSize")]
        [Validation(Required=false)]
        public long? StorageSize { get; set; }

    }

}
