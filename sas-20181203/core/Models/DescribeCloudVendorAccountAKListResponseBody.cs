// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCloudVendorAccountAKListResponseBody : TeaModel {
        /// <summary>
        /// The information about the AccessKey pairs.
        /// </summary>
        [NameInMap("CloudVendorAccountAKs")]
        [Validation(Required=false)]
        public List<DescribeCloudVendorAccountAKListResponseBodyCloudVendorAccountAKs> CloudVendorAccountAKs { get; set; }
        public class DescribeCloudVendorAccountAKListResponseBodyCloudVendorAccountAKs : TeaModel {
            /// <summary>
            /// The type of the account to which the AccessKey pair belongs. Valid values:
            /// 
            /// *   **primary**: a primary account
            /// *   **sub**: a sub-account
            /// </summary>
            [NameInMap("AkType")]
            [Validation(Required=false)]
            public string AkType { get; set; }

            /// <summary>
            /// The unique ID of the AccessKey pair.
            /// </summary>
            [NameInMap("AuthId")]
            [Validation(Required=false)]
            public long? AuthId { get; set; }

            /// <summary>
            /// The modules that are associated with the AccessKey pair.
            /// </summary>
            [NameInMap("AuthModules")]
            [Validation(Required=false)]
            public List<DescribeCloudVendorAccountAKListResponseBodyCloudVendorAccountAKsAuthModules> AuthModules { get; set; }
            public class DescribeCloudVendorAccountAKListResponseBodyCloudVendorAccountAKsAuthModules : TeaModel {
                /// <summary>
                /// The error message of the module.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The code of the module. Valid values:
                /// 
                /// *   **HOST**: host
                /// *   **CSPM**: configuration assessment
                /// *   **SIEM**: CloudSiem
                /// *   **TRIAL**: log audit
                /// </summary>
                [NameInMap("Module")]
                [Validation(Required=false)]
                public string Module { get; set; }

                /// <summary>
                /// The cloud asset that is associated with the module.
                /// </summary>
                [NameInMap("ModuleAssetType")]
                [Validation(Required=false)]
                public string ModuleAssetType { get; set; }

                /// <summary>
                /// The display name of the module.
                /// </summary>
                [NameInMap("ModuleDisp")]
                [Validation(Required=false)]
                public string ModuleDisp { get; set; }

                /// <summary>
                /// The service status of the module. Valid values:
                /// 
                /// *   **0**: being used
                /// *   **1**: exception occurred
                /// *   **2**: being validated
                /// *   **3**: validation timed out
                /// </summary>
                [NameInMap("ModuleServiceStatus")]
                [Validation(Required=false)]
                public int? ModuleServiceStatus { get; set; }

                /// <summary>
                /// The permission description of the module.
                /// </summary>
                [NameInMap("ModuleStatement")]
                [Validation(Required=false)]
                public string ModuleStatement { get; set; }

                /// <summary>
                /// The error message of the log audit service.
                /// </summary>
                [NameInMap("TrailMessage")]
                [Validation(Required=false)]
                public string TrailMessage { get; set; }

                /// <summary>
                /// The status of the log audit service. Valid values:
                /// 
                /// *   **init**: being initialized
                /// *   **verify**: being validated
                /// *   **enable**: enabled
                /// *   **disable**: disabled
                /// *   **error**: exception occurred
                /// *   **timeout**: validation timed out
                /// </summary>
                [NameInMap("TrailStatus")]
                [Validation(Required=false)]
                public string TrailStatus { get; set; }

            }

            /// <summary>
            /// The error message of the AccessKey pair.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The AccessKey ID.
            /// </summary>
            [NameInMap("SecretId")]
            [Validation(Required=false)]
            public string SecretId { get; set; }

            /// <summary>
            /// The service status of the AccessKey pair. Valid values:
            /// 
            /// *   **0**: being used
            /// *   **1**: exception occurred
            /// *   **2**: being validated
            /// *   **3**: validation timed out
            /// </summary>
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public int? ServiceStatus { get; set; }

            /// <summary>
            /// The status of the AccessKey pair. Valid values:
            /// 
            /// *   **0**: enabled
            /// *   **1**: disabled
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The cloud service provider. Valid values:
            /// 
            /// *   **Tencent**: Tencent Cloud
            /// *   **HUAWEICLOUD**: Huawei Cloud
            /// *   **Azure**: Microsoft Azure
            /// *   **AWS**: Amazon Web Services (AWS)
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeCloudVendorAccountAKListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeCloudVendorAccountAKListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
