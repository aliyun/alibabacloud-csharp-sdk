// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class GetMediaMetaResponseBody : TeaModel {
        [NameInMap("MediaMeta")]
        [Validation(Required=false)]
        public GetMediaMetaResponseBodyMediaMeta MediaMeta { get; set; }
        public class GetMediaMetaResponseBodyMediaMeta : TeaModel {
            [NameInMap("MediaFormat")]
            [Validation(Required=false)]
            public GetMediaMetaResponseBodyMediaMetaMediaFormat MediaFormat { get; set; }
            public class GetMediaMetaResponseBodyMediaMetaMediaFormat : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public GetMediaMetaResponseBodyMediaMetaMediaFormatAddress Address { get; set; }
                public class GetMediaMetaResponseBodyMediaMetaMediaFormatAddress : TeaModel {
                    [NameInMap("AddressLine")]
                    [Validation(Required=false)]
                    public string AddressLine { get; set; }
                    [NameInMap("City")]
                    [Validation(Required=false)]
                    public string City { get; set; }
                    [NameInMap("Country")]
                    [Validation(Required=false)]
                    public string Country { get; set; }
                    [NameInMap("District")]
                    [Validation(Required=false)]
                    public string District { get; set; }
                    [NameInMap("Province")]
                    [Validation(Required=false)]
                    public string Province { get; set; }
                    [NameInMap("Township")]
                    [Validation(Required=false)]
                    public string Township { get; set; }
                };

                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                [NameInMap("FormatLongName")]
                [Validation(Required=false)]
                public string FormatLongName { get; set; }

                [NameInMap("FormatName")]
                [Validation(Required=false)]
                public string FormatName { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("NumberPrograms")]
                [Validation(Required=false)]
                public int? NumberPrograms { get; set; }

                [NameInMap("NumberStreams")]
                [Validation(Required=false)]
                public int? NumberStreams { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Tag")]
                [Validation(Required=false)]
                public GetMediaMetaResponseBodyMediaMetaMediaFormatTag Tag { get; set; }
                public class GetMediaMetaResponseBodyMediaMetaMediaFormatTag : TeaModel {
                    [NameInMap("Album")]
                    [Validation(Required=false)]
                    public string Album { get; set; }
                    [NameInMap("AlbumArtist")]
                    [Validation(Required=false)]
                    public string AlbumArtist { get; set; }
                    [NameInMap("Artist")]
                    [Validation(Required=false)]
                    public string Artist { get; set; }
                    [NameInMap("Composer")]
                    [Validation(Required=false)]
                    public string Composer { get; set; }
                    [NameInMap("CreationTime")]
                    [Validation(Required=false)]
                    public string CreationTime { get; set; }
                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }
                    [NameInMap("Performer")]
                    [Validation(Required=false)]
                    public string Performer { get; set; }
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }
                };

            }
            [NameInMap("MediaStreams")]
            [Validation(Required=false)]
            public GetMediaMetaResponseBodyMediaMetaMediaStreams MediaStreams { get; set; }
            public class GetMediaMetaResponseBodyMediaMetaMediaStreams : TeaModel {
                [NameInMap("AudioStreams")]
                [Validation(Required=false)]
                public List<GetMediaMetaResponseBodyMediaMetaMediaStreamsAudioStreams> AudioStreams { get; set; }
                public class GetMediaMetaResponseBodyMediaMetaMediaStreamsAudioStreams : TeaModel {
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    [NameInMap("ChannelLayout")]
                    [Validation(Required=false)]
                    public string ChannelLayout { get; set; }

                    [NameInMap("Channels")]
                    [Validation(Required=false)]
                    public int? Channels { get; set; }

                    [NameInMap("CodecLongName")]
                    [Validation(Required=false)]
                    public string CodecLongName { get; set; }

                    [NameInMap("CodecName")]
                    [Validation(Required=false)]
                    public string CodecName { get; set; }

                    [NameInMap("CodecTag")]
                    [Validation(Required=false)]
                    public string CodecTag { get; set; }

                    [NameInMap("CodecTagString")]
                    [Validation(Required=false)]
                    public string CodecTagString { get; set; }

                    [NameInMap("CodecTimeBase")]
                    [Validation(Required=false)]
                    public string CodecTimeBase { get; set; }

                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    [NameInMap("Frames")]
                    [Validation(Required=false)]
                    public string Frames { get; set; }

                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                    [NameInMap("SampleFormat")]
                    [Validation(Required=false)]
                    public string SampleFormat { get; set; }

                    [NameInMap("SampleRate")]
                    [Validation(Required=false)]
                    public string SampleRate { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("TimeBase")]
                    [Validation(Required=false)]
                    public string TimeBase { get; set; }

                }

                [NameInMap("SubtitleStreams")]
                [Validation(Required=false)]
                public List<GetMediaMetaResponseBodyMediaMetaMediaStreamsSubtitleStreams> SubtitleStreams { get; set; }
                public class GetMediaMetaResponseBodyMediaMetaMediaStreamsSubtitleStreams : TeaModel {
                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                }

                [NameInMap("VideoStreams")]
                [Validation(Required=false)]
                public List<GetMediaMetaResponseBodyMediaMetaMediaStreamsVideoStreams> VideoStreams { get; set; }
                public class GetMediaMetaResponseBodyMediaMetaMediaStreamsVideoStreams : TeaModel {
                    [NameInMap("AverageFrameRate")]
                    [Validation(Required=false)]
                    public string AverageFrameRate { get; set; }

                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    [NameInMap("CodecLongName")]
                    [Validation(Required=false)]
                    public string CodecLongName { get; set; }

                    [NameInMap("CodecName")]
                    [Validation(Required=false)]
                    public string CodecName { get; set; }

                    [NameInMap("CodecTag")]
                    [Validation(Required=false)]
                    public string CodecTag { get; set; }

                    [NameInMap("CodecTagString")]
                    [Validation(Required=false)]
                    public string CodecTagString { get; set; }

                    [NameInMap("CodecTimeBase")]
                    [Validation(Required=false)]
                    public string CodecTimeBase { get; set; }

                    [NameInMap("DisplayAspectRatio")]
                    [Validation(Required=false)]
                    public string DisplayAspectRatio { get; set; }

                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    [NameInMap("FrameRrate")]
                    [Validation(Required=false)]
                    public string FrameRrate { get; set; }

                    [NameInMap("Frames")]
                    [Validation(Required=false)]
                    public string Frames { get; set; }

                    [NameInMap("HasBFrames")]
                    [Validation(Required=false)]
                    public int? HasBFrames { get; set; }

                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public int? Level { get; set; }

                    [NameInMap("PixelFormat")]
                    [Validation(Required=false)]
                    public string PixelFormat { get; set; }

                    [NameInMap("Profile")]
                    [Validation(Required=false)]
                    public string Profile { get; set; }

                    [NameInMap("Rotate")]
                    [Validation(Required=false)]
                    public string Rotate { get; set; }

                    [NameInMap("SampleAspectRatio")]
                    [Validation(Required=false)]
                    public string SampleAspectRatio { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("TimeBase")]
                    [Validation(Required=false)]
                    public string TimeBase { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                }

            }
        };

        [NameInMap("MediaUri")]
        [Validation(Required=false)]
        public string MediaUri { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
