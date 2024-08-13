// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCertWarehouseRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// The instance ID of the certificate application repository.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the certificate application repository. Fuzzy match is supported.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 50.
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public long? ShowSize { get; set; }

        /// <summary>
        /// The type of the certificate application repository. Valid values:
        /// 
        /// *   **ssl**: certificate application repository of SSL certificates
        /// *   **uploadPCA**: certificate application repository of uploaded private certificates
        /// *   **free**: certificate application repository of free certificates, available only on the China site (aliyun.com)
        /// *   **aliyunPCA**: certificate application repository of private certificates purchased from Alibaba Cloud Private Certificate Authority (PCA), available only on the China site (aliyun.com)
        /// *   **disable**: disabled certificate application repository
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
