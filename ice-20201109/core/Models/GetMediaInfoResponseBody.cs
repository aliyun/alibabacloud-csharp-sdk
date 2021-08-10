// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaInfoResponseBody : TeaModel {
        /// <summary>
        /// RequestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MediaInfo")]
        [Validation(Required=false)]
        public GetMediaInfoResponseBodyMediaInfo MediaInfo { get; set; }
        public class GetMediaInfoResponseBodyMediaInfo : TeaModel {
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }
            [NameInMap("MediaBasicInfo")]
            [Validation(Required=false)]
            public GetMediaInfoResponseBodyMediaInfoMediaBasicInfo MediaBasicInfo { get; set; }
            public class GetMediaInfoResponseBodyMediaInfoMediaBasicInfo : TeaModel {
                /// <summary>
                /// MediaId
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// 待注册的媒资在相应系统中的地址
                /// </summary>
                [NameInMap("InputURL")]
                [Validation(Required=false)]
                public string InputURL { get; set; }

                /// <summary>
                /// 媒资媒体类型
                /// </summary>
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                /// <summary>
                /// 媒资业务类型
                /// </summary>
                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }

                /// <summary>
                /// 来源
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// 标题
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// 内容描述
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// 分类
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// 标签
                /// </summary>
                [NameInMap("MediaTags")]
                [Validation(Required=false)]
                public string MediaTags { get; set; }

                /// <summary>
                /// 封面地址
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// 用户数据
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

                /// <summary>
                /// 资源状态
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// 媒资创建时间
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// 媒资修改时间
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// 媒资删除时间
                /// </summary>
                [NameInMap("DeletedTime")]
                [Validation(Required=false)]
                public string DeletedTime { get; set; }

                /// <summary>
                /// 雪碧图
                /// </summary>
                [NameInMap("SpriteImages")]
                [Validation(Required=false)]
                public string SpriteImages { get; set; }

            }
            [NameInMap("DynamicMetaDataList")]
            [Validation(Required=false)]
            public List<GetMediaInfoResponseBodyMediaInfoDynamicMetaDataList> DynamicMetaDataList { get; set; }
            public class GetMediaInfoResponseBodyMediaInfoDynamicMetaDataList : TeaModel {
                public float? In { get; set; }
                public float? Out { get; set; }
                public string Type { get; set; }
                public string Data { get; set; }
            }
            [NameInMap("AiRoughDataList")]
            [Validation(Required=false)]
            public List<GetMediaInfoResponseBodyMediaInfoAiRoughDataList> AiRoughDataList { get; set; }
            public class GetMediaInfoResponseBodyMediaInfoAiRoughDataList : TeaModel {
                public string Type { get; set; }
                public string Result { get; set; }
            }
            [NameInMap("FileInfoList")]
            [Validation(Required=false)]
            public List<GetMediaInfoResponseBodyMediaInfoFileInfoList> FileInfoList { get; set; }
            public class GetMediaInfoResponseBodyMediaInfoFileInfoList : TeaModel {
                public GetMediaInfoResponseBodyMediaInfoFileInfoListFileBasicInfo FileBasicInfo { get; set; }
                public class GetMediaInfoResponseBodyMediaInfoFileInfoListFileBasicInfo : TeaModel {
                    /// <summary>
                    /// 文件名
                    /// </summary>
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// 文件状态
                    /// </summary>
                    [NameInMap("FileStatus")]
                    [Validation(Required=false)]
                    public string FileStatus { get; set; }

                    /// <summary>
                    /// 文件类型
                    /// </summary>
                    [NameInMap("FileType")]
                    [Validation(Required=false)]
                    public string FileType { get; set; }

                    /// <summary>
                    /// 文件大小（字节）
                    /// </summary>
                    [NameInMap("FileSize")]
                    [Validation(Required=false)]
                    public string FileSize { get; set; }

                    /// <summary>
                    /// 文件oss地址
                    /// </summary>
                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }

                    /// <summary>
                    /// 文件存储区域
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// 封装格式
                    /// </summary>
                    [NameInMap("FormatName")]
                    [Validation(Required=false)]
                    public string FormatName { get; set; }

                    /// <summary>
                    /// 时长
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// 码率
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// 宽
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                    /// <summary>
                    /// 高
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                }
                public List<GetMediaInfoResponseBodyMediaInfoFileInfoListAudioStreamInfoList> AudioStreamInfoList { get; set; }
                public class GetMediaInfoResponseBodyMediaInfoFileInfoListAudioStreamInfoList : TeaModel {
                    public string Index { get; set; }
                    public string CodecName { get; set; }
                    public string CodecLongName { get; set; }
                    public string CodecTimeBase { get; set; }
                    public string CodecTagString { get; set; }
                    public string CodecTag { get; set; }
                    public string Profile { get; set; }
                    public string SampleFmt { get; set; }
                    public string SampleRate { get; set; }
                    public string Channels { get; set; }
                    public string ChannelLayout { get; set; }
                    public string Timebase { get; set; }
                    public string StartTime { get; set; }
                    public string Duration { get; set; }
                    public string Bitrate { get; set; }
                    public string Fps { get; set; }
                    public string NumFrames { get; set; }
                    public string Lang { get; set; }
                }
                public List<GetMediaInfoResponseBodyMediaInfoFileInfoListVideoStreamInfoList> VideoStreamInfoList { get; set; }
                public class GetMediaInfoResponseBodyMediaInfoFileInfoListVideoStreamInfoList : TeaModel {
                    public string Index { get; set; }
                    public string CodecName { get; set; }
                    public string CodecLongName { get; set; }
                    public string Profile { get; set; }
                    public string CodecTimeBase { get; set; }
                    public string CodecTagString { get; set; }
                    public string CodecTag { get; set; }
                    public string Width { get; set; }
                    public string Height { get; set; }
                    public string HasBFrames { get; set; }
                    public string Sar { get; set; }
                    public string Dar { get; set; }
                    public string PixFmt { get; set; }
                    public string Level { get; set; }
                    public string Fps { get; set; }
                    public string AvgFPS { get; set; }
                    public string Timebase { get; set; }
                    public string StartTime { get; set; }
                    public string Duration { get; set; }
                    public string Bitrate { get; set; }
                    public string NumFrames { get; set; }
                    public string Lang { get; set; }
                    public string Rotate { get; set; }
                    public string NbFrames { get; set; }
                }
                public List<GetMediaInfoResponseBodyMediaInfoFileInfoListSubtitleStreamInfoList> SubtitleStreamInfoList { get; set; }
                public class GetMediaInfoResponseBodyMediaInfoFileInfoListSubtitleStreamInfoList : TeaModel {
                    public string Index { get; set; }
                    public string CodecName { get; set; }
                    public string CodecLongName { get; set; }
                    public string CodecTimeBase { get; set; }
                    public string CodecTagString { get; set; }
                    public string CodecTag { get; set; }
                    public string Timebase { get; set; }
                    public string StartTime { get; set; }
                    public string Duration { get; set; }
                    public string Lang { get; set; }
                }
            }
        };

    }

}
