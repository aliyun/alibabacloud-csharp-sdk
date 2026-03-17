// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class AddSmartAccessGatewayDnsForwardRequest : TeaModel {
        /// <summary>
        /// <para>The domain name.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Wildcard domain names are supported. You can use the wildcard character asterisk (\*) to specify a wildcard domain name.</description></item>
        /// </list>
        /// <para>For example, you can enter \*.baidu.com to specify the domain name baidu.com.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The primary DNS server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>114.114.114.114</para>
        /// </summary>
        [NameInMap("MasterIp")]
        [Validation(Required=false)]
        public string MasterIp { get; set; }

        /// <summary>
        /// <para>The forwarding mode.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is not in use. Ignore this parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>first</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The number of the egress port.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is optional if OutboundPortType is set to PhysicalPort. Ignore this parameter if OutboundPortType is set to Tunnel.</description></item>
        /// <item><description>The value of OutboundPortIndex is the unique index of the port name specified by poOutboundPortName. For example, 0 is the index for the port named eth0, and 2 is the index for the port named lte.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OutboundPortIndex")]
        [Validation(Required=false)]
        public string OutboundPortIndex { get; set; }

        /// <summary>
        /// <para>The egress port.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is optional if OutboundPortType is set to PhysicalPort. Ignore this parameter if OutboundPortType is set to Tunnel.</description></item>
        /// <item><description>The value of OutboundPortIndex is the unique index of the port name specified by poOutboundPortName. For example, 0 is the index for the port named eth0, and 2 is the index for the port named lte.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>eth0</para>
        /// </summary>
        [NameInMap("OutboundPortName")]
        [Validation(Required=false)]
        public string OutboundPortName { get; set; }

        /// <summary>
        /// <para>The type of the egress port.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>A value of Tunnel specifies a tunnel, and a value of PhysicalPort specifies a physical port.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Tunnel</para>
        /// </summary>
        [NameInMap("OutboundPortType")]
        [Validation(Required=false)]
        public string OutboundPortType { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-v9un1ccz22owd76lf8</para>
        /// </summary>
        [NameInMap("SagInsId")]
        [Validation(Required=false)]
        public string SagInsId { get; set; }

        /// <summary>
        /// <para>The serial number (SN) of the device.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sagf4dkqh78</para>
        /// </summary>
        [NameInMap("SagSn")]
        [Validation(Required=false)]
        public string SagSn { get; set; }

        /// <summary>
        /// <para>The secondary DNS server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.0.14</para>
        /// </summary>
        [NameInMap("SlaveIp")]
        [Validation(Required=false)]
        public string SlaveIp { get; set; }

    }

}
