// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class AttachGatewayDomainRequest : TeaModel {
        /// <summary>
        /// <para>The custom domain name information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CustomDomain")]
        [Validation(Required=false)]
        public AttachGatewayDomainRequestCustomDomain CustomDomain { get; set; }
        public class AttachGatewayDomainRequestCustomDomain : TeaModel {
            /// <summary>
            /// <para>The ID of the SSL certificate bound to the domain name. Obtain the certificate ID after you upload or purchase a certificate in the <a href="https://yundunnext.console.aliyun.com/?spm=5176.2020520163.console-base_help.2.4b3baJixaJixOc%5C&p=cas">Certificate Management Service</a> console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1473**25</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

            /// <summary>
            /// <para>The custom domain name.</para>
            /// <para>This parameter is required.</para>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>intranet</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
