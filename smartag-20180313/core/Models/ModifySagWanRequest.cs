// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ModifySagWanRequest : TeaModel {
        /// <summary>
        /// <para>The maximum bandwidth of the WAN port. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The IP address of the gateway.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the WAN port uses a static IP address, you must set this parameter.</description></item>
        /// <item><description>After this parameter is set, the SAG device generates a default route.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.254</para>
        /// </summary>
        [NameInMap("Gateway")]
        [Validation(Required=false)]
        public string Gateway { get; set; }

        /// <summary>
        /// <para>The IP address of the WAN port.</para>
        /// <remarks>
        /// <para> If the WAN port uses a static IP address, you must set this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.1</para>
        /// </summary>
        [NameInMap("IP")]
        [Validation(Required=false)]
        public string IP { get; set; }

        /// <summary>
        /// <para>The connection type of the WAN port: Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DHCP</b>: The WAN port connects to the Internet through an IP address that is dynamically assigned by the Dynamic Host Configuration Protocol (DHCP) server.</description></item>
        /// <item><description><b>STATIC</b>: The WAN port connects to the Internet through a static IP address. If you set this value, you must configure a static IP address, a subnet mask, and a gateway IP address for the WAN port.</description></item>
        /// <item><description><b>PPPOE</b>: The WAN port connects to the Internet through dial-up connections. If you set this value, you must enter the username and password of the PPPoE account provided by the Internet service provider (ISP).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DHCP</para>
        /// </summary>
        [NameInMap("IPType")]
        [Validation(Required=false)]
        public string IPType { get; set; }

        /// <summary>
        /// <para>The ISP used by the WAN port. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CT</b>: China Telecom</description></item>
        /// <item><description><b>CM</b>: China Mobile</description></item>
        /// <item><description><b>CU</b>: China Unicom</description></item>
        /// <item><description><b>Other</b>: Other ISPs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CT</para>
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// <para>The subnet mask of the WAN port IP address.</para>
        /// <remarks>
        /// <para> If the WAN port uses a static IP address, you must set this parameter.</para>
        /// </remarks>
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
        /// <para>The password of the PPPoE account.</para>
        /// <para>The username must be 6 to 30 characters in length, and can contain digits and letters.</para>
        /// <remarks>
        /// <para> If the connection type of the WAN port is PPPoE, you must set this parameter. If you do not need to modify the password, you can ignore this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>P12ppq***</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The number of the WAN port.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PortName")]
        [Validation(Required=false)]
        public string PortName { get; set; }

        /// <summary>
        /// <para>The priority of the WAN port.</para>
        /// <para>Valid values: <b>-1</b> and <b>1 to 50</b>.</para>
        /// <para>A smaller value indicates a higher priority. A value of <b>-1</b> indicates that traffic forwarding is disabled on the WAN port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The ID of the region where the SAG instance is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/69813.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>The serial number of the SAG device.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag32a30****</para>
        /// </summary>
        [NameInMap("SmartAGSn")]
        [Validation(Required=false)]
        public string SmartAGSn { get; set; }

        /// <summary>
        /// <para>The username of the PPPoE account.</para>
        /// <para>The username must be 6 to 30 characters in length, and can contain digits and letters.</para>
        /// <remarks>
        /// <para> If the connection type of the WAN port is PPPoE, you must set this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>P12ppp***</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The weight of the WAN port.</para>
        /// <para>Valid values: <b>1 to 100</b>. Default value: <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
