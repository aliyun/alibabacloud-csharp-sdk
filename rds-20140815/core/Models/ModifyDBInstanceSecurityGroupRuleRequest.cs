// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceSecurityGroupRuleRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call <a href="https://help.aliyun.com/document_detail/2628785.html">DescribeDBInstances</a> to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp15i4hn07r******</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The description of the security group rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zht_test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The transport layer protocol type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TCP</description></item>
        /// <item><description>UDP</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The range of destination ports for the transport layer protocol (TCP/UDP) that the security group opens.</para>
        /// <para>Valid values: 1 to 65535. Separate the start port and end port with a forward slash (/). Example: 1/200.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1/200</para>
        /// </summary>
        [NameInMap("PortRange")]
        [Validation(Required=false)]
        public string PortRange { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The security group rule ID. You can call <a href="https://help.aliyun.com/document_detail/2834044.html">DescribeDBInstanceSecurityGroupRule</a> to obtain the security group rule ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgr-2ze17u******</para>
        /// </summary>
        [NameInMap("SecurityGroupRuleId")]
        [Validation(Required=false)]
        public string SecurityGroupRuleId { get; set; }

        /// <summary>
        /// <para>The source IP address range. CIDR format and IPv4 format are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.100</para>
        /// </summary>
        [NameInMap("SourceCidrIp")]
        [Validation(Required=false)]
        public string SourceCidrIp { get; set; }

    }

}
