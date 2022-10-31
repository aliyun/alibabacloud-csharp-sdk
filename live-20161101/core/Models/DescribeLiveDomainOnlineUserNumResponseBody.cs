// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainOnlineUserNumResponseBody : TeaModel {
        [NameInMap("OnlineUserInfo")]
        [Validation(Required=false)]
        public DescribeLiveDomainOnlineUserNumResponseBodyOnlineUserInfo OnlineUserInfo { get; set; }
        public class DescribeLiveDomainOnlineUserNumResponseBodyOnlineUserInfo : TeaModel {
            [NameInMap("LiveStreamOnlineUserNumInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainOnlineUserNumResponseBodyOnlineUserInfoLiveStreamOnlineUserNumInfo> LiveStreamOnlineUserNumInfo { get; set; }
            public class DescribeLiveDomainOnlineUserNumResponseBodyOnlineUserInfoLiveStreamOnlineUserNumInfo : TeaModel {
                [NameInMap("Infos")]
                [Validation(Required=false)]
                public DescribeLiveDomainOnlineUserNumResponseBodyOnlineUserInfoLiveStreamOnlineUserNumInfoInfos Infos { get; set; }
                public class DescribeLiveDomainOnlineUserNumResponseBodyOnlineUserInfoLiveStreamOnlineUserNumInfoInfos : TeaModel {
                    [NameInMap("Info")]
                    [Validation(Required=false)]
                    public List<DescribeLiveDomainOnlineUserNumResponseBodyOnlineUserInfoLiveStreamOnlineUserNumInfoInfosInfo> Info { get; set; }
                    public class DescribeLiveDomainOnlineUserNumResponseBodyOnlineUserInfoLiveStreamOnlineUserNumInfoInfosInfo : TeaModel {
                        [NameInMap("TranscodeTemplate")]
                        [Validation(Required=false)]
                        public string TranscodeTemplate { get; set; }

                        [NameInMap("UserNumber")]
                        [Validation(Required=false)]
                        public long? UserNumber { get; set; }

                    }

                }

                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StreamCount")]
        [Validation(Required=false)]
        public int? StreamCount { get; set; }

        [NameInMap("UserCount")]
        [Validation(Required=false)]
        public int? UserCount { get; set; }

    }

}
