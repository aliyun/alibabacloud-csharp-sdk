// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataLimitSetResponseBody : TeaModel {
        /// <summary>
        /// The information about the data asset.
        /// </summary>
        [NameInMap("DataLimitSet")]
        [Validation(Required=false)]
        public DescribeDataLimitSetResponseBodyDataLimitSet DataLimitSet { get; set; }
        public class DescribeDataLimitSetResponseBodyDataLimitSet : TeaModel {
            /// <summary>
            /// An array that consists of data assets that DSC is authorized to scan.
            /// </summary>
            [NameInMap("DataLimitList")]
            [Validation(Required=false)]
            public List<DescribeDataLimitSetResponseBodyDataLimitSetDataLimitList> DataLimitList { get; set; }
            public class DescribeDataLimitSetResponseBodyDataLimitSetDataLimitList : TeaModel {
                /// <summary>
                /// Indicates whether the test of connectivity between DSC and the data asset is passed.
                /// 
                /// *   **2**: The connectivity test is in progress.
                /// *   **3**: The connectivity test is passed.
                /// *   **4**: The connectivity test failed.
                /// </summary>
                [NameInMap("CheckStatus")]
                [Validation(Required=false)]
                public int? CheckStatus { get; set; }

                /// <summary>
                /// The name of the data detection status.
                /// </summary>
                [NameInMap("CheckStatusName")]
                [Validation(Required=false)]
                public string CheckStatusName { get; set; }

                /// <summary>
                /// The connection string that is used to access the data asset.
                /// </summary>
                [NameInMap("Connector")]
                [Validation(Required=false)]
                public string Connector { get; set; }

                /// <summary>
                /// The time when the data asset was created. Unit: milliseconds.
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
                /// The parent asset ID of the data asset.
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                /// <summary>
                /// The region in which the data asset resides.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The type of service to which the data asset belongs. Valid values:
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
                /// The code of the service to which the data asset belongs. Valid values:
                /// 
                /// *   **ODPS**
                /// *   **OSS**
                /// *   **ADS**
                /// *   **OTS**
                /// *   **RDS**
                /// </summary>
                [NameInMap("ResourceTypeCode")]
                [Validation(Required=false)]
                public string ResourceTypeCode { get; set; }

                /// <summary>
                /// The username that is used to access the data asset.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// An array consisting of the OSS objects that DSC is authorized to scan.
            /// </summary>
            [NameInMap("OssBucketList")]
            [Validation(Required=false)]
            public List<DescribeDataLimitSetResponseBodyDataLimitSetOssBucketList> OssBucketList { get; set; }
            public class DescribeDataLimitSetResponseBodyDataLimitSetOssBucketList : TeaModel {
                /// <summary>
                /// The name of the OSS bucket to which the OSS object belongs.
                /// </summary>
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// The region ID of the OSS object.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// An array consisting of the regions in which the data assets can be scanned.
            /// </summary>
            [NameInMap("RegionList")]
            [Validation(Required=false)]
            public List<DescribeDataLimitSetResponseBodyDataLimitSetRegionList> RegionList { get; set; }
            public class DescribeDataLimitSetResponseBodyDataLimitSetRegionList : TeaModel {
                /// <summary>
                /// The name of the region.
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// The type of service to which the data asset belongs. Valid values:
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
            /// *   **ODPS**
            /// *   **OSS**
            /// *   **ADS**
            /// *   **OTS**
            /// *   **RDS**
            /// </summary>
            [NameInMap("ResourceTypeCode")]
            [Validation(Required=false)]
            public string ResourceTypeCode { get; set; }

            /// <summary>
            /// The total number of data objects in the data assets.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
