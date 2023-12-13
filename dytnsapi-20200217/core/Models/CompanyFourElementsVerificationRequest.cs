/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class CompanyFourElementsVerificationRequest : TeaModel {
        /// <summary>
        /// The authorization code.
        /// 
        /// >  On the [My Applications](https://dytns.console.aliyun.com/analysis/apply) page in the [Cell Phone Number Service console](https://dytns.console.aliyun.com/overview?spm=a2c4g.608385.0.0.79847f8b3awqUC), you can obtain the authorization code (also known as authorization ID).
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// The enterprise name.
        /// </summary>
        [NameInMap("EpCertName")]
        [Validation(Required=false)]
        public string EpCertName { get; set; }

        /// <summary>
        /// The business license number.
        /// </summary>
        [NameInMap("EpCertNo")]
        [Validation(Required=false)]
        public string EpCertNo { get; set; }

        /// <summary>
        /// The name of the legal representative.
        /// 
        /// >  If an enterprise has multiple legal representatives, separate them with commas (,).
        /// </summary>
        [NameInMap("LegalPersonCertName")]
        [Validation(Required=false)]
        public string LegalPersonCertName { get; set; }

        /// <summary>
        /// The ID card number of the legal representative.
        /// 
        /// >  If an enterprise has multiple legal representatives, separate the ID card numbers with commas (,).
        /// </summary>
        [NameInMap("LegalPersonCertNo")]
        [Validation(Required=false)]
        public string LegalPersonCertNo { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
