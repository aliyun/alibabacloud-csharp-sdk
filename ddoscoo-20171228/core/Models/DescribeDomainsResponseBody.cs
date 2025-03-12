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
            [NameInMap("BlackList")]
            [Validation(Required=false)]
            public List<string> BlackList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CcEnabled")]
            [Validation(Required=false)]
            public bool? CcEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CcRuleEnabled")]
            [Validation(Required=false)]
            public bool? CcRuleEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("CcTemplate")]
            [Validation(Required=false)]
            public string CcTemplate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testCertName</para>
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            [NameInMap("CertRegion")]
            [Validation(Required=false)]
            public string CertRegion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxxx.aliyunddos1006.com</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Http2Enable")]
            [Validation(Required=false)]
            public bool? Http2Enable { get; set; }

            [NameInMap("ProxyTypeList")]
            [Validation(Required=false)]
            public List<DescribeDomainsResponseBodyDomainsProxyTypeList> ProxyTypeList { get; set; }
            public class DescribeDomainsResponseBodyDomainsProxyTypeList : TeaModel {
                [NameInMap("ProxyPorts")]
                [Validation(Required=false)]
                public List<string> ProxyPorts { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>http</para>
                /// </summary>
                [NameInMap("ProxyType")]
                [Validation(Required=false)]
                public string ProxyType { get; set; }

            }

            [NameInMap("RealServers")]
            [Validation(Required=false)]
            public List<DescribeDomainsResponseBodyDomainsRealServers> RealServers { get; set; }
            public class DescribeDomainsResponseBodyDomainsRealServers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1.1.1.1</para>
                /// </summary>
                [NameInMap("RealServer")]
                [Validation(Required=false)]
                public string RealServer { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RsType")]
                [Validation(Required=false)]
                public int? RsType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("SslCiphers")]
            [Validation(Required=false)]
            public string SslCiphers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("SslProtocols")]
            [Validation(Required=false)]
            public string SslProtocols { get; set; }

            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public List<string> WhiteList { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
