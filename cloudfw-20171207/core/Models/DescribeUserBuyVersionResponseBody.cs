// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeUserBuyVersionResponseBody : TeaModel {
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        [NameInMap("Expire")]
        [Validation(Required=false)]
        public long? Expire { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        [NameInMap("IpNumber")]
        [Validation(Required=false)]
        public long? IpNumber { get; set; }

        [NameInMap("LogStatus")]
        [Validation(Required=false)]
        public bool? LogStatus { get; set; }

        [NameInMap("LogStorage")]
        [Validation(Required=false)]
        public long? LogStorage { get; set; }

        [NameInMap("MaxOverflow")]
        [Validation(Required=false)]
        public long? MaxOverflow { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("UserStatus")]
        [Validation(Required=false)]
        public bool? UserStatus { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

        [NameInMap("VpcNumber")]
        [Validation(Required=false)]
        public long? VpcNumber { get; set; }

    }

}
