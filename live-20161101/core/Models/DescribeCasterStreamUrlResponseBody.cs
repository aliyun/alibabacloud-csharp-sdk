// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterStreamUrlResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("CasterStreams")]
        [Validation(Required=false)]
        public DescribeCasterStreamUrlResponseBodyCasterStreams CasterStreams { get; set; }
        public class DescribeCasterStreamUrlResponseBodyCasterStreams : TeaModel {
            [NameInMap("CasterStream")]
            [Validation(Required=false)]
            public List<DescribeCasterStreamUrlResponseBodyCasterStreamsCasterStream> CasterStream { get; set; }
            public class DescribeCasterStreamUrlResponseBodyCasterStreamsCasterStream : TeaModel {
                public string RtmpUrl { get; set; }
                public int? OutputType { get; set; }
                public DescribeCasterStreamUrlResponseBodyCasterStreamsCasterStreamStreamInfos StreamInfos { get; set; }
                public class DescribeCasterStreamUrlResponseBodyCasterStreamsCasterStreamStreamInfos : TeaModel {
                    [NameInMap("StreamInfo")]
                    [Validation(Required=false)]
                    public List<DescribeCasterStreamUrlResponseBodyCasterStreamsCasterStreamStreamInfosStreamInfo> StreamInfo { get; set; }
                    public class DescribeCasterStreamUrlResponseBodyCasterStreamsCasterStreamStreamInfosStreamInfo : TeaModel {
                        [NameInMap("VideoFormat")]
                        [Validation(Required=false)]
                        public string VideoFormat { get; set; }

                        [NameInMap("OutputStreamUrl")]
                        [Validation(Required=false)]
                        public string OutputStreamUrl { get; set; }

                        [NameInMap("TranscodeConfig")]
                        [Validation(Required=false)]
                        public string TranscodeConfig { get; set; }

                    }

                }
                public string SceneId { get; set; }
                public string StreamUrl { get; set; }
            }
        };

        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

    }

}
