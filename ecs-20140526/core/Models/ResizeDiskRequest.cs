// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ResizeDiskRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The disk ID. You can call <a href="https://help.aliyun.com/document_detail/25514.html">DescribeDisks</a> to query disk IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>The new disk capacity that you want after expansion. Unit: GiB. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>System disk:</para>
        /// <list type="bullet">
        /// <item><description>Basic disk: 20 to 500.</description></item>
        /// <item><description>Enterprise SSD:<list type="bullet">
        /// <item><description>PL0: 1 to 2048.</description></item>
        /// <item><description>PL1: 20 to 2048.</description></item>
        /// <item><description>PL2: 461 to 2048.</description></item>
        /// <item><description>PL3: 1261 to 2048.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>ESSD AutoPL disk: 1 to 2048.</description></item>
        /// <item><description>Other disk types: 20 to 2048.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Data disk:</para>
        /// <list type="bullet">
        /// <item><description><para>Ultra disk (cloud_efficiency): 20 to 32768.</para>
        /// </description></item>
        /// <item><description><para>Standard SSD (cloud_ssd): 20 to 32768.</para>
        /// </description></item>
        /// <item><description><para>Enterprise SSD (cloud_essd): The valid values depend on the value of <c>PerformanceLevel</c>. You can call <a href="https://help.aliyun.com/document_detail/25514.html">DescribeDisks</a> to query disk information and check the <c>PerformanceLevel</c> parameter in the response.</para>
        /// <list type="bullet">
        /// <item><description>PL0: 1 to 65536.</description></item>
        /// <item><description>PL1: 20 to 65536.</description></item>
        /// <item><description>PL2: 461 to 65536.</description></item>
        /// <item><description>PL3: 1261 to 65536.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Basic disk (cloud): 5 to 2000.</para>
        /// </description></item>
        /// <item><description><para>ESSD AutoPL disk (cloud_auto): 1 to 65536.
        /// &lt;props=&quot;china&quot;&gt;</para>
        /// </description></item>
        /// <item><description><para>ESSD Entry disk (cloud_essd_entry): 10 to 32768.</para>
        /// </description></item>
        /// <item><description><para>Elastic ephemeral disk - Standard (elastic_ephemeral_disk_standard): 64 to 8,192.</para>
        /// </description></item>
        /// <item><description><para>Elastic ephemeral disk - Premium (elastic_ephemeral_disk_premium): 64 to 8,192.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The new disk capacity must be greater than the original disk capacity. Otherwise, an error is returned.</para>
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
        /// <para>The method used to expand the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>offline (default): offline expansion. After the expansion, you must restart the instance in the console by following the instructions in <a href="https://help.aliyun.com/document_detail/25440.html">Restart an instance</a> or by calling the <a href="https://help.aliyun.com/document_detail/25502.html">RebootInstance</a> operation for the changes to take effect.</para>
        /// </description></item>
        /// <item><description><para>online: online expansion. The expansion takes effect without the need to restart the instance. Supported disk types include ultra disks, standard SSDs, enterprise SSDs, and elastic ephemeral disks.</para>
        /// </description></item>
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
