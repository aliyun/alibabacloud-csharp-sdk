// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDomainsResponseBody : TeaModel {
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<DescribeDomainsResponseBodyDomains> Domains { get; set; }
        public class DescribeDomainsResponseBodyDomains : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("ProxyTypeList")]
            [Validation(Required=false)]
            public List<DescribeDomainsResponseBodyDomainsProxyTypeList> ProxyTypeList { get; set; }
            public class DescribeDomainsResponseBodyDomainsProxyTypeList : TeaModel {
                [NameInMap("ProxyPorts")]
                [Validation(Required=false)]
                public List<string> ProxyPorts { get; set; }

                [NameInMap("ProxyType")]
                [Validation(Required=false)]
                public string ProxyType { get; set; }

            }

            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public List<string> WhiteList { get; set; }

            [NameInMap("BlackList")]
            [Validation(Required=false)]
            public List<string> BlackList { get; set; }

            [NameInMap("RealServers")]
            [Validation(Required=false)]
            public List<DescribeDomainsResponseBodyDomainsRealServers> RealServers { get; set; }
            public class DescribeDomainsResponseBodyDomainsRealServers : TeaModel {
                [NameInMap("RsType")]
                [Validation(Required=false)]
                public int? RsType { get; set; }

                [NameInMap("RealServer")]
                [Validation(Required=false)]
                public string RealServer { get; set; }

            }

            [NameInMap("SslProtocols")]
            [Validation(Required=false)]
            public string SslProtocols { get; set; }

            [NameInMap("CcTemplate")]
            [Validation(Required=false)]
            public string CcTemplate { get; set; }

            [NameInMap("CcEnabled")]
            [Validation(Required=false)]
            public bool? CcEnabled { get; set; }

            [NameInMap("SslCiphers")]
            [Validation(Required=false)]
            public string SslCiphers { get; set; }

            [NameInMap("CcRuleEnabled")]
            [Validation(Required=false)]
            public bool? CcRuleEnabled { get; set; }

            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            [NameInMap("Http2Enable")]
            [Validation(Required=false)]
            public bool? Http2Enable { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
