// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetSpeechLicenseDeviceStatisticsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSpeechLicenseDeviceStatisticsResponseBodyData Data { get; set; }
        public class GetSpeechLicenseDeviceStatisticsResponseBodyData : TeaModel {
            [NameInMap("AvailableQuota")]
            [Validation(Required=false)]
            public int? AvailableQuota { get; set; }

            [NameInMap("ExpiredQuota")]
            [Validation(Required=false)]
            public int? ExpiredQuota { get; set; }

            [NameInMap("ExpiringQuota")]
            [Validation(Required=false)]
            public int? ExpiringQuota { get; set; }

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
