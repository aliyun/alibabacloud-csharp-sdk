// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class StartPlaylistResponseBody : TeaModel {
        [NameInMap("ProgramId")]
        [Validation(Required=false)]
        public string ProgramId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StreamInfo")]
        [Validation(Required=false)]
        public StartPlaylistResponseBodyStreamInfo StreamInfo { get; set; }
        public class StartPlaylistResponseBodyStreamInfo : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("StreamName")]
            [Validation(Required=false)]
            public string StreamName { get; set; }

            [NameInMap("Streams")]
            [Validation(Required=false)]
            public StartPlaylistResponseBodyStreamInfoStreams Streams { get; set; }
            public class StartPlaylistResponseBodyStreamInfoStreams : TeaModel {
                [NameInMap("Stream")]
                [Validation(Required=false)]
                public List<StartPlaylistResponseBodyStreamInfoStreamsStream> Stream { get; set; }
                public class StartPlaylistResponseBodyStreamInfoStreamsStream : TeaModel {
                    [NameInMap("PullFlvUrl")]
                    [Validation(Required=false)]
                    public string PullFlvUrl { get; set; }

                    [NameInMap("PullM3U8Url")]
                    [Validation(Required=false)]
                    public string PullM3U8Url { get; set; }

                    [NameInMap("PullRtmpUrl")]
                    [Validation(Required=false)]
                    public string PullRtmpUrl { get; set; }

                    [NameInMap("Quality")]
                    [Validation(Required=false)]
                    public string Quality { get; set; }

                }

            }

        }

    }

}
