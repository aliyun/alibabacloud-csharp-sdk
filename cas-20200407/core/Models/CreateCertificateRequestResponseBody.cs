// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class CreateCertificateRequestResponseBody : TeaModel {
        /// <summary>
        /// The ID of the certificate application order.
        /// 
        /// >  You can use the ID to query the status of the certificate application. For more information, see [DescribeCertificateState](https://help.aliyun.com/document_detail/164111.html).
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
