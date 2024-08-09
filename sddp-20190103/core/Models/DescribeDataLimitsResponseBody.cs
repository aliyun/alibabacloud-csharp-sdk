// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataLimitsResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// A list of data assets.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataLimitsResponseBodyItems> Items { get; set; }
        public class DescribeDataLimitsResponseBodyItems : TeaModel {
            /// <summary>
            /// Indicates whether the security audit feature is enabled. Valid values:
            /// 
            /// *   **1**: yes
            /// *   **0**: no
            /// </summary>
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public int? AuditStatus { get; set; }

            /// <summary>
            /// Indicates whether the data asset can be automatically scanned. Valid values:
            /// 
            /// *   **0**: no
            /// *   **1**: yes
            /// </summary>
            [NameInMap("AutoScan")]
            [Validation(Required=false)]
            public int? AutoScan { get; set; }

            /// <summary>
            /// The data detection status. Valid values:
            /// 
            /// *   **0**: The data detection is ready.
            /// *   **1**: The data detection is running.
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
            /// Indicates whether DSC has the data de-identification permissions on the data asset. Valid values:
            /// 
            /// *   **1**: yes
            /// *   **0**: no
            /// </summary>
            [NameInMap("DatamaskStatus")]
            [Validation(Required=false)]
            public int? DatamaskStatus { get; set; }

            /// <summary>
            /// The database engine version.
            /// </summary>
            [NameInMap("DbVersion")]
            [Validation(Required=false)]
            public string DbVersion { get; set; }

            /// <summary>
            /// Indicates whether DSC has the data identification permissions on the data asset. Valid values:
            /// 
            /// *   **1**: yes
            /// *   **0**: no
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }

            /// <summary>
            /// The type of the database engine. Valid values include **MySQL**, **SQLServer**, **Oracle**, **PostgreSQL**, and **MongoDB**.
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// The error code.
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// The reason for the failure.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// Indicates whether the data leak prevention feature is enabled. Valid values:
            /// 
            /// *   **0**: no
            /// *   **1**: yes (default)
            /// </summary>
            [NameInMap("EventStatus")]
            [Validation(Required=false)]
            public int? EventStatus { get; set; }

            /// <summary>
            /// The time when the data asset was created. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The unique ID of the data asset.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The description of the instance.
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// The ID of the data asset to which the table belongs.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The time when the last scan is performed.
            /// 
            /// *   The value is a UNIX timestamp.
            /// *   Unit: milliseconds.
            /// </summary>
            [NameInMap("LastFinishedTime")]
            [Validation(Required=false)]
            public long? LastFinishedTime { get; set; }

            [NameInMap("LastStartTime")]
            [Validation(Required=false)]
            public long? LastStartTime { get; set; }

            /// <summary>
            /// The region in which the data asset resides.
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// The retention period of raw logs. Unit: days.
            /// </summary>
            [NameInMap("LogStoreDay")]
            [Validation(Required=false)]
            public int? LogStoreDay { get; set; }

            /// <summary>
            /// The ID of the member.
            /// </summary>
            [NameInMap("MemberAccount")]
            [Validation(Required=false)]
            public long? MemberAccount { get; set; }

            /// <summary>
            /// The next time when the data asset is scanned. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("NextStartTime")]
            [Validation(Required=false)]
            public long? NextStartTime { get; set; }

            /// <summary>
            /// Indicates whether the optical character recognition (OCR) feature is enabled. Valid values:
            /// 
            /// *   **0**: no
            /// *   **1**: yes
            /// </summary>
            [NameInMap("OcrStatus")]
            [Validation(Required=false)]
            public int? OcrStatus { get; set; }

            /// <summary>
            /// The parent ID of the data asset that you want to query. Valid values include **bucket, db, and project**.
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// The port number of the self-managed database.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The status of the data asset scan. Valid values:
            /// 
            /// *   **-1**: invalid
            /// *   **0**: waiting
            /// *   **1**: being scanned
            /// *   **2**: suspended
            /// *   **3**: completed
            /// </summary>
            [NameInMap("ProcessStatus")]
            [Validation(Required=false)]
            public int? ProcessStatus { get; set; }

            /// <summary>
            /// The total number of data tables or files.
            /// </summary>
            [NameInMap("ProcessTotalCount")]
            [Validation(Required=false)]
            public int? ProcessTotalCount { get; set; }

            /// <summary>
            /// The region in which the asset resides.
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
            /// *   **6**: self-managed database
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public long? ResourceType { get; set; }

            /// <summary>
            /// The code of the service to which the data asset belongs. Valid values: **MaxCompute, OSS, ADS, OTS, and RDS**.
            /// </summary>
            [NameInMap("ResourceTypeCode")]
            [Validation(Required=false)]
            public string ResourceTypeCode { get; set; }

            /// <summary>
            /// The number of sensitive data samples. Valid values: **0**, **5**, and **10**. Unit: data entries.
            /// </summary>
            [NameInMap("SamplingSize")]
            [Validation(Required=false)]
            public int? SamplingSize { get; set; }

            /// <summary>
            /// A list of the IDs of the security groups that are used by PrivateLink when you install the DSC agent.
            /// </summary>
            [NameInMap("SecurityGroupIdList")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIdList { get; set; }

            /// <summary>
            /// Indicates whether the security audit feature is supported. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("SupportAudit")]
            [Validation(Required=false)]
            public bool? SupportAudit { get; set; }

            /// <summary>
            /// Indicates whether the data de-identification feature is supported. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("SupportDatamask")]
            [Validation(Required=false)]
            public bool? SupportDatamask { get; set; }

            /// <summary>
            /// Indicates whether anomalous event detection is supported. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("SupportEvent")]
            [Validation(Required=false)]
            public bool? SupportEvent { get; set; }

            /// <summary>
            /// Indicates whether OCR is supported. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("SupportOcr")]
            [Validation(Required=false)]
            public bool? SupportOcr { get; set; }

            /// <summary>
            /// Indicates whether the data asset scan feature is supported. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("SupportScan")]
            [Validation(Required=false)]
            public bool? SupportScan { get; set; }

            /// <summary>
            /// The alias of the tenant.
            /// </summary>
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// The total number of fields in the table.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// The username that is used to access the data asset.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// A list of the IDs of the vSwitches that are used by PrivateLink when you install the DSC agent.
            /// </summary>
            [NameInMap("VSwitchIdList")]
            [Validation(Required=false)]
            public List<string> VSwitchIdList { get; set; }

            /// <summary>
            /// The ID of the virtual private cloud (VPC) to which the data asset belongs.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
