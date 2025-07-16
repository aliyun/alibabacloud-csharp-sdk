// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListGatewayDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The custom domain names.</para>
        /// </summary>
        [NameInMap("CustomDomains")]
        [Validation(Required=false)]
        public List<ListGatewayDomainsResponseBodyCustomDomains> CustomDomains { get; set; }
        public class ListGatewayDomainsResponseBodyCustomDomains : TeaModel {
            [NameInMap("CertificateEndDate")]
            [Validation(Required=false)]
            public string CertificateEndDate { get; set; }

            /// <summary>
            /// <para>The ID of the SSL certificate bound to the domain name. Obtain the certificate ID after you upload or purchase a certificate in the <a href="https://yundunnext.console.aliyun.com/?spm=5176.2020520163.console-base_help.2.4b3baJixaJixOc%5C&p=cas">Certificate Management Service</a> console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1473**25</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

            [NameInMap("CertificateName")]
            [Validation(Required=false)]
            public string CertificateName { get; set; }

            [NameInMap("CertificateStartDate")]
            [Validation(Required=false)]
            public string CertificateStartDate { get; set; }

            [NameInMap("CertificateStatus")]
            [Validation(Required=false)]
            public string CertificateStatus { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The custom domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The domain name type.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>intranet: internal network.</description></item>
            /// <item><description>internet: public network.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>intranet</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successfully get custom domains</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
