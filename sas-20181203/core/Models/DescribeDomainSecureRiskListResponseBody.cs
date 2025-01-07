// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDomainSecureRiskListResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of the websites for which no certificates are installed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NoSslCount")]
        [Validation(Required=false)]
        public int? NoSslCount { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE500770-42D3-442E-9DDD-156E0F9F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of risks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskCount")]
        [Validation(Required=false)]
        public int? RiskCount { get; set; }

        /// <summary>
        /// <para>The risks.</para>
        /// </summary>
        [NameInMap("RiskList")]
        [Validation(Required=false)]
        public List<DescribeDomainSecureRiskListResponseBodyRiskList> RiskList { get; set; }
        public class DescribeDomainSecureRiskListResponseBodyRiskList : TeaModel {
            /// <summary>
            /// <para>The number of alerts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AlarmCount")]
            [Validation(Required=false)]
            public int? AlarmCount { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The issuer of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>globalsign</para>
            /// </summary>
            [NameInMap("SslBrand")]
            [Validation(Required=false)]
            public string SslBrand { get; set; }

            /// <summary>
            /// <para>Indicates whether the certificate is configured. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: yes</description></item>
            /// <item><description><b>0</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SslStatus")]
            [Validation(Required=false)]
            public int? SslStatus { get; set; }

            /// <summary>
            /// <para>The UUIDs of the backend servers of the website.</para>
            /// </summary>
            [NameInMap("UuidList")]
            [Validation(Required=false)]
            public List<string> UuidList { get; set; }

            /// <summary>
            /// <para>The number of vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VulCount")]
            [Validation(Required=false)]
            public int? VulCount { get; set; }

        }

    }

}
