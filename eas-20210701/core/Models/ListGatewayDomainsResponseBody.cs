// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListGatewayDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of custom domain names.</para>
        /// </summary>
        [NameInMap("CustomDomains")]
        [Validation(Required=false)]
        public List<ListGatewayDomainsResponseBodyCustomDomains> CustomDomains { get; set; }
        public class ListGatewayDomainsResponseBodyCustomDomains : TeaModel {
            /// <summary>
            /// <para>The expiration date of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-25</para>
            /// </summary>
            [NameInMap("CertificateEndDate")]
            [Validation(Required=false)]
            public string CertificateEndDate { get; set; }

            /// <summary>
            /// <para>The ID of the SSL certificate attached to the domain name. To obtain the certificate ID, upload or purchase a certificate in the <a href="https://yundunnext.console.aliyun.com/?spm=5176.2020520163.console-base_help.2.4b3baJixaJixOc%5C&p=cas">Digital Certificate Management Service</a> console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1473**25</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

            /// <summary>
            /// <para>The name of the SSL certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cert-9955038</para>
            /// </summary>
            [NameInMap("CertificateName")]
            [Validation(Required=false)]
            public string CertificateName { get; set; }

            /// <summary>
            /// <para>The issuance date of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-07-13</para>
            /// </summary>
            [NameInMap("CertificateStartDate")]
            [Validation(Required=false)]
            public string CertificateStartDate { get; set; }

            /// <summary>
            /// <para>The status of the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Succeeded</para>
            /// </summary>
            [NameInMap("CertificateStatus")]
            [Validation(Required=false)]
            public string CertificateStatus { get; set; }

            /// <summary>
            /// <para>The time when the domain name was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-05-19T14:19:42Z</para>
            /// </summary>
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
            /// <para>The type of the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>intranet</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The time when the domain name was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-19T14:19:42Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The message returned for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successfully get custom domains</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
