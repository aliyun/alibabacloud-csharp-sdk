// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ResizeDiskRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">Ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the cloud disk. You can call the <a href="https://help.aliyun.com/document_detail/25514.html">DescribeDisks</a> operation to query the ID of the cloud disk.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>The new capacity of the cloud disk. Unit: GiB. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>System cloud disk:</para>
        /// <list type="bullet">
        /// <item><description>Basic cloud disk: 20 to 500.</description></item>
        /// <item><description>ESSD:<list type="bullet">
        /// <item><description>PL0: 1 to 2048.</description></item>
        /// <item><description>PL1: 20 to 2048.</description></item>
        /// <item><description>PL2: 461 to 2048.</description></item>
        /// <item><description>PL3: 1261 to 2048.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>ESSD AutoPL disk: 1 to 2048.</description></item>
        /// <item><description>Other cloud disk types: 20 to 2048.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Data cloud disk:</para>
        /// <list type="bullet">
        /// <item><description><para>Ultra cloud disk (cloud_efficiency): 20 to 32768.</para>
        /// </description></item>
        /// <item><description><para>Standard SSD (cloud_ssd): 20 to 32768.</para>
        /// </description></item>
        /// <item><description><para>ESSD (cloud_essd): The valid values vary based on the <c>PerformanceLevel</c> parameter. You can call the <a href="https://help.aliyun.com/document_detail/25514.html">DescribeDisks</a> operation to query the cloud disk information and check the valid values based on the <c>PerformanceLevel</c> parameter in the response.</para>
        /// <list type="bullet">
        /// <item><description>PL0: 1 to 65536.</description></item>
        /// <item><description>PL1: 20 to 65536.</description></item>
        /// <item><description>PL2: 461 to 65536.</description></item>
        /// <item><description>PL3: 1261 to 65536.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Basic cloud disk (cloud): 5 to 2000.</para>
        /// </description></item>
        /// <item><description><para>ESSD AutoPL disk (cloud_auto): 1 to 65536.
        /// &lt;props=&quot;china&quot;&gt;</para>
        /// </description></item>
        /// <item><description><para>ESSD Entry disk (cloud_essd_entry): 10 to 32768.</para>
        /// </description></item>
        /// <item><description><para>Standard elastic ephemeral disk (elastic_ephemeral_disk_standard): 64 to 8192.</para>
        /// </description></item>
        /// <item><description><para>Premium elastic ephemeral disk (elastic_ephemeral_disk_premium): 64 to 8192.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The new capacity must be greater than the original capacity. Otherwise, an error is returned when you call this operation.</para>
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
        /// <para>The method used to resize the cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>offline: offline resizing. This is the default value. After the cloud disk is resized, you must <a href="https://help.aliyun.com/document_detail/25440.html">restart the instance</a> in the console or call the <a href="https://help.aliyun.com/document_detail/25502.html">RebootInstance</a> operation for the resize to take effect.</para>
        /// </description></item>
        /// <item><description><para>online: online resizing. The cloud disk is resized without the need to restart the instance. This value supports ultra cloud disks, standard SSDs, ESSDs, and elastic ephemeral disks.</para>
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
