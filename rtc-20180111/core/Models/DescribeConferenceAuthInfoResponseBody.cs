// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeConferenceAuthInfoResponseBody : TeaModel {
        [NameInMap("AuthInfo")]
        [Validation(Required=false)]
        public DescribeConferenceAuthInfoResponseBodyAuthInfo AuthInfo { get; set; }
        public class DescribeConferenceAuthInfoResponseBodyAuthInfo : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }
            [NameInMap("Nonce")]
            [Validation(Required=false)]
            public string Nonce { get; set; }
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public int? Timestamp { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ConferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

    }

}
