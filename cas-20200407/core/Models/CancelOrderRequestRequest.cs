// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class CancelOrderRequestRequest : TeaModel {
        /// <summary>
        /// The ID of the certificate application order that you want to cancel.
        /// 
        /// >  After you call the [CreateCertificateForPackageRequest](~~CreateCertificateForPackageRequest~~), [CreateCertificateRequest](~~CreateCertificateRequest~~), or [CreateCertificateWithCsrRequest](~~CreateCertificateWithCsrRequest~~) operation to submit a certificate application, you can obtain the ID of the certificate application order from the **OrderId** response parameter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

    }

}
