// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribePdnsUserInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public DescribePdnsUserInfoResponseBodyUserInfo UserInfo { get; set; }
        public class DescribePdnsUserInfoResponseBodyUserInfo : TeaModel {
            [NameInMap("AvailableAccessSecurityType")]
            [Validation(Required=false)]
            public string AvailableAccessSecurityType { get; set; }

            [NameInMap("AvailableService")]
            [Validation(Required=false)]
            public string AvailableService { get; set; }

            [NameInMap("PdnsId")]
            [Validation(Required=false)]
            public long? PdnsId { get; set; }

            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("StatisticSwitchStatus")]
            [Validation(Required=false)]
            public string StatisticSwitchStatus { get; set; }

            [NameInMap("StoppedService")]
            [Validation(Required=false)]
            public string StoppedService { get; set; }

        }

    }

}
