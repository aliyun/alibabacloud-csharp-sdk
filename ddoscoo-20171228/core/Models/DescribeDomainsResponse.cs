// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDomainsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public long? Total { get; set; }

        [NameInMap("Domains")]
        [Validation(Required=true)]
        public List<DescribeDomainsResponseDomains> Domains { get; set; }
        public class DescribeDomainsResponseDomains : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=true)]
            public string Domain { get; set; }

            [NameInMap("CcEnabled")]
            [Validation(Required=true)]
            public bool? CcEnabled { get; set; }

            [NameInMap("CcRuleEnabled")]
            [Validation(Required=true)]
            public bool? CcRuleEnabled { get; set; }

            [NameInMap("CcTemplate")]
            [Validation(Required=true)]
            public string CcTemplate { get; set; }

            [NameInMap("SslProtocols")]
            [Validation(Required=true)]
            public string SslProtocols { get; set; }

            [NameInMap("SslCiphers")]
            [Validation(Required=true)]
            public string SslCiphers { get; set; }

            [NameInMap("Http2Enable")]
            [Validation(Required=true)]
            public bool? Http2Enable { get; set; }

            [NameInMap("Cname")]
            [Validation(Required=true)]
            public string Cname { get; set; }

            [NameInMap("CertName")]
            [Validation(Required=true)]
            public string CertName { get; set; }

            [NameInMap("ProxyTypeList")]
            [Validation(Required=true)]
            public List<DescribeDomainsResponseDomainsProxyTypeList> ProxyTypeList { get; set; }
            public class DescribeDomainsResponseDomainsProxyTypeList : TeaModel {
                [NameInMap("ProxyType")]
                [Validation(Required=true)]
                public string ProxyType { get; set; }

                [NameInMap("ProxyPorts")]
                [Validation(Required=true)]
                public List<string> ProxyPorts { get; set; }

            }

            [NameInMap("RealServers")]
            [Validation(Required=true)]
            public List<DescribeDomainsResponseDomainsRealServers> RealServers { get; set; }
            public class DescribeDomainsResponseDomainsRealServers : TeaModel {
                [NameInMap("RsType")]
                [Validation(Required=true)]
                public int? RsType { get; set; }

                [NameInMap("RealServer")]
                [Validation(Required=true)]
                public string RealServer { get; set; }

            }

            [NameInMap("WhiteList")]
            [Validation(Required=true)]
            public List<string> WhiteList { get; set; }

            [NameInMap("BlackList")]
            [Validation(Required=true)]
            public List<string> BlackList { get; set; }

        }

    }

}
