// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetCertWarehouseQuotaResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total quota for certificate repositories, including the free quota and purchased quota.
        /// </summary>
        [NameInMap("TotalQuota")]
        [Validation(Required=false)]
        public long? TotalQuota { get; set; }

        /// <summary>
        /// The used quota.
        /// </summary>
        [NameInMap("UseCount")]
        [Validation(Required=false)]
        public long? UseCount { get; set; }

    }

}
