// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DeletePCACertRequest : TeaModel {
        /// <summary>
        /// The unique identifier of the certificate. You can call the [ListCert](https://help.aliyun.com/document_detail/452331.html) operation to query the unique identifiers of certificates.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

    }

}
