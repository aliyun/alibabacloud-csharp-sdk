// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DiagnoseVpnConnectionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B8094E1E-935B-1397-96A8-4F87A5D1BF29</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The diagnostic information list of IPsec-VPN connections.</para>
        /// </summary>
        [NameInMap("VpnConnections")]
        [Validation(Required=false)]
        public List<DiagnoseVpnConnectionsResponseBodyVpnConnections> VpnConnections { get; set; }
        public class DiagnoseVpnConnectionsResponseBodyVpnConnections : TeaModel {
            /// <summary>
            /// <para>The error reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Phase1 negotiation timeout</para>
            /// </summary>
            [NameInMap("FailedReason")]
            [Validation(Required=false)]
            public string FailedReason { get; set; }

            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Phase1NegotiationTimeout</para>
            /// </summary>
            [NameInMap("FailedReasonCode")]
            [Validation(Required=false)]
            public string FailedReasonCode { get; set; }

            /// <summary>
            /// <para>The timestamp when the current error occurred on the IPsec-VPN connection. Unit: milliseconds.</para>
            /// <para>The timestamp is in UNIX format and represents the total number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC to the time when the current error occurred on the IPsec-VPN connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1673581161000</para>
            /// </summary>
            [NameInMap("FailedTime")]
            [Validation(Required=false)]
            public long? FailedTime { get; set; }

            /// <summary>
            /// <para>The parameter value configured on the IPsec-VPN connection when the parameter values configured on the IPsec-VPN connection and the peer gateway device do not match.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SHA256</para>
            /// </summary>
            [NameInMap("MismatchLocalParam")]
            [Validation(Required=false)]
            public string MismatchLocalParam { get; set; }

            /// <summary>
            /// <para>The parameter value configured on the peer gateway device when the parameter values configured on the IPsec-VPN connection and the peer gateway device do not match.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SHA</para>
            /// </summary>
            [NameInMap("MismatchRemoteParam")]
            [Validation(Required=false)]
            public string MismatchRemoteParam { get; set; }

            /// <summary>
            /// <para>The severity level of the current error.</para>
            /// <list type="bullet">
            /// <item><description><b>Critical</b>: Critical. Troubleshoot the issue immediately.</description></item>
            /// <item><description><b>Warn</b>: Warning. Troubleshoot the issue as soon as possible.</description></item>
            /// <item><description><b>Normal</b>: Normal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Warn</para>
            /// </summary>
            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// <para>The log information related to the current error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-13 11:39:21 vco-bp1spxu8hlcvpd7ry**** [PROTO_ERR]: ikev1.c:1433:isakmp_ph1resend(): phase1 negotiation failed due to time up. [{remote id:4}{ph1: 172.16.0.88[500] &lt;=&gt; 192.168.0.206[500], 172.16.0.88 &lt;=&gt; 192.168.0.206}]</para>
            /// </summary>
            [NameInMap("SourceLog")]
            [Validation(Required=false)]
            public string SourceLog { get; set; }

            /// <summary>
            /// <para>The tunnel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tun-64n1sr9dig64k6****</para>
            /// </summary>
            [NameInMap("TunnelId")]
            [Validation(Required=false)]
            public string TunnelId { get; set; }

            /// <summary>
            /// <para>The ID of the IPsec-VPN connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vco-bp1spxu8hlcvpd7ry****</para>
            /// </summary>
            [NameInMap("VpnConnectionId")]
            [Validation(Required=false)]
            public string VpnConnectionId { get; set; }

        }

    }

}
