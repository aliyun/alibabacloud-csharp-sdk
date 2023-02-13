// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class UpdateCACertificateStatusRequest : TeaModel {
        /// <summary>
        /// The unique identifier of the CA certificate whose status you want to change.
        /// 
        /// >  You can call the [DescribeCACertificateList](~~328095~~) operation to query the unique identifiers of all CA certificates.
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// The state to which you want to change the CA certificate. Set to the value to **REVOKE**. After this operation is called, the status of the CA certificate is changed to **REVOKE**.
        /// 
        /// >  You can call this operation only if the status of a CA certificate is **ISSUE**. You can call the [DescribeCACertificate](~~328096~~) operation to query the status of a CA certificate.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
