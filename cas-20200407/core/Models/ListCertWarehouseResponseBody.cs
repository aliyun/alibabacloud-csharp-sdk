// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCertWarehouseResponseBody : TeaModel {
        /// <summary>
        /// The certificate application repositories.
        /// </summary>
        [NameInMap("CertWarehouseList")]
        [Validation(Required=false)]
        public List<ListCertWarehouseResponseBodyCertWarehouseList> CertWarehouseList { get; set; }
        public class ListCertWarehouseResponseBodyCertWarehouseList : TeaModel {
            /// <summary>
            /// The timestamp when the certificate application repository expires. Unit: milliseconds.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The instance ID of the certificate application repository.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// Indicates whether the certificate application repository has expired. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("IsExpired")]
            [Validation(Required=false)]
            public bool? IsExpired { get; set; }

            /// <summary>
            /// The name of the certificate application repository.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The instance ID of the private CA.
            /// </summary>
            [NameInMap("PcaInstanceId")]
            [Validation(Required=false)]
            public string PcaInstanceId { get; set; }

            /// <summary>
            /// The queries per second (QPS).
            /// </summary>
            [NameInMap("Qps")]
            [Validation(Required=false)]
            public long? Qps { get; set; }

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

            /// <summary>
            /// The ID of the certificate application repository.
            /// </summary>
            [NameInMap("WhId")]
            [Validation(Required=false)]
            public long? WhId { get; set; }

        }

        /// <summary>
        /// The page number of the returned page. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned per page. Default value: 50.
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public long? ShowSize { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
