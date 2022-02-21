// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainOnlineUserNumResponseBody : TeaModel {
        [NameInMap("OnlineUserInfo")]
        [Validation(Required=false)]
        public DescribeVsDomainOnlineUserNumResponseBodyOnlineUserInfo OnlineUserInfo { get; set; }
        public class DescribeVsDomainOnlineUserNumResponseBodyOnlineUserInfo : TeaModel {
            [NameInMap("LiveStreamOnlineUserNumInfo")]
            [Validation(Required=false)]
            public List<DescribeVsDomainOnlineUserNumResponseBodyOnlineUserInfoLiveStreamOnlineUserNumInfo> LiveStreamOnlineUserNumInfo { get; set; }
            public class DescribeVsDomainOnlineUserNumResponseBodyOnlineUserInfoLiveStreamOnlineUserNumInfo : TeaModel {
                public DescribeVsDomainOnlineUserNumResponseBodyOnlineUserInfoLiveStreamOnlineUserNumInfoInfos Infos { get; set; }
                public class DescribeVsDomainOnlineUserNumResponseBodyOnlineUserInfoLiveStreamOnlineUserNumInfoInfos : TeaModel {
                    [NameInMap("Info")]
                    [Validation(Required=false)]
                    public List<DescribeVsDomainOnlineUserNumResponseBodyOnlineUserInfoLiveStreamOnlineUserNumInfoInfosInfo> Info { get; set; }
                    public class DescribeVsDomainOnlineUserNumResponseBodyOnlineUserInfoLiveStreamOnlineUserNumInfoInfosInfo : TeaModel {
                        [NameInMap("TranscodeTemplate")]
                        [Validation(Required=false)]
                        public string TranscodeTemplate { get; set; }

                        [NameInMap("UserNumber")]
                        [Validation(Required=false)]
                        public long? UserNumber { get; set; }

                    }

                }
                public string StreamName { get; set; }
            }
        };

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
