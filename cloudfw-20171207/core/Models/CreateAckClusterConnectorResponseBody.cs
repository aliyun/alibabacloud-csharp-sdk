// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateAckClusterConnectorResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the ACK cluster connector.</para>
        /// </summary>
        [NameInMap("AckClusterConnector")]
        [Validation(Required=false)]
        public CreateAckClusterConnectorResponseBodyAckClusterConnector AckClusterConnector { get; set; }
        public class CreateAckClusterConnectorResponseBodyAckClusterConnector : TeaModel {
            /// <summary>
            /// <para>The IP address used by the ACK cluster connector to access the ACK cluster over the internal network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.40.32.240</para>
            /// </summary>
            [NameInMap("AckClientHostIp")]
            [Validation(Required=false)]
            public string AckClientHostIp { get; set; }

            /// <summary>
            /// <para>The ID of the ACK cluster.</para>
            /// <list type="bullet">
            /// <item><description>Call the <a href="~~DescribeAckClusters~~">DescribeAckClusters</a> operation to query the list of ACK clusters.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cb0f5640b1b2d404cad6ba21509d7847b</para>
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
            /// <para>The unique ID of the ACK cluster connector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ac-7c1bad6c3cc84c33baab</para>
            /// </summary>
            [NameInMap("ConnectorId")]
            [Validation(Required=false)]
            public string ConnectorId { get; set; }

            /// <summary>
            /// <para>The name of the ACK cluster connector. The name is 1 to 64 characters in length and can contain Chinese characters, letters, digits, periods (.), underscores (_), and hyphens (-).</para>
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
            /// <para>The timestamp when the ACK cluster connector was created. This value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1724982259</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud UID of the account to which the ACK cluster belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>135809047715****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <para>The ID of the primary vSwitch for the ACK cluster connector.</para>
            /// <list type="bullet">
            /// <item><description>Call the <a href="~~DescribeAccessInstanceVSwitchList~~">DescribeAccessInstanceVSwitchList</a> operation to query the list of vSwitches for synchronization nodes.</description></item>
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
            /// <para>The zone ID of the primary vSwitch for the ACK cluster connector.</para>
            /// <list type="bullet">
            /// <item><description>Call the <a href="~~DescribeAccessInstanceZoneList~~">DescribeAccessInstanceZoneList</a> operation to query the list of zones for synchronization nodes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-g</para>
            /// </summary>
            [NameInMap("PrimaryVswitchZoneId")]
            [Validation(Required=false)]
            public string PrimaryVswitchZoneId { get; set; }

            /// <summary>
            /// <para>The region ID of the ACK cluster connector.</para>
            /// <list type="bullet">
            /// <item><description>Call the <a href="~~DescribeAccessInstanceRegionList~~">DescribeAccessInstanceRegionList</a> operation to query the list of regions for synchronization nodes.</description></item>
            /// </list>
            /// <remarks>
            /// <para>For more information about the regions that Cloud Firewall supports for ACK cluster connectors, see <a href="https://help.aliyun.com/document_detail/2865120.html">ACK cluster synchronization nodes</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>The ID of the standby vSwitch for the ACK cluster connector.</para>
            /// <list type="bullet">
            /// <item><description>Call the <a href="~~DescribeAccessInstanceVSwitchList~~">DescribeAccessInstanceVSwitchList</a> operation to query the list of vSwitches for synchronization nodes.</description></item>
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
            /// <para>The zone ID of the standby vSwitch for the ACK cluster connector.</para>
            /// <list type="bullet">
            /// <item><description>Call the <a href="~~DescribeAccessInstanceZoneList~~">DescribeAccessInstanceZoneList</a> operation to query the list of zones for synchronization nodes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("StandbyVswitchZoneId")]
            [Validation(Required=false)]
            public string StandbyVswitchZoneId { get; set; }

            /// <summary>
            /// <para>The unique ID of the task to create the ACK cluster connector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-c92d4544ef7b6a42</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

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
        /// <para>0DC783F1-B3A7-578D-8A63-*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
