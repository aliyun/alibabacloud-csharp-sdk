// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaInfoResponseBody : TeaModel {
        [NameInMap("MediaInfo")]
        [Validation(Required=false)]
        public GetMediaInfoResponseBodyMediaInfo MediaInfo { get; set; }
        public class GetMediaInfoResponseBodyMediaInfo : TeaModel {
            [NameInMap("FileInfoList")]
            [Validation(Required=false)]
            public List<GetMediaInfoResponseBodyMediaInfoFileInfoList> FileInfoList { get; set; }
            public class GetMediaInfoResponseBodyMediaInfoFileInfoList : TeaModel {
                public List<GetMediaInfoResponseBodyMediaInfoFileInfoListAudioStreamInfoList> AudioStreamInfoList { get; set; }
                public class GetMediaInfoResponseBodyMediaInfoFileInfoListAudioStreamInfoList : TeaModel {
                    public string Bitrate { get; set; }
                    public string ChannelLayout { get; set; }
                    public string Channels { get; set; }
                    public string CodecLongName { get; set; }
                    public string CodecName { get; set; }
                    public string CodecTag { get; set; }
                    public string CodecTagString { get; set; }
                    public string CodecTimeBase { get; set; }
                    public string Duration { get; set; }
                    public string Fps { get; set; }
                    public string Index { get; set; }
                    public string Lang { get; set; }
                    public string NumFrames { get; set; }
                    public string Profile { get; set; }
                    public string SampleFmt { get; set; }
                    public string SampleRate { get; set; }
                    public string StartTime { get; set; }
                    public string Timebase { get; set; }
                }
                public GetMediaInfoResponseBodyMediaInfoFileInfoListFileBasicInfo FileBasicInfo { get; set; }
                public class GetMediaInfoResponseBodyMediaInfoFileInfoListFileBasicInfo : TeaModel {
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("FileSize")]
                    [Validation(Required=false)]
                    public string FileSize { get; set; }

                    [NameInMap("FileStatus")]
                    [Validation(Required=false)]
                    public string FileStatus { get; set; }

                    [NameInMap("FileType")]
                    [Validation(Required=false)]
                    public string FileType { get; set; }

                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }

                    [NameInMap("FormatName")]
                    [Validation(Required=false)]
                    public string FormatName { get; set; }

                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public string ModifiedTime { get; set; }

                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }
                public List<GetMediaInfoResponseBodyMediaInfoFileInfoListSubtitleStreamInfoList> SubtitleStreamInfoList { get; set; }
                public class GetMediaInfoResponseBodyMediaInfoFileInfoListSubtitleStreamInfoList : TeaModel {
                    public string CodecLongName { get; set; }
                    public string CodecName { get; set; }
                    public string CodecTag { get; set; }
                    public string CodecTagString { get; set; }
                    public string CodecTimeBase { get; set; }
                    public string Duration { get; set; }
                    public string Index { get; set; }
                    public string Lang { get; set; }
                    public string StartTime { get; set; }
                    public string Timebase { get; set; }
                }
                public List<GetMediaInfoResponseBodyMediaInfoFileInfoListVideoStreamInfoList> VideoStreamInfoList { get; set; }
                public class GetMediaInfoResponseBodyMediaInfoFileInfoListVideoStreamInfoList : TeaModel {
                    public string AvgFPS { get; set; }
                    public string Bitrate { get; set; }
                    public string CodecLongName { get; set; }
                    public string CodecName { get; set; }
                    public string CodecTag { get; set; }
                    public string CodecTagString { get; set; }
                    public string CodecTimeBase { get; set; }
                    public string Dar { get; set; }
                    public string Duration { get; set; }
                    public string Fps { get; set; }
                    public string HasBFrames { get; set; }
                    public string Height { get; set; }
                    public string Index { get; set; }
                    public string Lang { get; set; }
                    public string Level { get; set; }
                    public string NbFrames { get; set; }
                    public string NumFrames { get; set; }
                    public string PixFmt { get; set; }
                    public string Profile { get; set; }
                    public string Rotate { get; set; }
                    public string Sar { get; set; }
                    public string StartTime { get; set; }
                    public string Timebase { get; set; }
                    public string Width { get; set; }
                }
            }
            [NameInMap("MediaBasicInfo")]
            [Validation(Required=false)]
            public GetMediaInfoResponseBodyMediaInfoMediaBasicInfo MediaBasicInfo { get; set; }
            public class GetMediaInfoResponseBodyMediaInfoMediaBasicInfo : TeaModel {
                [NameInMap("Biz")]
                [Validation(Required=false)]
                public string Biz { get; set; }

                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }

                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DeletedTime")]
                [Validation(Required=false)]
                public string DeletedTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("InputURL")]
                [Validation(Required=false)]
                public string InputURL { get; set; }

                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                [NameInMap("MediaTags")]
                [Validation(Required=false)]
                public string MediaTags { get; set; }

                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("SpriteImages")]
                [Validation(Required=false)]
                public string SpriteImages { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("UploadSource")]
                [Validation(Required=false)]
                public string UploadSource { get; set; }

                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
