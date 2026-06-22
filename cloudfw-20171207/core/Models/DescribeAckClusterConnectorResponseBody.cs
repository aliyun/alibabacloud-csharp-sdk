// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAckClusterConnectorResponseBody : TeaModel {
        /// <summary>
        /// <para>The ACK cluster connector.</para>
        /// </summary>
        [NameInMap("AckClusterConnector")]
        [Validation(Required=false)]
        public DescribeAckClusterConnectorResponseBodyAckClusterConnector AckClusterConnector { get; set; }
        public class DescribeAckClusterConnectorResponseBodyAckClusterConnector : TeaModel {
            /// <summary>
            /// <para>The ID of the ACK cluster. You can obtain the value from:</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeAckClusters~~">DescribeAckClusters</a>: Lists ACK clusters.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>c857d908016794125883a9ee8196cba17</para>
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
            /// <para>The ID of the ACK cluster connector. You can obtain the value from:</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeAckClusterConnectors~~">DescribeAckClusterConnectors</a>: Lists ACK cluster connectors.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ac-7c1bad6c3cc84c33baab</para>
            /// </summary>
            [NameInMap("ConnectorId")]
            [Validation(Required=false)]
            public string ConnectorId { get; set; }

            /// <summary>
            /// <para>The name of the ACK cluster connector. The name is 1 to 64 characters in length and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), and hyphens (-).</para>
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
            /// <para>The timestamp when the ACK cluster connector was created. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1724982259</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud UID of the account to which the ACK cluster resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>135809047715****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <para>The primary vSwitch of the ACK cluster connector. You can obtain the value from:</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeAccessInstanceVSwitchList~~">DescribeAccessInstanceVSwitchList</a>: Lists vSwitches of synchronization nodes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2zerfbbje7dvnbii2****</para>
            /// </summary>
            [NameInMap("PrimaryVswitchId")]
            [Validation(Required=false)]
            public string PrimaryVswitchId { get; set; }

            /// <summary>
            /// <para>The IP address of the primary vSwitch of the ACK cluster connector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.100.1.1</para>
            /// </summary>
            [NameInMap("PrimaryVswitchIp")]
            [Validation(Required=false)]
            public string PrimaryVswitchIp { get; set; }

            /// <summary>
            /// <para>The zone of the primary vSwitch of the ACK cluster connector. You can obtain the value from:</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeAccessInstanceZoneList~~">DescribeAccessInstanceZoneList</a>: Lists zones of synchronization node vSwitches.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-g</para>
            /// </summary>
            [NameInMap("PrimaryVswitchZoneId")]
            [Validation(Required=false)]
            public string PrimaryVswitchZoneId { get; set; }

            /// <summary>
            /// <para>The region ID of the ACK cluster connector. You can obtain the value from:</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeAccessInstanceRegionList~~">DescribeAccessInstanceRegionList</a>: Queries the list of synchronization node regions.</description></item>
            /// </list>
            /// <remarks>
            /// <para>For more information about the regions supported by ACK cluster connectors in Cloud Firewall, see <a href="https://help.aliyun.com/document_detail/2865120.html">ACK cluster synchronization nodes</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>The standby vSwitch of the ACK cluster connector. You can obtain the value from:</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeAccessInstanceVSwitchList~~">DescribeAccessInstanceVSwitchList</a>: Lists vSwitches of synchronization nodes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2ze2gtlfozrab01cfo****</para>
            /// </summary>
            [NameInMap("StandbyVswitchId")]
            [Validation(Required=false)]
            public string StandbyVswitchId { get; set; }

            /// <summary>
            /// <para>The IP address of the standby vSwitch of the ACK cluster connector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.100.2.1</para>
            /// </summary>
            [NameInMap("StandbyVswitchIp")]
            [Validation(Required=false)]
            public string StandbyVswitchIp { get; set; }

            /// <summary>
            /// <para>The zone of the standby vSwitch of the ACK cluster connector. You can obtain the value from:</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeAccessInstanceZoneList~~">DescribeAccessInstanceZoneList</a>: Lists zones of synchronization node vSwitches.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-h</para>
            /// </summary>
            [NameInMap("StandbyVswitchZoneId")]
            [Validation(Required=false)]
            public string StandbyVswitchZoneId { get; set; }

            /// <summary>
            /// <para>The synchronization interval of the ACK cluster connector. Valid values: 2 to 60. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

            /// <summary>
            /// <para>The reason why the ACK cluster connector is unhealthy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The ACK cluster status is unavailable.</para>
            /// </summary>
            [NameInMap("UnhealthyReason")]
            [Validation(Required=false)]
            public string UnhealthyReason { get; set; }

            /// <summary>
            /// <para>The instance ID of the VPC-connected instance to which the ACK cluster belongs.</para>
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
        /// <para>45E2E720-D2B4-506F-B682-1FCBE971****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
