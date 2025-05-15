// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ResizeDiskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the order.</para>
        /// <remarks>
        /// <para>This parameter is returned only when you resize subscription disks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the disk. You can call the <a href="https://help.aliyun.com/document_detail/25514.html">DescribeDisks</a> operation to query available disk IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>The new disk capacity. Unit: GiB. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>System disk:</para>
        /// <list type="bullet">
        /// <item><description><para>Basic disk (cloud): 20 to 500.</para>
        /// </description></item>
        /// <item><description><para>ESSD (cloud_essd): The valid values vary based on the performance level of the ESSD.</para>
        /// <list type="bullet">
        /// <item><description>Valid values when SystemDisk.PerformanceLevel is set to PL0: 1 to 2048.</description></item>
        /// <item><description>Valid values when SystemDisk.PerformanceLevel is set to PL1: 20 to 2048.</description></item>
        /// <item><description>Valid values when SystemDisk.PerformanceLevel is set to PL2: 461 to 2048.</description></item>
        /// <item><description>Valid values when SystemDisk.PerformanceLevel is set to PL3: 1261 to 2048.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>ESSD AutoPL disk: 1 to 2048.</para>
        /// </description></item>
        /// <item><description><para>Other disk categories: 20 to 2048.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Data disk:</para>
        /// <list type="bullet">
        /// <item><description><para>Ultra disk (cloud_efficiency): 20 to 32768.</para>
        /// </description></item>
        /// <item><description><para>Standard SSD (cloud_ssd): 20 to 32768.</para>
        /// </description></item>
        /// <item><description><para>ESSD (cloud_essd): The valid values vary based on the performance level of the ESSD.`` To query the performance level of an ESSD, call the <a href="https://help.aliyun.com/document_detail/25514.html">DescribeDisks</a> operation to query disk information and check the <c>PerformanceLevel</c> value in the response.</para>
        /// <list type="bullet">
        /// <item><description>PL0 ESSD: 1 to 65536.</description></item>
        /// <item><description>PL1 ESSD: 20 to 65536.</description></item>
        /// <item><description>PL2 ESSD: 461 to 65536.</description></item>
        /// <item><description>PL3 ESSD: 1261 to 65536.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Basic disk (cloud): 5 to 2000.</para>
        /// </description></item>
        /// <item><description><para>ESSD AutoPL disk (cloud_auto): 1 to 65536.</para>
        /// </description></item>
        /// <item><description><para>Standard elastic ephemeral disk (elastic_ephemeral_disk_standard): 64 to 8192.</para>
        /// </description></item>
        /// <item><description><para>Premium elastic ephemeral disk (elastic_ephemeral_disk_premium): 64 to 8192.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> The new disk capacity must be larger than the original disk capacity. Otherwise, an error is reported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1900</para>
        /// </summary>
        [NameInMap("NewSize")]
        [Validation(Required=false)]
        public int? NewSize { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The method that you want to use to resize the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>offline (default): resizes the disk offline. After you resize a disk offline, you must <a href="https://help.aliyun.com/document_detail/25440.html">restart the associated instance</a> in the ECS console or by calling the <a href="https://help.aliyun.com/document_detail/25502.html">RebootInstance</a> operation for the resizing operation to take effect.</description></item>
        /// <item><description>online: resizes the disk online. After you resize a disk online, the resizing operation immediately takes effect. You do not need to restart the associated instance. You can resize ultra disks, standard SSDs, ESSDs, and elastic ephemeral disks online.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>offline</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
