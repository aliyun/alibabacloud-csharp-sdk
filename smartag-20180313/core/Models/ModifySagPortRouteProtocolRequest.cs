// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ModifySagPortRouteProtocolRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The name of the port.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PortName")]
        [Validation(Required=false)]
        public string PortName { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Smart Access Gateway (SAG) instance is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The BGP autonomous system number (ASN) of the peer device.</para>
        /// <remarks>
        /// <para> You must set this parameter when you enable BGP.</para>
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
        /// <para> You must set this parameter when you enable BGP.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.1</para>
        /// </summary>
        [NameInMap("RemoteIp")]
        [Validation(Required=false)]
        public string RemoteIp { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The routing protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>STATIC</b>: uses a static routing protocol.</description></item>
        /// <item><description><b>OSPF</b>: uses the Open Shortest Path First protocol (OSPF).</description></item>
        /// <item><description><b>BGP</b>: uses the Border Gateway Protocol (BGP).</description></item>
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
        /// <para>The ID of the SAG instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-whfn****</para>
        /// </summary>
        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

        /// <summary>
        /// <para>The serial number of the SAG device associated with the SAG instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag32a30****</para>
        /// </summary>
        [NameInMap("SmartAGSn")]
        [Validation(Required=false)]
        public string SmartAGSn { get; set; }

        /// <summary>
        /// <para>The VLAN ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Vlan")]
        [Validation(Required=false)]
        public string Vlan { get; set; }

    }

}
