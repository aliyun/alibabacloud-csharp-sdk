// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataLimitDetailResponseBody : TeaModel {
        /// <summary>
        /// The details of the data asset.
        /// </summary>
        [NameInMap("DataLimit")]
        [Validation(Required=false)]
        public DescribeDataLimitDetailResponseBodyDataLimit DataLimit { get; set; }
        public class DescribeDataLimitDetailResponseBodyDataLimit : TeaModel {
            /// <summary>
            /// The status of the connectivity test between the data asset and DSC. Valid values:
            /// 
            /// *   **2**: indicates that the data asset was being connected.
            /// *   **3**: indicates that the data asset was connected to DSC.
            /// *   **4**: indicates that the data asset failed to be connected.
            /// </summary>
            [NameInMap("CheckStatus")]
            [Validation(Required=false)]
            public int? CheckStatus { get; set; }

            /// <summary>
            /// The result that indicates the status of the connectivity test between the data asset and DSC. Valid values:
            /// 
            /// *   **Passed**
            /// *   **Failed**
            /// *   **Testing**
            /// </summary>
            [NameInMap("CheckStatusName")]
            [Validation(Required=false)]
            public string CheckStatusName { get; set; }

            /// <summary>
            /// The time when the data asset was connected to DSC. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The ID of the data asset.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The region in which the data asset resides.
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// The ID and name of the data asset in the service to which the data asset belongs.
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// The port number that is used to connect to the database.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The ID of the region in which the data asset resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The type of the service to which the data asset belongs. Valid values:
            /// 
            /// *   **1**: MaxCompute
            /// *   **2**: OSS
            /// *   **3**: AnalyticDB for MySQL
            /// *   **4**: Tablestore
            /// *   **5**: ApsaraDB RDS
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public long? ResourceType { get; set; }

            /// <summary>
            /// The service to which the data asset belongs. Valid values:
            /// 
            /// *   **MaxCompute**
            /// *   **OSS**
            /// *   **ADS**
            /// *   **OTS**
            /// *   **RDS**
            /// </summary>
            [NameInMap("ResourceTypeCode")]
            [Validation(Required=false)]
            public string ResourceTypeCode { get; set; }

            /// <summary>
            /// The account of the user who manages the data asset.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
