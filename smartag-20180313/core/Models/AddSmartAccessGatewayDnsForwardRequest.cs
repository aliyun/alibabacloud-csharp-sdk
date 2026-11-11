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
        /// <list type="bullet">
        /// <item><description>Wildcard domain names and full match are supported. You can enter an asterisk (*) for the domain name to match all. Examples:
        /// *.baidu.com. The allowed input format is baidu.com.</description></item>
        /// </list>
        /// </remarks>
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
        /// <list type="bullet">
        /// <item><description>This field is invalid. You can ignore it.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>first</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The outbound port index.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is optional when OutboundPortType is set to PhysicalPort, and is not required when OutboundPortType is set to Tunnel.</description></item>
        /// <item><description>OutboundPortIndex and OutboundPortName have a one-to-one mapping: 0 - eth0; 2 - lte.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OutboundPortIndex")]
        [Validation(Required=false)]
        public string OutboundPortIndex { get; set; }

        /// <summary>
        /// <para>The outbound port.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is optional when OutboundPortType is set to PhysicalPort, and is not required when OutboundPortType is set to Tunnel.</description></item>
        /// <item><description>OutboundPortIndex and OutboundPortName have a one-to-one mapping: 0 - eth0; 2 - lte.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>eth0</para>
        /// </summary>
        [NameInMap("OutboundPortName")]
        [Validation(Required=false)]
        public string OutboundPortName { get; set; }

        /// <summary>
        /// <para>The outbound port type.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>A value of Tunnel indicates a tunnel port, and a value of PhysicalPort indicates a physical port.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Tunnel</para>
        /// </summary>
        [NameInMap("OutboundPortType")]
        [Validation(Required=false)]
        public string OutboundPortType { get; set; }

        /// <summary>
        /// <para>The region ID of the Smart Access Gateway instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the Smart Access Gateway instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-v9un1ccz22owd76lf8</para>
        /// </summary>
        [NameInMap("SagInsId")]
        [Validation(Required=false)]
        public string SagInsId { get; set; }

        /// <summary>
        /// <para>The serial number of the device.</para>
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
