// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetVpnGatewayDiagnoseResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the diagnostic started.</para>
        /// <para>The time follows the ISO8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-15T05:28:57Z</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public string BeginTime { get; set; }

        /// <summary>
        /// <para>The ID of the diagnostic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpndgn-uf6sgneym02lxyuv4****</para>
        /// </summary>
        [NameInMap("DiagnoseId")]
        [Validation(Required=false)]
        public string DiagnoseId { get; set; }

        /// <summary>
        /// <para>The information about the diagnostic items.</para>
        /// </summary>
        [NameInMap("DiagnoseResult")]
        [Validation(Required=false)]
        public List<GetVpnGatewayDiagnoseResultResponseBodyDiagnoseResult> DiagnoseResult { get; set; }
        public class GetVpnGatewayDiagnoseResultResponseBodyDiagnoseResult : TeaModel {
            /// <summary>
            /// <para>The diagnostic item.</para>
            /// <list type="bullet">
            /// <item><description><b>RouteEntryConflict</b>: route conflicts.</description></item>
            /// <item><description><b>VpnRouteQuota</b>: the quota of destination-based routes for the VPN gateway.</description></item>
            /// <item><description><b>VpnIPsecQuota</b>: the quota of IPsec-VPN connections for the VPN gateway.</description></item>
            /// <item><description><b>VpnPbrRouteQuota</b>: the quota of policy-based routes for the VPN gateway.</description></item>
            /// <item><description><b>VcoConfigConsistency</b>: the consistency of the IPsec-VPN connection.</description></item>
            /// <item><description><b>VcoUserInternetIpConnectivity</b>: Internet connectivity of the customer gateway.</description></item>
            /// <item><description><b>VcoPrivateConnectivity</b>: private network connectivity.</description></item>
            /// </list>
            /// <para>For more information about the diagnostic items, see <a href="https://help.aliyun.com/document_detail/190330.html">Background information about quick diagnostics</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RouteEntryConflict</para>
            /// </summary>
            [NameInMap("DiagnoseName")]
            [Validation(Required=false)]
            public string DiagnoseName { get; set; }

            /// <summary>
            /// <para>The diagnostic result.</para>
            /// <para>The system returns different results for each diagnostic item.</para>
            /// <list type="bullet">
            /// <item><description><para><b>RouteEntryConflict</b>: information about route conflicts.</para>
            /// </description></item>
            /// <item><description><para><b>VpnRouteQuota</b>:</para>
            /// <list type="bullet">
            /// <item><description><b>quotaName</b>: the quota ID of destination-based routes.</description></item>
            /// <item><description><b>quantity</b>: the quota of destination-based routes for the VPN gateway.</description></item>
            /// <item><description><b>used</b>: the number of destination-based routes created for the VPN gateway.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>VpnIPsecQuota</b>:</para>
            /// <list type="bullet">
            /// <item><description><b>quotaName</b>: the quota ID of IPsec-VPN connections.</description></item>
            /// <item><description><b>quantity</b>: the quota of IPsec-VPN connections for the VPN gateway.</description></item>
            /// <item><description><b>used</b>: the number of IPsec-VPN connections created for the VPN gateway.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>VpnPbrRouteQuota</b>:</para>
            /// <list type="bullet">
            /// <item><description><b>quotaName</b>: the quota ID of policy-based routes.</description></item>
            /// <item><description><b>quantity</b>: the quota of policy-based routes for the VPN gateway.</description></item>
            /// <item><description><b>used</b>: the number of policy-based routes created for the VPN gateway.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>VcoConfigConsistency</b>:</para>
            /// <list type="bullet">
            /// <item><description><b>vcoLackConf</b>: The system cannot obtain the configuration of the peer of the IPsec-VPN connection.</description></item>
            /// <item><description><b>vcoRunningConf</b>: the configurations that have been added to the peer of the IPsec-VPN connection.</description></item>
            /// <item><description><b>vcoDiffConf</b>: the configurations that are inconsistent between the local end and the peer.</description></item>
            /// <item><description><b>vcoConf</b>: the configurations that have been added to the local end.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>VcoUserInternetIpConnectivity</b>:</para>
            /// <list type="bullet">
            /// <item><description><b>targetIp</b>: the public IP address of the customer gateway.</description></item>
            /// <item><description><b>rtt</b>: the latency when the system accesses the public IP address of the customer gateway. Unit: milliseconds.</description></item>
            /// <item><description><b>lossRate</b>: the packet loss when the system accesses the public IP address of the customer gateway.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>VcoPrivateConnectivity</b>:</para>
            /// <list type="bullet">
            /// <item><description><b>targetIp</b>: the source IP address.</description></item>
            /// <item><description><b>srcIp</b>: the destination IP address.</description></item>
            /// <item><description><b>rtt</b>: the latency when the source IP address accesses the destination IP address. Unit: milliseconds.</description></item>
            /// <item><description><b>lossRate</b>: the packet loss when the source IP address accesses the destination IP address.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;targetIp\&quot;:\&quot;192.168.0.1\&quot;,\&quot;srcIp\&quot;:\&quot;192.168.1.1\&quot;,\&quot;rtt\&quot;:-1.0,\&quot;lossRate\&quot;:100.0}</para>
            /// </summary>
            [NameInMap("DiagnoseResultDescription")]
            [Validation(Required=false)]
            public string DiagnoseResultDescription { get; set; }

            /// <summary>
            /// <para>The diagnostic result level.</para>
            /// <list type="bullet">
            /// <item><description><b>normal</b></description></item>
            /// <item><description><b>warning</b></description></item>
            /// <item><description><b>error</b></description></item>
            /// </list>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/190330.html">Background information about quick diagnostics</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("DiagnoseResultLevel")]
            [Validation(Required=false)]
            public string DiagnoseResultLevel { get; set; }

        }

        /// <summary>
        /// <para>The timestamp when the system finishes diagnosing the item.</para>
        /// <para>The time follows the ISO8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-15T05:29:08Z</para>
        /// </summary>
        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        /// <summary>
        /// <para>The number of diagnostic items that have been diagnosed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("FinishedCount")]
        [Validation(Required=false)]
        public int? FinishedCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>312C4D5A-6563-5FC6-8C6E-A43A5A316FEB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource that is diagnosed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vco-uf6huqsu63azl7mdp****</para>
        /// </summary>
        [NameInMap("ResourceInstanceId")]
        [Validation(Required=false)]
        public string ResourceInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the resource.</para>
        /// <para>The value is set to <b>IPsec</b>, which indicates an IPsec-VPN connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPsec</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The total number of diagnostic items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The ID of the VPN gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-uf6fzwp0ck3frwtbk****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
