// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCertRequest : TeaModel {
        /// <summary>
        /// 证书的类型 。取值：
        /// 
        /// - **CA**：表示CA证书。
        /// - **CERT**：表示签发的证书。
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// The keyword for the query. You can enter a name, domain name, or Subject Alternative Name (SAN) extension. Fuzzy match is supported.
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 50.
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public long? ShowSize { get; set; }

        /// <summary>
        /// The source of the certificate. Valid values:
        /// 
        /// *   **upload**: uploaded certificate
        /// *   **aliyun**: Alibaba Cloud certificate
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// The status of the certificate. Valid values:
        /// 
        /// *   **ISSUE**: issued
        /// *   **REVOKE**: revoked
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The ID of the certificate repository. You can call the ListCertWarehouse API operation to query the IDs of certificate repositories.
        /// </summary>
        [NameInMap("WarehouseId")]
        [Validation(Required=false)]
        public long? WarehouseId { get; set; }

    }

}
