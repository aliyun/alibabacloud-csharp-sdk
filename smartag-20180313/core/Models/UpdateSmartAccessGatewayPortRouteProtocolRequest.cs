// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class UpdateSmartAccessGatewayPortRouteProtocolRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query only the SAG instances that belong to another Alibaba Cloud account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default)</description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CrossAccount")]
        [Validation(Required=false)]
        public bool? CrossAccount { get; set; }

        /// <summary>
        /// <para>The port name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PortName")]
        [Validation(Required=false)]
        public string PortName { get; set; }

        /// <summary>
        /// <para>The region ID of the SAG instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/69813.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The autonomous system number (ASN) of the SAG device.</para>
        /// <remarks>
        /// <para>When you enable BGP, you must set this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>65535</para>
        /// </summary>
        [NameInMap("RemoteAs")]
        [Validation(Required=false)]
        public string RemoteAs { get; set; }

        /// <summary>
        /// <para>The IP address of the peer device.</para>
        /// <remarks>
        /// <para>When you enable BGP, you must set this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.1</para>
        /// </summary>
        [NameInMap("RemoteIp")]
        [Validation(Required=false)]
        public string RemoteIp { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the SAG instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>109790620697****</para>
        /// </summary>
        [NameInMap("ResourceUid")]
        [Validation(Required=false)]
        public string ResourceUid { get; set; }

        /// <summary>
        /// <para>The routing protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>STATIC</b></description></item>
        /// <item><description><b>OSPF</b></description></item>
        /// <item><description><b>BGP</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STATIC</para>
        /// </summary>
        [NameInMap("RouteProtocol")]
        [Validation(Required=false)]
        public string RouteProtocol { get; set; }

        /// <summary>
        /// <para>The ID of the Smart Access Gateway (SAG) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-3manef62evrfr6****</para>
        /// </summary>
        [NameInMap("SagInsId")]
        [Validation(Required=false)]
        public string SagInsId { get; set; }

        /// <summary>
        /// <para>The serial number of the SAG device.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sagf4dk****</para>
        /// </summary>
        [NameInMap("SagSn")]
        [Validation(Required=false)]
        public string SagSn { get; set; }

        /// <summary>
        /// <para>The VLAN ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Vlan")]
        [Validation(Required=false)]
        public string Vlan { get; set; }

    }

}
