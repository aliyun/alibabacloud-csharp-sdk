// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneNumberAnalysisTransparentResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribePhoneNumberAnalysisTransparentResponseBodyData Data { get; set; }
        public class DescribePhoneNumberAnalysisTransparentResponseBodyData : TeaModel {
            [NameInMap("Device_risk")]
            [Validation(Required=false)]
            public string DeviceRisk { get; set; }

            [NameInMap("Ip_risk")]
            [Validation(Required=false)]
            public string IpRisk { get; set; }

            [NameInMap("Score1")]
            [Validation(Required=false)]
            public string Score1 { get; set; }

            [NameInMap("Score2")]
            [Validation(Required=false)]
            public string Score2 { get; set; }

            [NameInMap("Score3")]
            [Validation(Required=false)]
            public string Score3 { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
