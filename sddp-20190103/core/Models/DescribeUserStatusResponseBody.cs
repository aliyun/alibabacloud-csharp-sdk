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
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }
            [NameInMap("Authed")]
            [Validation(Required=false)]
            public bool? Authed { get; set; }
            [NameInMap("Buyed")]
            [Validation(Required=false)]
            public bool? Buyed { get; set; }
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }
            [NameInMap("DataMaskColumns")]
            [Validation(Required=false)]
            public long? DataMaskColumns { get; set; }
            [NameInMap("DataMaskTasks")]
            [Validation(Required=false)]
            public long? DataMaskTasks { get; set; }
            [NameInMap("DatamaskColumns")]
            [Validation(Required=false)]
            public long? DatamaskColumns { get; set; }
            [NameInMap("DivulgeCount")]
            [Validation(Required=false)]
            public long? DivulgeCount { get; set; }
            [NameInMap("DlpTotalCount")]
            [Validation(Required=false)]
            public long? DlpTotalCount { get; set; }
            [NameInMap("IncSensitiveObjects")]
            [Validation(Required=false)]
            public long? IncSensitiveObjects { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("InstanceNum")]
            [Validation(Required=false)]
            public int? InstanceNum { get; set; }
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public int? InstanceStatus { get; set; }
            [NameInMap("LabStatus")]
            [Validation(Required=false)]
            public int? LabStatus { get; set; }
            [NameInMap("OssBucketSet")]
            [Validation(Required=false)]
            public bool? OssBucketSet { get; set; }
            [NameInMap("OssSize")]
            [Validation(Required=false)]
            public long? OssSize { get; set; }
            [NameInMap("RemainDays")]
            [Validation(Required=false)]
            public int? RemainDays { get; set; }
            [NameInMap("SensitiveObject")]
            [Validation(Required=false)]
            public long? SensitiveObject { get; set; }
            [NameInMap("SensitiveTable")]
            [Validation(Required=false)]
            public long? SensitiveTable { get; set; }
            [NameInMap("SensitiveTables")]
            [Validation(Required=false)]
            public long? SensitiveTables { get; set; }
            [NameInMap("TotalDataMaskColumns")]
            [Validation(Required=false)]
            public long? TotalDataMaskColumns { get; set; }
            [NameInMap("Trail")]
            [Validation(Required=false)]
            public bool? Trail { get; set; }
            [NameInMap("UseInstanceNum")]
            [Validation(Required=false)]
            public int? UseInstanceNum { get; set; }
            [NameInMap("UseOssSize")]
            [Validation(Required=false)]
            public long? UseOssSize { get; set; }
        };

    }

}
