// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListUserCertificateOrderRequest : TeaModel {
        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// The domain name that is bound or the ID of the resource. Fuzzy match is supported.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The type of the order. Default value: **CPACK**. Valid values:
        /// 
        /// *   **CPACK**: virtual resource order. If you set OrderType to CPACK, only the information about orders that are generated to consume the certificate quota is returned.
        /// *   **BUY**: purchase order. If you set OrderType to BUY, only the information about purchase orders is returned. In most cases, this type of order can be ignored.
        /// *   **UPLOAD**: uploaded certificate. If you set OrderType to UPLOAD, only uploaded certificates are returned.
        /// *   **CERT**: certificate. If you set OrderType to CERT, both issued certificates and uploaded certificates are returned.
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// The ID of the resource group. You can call the [ListResources](https://help.aliyun.com/document_detail/2716559.html) operation to obtain the ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 50.
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public long? ShowSize { get; set; }

        /// <summary>
        /// The certificate status of the order. Valid values:
        /// 
        /// *   **PAYED**: pending application. You can set Status to PAYED only if you set OrderType to CPACK or BUY.
        /// *   **CHECKING**: validating. You can set Status to CHECKING only if you set OrderType to CPACK or BUY.
        /// *   **CHECKED_FAIL**: validation failed. You can set Status to CHECKED_FAIL only if you set OrderType to CPACK or BUY.
        /// *   **ISSUED**: issued.
        /// *   **WILLEXPIRED**: about to expire.
        /// *   **EXPIRED**: expired.
        /// *   **NOTACTIVATED**: not activated. You can set Status to NOTACTIVATED only if you set OrderType to CPACK or BUY.
        /// *   **REVOKED**: revoked. You can set Status to REVOKED only if you set OrderType to CPACK or BUY.
        /// 
        /// If you set OrderType to CERT or UPLOAD and Status is left empty, valid certificates are returned by default, including issued certificates and certificates that are about to expire. If you set OrderType to CPACK or BUY and Status is left empty, all orders are returned by default.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
