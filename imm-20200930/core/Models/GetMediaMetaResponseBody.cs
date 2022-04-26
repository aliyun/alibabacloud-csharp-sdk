// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetMediaMetaResponseBody : TeaModel {
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<Address> Addresses { get; set; }

        [NameInMap("Album")]
        [Validation(Required=false)]
        public string Album { get; set; }

        [NameInMap("AlbumArtist")]
        [Validation(Required=false)]
        public string AlbumArtist { get; set; }

        [NameInMap("Artist")]
        [Validation(Required=false)]
        public string Artist { get; set; }

        [NameInMap("AudioStreams")]
        [Validation(Required=false)]
        public List<AudioStream> AudioStreams { get; set; }

        [NameInMap("Bitrate")]
        [Validation(Required=false)]
        public long? Bitrate { get; set; }

        [NameInMap("Composer")]
        [Validation(Required=false)]
        public string Composer { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public double? Duration { get; set; }

        [NameInMap("FormatLongName")]
        [Validation(Required=false)]
        public string FormatLongName { get; set; }

        [NameInMap("FormatName")]
        [Validation(Required=false)]
        public string FormatName { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("LatLong")]
        [Validation(Required=false)]
        public string LatLong { get; set; }

        [NameInMap("Performer")]
        [Validation(Required=false)]
        public string Performer { get; set; }

        [NameInMap("ProduceTime")]
        [Validation(Required=false)]
        public string ProduceTime { get; set; }

        [NameInMap("ProgramCount")]
        [Validation(Required=false)]
        public long? ProgramCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public double? StartTime { get; set; }

        [NameInMap("StreamCount")]
        [Validation(Required=false)]
        public long? StreamCount { get; set; }

        [NameInMap("Subtitles")]
        [Validation(Required=false)]
        public List<SubtitleStream> Subtitles { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("VideoHeight")]
        [Validation(Required=false)]
        public long? VideoHeight { get; set; }

        [NameInMap("VideoStartTime")]
        [Validation(Required=false)]
        public double? VideoStartTime { get; set; }

        [NameInMap("VideoStreams")]
        [Validation(Required=false)]
        public List<VideoStream> VideoStreams { get; set; }

        [NameInMap("VideoWidth")]
        [Validation(Required=false)]
        public long? VideoWidth { get; set; }

    }

}
