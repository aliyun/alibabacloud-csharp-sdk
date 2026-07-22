// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallAccessDetailRequest : TeaModel {
        /// <summary>
        /// <para>The IP address of the local asset. You must specify at least one of AssetIP and Port. If both are left empty, the API returns a 400 error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("AssetIP")]
        [Validation(Required=false)]
        public string AssetIP { get; set; }

        /// <summary>
        /// <para>The page number in a paging query. Settings this parameter to specify the current page for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The traffic direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>in</b>: inbound.</description></item>
        /// <item><description><b>out</b>: outbound.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified in Settings, traffic in all directions is queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>in</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1729042555</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The protocol type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>tcp</b>: TCP protocol.</description></item>
        /// <item><description><b>udp</b>: UDP protocol.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("IPProtocol")]
        [Validation(Required=false)]
        public string IPProtocol { get; set; }

        /// <summary>
        /// <para>The language type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asc</b>: ascending order.</description></item>
        /// <item><description><b>desc</b> (default): descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The source IP address of the peer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.125.1.XX</para>
        /// </summary>
        [NameInMap("PeerAssetIP")]
        [Validation(Required=false)]
        public string PeerAssetIP { get; set; }

        /// <summary>
        /// <para>The instance ID of the peer asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-123451</para>
        /// </summary>
        [NameInMap("PeerAssetInstanceId")]
        [Validation(Required=false)]
        public string PeerAssetInstanceId { get; set; }

        /// <summary>
        /// <para>The instance name of the peer asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs22</para>
        /// </summary>
        [NameInMap("PeerAssetInstanceName")]
        [Validation(Required=false)]
        public string PeerAssetInstanceName { get; set; }

        /// <summary>
        /// <para>The instance ID of the peer VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-90rq0anm6t8vbwbo****</para>
        /// </summary>
        [NameInMap("PeerVpcId")]
        [Validation(Required=false)]
        public string PeerVpcId { get; set; }

        /// <summary>
        /// <para>The port number. You must specify at least one of AssetIP and Port. If both are left empty, the API returns a 400 error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The risk assessment level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// <para>The sort field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>InBytes</b></para>
        /// </description></item>
        /// <item><description><para><b>OutBytes</b></para>
        /// </description></item>
        /// <item><description><para><b>TotalBytes</b></para>
        /// </description></item>
        /// <item><description><para><b>InPackets</b></para>
        /// </description></item>
        /// <item><description><para><b>OutPackets</b></para>
        /// </description></item>
        /// <item><description><para><b>SessionCount</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InBytes</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1655778046</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The VPC-connected instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2ze4xj5kmb5udb****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
