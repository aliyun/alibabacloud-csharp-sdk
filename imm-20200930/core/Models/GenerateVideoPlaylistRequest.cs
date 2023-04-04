// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GenerateVideoPlaylistRequest : TeaModel {
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        [NameInMap("MasterURI")]
        [Validation(Required=false)]
        public string MasterURI { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("SourceDuration")]
        [Validation(Required=false)]
        public float? SourceDuration { get; set; }

        [NameInMap("SourceStartTime")]
        [Validation(Required=false)]
        public float? SourceStartTime { get; set; }

        [NameInMap("SourceSubtitles")]
        [Validation(Required=false)]
        public List<GenerateVideoPlaylistRequestSourceSubtitles> SourceSubtitles { get; set; }
        public class GenerateVideoPlaylistRequestSourceSubtitles : TeaModel {
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<GenerateVideoPlaylistRequestTargets> Targets { get; set; }
        public class GenerateVideoPlaylistRequestTargets : TeaModel {
            [NameInMap("Audio")]
            [Validation(Required=false)]
            public TargetAudio Audio { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            [NameInMap("InitialSegments")]
            [Validation(Required=false)]
            public List<float?> InitialSegments { get; set; }

            [NameInMap("InitialTranscode")]
            [Validation(Required=false)]
            public float? InitialTranscode { get; set; }

            [NameInMap("Speed")]
            [Validation(Required=false)]
            public float? Speed { get; set; }

            [NameInMap("Subtitle")]
            [Validation(Required=false)]
            public TargetSubtitle Subtitle { get; set; }

            [NameInMap("TranscodeAhead")]
            [Validation(Required=false)]
            public int? TranscodeAhead { get; set; }

            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

            [NameInMap("Video")]
            [Validation(Required=false)]
            public TargetVideo Video { get; set; }

        }

    }

}
