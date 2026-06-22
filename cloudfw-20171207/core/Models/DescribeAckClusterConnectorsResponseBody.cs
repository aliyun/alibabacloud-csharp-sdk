// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAckClusterConnectorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of ACK cluster connectors.</para>
        /// </summary>
        [NameInMap("AckClusterConnectors")]
        [Validation(Required=false)]
        public List<DescribeAckClusterConnectorsResponseBodyAckClusterConnectors> AckClusterConnectors { get; set; }
        public class DescribeAckClusterConnectorsResponseBodyAckClusterConnectors : TeaModel {
            /// <summary>
            /// <para>The ACK cluster ID. You can call the following operation to obtain the value:</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeAckClusters~~">DescribeAckClusters</a>: Queries a list of ACK clusters in batches.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>f9b9815a5280****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the ACK cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestClusterA</para>
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
            /// <para>The ID of the ACK cluster connector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ac-7c1bad6c3cc84c33baab</para>
            /// </summary>
            [NameInMap("ConnectorId")]
            [Validation(Required=false)]
            public string ConnectorId { get; set; }

            /// <summary>
            /// <para>The name of the ACK cluster connector. The name must be 1 to 64 characters in length and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), and hyphens (-).</para>
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
            /// <para>1760493347</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The list of address book UUIDs created on the ACK cluster connector.</para>
            /// </summary>
            [NameInMap("GroupUuids")]
            [Validation(Required=false)]
            public List<string> GroupUuids { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud UID of the account to which the ACK cluster resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>159663371500****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <para>The primary vSwitch of the ACK cluster connector. You can call the following operation to obtain the value:</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeAccessInstanceVSwitchList~~">DescribeAccessInstanceVSwitchList</a>: Queries the list of synchronization node vSwitches in batches.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2ze2gtlfozrab01cfo****</para>
            /// </summary>
            [NameInMap("PrimaryVswitchId")]
            [Validation(Required=false)]
            public string PrimaryVswitchId { get; set; }

            /// <summary>
            /// <para>The IP address of the primary vSwitch of the ACK cluster connector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.100.2.XXX</para>
            /// </summary>
            [NameInMap("PrimaryVswitchIp")]
            [Validation(Required=false)]
            public string PrimaryVswitchIp { get; set; }

            /// <summary>
            /// <para>The zone of the primary vSwitch of the ACK cluster connector. You can call the following operation to obtain the value:</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeAccessInstanceZoneList~~">DescribeAccessInstanceZoneList</a>: Queries the list of synchronization node vSwitch zones in batches.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-g</para>
            /// </summary>
            [NameInMap("PrimaryVswitchZoneId")]
            [Validation(Required=false)]
            public string PrimaryVswitchZoneId { get; set; }

            /// <summary>
            /// <para>The region ID of the ACK cluster connector. You can call the following operation to obtain the value:</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeAccessInstanceRegionList~~">DescribeAccessInstanceRegionList</a>: Queries the list of synchronization node regions.</description></item>
            /// </list>
            /// <remarks>
            /// <para>For more information about the regions supported by ACK cluster connectors in Cloud Firewall, see <a href="https://help.aliyun.com/document_detail/2865120.html">ACK cluster synchronization nodes</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>The standby vSwitch of the ACK cluster connector. You can call the following operation to obtain the value:</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeAccessInstanceVSwitchList~~">DescribeAccessInstanceVSwitchList</a>: Queries the list of synchronization node vSwitches in batches.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2zerfbbje7dvnbii2****</para>
            /// </summary>
            [NameInMap("StandbyVswitchId")]
            [Validation(Required=false)]
            public string StandbyVswitchId { get; set; }

            /// <summary>
            /// <para>The IP address of the standby vSwitch of the ACK cluster connector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.100.1.XXX</para>
            /// </summary>
            [NameInMap("StandbyVswitchIp")]
            [Validation(Required=false)]
            public string StandbyVswitchIp { get; set; }

            /// <summary>
            /// <para>The zone of the standby vSwitch of the ACK cluster connector. You can call the following operation to obtain the value:</para>
            /// <list type="bullet">
            /// <item><description><a href="~~DescribeAccessInstanceZoneList~~">DescribeAccessInstanceZoneList</a>: Queries the list of synchronization node vSwitch zones in batches.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-h</para>
            /// </summary>
            [NameInMap("StandbyVswitchZoneId")]
            [Validation(Required=false)]
            public string StandbyVswitchZoneId { get; set; }

            /// <summary>
            /// <para>The container synchronization cycle of the ACK cluster connector.</para>
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
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7F333E0-7B70-54DA-A307-4B2B49DE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
