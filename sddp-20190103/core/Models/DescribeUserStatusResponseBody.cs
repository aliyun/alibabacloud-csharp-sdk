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
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }
            [NameInMap("DataManagerRole")]
            [Validation(Required=false)]
            public int? DataManagerRole { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("InstanceNum")]
            [Validation(Required=false)]
            public int? InstanceNum { get; set; }
            [NameInMap("LabStatus")]
            [Validation(Required=false)]
            public int? LabStatus { get; set; }
            [NameInMap("Purchased")]
            [Validation(Required=false)]
            public bool? Purchased { get; set; }
            [NameInMap("RemainDays")]
            [Validation(Required=false)]
            public int? RemainDays { get; set; }
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
