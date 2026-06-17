// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class UpdateAckClusterConnectorResponseBody : TeaModel {
        /// <summary>
        /// <para>The ACK cluster connector.</para>
        /// </summary>
        [NameInMap("AckClusterConnector")]
        [Validation(Required=false)]
        public UpdateAckClusterConnectorResponseBodyAckClusterConnector AckClusterConnector { get; set; }
        public class UpdateAckClusterConnectorResponseBodyAckClusterConnector : TeaModel {
            /// <summary>
            /// <para>The ID of the ACK cluster. You can call the <a href="~~DescribeAckClusters~~">DescribeAckClusters</a> operation to query the list of ACK clusters.</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeAckClusters~~">DescribeAckClusters</a>: Queries a list of ACK clusters.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>c57ecf39ff32c415e8549a7df27a7e947</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the ACK cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack-cluster-name</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The health check status of the ACK cluster connector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>healthy</para>
            /// </summary>
            [NameInMap("ConnectorHealthCheckStatus")]
            [Validation(Required=false)]
            public string ConnectorHealthCheckStatus { get; set; }

            /// <summary>
            /// <para>The ID of the ACK cluster connector. You can call the <a href="~~DescribeAckClusterConnectors~~">DescribeAckClusterConnectors</a> operation to query the list of ACK cluster connectors.</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeAckClusterConnectors~~">DescribeAckClusterConnectors</a>: Queries a list of ACK cluster connectors.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ac-7c1bad6c3cc84c33baab</para>
            /// </summary>
            [NameInMap("ConnectorId")]
            [Validation(Required=false)]
            public string ConnectorId { get; set; }

            /// <summary>
            /// <para>The name of the ACK cluster connector. The name must be 1 to 64 characters in length and can contain Chinese characters, letters, digits, periods (.), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack-cluster-connector-name</para>
            /// </summary>
            [NameInMap("ConnectorName")]
            [Validation(Required=false)]
            public string ConnectorName { get; set; }

            /// <summary>
            /// <para>The instance status of the ACK cluster connector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ready</para>
            /// </summary>
            [NameInMap("ConnectorStatus")]
            [Validation(Required=false)]
            public string ConnectorStatus { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp when the ACK cluster connector was created. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1724982259</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID (UID) of the account to which the ACK cluster resources belong.</para>
            /// 
            /// <b>Example:</b>
            /// <para>135809047715****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <para>The primary vSwitch of the ACK cluster connector. You can call the <a href="~~DescribeAccessInstanceVSwitchList~~">DescribeAccessInstanceVSwitchList</a> operation to query the list of vSwitches for synchronization nodes.</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeAccessInstanceVSwitchList~~">DescribeAccessInstanceVSwitchList</a>: Queries a list of vSwitches for synchronization nodes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2zerfbbje7dvnbii2****</para>
            /// </summary>
            [NameInMap("PrimaryVswitchId")]
            [Validation(Required=false)]
            public string PrimaryVswitchId { get; set; }

            /// <summary>
            /// <para>The IP address of the primary vSwitch for the ACK cluster connector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.100.1.1</para>
            /// </summary>
            [NameInMap("PrimaryVswitchIp")]
            [Validation(Required=false)]
            public string PrimaryVswitchIp { get; set; }

            /// <summary>
            /// <para>The zone of the primary vSwitch for the ACK cluster connector. You can call the <a href="~~DescribeAccessInstanceZoneList~~">DescribeAccessInstanceZoneList</a> operation to query the list of zones for synchronization nodes.</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeAccessInstanceZoneList~~">DescribeAccessInstanceZoneList</a>: Queries in batches the list of zones for the vSwitches of sync nodes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-g</para>
            /// </summary>
            [NameInMap("PrimaryVswitchZoneId")]
            [Validation(Required=false)]
            public string PrimaryVswitchZoneId { get; set; }

            /// <summary>
            /// <para>The region ID of the ACK cluster connector. You can call the <a href="~~DescribeAccessInstanceRegionList~~">DescribeAccessInstanceRegionList</a> operation to query the list of regions for synchronization nodes.</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeAccessInstanceRegionList~~">DescribeAccessInstanceRegionList</a>: Queries the list of sync node regions.</description></item>
            /// </list>
            /// <remarks>
            /// <para>For more information about the regions that Cloud Firewall supports for ACK cluster connectors, see <a href="https://help.aliyun.com/document_detail/2865120.html">ACK cluster synchronization nodes</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>The standby vSwitch of the ACK cluster connector. You can call the <a href="~~DescribeAccessInstanceVSwitchList~~">DescribeAccessInstanceVSwitchList</a> operation to query the list of vSwitches for synchronization nodes.</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeAccessInstanceVSwitchList~~">DescribeAccessInstanceVSwitchList</a>: Batch queries the list of vSwitches for synchronization nodes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2ze2gtlfozrab01cfo****</para>
            /// </summary>
            [NameInMap("StandbyVswitchId")]
            [Validation(Required=false)]
            public string StandbyVswitchId { get; set; }

            /// <summary>
            /// <para>The IP address of the standby vSwitch for the ACK cluster connector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.100.2.1</para>
            /// </summary>
            [NameInMap("StandbyVswitchIp")]
            [Validation(Required=false)]
            public string StandbyVswitchIp { get; set; }

            /// <summary>
            /// <para>The zone of the standby vSwitch for the ACK cluster connector. You can call the <a href="~~DescribeAccessInstanceZoneList~~">DescribeAccessInstanceZoneList</a> operation to query the list of zones for synchronization nodes.</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeAccessInstanceZoneList~~">DescribeAccessInstanceZoneList</a>: Batch queries the list of zones for the vSwitches of synchronization nodes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-h</para>
            /// </summary>
            [NameInMap("StandbyVswitchZoneId")]
            [Validation(Required=false)]
            public string StandbyVswitchZoneId { get; set; }

            /// <summary>
            /// <para>The synchronization interval for the ACK cluster connector. Valid values: 2 to 60. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

            /// <summary>
            /// <para>The ID of the VPC to which the ACK cluster belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-j6cvhdscntzuvr0x****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5D16AADE-DA2E-5CAB-AA3B-AA197D97****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
