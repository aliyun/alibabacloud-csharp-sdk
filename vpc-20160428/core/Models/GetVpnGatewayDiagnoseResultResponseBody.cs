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
        /// <para>The time is displayed in UTC in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-15T05:28:57Z</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public string BeginTime { get; set; }

        /// <summary>
        /// <para>The diagnostic ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpndgn-uf6sgneym02lxyuv4****</para>
        /// </summary>
        [NameInMap("DiagnoseId")]
        [Validation(Required=false)]
        public string DiagnoseId { get; set; }

        /// <summary>
        /// <para>The list of diagnostic items.</para>
        /// </summary>
        [NameInMap("DiagnoseResult")]
        [Validation(Required=false)]
        public List<GetVpnGatewayDiagnoseResultResponseBodyDiagnoseResult> DiagnoseResult { get; set; }
        public class GetVpnGatewayDiagnoseResultResponseBodyDiagnoseResult : TeaModel {
            /// <summary>
            /// <para>The diagnostic item.</para>
            /// <list type="bullet">
            /// <item><description><b>RouteEntryConflict</b>: route conflict.</description></item>
            /// <item><description><b>VpnRouteQuota</b>: VPN gateway destination route quota.</description></item>
            /// <item><description><b>VpnIPsecQuota</b>: VPN gateway IPsec-VPN connection quota.</description></item>
            /// <item><description><b>VpnPbrRouteQuota</b>: VPN gateway policy-based route quota.</description></item>
            /// <item><description><b>VcoConfigConsistency</b>: IPsec configuration consistency.</description></item>
            /// <item><description><b>VcoUserInternetIpConnectivity</b>: public connectivity of the customer gateway.</description></item>
            /// <item><description><b>VcoPrivateConnectivity</b>: private network connectivity.</description></item>
            /// </list>
            /// <para>For more information about each diagnostic item, see <a href="https://help.aliyun.com/document_detail/190330.html">One-click diagnostics background information</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RouteEntryConflict</para>
            /// </summary>
            [NameInMap("DiagnoseName")]
            [Validation(Required=false)]
            public string DiagnoseName { get; set; }

            /// <summary>
            /// <para>The diagnostic result of the diagnostic item.</para>
            /// <para>The operation returns different information for each diagnostic item:</para>
            /// <list type="bullet">
            /// <item><description><b>RouteEntryConflict</b>: The system returns information about the route conflict.</description></item>
            /// <item><description><b>VpnRouteQuota</b>:<list type="bullet">
            /// <item><description><b>quotaName</b>: the ID of the destination route quota.</description></item>
            /// <item><description><b>quantity</b>: the number of destination routes that the current VPN gateway instance supports.</description></item>
            /// <item><description><b>used</b>: the number of destination routes that have been created for the current VPN gateway instance.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>VpnIPsecQuota</b>:<list type="bullet">
            /// <item><description><b>quotaName</b>: the ID of the IPsec-VPN connection quota.</description></item>
            /// <item><description><b>quantity</b>: the number of IPsec-VPN connections that the current VPN gateway instance supports.</description></item>
            /// <item><description><b>used</b>: the number of IPsec-VPN connections that have been created for the current VPN gateway instance.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>VpnPbrRouteQuota</b>:<list type="bullet">
            /// <item><description><b>quotaName</b>: the ID of the policy-based route quota.</description></item>
            /// <item><description><b>quantity</b>: the number of policy-based routes that the current VPN gateway instance supports.</description></item>
            /// <item><description><b>used</b>: the number of policy-based routes that have been created for the current VPN gateway instance.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>VcoConfigConsistency</b>:<list type="bullet">
            /// <item><description><b>vcoLackConf</b>: the system cannot obtain the configuration of the peer end of the IPsec-VPN connection.</description></item>
            /// <item><description><b>vcoRunningConf</b>: the configuration that has been added to the peer end of the IPsec-VPN connection.</description></item>
            /// <item><description><b>vcoDiffConf</b>: the list of configurations that are inconsistent between the local end and the peer end of the IPsec-VPN connection.</description></item>
            /// <item><description><b>vcoConf</b>: the configuration that has been added to the local end of the IPsec-VPN connection.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>VcoUserInternetIpConnectivity</b>:<list type="bullet">
            /// <item><description><b>targetIp</b>: the public IP address of the customer gateway.</description></item>
            /// <item><description><b>rtt</b>: the latency when the system accesses the public IP address of the customer gateway. Unit: ms.</description></item>
            /// <item><description><b>lossRate</b>: the packet loss rate when the system accesses the public IP address of the customer gateway.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>VcoPrivateConnectivity</b>:<list type="bullet">
            /// <item><description><b>targetIp</b>: the source IP address.</description></item>
            /// <item><description><b>srcIp</b>: the destination IP address.</description></item>
            /// <item><description><b>rtt</b>: the latency when the source IP address accesses the destination IP address. Unit: ms.</description></item>
            /// <item><description><b>lossRate</b>: the packet loss rate when the source IP address accesses the destination IP address.</description></item>
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
            /// <para>The diagnostic result level of the diagnostic item.</para>
            /// <list type="bullet">
            /// <item><description><b>normal</b>: Normal.</description></item>
            /// <item><description><b>warning</b>: Warning.</description></item>
            /// <item><description><b>error</b>: Error.</description></item>
            /// </list>
            /// <para>For more information about the diagnostic result levels of each diagnostic item, see <a href="https://help.aliyun.com/document_detail/190330.html">One-click diagnostics background information</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("DiagnoseResultLevel")]
            [Validation(Required=false)]
            public string DiagnoseResultLevel { get; set; }

        }

        /// <summary>
        /// <para>The time when the diagnostic ended.</para>
        /// <para>The time is displayed in UTC in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-15T05:29:08Z</para>
        /// </summary>
        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        /// <summary>
        /// <para>The number of diagnostic items that have been completed.</para>
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
        /// <para>The ID of the diagnosed resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vco-uf6huqsu63azl7mdp****</para>
        /// </summary>
        [NameInMap("ResourceInstanceId")]
        [Validation(Required=false)]
        public string ResourceInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the diagnosed resource.</para>
        /// <para>Valid values: <b>IPsec</b>, which indicates an IPsec-VPN connection.</para>
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
        /// <para>The VPN gateway instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-uf6fzwp0ck3frwtbk****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
