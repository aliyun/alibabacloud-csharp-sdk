// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainOnlineUserNumResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("StreamCount")]
        [Validation(Required=true)]
        public int? StreamCount { get; set; }

        [NameInMap("UserCount")]
        [Validation(Required=true)]
        public int? UserCount { get; set; }

        [NameInMap("OnlineUserInfo")]
        [Validation(Required=true)]
        public DescribeLiveDomainOnlineUserNumResponseOnlineUserInfo OnlineUserInfo { get; set; }
        public class DescribeLiveDomainOnlineUserNumResponseOnlineUserInfo : TeaModel {
            [NameInMap("LiveStreamOnlineUserNumInfo")]
            [Validation(Required=true)]
            public List<DescribeLiveDomainOnlineUserNumResponseOnlineUserInfoLiveStreamOnlineUserNumInfo> LiveStreamOnlineUserNumInfo { get; set; }
            public class DescribeLiveDomainOnlineUserNumResponseOnlineUserInfoLiveStreamOnlineUserNumInfo : TeaModel {
                public string StreamName { get; set; }
                public DescribeLiveDomainOnlineUserNumResponseOnlineUserInfoLiveStreamOnlineUserNumInfoInfos Infos { get; set; }
                public class DescribeLiveDomainOnlineUserNumResponseOnlineUserInfoLiveStreamOnlineUserNumInfoInfos : TeaModel {
                    [NameInMap("Info")]
                    [Validation(Required=true)]
                    public List<DescribeLiveDomainOnlineUserNumResponseOnlineUserInfoLiveStreamOnlineUserNumInfoInfosInfo> Info { get; set; }
                    public class DescribeLiveDomainOnlineUserNumResponseOnlineUserInfoLiveStreamOnlineUserNumInfoInfosInfo : TeaModel {
                        [NameInMap("TranscodeTemplate")]
                        [Validation(Required=true)]
                        public string TranscodeTemplate { get; set; }

                        [NameInMap("UserNumber")]
                        [Validation(Required=true)]
                        public long UserNumber { get; set; }

                    }

                }
            }
        };

    }

}
