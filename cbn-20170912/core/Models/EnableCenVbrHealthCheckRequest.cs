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
        /// <para>The description of the health check.</para>
        /// <para>The description must be 1 to 256 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdesc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time interval at which probe packets are sent during a health check. Unit: seconds. Default value: <b>2</b>. Valid values: <b>2 to 3</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable probing during the health check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: yes</para>
        /// <pre><c>If you enable probing, the system does not switch to another route if the detected route is not reachable. 
        /// 
        ///   Make sure that a redundant route is available. Otherwise, network disconnections may occur. 
        /// </c></pre>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): no</para>
        /// <pre><c>Probing is disabled by default. If a redundant route is specified, the system switches to the redundant route if the detected route is not reachable.
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
        /// <para>The source IP address for the health check. You can set the source IP address in the following ways:</para>
        /// <list type="bullet">
        /// <item><description><b>Automatic IP Address</b> (recommended): The system automatically assigns an IP address from the 100.96.0.0/16 CIDR block.</description></item>
        /// <item><description><b>Custom IP Address</b>: You must specify an idle IP address from the 10.0.0.0/8, 192.168.0.0/16, or 172.16.0.0/12 CIDR block. The specified IP address cannot be the IP address of the VBR on the Alibaba Cloud side, the IP address of the VBR on the customer side, or other IP addresses with which the VBR communicates through the CEN instance.</description></item>
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
        /// <para>Set the destination IP address to the IP address of the VBR on the customer side.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.XX.XX.1</para>
        /// </summary>
        [NameInMap("HealthCheckTargetIp")]
        [Validation(Required=false)]
        public string HealthCheckTargetIp { get; set; }

        /// <summary>
        /// <para>The number of probe packets that are sent during a health check. Unit: packets. Valid values: <b>3 to 8</b>. Default value: <b>8</b>.</para>
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
        /// <para>The ID of the VBR.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-wz95o9aylj181n5mzk****</para>
        /// </summary>
        [NameInMap("VbrInstanceId")]
        [Validation(Required=false)]
        public string VbrInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the VBR belongs.</para>
        /// <remarks>
        /// <para>This parameter is required if the VBR and the CEN instance belong to different Alibaba Cloud accounts.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1250123456123456</para>
        /// </summary>
        [NameInMap("VbrInstanceOwnerId")]
        [Validation(Required=false)]
        public long? VbrInstanceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the VBR is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> operation to query the most recent region list.</para>
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
