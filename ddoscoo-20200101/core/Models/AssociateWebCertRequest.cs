// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class AssociateWebCertRequest : TeaModel {
        /// <summary>
        /// The public key of the certificate that you want to associate. This parameter must be used together with **CertName** and **Key**.
        /// 
        /// > If you specify **CertName**, **Cert**, and **Key**, you do not need to specify **CertId**.
        /// </summary>
        [NameInMap("Cert")]
        [Validation(Required=false)]
        public string Cert { get; set; }

        /// <summary>
        /// The ID of the certificate that you want to associate. If the certificate that you want to associate has been issued in Certificate Management Service, you can specify the certificate ID to associate the certificate.
        /// 
        /// > If you specify the certificate ID, you do not need to specify a value for the **CertName**, **Cert**, and **Key** parameters.
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public int? CertId { get; set; }

        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// The name of the certificate that you want to associate. This parameter must be used together with the **Cert** and **Key** parameters.
        /// 
        /// > If you specify a value for the **CertName**, **Cert**, and **Key** parameters, you do not need to specify a value for the **CertId** parameter.
        /// </summary>
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        [NameInMap("CertRegion")]
        [Validation(Required=false)]
        public string CertRegion { get; set; }

        /// <summary>
        /// The domain name of the website.
        /// 
        /// > A forwarding rule must be configured for the domain name. You can call the [DescribeDomains](~~91724~~) operation to query all domain names.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The private key of the certificate that you want to associate. This parameter must be used together with **CertName** and **Cert**.
        /// 
        /// > If you specify **CertName**, **Cert**, and **Key**, you do not need to specify **CertId**.
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
