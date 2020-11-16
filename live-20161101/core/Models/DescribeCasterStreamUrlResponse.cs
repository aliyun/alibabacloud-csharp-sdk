// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterStreamUrlResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("CasterId")]
        [Validation(Required=true)]
        public string CasterId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("CasterStreams")]
        [Validation(Required=true)]
        public DescribeCasterStreamUrlResponseCasterStreams CasterStreams { get; set; }
        public class DescribeCasterStreamUrlResponseCasterStreams : TeaModel {
            [NameInMap("CasterStream")]
            [Validation(Required=true)]
            public List<DescribeCasterStreamUrlResponseCasterStreamsCasterStream> CasterStream { get; set; }
            public class DescribeCasterStreamUrlResponseCasterStreamsCasterStream : TeaModel {
                public string SceneId { get; set; }
                public string StreamUrl { get; set; }
                public string RtmpUrl { get; set; }
                public int? OutputType { get; set; }
                public DescribeCasterStreamUrlResponseCasterStreamsCasterStreamStreamInfos StreamInfos { get; set; }
                public class DescribeCasterStreamUrlResponseCasterStreamsCasterStreamStreamInfos : TeaModel {
                    [NameInMap("StreamInfo")]
                    [Validation(Required=true)]
                    public List<DescribeCasterStreamUrlResponseCasterStreamsCasterStreamStreamInfosStreamInfo> StreamInfo { get; set; }
                    public class DescribeCasterStreamUrlResponseCasterStreamsCasterStreamStreamInfosStreamInfo : TeaModel {
                        [NameInMap("TranscodeConfig")]
                        [Validation(Required=true)]
                        public string TranscodeConfig { get; set; }

                        [NameInMap("VideoFormat")]
                        [Validation(Required=true)]
                        public string VideoFormat { get; set; }

                        [NameInMap("OutputStreamUrl")]
                        [Validation(Required=true)]
                        public string OutputStreamUrl { get; set; }

                    }

                }
            }
        };

    }

}
