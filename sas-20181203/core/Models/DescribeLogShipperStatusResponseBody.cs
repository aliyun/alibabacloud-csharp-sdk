// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLogShipperStatusResponseBody : TeaModel {
        /// <summary>
        /// The status information.
        /// </summary>
        [NameInMap("LogShipperStatus")]
        [Validation(Required=false)]
        public DescribeLogShipperStatusResponseBodyLogShipperStatus LogShipperStatus { get; set; }
        public class DescribeLogShipperStatusResponseBodyLogShipperStatus : TeaModel {
            /// <summary>
            /// Indicates whether Security Center is authorized to access Log Service. Valid values:
            /// 
            /// *   **yes**
            /// *   **no**
            /// </summary>
            [NameInMap("AuthStatus")]
            [Validation(Required=false)]
            public string AuthStatus { get; set; }

            /// <summary>
            /// Indicates whether the log analysis feature is purchased. Valid values:
            /// 
            /// *   **yes**
            /// *   **no**
            /// </summary>
            [NameInMap("BuyStatus")]
            [Validation(Required=false)]
            public string BuyStatus { get; set; }

            /// <summary>
            /// The version of the log analysis field. Valid values:
            /// - SAS_V1
            /// - SAS_V2
            /// </summary>
            [NameInMap("EtlMetaVersion")]
            [Validation(Required=false)]
            public string EtlMetaVersion { get; set; }

            /// <summary>
            /// The status of the log analysis feature. Valid values:
            /// 
            /// *   **yes**: enabled
            /// *   **no**: disabled
            /// </summary>
            [NameInMap("OpenStatus")]
            [Validation(Required=false)]
            public string OpenStatus { get; set; }

            /// <summary>
            /// Indicates whether the pay-as-you-go billing method is used. Valid values:
            /// 
            /// *   **yes**
            /// *   **no**
            /// </summary>
            [NameInMap("PostPaidOpenStatus")]
            [Validation(Required=false)]
            public string PostPaidOpenStatus { get; set; }

            /// <summary>
            /// Indicates whether the log analysis feature supports the pay-as-you-go billing method. Valid values:
            /// 
            /// *   **yes**
            /// *   **no**
            /// </summary>
            [NameInMap("PostPaidSupportStatus")]
            [Validation(Required=false)]
            public string PostPaidSupportStatus { get; set; }

            /// <summary>
            /// The status of the dedicated Log Service project. Valid values:
            /// 
            /// *   **Normal**: normal
            /// *   **Disable**: disabled
            /// </summary>
            [NameInMap("SlsProjectStatus")]
            [Validation(Required=false)]
            public string SlsProjectStatus { get; set; }

            /// <summary>
            /// Indicates whether Log Service is activated. Valid values:
            /// 
            /// *   **yes**
            /// *   **no**
            /// </summary>
            [NameInMap("SlsServiceStatus")]
            [Validation(Required=false)]
            public string SlsServiceStatus { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
