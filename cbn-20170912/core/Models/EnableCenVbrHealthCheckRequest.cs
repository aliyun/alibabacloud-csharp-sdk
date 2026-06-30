// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class EnableCenVbrHealthCheckRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Cloud Enterprise Network (CEN) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-hahhfskfkseig****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// <para>The description must be 1 to 256 characters in length and cannot start with <c>http:// </c>or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdesc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time interval at which probe packets are sent during a health check. Unit: seconds. Default value: 2. Valid values: <b>2</b> to <b>3</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable only the detection feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Yes.</para>
        /// <pre><c>  If you enable only the detection feature, the system performs a health check but does not switch routes when the Express Connect circuit is down.
        /// 
        ///   &gt; Make sure that you have another way to ensure link redundancy. Otherwise, network interruptions may occur.
        /// </c></pre>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): No.</para>
        /// <pre><c>  This feature is disabled by default. If the health check detects a link failure and a redundant route is available in the CEN instance, the system immediately switches to the available route.
        /// </c></pre>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HealthCheckOnly")]
        [Validation(Required=false)]
        public bool? HealthCheckOnly { get; set; }

        /// <summary>
        /// <para>The source IP address for the health check. You can configure the source IP address in one of the following ways:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Automatic IP address</b> (recommended): The system automatically assigns an IP address from the 100.96.0.0/16 CIDR block.</para>
        /// </description></item>
        /// <item><description><para><b>Custom IP address</b>: You can specify an unused IP address from the 10.0.0.0/8, 192.168.0.0/16, or 172.16.0.0/12 CIDR block. The specified IP address cannot conflict with an IP address that is used for communication in the CEN instance. The specified IP address also cannot conflict with the Alibaba Cloud-side or client-side IP address of the VBR instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.1</para>
        /// </summary>
        [NameInMap("HealthCheckSourceIp")]
        [Validation(Required=false)]
        public string HealthCheckSourceIp { get; set; }

        /// <summary>
        /// <para>The destination IP address for the health check.</para>
        /// <para>The destination IP address is the client-side IP address of the VBR instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.XX.XX.1</para>
        /// </summary>
        [NameInMap("HealthCheckTargetIp")]
        [Validation(Required=false)]
        public string HealthCheckTargetIp { get; set; }

        /// <summary>
        /// <para>The number of probe packets that are sent during a health check. Unit: packets. Valid values: 3 to <b>8</b>. Default value: <b>8</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

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
        /// <para>The ID of the VBR instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-wz95o9aylj181n5mzk****</para>
        /// </summary>
        [NameInMap("VbrInstanceId")]
        [Validation(Required=false)]
        public string VbrInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the VBR instance belongs.</para>
        /// <remarks>
        /// <para>This parameter is required if the VBR instance and the CEN instance belong to different Alibaba Cloud accounts.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1250123456123456</para>
        /// </summary>
        [NameInMap("VbrInstanceOwnerId")]
        [Validation(Required=false)]
        public long? VbrInstanceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the VBR instance is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("VbrInstanceRegionId")]
        [Validation(Required=false)]
        public string VbrInstanceRegionId { get; set; }

    }

}
