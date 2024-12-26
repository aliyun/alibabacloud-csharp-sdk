// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ScaleInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The infrequent access (IA) storage space of the instance. Unit: GB.</para>
        /// <remarks>
        /// <para>Ignore this parameter for pay-as-you-go instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000G</para>
        /// </summary>
        [NameInMap("coldStorageSize")]
        [Validation(Required=false)]
        public long? ColdStorageSize { get; set; }

        /// <summary>
        /// <para>The specifications of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>8-core 32GB (number of compute nodes: 1)</description></item>
        /// <item><description>16-core 64GB (number of compute nodes: 1)</description></item>
        /// <item><description>32-core 128GB (number of compute nodes: 2)</description></item>
        /// <item><description>64-core 256GB (number of compute nodes: 4)</description></item>
        /// <item><description>96-core 384GB (number of compute nodes: 6)</description></item>
        /// <item><description>128-core 512GB (number of compute nodes: 8)</description></item>
        /// <item><description>Others</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Set this parameter to the number of cores.</para>
        /// </description></item>
        /// <item><description><para>If you want to set this parameter to specifications with more than 1,024 compute units (CUs), you must submit a ticket.</para>
        /// </description></item>
        /// <item><description><para>This parameter is invalid for Hologres Shared Cluster instances.</para>
        /// </description></item>
        /// <item><description><para>The specifications of 8-core 32GB (number of compute nodes: 1) are for trial use only and cannot be used for production.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public long? Cpu { get; set; }

        /// <summary>
        /// <para>是否开启ServerlessComputing</para>
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
        /// <para>This parameter is required only for virtual warehouse instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("gatewayCount")]
        [Validation(Required=false)]
        public long? GatewayCount { get; set; }

        /// <summary>
        /// <para>The specification change type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>UPGRADE</description></item>
        /// <item><description>DOWNGRADE</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you set this parameter to UPGRADE, the new specifications must be higher than the original specifications. You must configure at least one of the cpu, storageSize, and coldStorageSize parameters. If you leave a parameter empty, the related configuration remains unchanged.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter to DOWNGRADE, the new specifications must be lower than the original specifications. You must configure at least one of the cpu, storageSize, and coldStorageSize parameters. If you leave a parameter empty, the related configuration remains unchanged.</para>
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
        /// <para>Ignore this parameter for pay-as-you-go instances.</para>
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
