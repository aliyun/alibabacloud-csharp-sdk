// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceProvisioningResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceProvisioningResponseBodyData Data { get; set; }
        public class QueryDeviceProvisioningResponseBodyData : TeaModel {
            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public string AliyunUid { get; set; }

            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            [NameInMap("SourceIotInstanceId")]
            [Validation(Required=false)]
            public string SourceIotInstanceId { get; set; }

            [NameInMap("SourceRegion")]
            [Validation(Required=false)]
            public string SourceRegion { get; set; }

            [NameInMap("TargetIotInstanceId")]
            [Validation(Required=false)]
            public string TargetIotInstanceId { get; set; }

            [NameInMap("TargetRegion")]
            [Validation(Required=false)]
            public string TargetRegion { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
