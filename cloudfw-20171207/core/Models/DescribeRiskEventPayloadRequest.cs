// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeRiskEventPayloadRequest : TeaModel {
        /// <summary>
        /// <para>The destination IP address to query. If you specify this parameter, all intrusion events with the specified destination IP address are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>203.0.113.2</para>
        /// </summary>
        [NameInMap("DstIP")]
        [Validation(Required=false)]
        public string DstIP { get; set; }

        /// <summary>
        /// <para>The ID of the destination VPC to query. If you specify this parameter, all intrusion events that contain the specified ID of the destination VPC are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6jr1klwqb60dyn2****</para>
        /// </summary>
        [NameInMap("DstVpcId")]
        [Validation(Required=false)]
        public string DstVpcId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value is a timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1681288980</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The type of the firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VpcFirewall</b>: virtual private cloud (VPC) firewall</description></item>
        /// <item><description><b>InternetFirewall</b> (default): Internet firewall</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InternetFirewall</para>
        /// </summary>
        [NameInMap("FirewallType")]
        [Validation(Required=false)]
        public string FirewallType { get; set; }

        /// <summary>
        /// <para>The public IP address. If you specify this parameter, all intrusion events that contain the specified public IP address are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>203.0.113.3</para>
        /// </summary>
        [NameInMap("PublicIP")]
        [Validation(Required=false)]
        public string PublicIP { get; set; }

        /// <summary>
        /// <para>The source IP address to query. If you specify this parameter, all intrusion events from the specified source IP address are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>203.0.113.1</para>
        /// </summary>
        [NameInMap("SrcIP")]
        [Validation(Required=false)]
        public string SrcIP { get; set; }

        /// <summary>
        /// <para>The ID of the source VPC to query. If you specify this parameter, all intrusion events that contain the specified ID of the source VPC are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-wz9j2lqyo15udw5nt****</para>
        /// </summary>
        [NameInMap("SrcVpcId")]
        [Validation(Required=false)]
        public string SrcVpcId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1669533617</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The UUID of the intrusion event.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e62c25e0-1073-46bd-9567-b8f12b3d****</para>
        /// </summary>
        [NameInMap("UUID")]
        [Validation(Required=false)]
        public string UUID { get; set; }

    }

}
