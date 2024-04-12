// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Opt20210730.Models
{
    public class GetOrderInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOrderInfoResponseBodyData> Data { get; set; }
        public class GetOrderInfoResponseBodyData : TeaModel {
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("currentConcurrency")]
            [Validation(Required=false)]
            public int? CurrentConcurrency { get; set; }

            [NameInMap("currentDays")]
            [Validation(Required=false)]
            public int? CurrentDays { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("licenseKey")]
            [Validation(Required=false)]
            public string LicenseKey { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("totalDays")]
            [Validation(Required=false)]
            public int? TotalDays { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
