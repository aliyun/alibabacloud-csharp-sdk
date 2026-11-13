// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateAckClusterConnectorRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ACK cluster. You can obtain the value from the following API operation:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~DescribeAckClusters~~">DescribeAckClusters</a>: Queries the list of ACK clusters.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cb0f5640b1b2d404cad6ba21509d7847b</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the ACK cluster connector. The name must be 1 to 64 characters in length, and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack-cluster-connector-name</para>
        /// </summary>
        [NameInMap("ConnectorName")]
        [Validation(Required=false)]
        public string ConnectorName { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud UID of the account to which the ACK cluster resources belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>135809047715****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>The ID of the primary vSwitch for the ACK cluster connector. You can obtain the value from the following API operation:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~DescribeAccessInstanceVSwitchList~~">DescribeAccessInstanceVSwitchList</a>: Queries the list of vSwitches for synchronization nodes.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
        /// <para>The region ID of the ACK cluster connector. You can obtain the value from the following API operation:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~DescribeAccessInstanceRegionList~~">DescribeAccessInstanceRegionList</a>: Queries the regions of synchronization nodes.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about the regions where Cloud Firewall supports ACK cluster connectors, see <a href="https://help.aliyun.com/document_detail/2865120.html">ACK cluster synchronization nodes</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <para>The ID of the secondary vSwitch for the ACK cluster connector. You can obtain the value from the following API operation:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~DescribeAccessInstanceVSwitchList~~">DescribeAccessInstanceVSwitchList</a>: Queries the list of vSwitches for synchronization nodes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2ze2gtlfozrab01cfo****</para>
        /// </summary>
        [NameInMap("StandbyVswitchId")]
        [Validation(Required=false)]
        public string StandbyVswitchId { get; set; }

        /// <summary>
        /// <para>The IP address of the secondary vSwitch for the ACK cluster connector.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.100.2.1</para>
        /// </summary>
        [NameInMap("StandbyVswitchIp")]
        [Validation(Required=false)]
        public string StandbyVswitchIp { get; set; }

        /// <summary>
        /// <para>The synchronization interval of the ACK cluster connector. Valid values: 2 to 60. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public string Ttl { get; set; }

    }

}
