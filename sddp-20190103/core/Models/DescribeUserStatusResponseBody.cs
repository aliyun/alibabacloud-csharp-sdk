// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeUserStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserStatus")]
        [Validation(Required=false)]
        public DescribeUserStatusResponseBodyUserStatus UserStatus { get; set; }
        public class DescribeUserStatusResponseBodyUserStatus : TeaModel {
            [NameInMap("UseOssSize")]
            [Validation(Required=false)]
            public long? UseOssSize { get; set; }
            [NameInMap("UseInstanceNum")]
            [Validation(Required=false)]
            public int? UseInstanceNum { get; set; }
            [NameInMap("InstanceNum")]
            [Validation(Required=false)]
            public int? InstanceNum { get; set; }
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }
            [NameInMap("IncSensitiveTables")]
            [Validation(Required=false)]
            public long? IncSensitiveTables { get; set; }
            [NameInMap("AuditUpgradeStatus")]
            [Validation(Required=false)]
            public bool? AuditUpgradeStatus { get; set; }
            [NameInMap("DataMaskTasks")]
            [Validation(Required=false)]
            public long? DataMaskTasks { get; set; }
            [NameInMap("Authed")]
            [Validation(Required=false)]
            public bool? Authed { get; set; }
            [NameInMap("LabStatus")]
            [Validation(Required=false)]
            public int? LabStatus { get; set; }
            [NameInMap("OdpsSet")]
            [Validation(Required=false)]
            public bool? OdpsSet { get; set; }
            [NameInMap("OssBucketSet")]
            [Validation(Required=false)]
            public bool? OssBucketSet { get; set; }
            [NameInMap("SensitiveTable")]
            [Validation(Required=false)]
            public long? SensitiveTable { get; set; }
            [NameInMap("RemainDays")]
            [Validation(Required=false)]
            public int? RemainDays { get; set; }
            [NameInMap("TotalDataMaskColumns")]
            [Validation(Required=false)]
            public long? TotalDataMaskColumns { get; set; }
            [NameInMap("DatamaskColumns")]
            [Validation(Required=false)]
            public long? DatamaskColumns { get; set; }
            [NameInMap("AuthProductList")]
            [Validation(Required=false)]
            public string AuthProductList { get; set; }
            [NameInMap("Trail")]
            [Validation(Required=false)]
            public bool? Trail { get; set; }
            [NameInMap("DivulgeCount")]
            [Validation(Required=false)]
            public long? DivulgeCount { get; set; }
            [NameInMap("RdsSet")]
            [Validation(Required=false)]
            public bool? RdsSet { get; set; }
            [NameInMap("DbAuditStatus")]
            [Validation(Required=false)]
            public int? DbAuditStatus { get; set; }
            [NameInMap("RenewStatus")]
            [Validation(Required=false)]
            public bool? RenewStatus { get; set; }
            [NameInMap("SensitiveObjects")]
            [Validation(Required=false)]
            public long? SensitiveObjects { get; set; }
            [NameInMap("DataMaskColumns")]
            [Validation(Required=false)]
            public long? DataMaskColumns { get; set; }
            [NameInMap("DlpTotalCount")]
            [Validation(Required=false)]
            public long? DlpTotalCount { get; set; }
            [NameInMap("SensitiveObject")]
            [Validation(Required=false)]
            public long? SensitiveObject { get; set; }
            [NameInMap("DlpCount")]
            [Validation(Required=false)]
            public long? DlpCount { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }
            [NameInMap("OssSize")]
            [Validation(Required=false)]
            public long? OssSize { get; set; }
            [NameInMap("SensitiveTotalTop")]
            [Validation(Required=false)]
            public string SensitiveTotalTop { get; set; }
            [NameInMap("SensitiveTables")]
            [Validation(Required=false)]
            public long? SensitiveTables { get; set; }
            [NameInMap("SensitiveTop")]
            [Validation(Required=false)]
            public string SensitiveTop { get; set; }
            [NameInMap("Buyed")]
            [Validation(Required=false)]
            public bool? Buyed { get; set; }
            [NameInMap("IncSensitiveObjects")]
            [Validation(Required=false)]
            public long? IncSensitiveObjects { get; set; }
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public int? InstanceStatus { get; set; }
            [NameInMap("AssetScanned")]
            [Validation(Required=false)]
            public bool? AssetScanned { get; set; }
            [NameInMap("AlarmCount")]
            [Validation(Required=false)]
            public long? AlarmCount { get; set; }
            [NameInMap("DisplayTime")]
            [Validation(Required=false)]
            public string DisplayTime { get; set; }
        };

    }

}
