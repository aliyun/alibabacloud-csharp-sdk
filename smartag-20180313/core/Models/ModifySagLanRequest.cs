// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ModifySagLanRequest : TeaModel {
        /// <summary>
        /// <para>The last IP address of the DHCP pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.254</para>
        /// </summary>
        [NameInMap("EndIp")]
        [Validation(Required=false)]
        public string EndIp { get; set; }

        /// <summary>
        /// <para>The IP address of the LAN port.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.1</para>
        /// </summary>
        [NameInMap("IP")]
        [Validation(Required=false)]
        public string IP { get; set; }

        /// <summary>
        /// <para>The connection type of the LAN port. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DHCP</b>: a dynamic IP address. Uses the Dynamic Host Configuration Protocol (DHCP) to dynamically assign an IP address to a connected device.</description></item>
        /// <item><description><b>STATIC</b>: a static IP address. Specifies a static IP address for the LAN port.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STATIC</para>
        /// </summary>
        [NameInMap("IPType")]
        [Validation(Required=false)]
        public string IPType { get; set; }

        /// <summary>
        /// <para>The time duration that the IP address is retained after it is assigned through DHCP. Unit: minute.</para>
        /// <para>Valid values: <b>1 to 43200</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("Lease")]
        [Validation(Required=false)]
        public string Lease { get; set; }

        /// <summary>
        /// <para>The subnet mask of the LAN port IP address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>255.255.255.0</para>
        /// </summary>
        [NameInMap("Mask")]
        [Validation(Required=false)]
        public string Mask { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The name of the LAN port.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PortName")]
        [Validation(Required=false)]
        public string PortName { get; set; }

        /// <summary>
        /// <para>The ID of the region where the SAG instance is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

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
        /// <para>The serial number of the SAG device that is associated with the SAG instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag32a30****</para>
        /// </summary>
        [NameInMap("SmartAGSn")]
        [Validation(Required=false)]
        public string SmartAGSn { get; set; }

        /// <summary>
        /// <para>The first IP address of the DHCP pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.2</para>
        /// </summary>
        [NameInMap("StartIp")]
        [Validation(Required=false)]
        public string StartIp { get; set; }

    }

}
