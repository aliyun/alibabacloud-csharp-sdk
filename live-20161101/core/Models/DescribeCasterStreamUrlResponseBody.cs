// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterStreamUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        [NameInMap("CasterStreams")]
        [Validation(Required=false)]
        public DescribeCasterStreamUrlResponseBodyCasterStreams CasterStreams { get; set; }
        public class DescribeCasterStreamUrlResponseBodyCasterStreams : TeaModel {
            [NameInMap("CasterStream")]
            [Validation(Required=false)]
            public List<DescribeCasterStreamUrlResponseBodyCasterStreamsCasterStream> CasterStream { get; set; }
            public class DescribeCasterStreamUrlResponseBodyCasterStreamsCasterStream : TeaModel {
                [NameInMap("OutputType")]
                [Validation(Required=false)]
                public int? OutputType { get; set; }

                [NameInMap("RtmpUrl")]
                [Validation(Required=false)]
                public string RtmpUrl { get; set; }

                [NameInMap("SceneId")]
                [Validation(Required=false)]
                public string SceneId { get; set; }

                [NameInMap("StreamInfos")]
                [Validation(Required=false)]
                public DescribeCasterStreamUrlResponseBodyCasterStreamsCasterStreamStreamInfos StreamInfos { get; set; }
                public class DescribeCasterStreamUrlResponseBodyCasterStreamsCasterStreamStreamInfos : TeaModel {
                    [NameInMap("StreamInfo")]
                    [Validation(Required=false)]
                    public List<DescribeCasterStreamUrlResponseBodyCasterStreamsCasterStreamStreamInfosStreamInfo> StreamInfo { get; set; }
                    public class DescribeCasterStreamUrlResponseBodyCasterStreamsCasterStreamStreamInfosStreamInfo : TeaModel {
                        [NameInMap("OutputStreamUrl")]
                        [Validation(Required=false)]
                        public string OutputStreamUrl { get; set; }

                        [NameInMap("TranscodeConfig")]
                        [Validation(Required=false)]
                        public string TranscodeConfig { get; set; }

                        [NameInMap("VideoFormat")]
                        [Validation(Required=false)]
                        public string VideoFormat { get; set; }

                    }

                }

                [NameInMap("StreamUrl")]
                [Validation(Required=false)]
                public string StreamUrl { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of streams that were returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
