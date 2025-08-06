// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribePlayDetailResponseBody : TeaModel {
        [NameInMap("BaseInfos")]
        [Validation(Required=false)]
        public List<DescribePlayDetailResponseBodyBaseInfos> BaseInfos { get; set; }
        public class DescribePlayDetailResponseBodyBaseInfos : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("Bps")]
            [Validation(Required=false)]
            public string Bps { get; set; }

            [NameInMap("BroadcastPace")]
            [Validation(Required=false)]
            public string BroadcastPace { get; set; }

            [NameInMap("ClientIP")]
            [Validation(Required=false)]
            public string ClientIP { get; set; }

            [NameInMap("Codec")]
            [Validation(Required=false)]
            public string Codec { get; set; }

            [NameInMap("DecodeStuckTime")]
            [Validation(Required=false)]
            public string DecodeStuckTime { get; set; }

            [NameInMap("Definition")]
            [Validation(Required=false)]
            public string Definition { get; set; }

            [NameInMap("FirstFrameDuration")]
            [Validation(Required=false)]
            public string FirstFrameDuration { get; set; }

            [NameInMap("Fps")]
            [Validation(Required=false)]
            public string Fps { get; set; }

            [NameInMap("IsHardDecode")]
            [Validation(Required=false)]
            public string IsHardDecode { get; set; }

            [NameInMap("Mdat")]
            [Validation(Required=false)]
            public string Mdat { get; set; }

            [NameInMap("Moov")]
            [Validation(Required=false)]
            public string Moov { get; set; }

            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            [NameInMap("NetworkDuration")]
            [Validation(Required=false)]
            public string NetworkDuration { get; set; }

            [NameInMap("NetworkStuckTime")]
            [Validation(Required=false)]
            public string NetworkStuckTime { get; set; }

            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            [NameInMap("PlayTs")]
            [Validation(Required=false)]
            public string PlayTs { get; set; }

            [NameInMap("PlayerLoadDuration")]
            [Validation(Required=false)]
            public string PlayerLoadDuration { get; set; }

            [NameInMap("PlayerPreDealDuration")]
            [Validation(Required=false)]
            public string PlayerPreDealDuration { get; set; }

            [NameInMap("PlayerReadyDuration")]
            [Validation(Required=false)]
            public string PlayerReadyDuration { get; set; }

            [NameInMap("SdkVersion")]
            [Validation(Required=false)]
            public string SdkVersion { get; set; }

            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TerminalType")]
            [Validation(Required=false)]
            public string TerminalType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
