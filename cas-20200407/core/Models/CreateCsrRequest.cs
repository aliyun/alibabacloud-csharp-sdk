// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class CreateCsrRequest : TeaModel {
        /// <summary>
        /// The algorithm. Valid values: RSA, SM2, and ECC. For more information about algorithms, see [Select an SSL certificate](https://help.aliyun.com/document_detail/197871.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// The primary domain name, which is a common name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// The name of the company.
        /// </summary>
        [NameInMap("CorpName")]
        [Validation(Required=false)]
        public string CorpName { get; set; }

        /// <summary>
        /// The code of the country or region in which the organization is located. For example, you can use CN to indicate China and use US to indicate the United States.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CountryCode")]
        [Validation(Required=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The department that uses the certificate.
        /// </summary>
        [NameInMap("Department")]
        [Validation(Required=false)]
        public string Department { get; set; }

        /// <summary>
        /// The key length that is used by the algorithm.
        /// 
        /// *   The key length for RSA algorithms can be 2,048, 3,072, and 4,096 bits.
        /// *   The key length for ECC and SM2 algorithms can be 256 bits.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("KeySize")]
        [Validation(Required=false)]
        public int? KeySize { get; set; }

        /// <summary>
        /// The city where the company is located.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Locality")]
        [Validation(Required=false)]
        public string Locality { get; set; }

        /// <summary>
        /// The name of the CSR. The name can be up to 50 characters in length and can contain letters, digits, underscores (_), hyphens (-), and periods (.).
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The province or location where the company is located.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// The secondary domain names. Separate multiple domain names with commas (,). You can use the CSR to apply for a certificate for both the primary and secondary domain names.
        /// </summary>
        [NameInMap("Sans")]
        [Validation(Required=false)]
        public string Sans { get; set; }

    }

}
