// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebRulesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("WebRules")]
        [Validation(Required=false)]
        public List<DescribeWebRulesResponseBodyWebRules> WebRules { get; set; }
        public class DescribeWebRulesResponseBodyWebRules : TeaModel {
            [NameInMap("BlackList")]
            [Validation(Required=false)]
            public List<string> BlackList { get; set; }

            [NameInMap("CcEnabled")]
            [Validation(Required=false)]
            public bool? CcEnabled { get; set; }

            [NameInMap("CcRuleEnabled")]
            [Validation(Required=false)]
            public bool? CcRuleEnabled { get; set; }

            [NameInMap("CcTemplate")]
            [Validation(Required=false)]
            public string CcTemplate { get; set; }

            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            [NameInMap("CertRegion")]
            [Validation(Required=false)]
            public string CertRegion { get; set; }

            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            [NameInMap("CustomCiphers")]
            [Validation(Required=false)]
            public List<string> CustomCiphers { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("GmCert")]
            [Validation(Required=false)]
            public DescribeWebRulesResponseBodyWebRulesGmCert GmCert { get; set; }
            public class DescribeWebRulesResponseBodyWebRulesGmCert : TeaModel {
                [NameInMap("CertId")]
                [Validation(Required=false)]
                public string CertId { get; set; }

                [NameInMap("GmEnable")]
                [Validation(Required=false)]
                public long? GmEnable { get; set; }

                [NameInMap("GmOnly")]
                [Validation(Required=false)]
                public long? GmOnly { get; set; }

            }

            [NameInMap("Http2Enable")]
            [Validation(Required=false)]
            public bool? Http2Enable { get; set; }

            [NameInMap("Http2HttpsEnable")]
            [Validation(Required=false)]
            public bool? Http2HttpsEnable { get; set; }

            [NameInMap("Https2HttpEnable")]
            [Validation(Required=false)]
            public bool? Https2HttpEnable { get; set; }

            [NameInMap("OcspEnabled")]
            [Validation(Required=false)]
            public bool? OcspEnabled { get; set; }

            [NameInMap("PolicyMode")]
            [Validation(Required=false)]
            public string PolicyMode { get; set; }

            [NameInMap("ProxyEnabled")]
            [Validation(Required=false)]
            public bool? ProxyEnabled { get; set; }

            [NameInMap("ProxyTypes")]
            [Validation(Required=false)]
            public List<DescribeWebRulesResponseBodyWebRulesProxyTypes> ProxyTypes { get; set; }
            public class DescribeWebRulesResponseBodyWebRulesProxyTypes : TeaModel {
                [NameInMap("ProxyPorts")]
                [Validation(Required=false)]
                public List<string> ProxyPorts { get; set; }

                [NameInMap("ProxyType")]
                [Validation(Required=false)]
                public string ProxyType { get; set; }

            }

            [NameInMap("PunishReason")]
            [Validation(Required=false)]
            public int? PunishReason { get; set; }

            [NameInMap("PunishStatus")]
            [Validation(Required=false)]
            public bool? PunishStatus { get; set; }

            [NameInMap("RealServers")]
            [Validation(Required=false)]
            public List<DescribeWebRulesResponseBodyWebRulesRealServers> RealServers { get; set; }
            public class DescribeWebRulesResponseBodyWebRulesRealServers : TeaModel {
                [NameInMap("RealServer")]
                [Validation(Required=false)]
                public string RealServer { get; set; }

                [NameInMap("RsType")]
                [Validation(Required=false)]
                public int? RsType { get; set; }

            }

            [NameInMap("Ssl13Enabled")]
            [Validation(Required=false)]
            public bool? Ssl13Enabled { get; set; }

            [NameInMap("SslCiphers")]
            [Validation(Required=false)]
            public string SslCiphers { get; set; }

            [NameInMap("SslProtocols")]
            [Validation(Required=false)]
            public string SslProtocols { get; set; }

            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public List<string> WhiteList { get; set; }

        }

    }

}
