// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class GetUserConfigResponseBody : TeaModel {
        [NameInMap("AccountSufficient")]
        [Validation(Required=false)]
        public bool? AccountSufficient { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("EnableEciDisk")]
        [Validation(Required=false)]
        public bool? EnableEciDisk { get; set; }

        [NameInMap("FreeTier")]
        [Validation(Required=false)]
        public GetUserConfigResponseBodyFreeTier FreeTier { get; set; }
        public class GetUserConfigResponseBodyFreeTier : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("InitBaseUnit")]
            [Validation(Required=false)]
            public string InitBaseUnit { get; set; }

            [NameInMap("InitBaseValue")]
            [Validation(Required=false)]
            public double? InitBaseValue { get; set; }

            [NameInMap("InitShowUnit")]
            [Validation(Required=false)]
            public string InitShowUnit { get; set; }

            [NameInMap("InitShowValue")]
            [Validation(Required=false)]
            public string InitShowValue { get; set; }

            [NameInMap("IsFreeTierUser")]
            [Validation(Required=false)]
            public bool? IsFreeTierUser { get; set; }

            [NameInMap("PeriodBaseUnit")]
            [Validation(Required=false)]
            public string PeriodBaseUnit { get; set; }

            [NameInMap("PeriodBaseValue")]
            [Validation(Required=false)]
            public double? PeriodBaseValue { get; set; }

            [NameInMap("PeriodShowUnit")]
            [Validation(Required=false)]
            public string PeriodShowUnit { get; set; }

            [NameInMap("PeriodShowValue")]
            [Validation(Required=false)]
            public string PeriodShowValue { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("FreeTierSpecAvailable")]
        [Validation(Required=false)]
        public bool? FreeTierSpecAvailable { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
