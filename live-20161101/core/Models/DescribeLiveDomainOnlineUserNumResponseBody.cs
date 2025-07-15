// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainOnlineUserNumResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the streams.</para>
        /// </summary>
        [NameInMap("OnlineUserInfo")]
        [Validation(Required=false)]
        public DescribeLiveDomainOnlineUserNumResponseBodyOnlineUserInfo OnlineUserInfo { get; set; }
        public class DescribeLiveDomainOnlineUserNumResponseBodyOnlineUserInfo : TeaModel {
            [NameInMap("LiveStreamOnlineUserNumInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainOnlineUserNumResponseBodyOnlineUserInfoLiveStreamOnlineUserNumInfo> LiveStreamOnlineUserNumInfo { get; set; }
            public class DescribeLiveDomainOnlineUserNumResponseBodyOnlineUserInfoLiveStreamOnlineUserNumInfo : TeaModel {
                /// <summary>
                /// <para>The statistics on the stream.</para>
                /// </summary>
                [NameInMap("Infos")]
                [Validation(Required=false)]
                public DescribeLiveDomainOnlineUserNumResponseBodyOnlineUserInfoLiveStreamOnlineUserNumInfoInfos Infos { get; set; }
                public class DescribeLiveDomainOnlineUserNumResponseBodyOnlineUserInfoLiveStreamOnlineUserNumInfoInfos : TeaModel {
                    [NameInMap("Info")]
                    [Validation(Required=false)]
                    public List<DescribeLiveDomainOnlineUserNumResponseBodyOnlineUserInfoLiveStreamOnlineUserNumInfoInfosInfo> Info { get; set; }
                    public class DescribeLiveDomainOnlineUserNumResponseBodyOnlineUserInfoLiveStreamOnlineUserNumInfoInfosInfo : TeaModel {
                        /// <summary>
                        /// <para>The transcoding template. A value of origin indicates that the stream is a source stream.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>origin</para>
                        /// </summary>
                        [NameInMap("TranscodeTemplate")]
                        [Validation(Required=false)]
                        public string TranscodeTemplate { get; set; }

                        /// <summary>
                        /// <para>The number of online users for the stream, which can be a source stream or transcoded stream.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("UserNumber")]
                        [Validation(Required=false)]
                        public long? UserNumber { get; set; }

                    }

                }

                /// <summary>
                /// <para>The name of the stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://example.com/test/liveStream****_3_1</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3A3A8C3D-F8B2-4FBF-9319-771A11B855FA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of streams.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("StreamCount")]
        [Validation(Required=false)]
        public int? StreamCount { get; set; }

        /// <summary>
        /// <para>The total number of online users at the specified point in time for all the live streams under the main streaming domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserCount")]
        [Validation(Required=false)]
        public int? UserCount { get; set; }

    }

}
