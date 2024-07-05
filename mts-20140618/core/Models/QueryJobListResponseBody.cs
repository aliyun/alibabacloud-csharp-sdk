// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryJobListResponseBody : TeaModel {
        /// <summary>
        /// The transcoding jobs.
        /// </summary>
        [NameInMap("JobList")]
        [Validation(Required=false)]
        public QueryJobListResponseBodyJobList JobList { get; set; }
        public class QueryJobListResponseBodyJobList : TeaModel {
            [NameInMap("Job")]
            [Validation(Required=false)]
            public List<QueryJobListResponseBodyJobListJob> Job { get; set; }
            public class QueryJobListResponseBodyJobListJob : TeaModel {
                /// <summary>
                /// The error code returned if the job failed. If the job was successful, this parameter is not returned.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The time when the job was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The time when the job was complete.
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// The information about the job input.
                /// </summary>
                [NameInMap("Input")]
                [Validation(Required=false)]
                public QueryJobListResponseBodyJobListJobInput Input { get; set; }
                public class QueryJobListResponseBodyJobListJobInput : TeaModel {
                    /// <summary>
                    /// The name of the OSS bucket in which the input file is stored.
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// The OSS region in which the input file resides.
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// The name of the OSS object that is used as the input file.
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                }

                /// <summary>
                /// The job ID.
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// The message sent by Message Service (MNS) to notify users of the job result.
                /// </summary>
                [NameInMap("MNSMessageResult")]
                [Validation(Required=false)]
                public QueryJobListResponseBodyJobListJobMNSMessageResult MNSMessageResult { get; set; }
                public class QueryJobListResponseBodyJobListJobMNSMessageResult : TeaModel {
                    /// <summary>
                    /// The error code returned if the job failed. This parameter is not returned if the job was successful.
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// The error message returned if the job failed. This parameter is not returned if the job was successful.
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// The ID of the message returned if the job was successful.
                    /// </summary>
                    [NameInMap("MessageId")]
                    [Validation(Required=false)]
                    public string MessageId { get; set; }

                }

                /// <summary>
                /// The error message returned if the job failed. If the job was successful, this parameter is not returned.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The job output.
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public QueryJobListResponseBodyJobListJobOutput Output { get; set; }
                public class QueryJobListResponseBodyJobListJobOutput : TeaModel {
                    /// <summary>
                    /// The audio configurations.
                    /// 
                    /// >  If this parameter is specified in the request, the corresponding parameters in the specified transcoding template are overwritten.
                    /// </summary>
                    [NameInMap("Audio")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputAudio Audio { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputAudio : TeaModel {
                        /// <summary>
                        /// The audio bitrate of the output file.
                        /// 
                        /// *   Unit: Kbit/s.
                        /// *   Default value: **128**.
                        /// </summary>
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        /// <summary>
                        /// The number of sound channels.
                        /// 
                        /// *   Valid values: 1, 2, 3, 4, 5, 6, 7, and 8.
                        /// *   Default value: **2**.
                        /// </summary>
                        [NameInMap("Channels")]
                        [Validation(Required=false)]
                        public string Channels { get; set; }

                        /// <summary>
                        /// The audio codec.
                        /// 
                        /// *   Valid values: aac, mp3, vorbis, and flac.
                        /// *   Default value: **aac**.
                        /// </summary>
                        [NameInMap("Codec")]
                        [Validation(Required=false)]
                        public string Codec { get; set; }

                        /// <summary>
                        /// The codec profile of the audio. Valid values when the value of Codec is aac: aaclow, aache, aachev2, aacld, and aaceld.
                        /// </summary>
                        [NameInMap("Profile")]
                        [Validation(Required=false)]
                        public string Profile { get; set; }

                        /// <summary>
                        /// The level of quality control on the audio.
                        /// </summary>
                        [NameInMap("Qscale")]
                        [Validation(Required=false)]
                        public string Qscale { get; set; }

                        /// <summary>
                        /// The sampling rate.
                        /// 
                        /// *   Valid values: 22050, 32000, 44100, 48000, and 96000.
                        /// *   Unit: Hz.
                        /// *   Default value: 44100.
                        /// 
                        /// >  If the video container format is FLV and the audio codec is MP3, the value of this parameter cannot be 32000, 48000, or 96000. If the audio codec is MP3, the value of this parameter cannot be 96000.
                        /// </summary>
                        [NameInMap("Samplerate")]
                        [Validation(Required=false)]
                        public string Samplerate { get; set; }

                        /// <summary>
                        /// The volume configurations.
                        /// </summary>
                        [NameInMap("Volume")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputAudioVolume Volume { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputAudioVolume : TeaModel {
                            /// <summary>
                            /// The volume adjustment range. Default value: -20. Unit: dB.
                            /// </summary>
                            [NameInMap("Level")]
                            [Validation(Required=false)]
                            public string Level { get; set; }

                            /// <summary>
                            /// The method that is used to adjust the volume. Valid values:
                            /// 
                            /// *   **auto**
                            /// *   **dynamic**
                            /// *   **linear**
                            /// </summary>
                            [NameInMap("Method")]
                            [Validation(Required=false)]
                            public string Method { get; set; }

                        }

                    }

                    /// <summary>
                    /// The sequence number of the audio stream.
                    /// 
                    /// *   Format: 0:a:{Sequence number}. Example: 0:a:0.
                    /// *   The sequence number is the index of the audio stream in the list and starts from 0.
                    /// *   If no sequence number is specified, the default audio stream is used.
                    /// </summary>
                    [NameInMap("AudioStreamMap")]
                    [Validation(Required=false)]
                    public string AudioStreamMap { get; set; }

                    /// <summary>
                    /// The information about clips.
                    /// </summary>
                    [NameInMap("Clip")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputClip Clip { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputClip : TeaModel {
                        /// <summary>
                        /// The time span of the clip.
                        /// </summary>
                        [NameInMap("TimeSpan")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputClipTimeSpan TimeSpan { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputClipTimeSpan : TeaModel {
                            /// <summary>
                            /// The duration of the clip.
                            /// 
                            /// *   Format: `hh:mm:ss[.SSS]`.
                            /// *   Example: 01:00:59.999.
                            /// 
                            /// Or
                            /// 
                            /// *   Format: `sssss[.SSS]`.
                            /// *   Example: 32000.23.
                            /// </summary>
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            /// <summary>
                            /// The point in time when the clip starts.
                            /// 
                            /// *   Format: `hh:mm:ss[.SSS]`.
                            /// *   Example: 01:59:59.999.
                            /// 
                            /// Or
                            /// 
                            /// *   Format: `sssss[.SSS]`.
                            /// *   Example: 32000.23.
                            /// </summary>
                            [NameInMap("Seek")]
                            [Validation(Required=false)]
                            public string Seek { get; set; }

                        }

                    }

                    /// <summary>
                    /// The container format configurations.
                    /// </summary>
                    [NameInMap("Container")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputContainer Container { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputContainer : TeaModel {
                        /// <summary>
                        /// The container format.
                        /// 
                        /// *   Default value: mp4.
                        /// *   Video formats include FLV, MP4, HLS (M3U8 + TS), and MPEG-DASH (MPD + fMP4).
                        /// *   Audio formats include MP3, MP4, Ogg, FLAC, and M4A.
                        /// *   Image formats include GIF and WebP. If the container format is GIF, the video codec must be GIF.
                        /// *   If the container format is WebP, the video codec must be WebP.
                        /// *   If the container format is FLV, the video codec cannot be H.265.
                        /// </summary>
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                    }

                    /// <summary>
                    /// The configurations of watermark blurring. The value is a JSON object. For more information, see the DeWatermark section of the [Parameter details](https://help.aliyun.com/document_detail/29253.html) topic.
                    /// </summary>
                    [NameInMap("DeWatermark")]
                    [Validation(Required=false)]
                    public string DeWatermark { get; set; }

                    /// <summary>
                    /// The encryption configurations. The encrypted video file is generated in the M3U8 format.
                    /// </summary>
                    [NameInMap("Encryption")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputEncryption Encryption { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputEncryption : TeaModel {
                        /// <summary>
                        /// The encryption ID.
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// The key that is used to encrypt the video.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The key encryption method. Valid values: Base64 and KMS.
                        /// 
                        /// >  For example, if the key is `encryptionkey128`, the key can be encrypted as `Base64("encryptionkey128")` or `KMS(Base64("encryptionkey128")` depending on the encryption method used.
                        /// </summary>
                        [NameInMap("KeyType")]
                        [Validation(Required=false)]
                        public string KeyType { get; set; }

                        /// <summary>
                        /// The URL that is used to request the key. The URL is Base64-encoded.
                        /// </summary>
                        [NameInMap("KeyUri")]
                        [Validation(Required=false)]
                        public string KeyUri { get; set; }

                        /// <summary>
                        /// The number of unencrypted frames at the beginning of the video. Leaving these frames unencrypted enables video playback to quickly start.
                        /// </summary>
                        [NameInMap("SkipCnt")]
                        [Validation(Required=false)]
                        public string SkipCnt { get; set; }

                        /// <summary>
                        /// The encryption type. Only **hls-aes-128** may be returned.
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// The custom fields.
                    /// </summary>
                    [NameInMap("ExtendData")]
                    [Validation(Required=false)]
                    public string ExtendData { get; set; }

                    /// <summary>
                    /// The non-standard support configurations for M3U8. The value is a JSON object. For more information, see the M3U8NonStandardSupport section of the [Parameter details](https://help.aliyun.com/document_detail/29253.html) topic.
                    /// </summary>
                    [NameInMap("M3U8NonStandardSupport")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputM3U8NonStandardSupport M3U8NonStandardSupport { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputM3U8NonStandardSupport : TeaModel {
                        /// <summary>
                        /// The non-standard support configurations for TS files. The value is a JSON object. For more information, see the TS section of the [Parameter details](https://help.aliyun.com/document_detail/29253.html) topic.
                        /// </summary>
                        [NameInMap("TS")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputM3U8NonStandardSupportTS TS { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputM3U8NonStandardSupportTS : TeaModel {
                            /// <summary>
                            /// Indicates whether the output of the MD5 value of the TS file is supported in the M3U8 file. Valid values:
                            /// 
                            /// *   **true**
                            /// *   **false**
                            /// </summary>
                            [NameInMap("Md5Support")]
                            [Validation(Required=false)]
                            public bool? Md5Support { get; set; }

                            /// <summary>
                            /// Indicates whether the output of the size of the TS file is supported in the M3U8 file. Valid values:
                            /// 
                            /// *   **true**
                            /// *   **false**
                            /// </summary>
                            [NameInMap("SizeSupport")]
                            [Validation(Required=false)]
                            public bool? SizeSupport { get; set; }

                        }

                    }

                    /// <summary>
                    /// The URL of the merging configuration file. Only one of MergeList and MergeConfigUrl takes effect.
                    /// 
                    /// *   The configuration file specified by MergeConfigUrl can contain up to 50 clips.
                    /// *   MergeConfigUrl indicates the URL of the configuration file for merging clips. Make sure that the configuration file is stored as an object in OSS and that MPS can access the OSS object. For information about the file content, see the details about merging parameters.
                    /// *   Example of the content of the merging configuration file: `{"MergeList":[{"MergeURL":"http://exampleBucket****.oss-cn-hangzhou.aliyuncs.com/video_01.mp4"}]}`.
                    /// </summary>
                    [NameInMap("MergeConfigUrl")]
                    [Validation(Required=false)]
                    public string MergeConfigUrl { get; set; }

                    /// <summary>
                    /// The configurations of clip merging. Up to four clips can be merged.
                    /// </summary>
                    [NameInMap("MergeList")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputMergeList MergeList { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputMergeList : TeaModel {
                        [NameInMap("Merge")]
                        [Validation(Required=false)]
                        public List<QueryJobListResponseBodyJobListJobOutputMergeListMerge> Merge { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputMergeListMerge : TeaModel {
                            /// <summary>
                            /// The duration of the clip.
                            /// 
                            /// *   Format: `hh:mm:ss[.SSS]` or `sssss[.SSS]`.
                            /// *   Examples: 01:59:59.999 and 32000.23.
                            /// </summary>
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            /// <summary>
                            /// The OSS URL of the clip.
                            /// 
                            /// *   Example: `http://example-bucket-.oss-cn-hangzhou.aliyuncs.com/example-object.flv`.
                            /// *   The object must be URL-encoded by using the UTF-8 standard. For more information, see [URL encoding](https://help.aliyun.com/document_detail/423796.html).
                            /// </summary>
                            [NameInMap("MergeURL")]
                            [Validation(Required=false)]
                            public string MergeURL { get; set; }

                            /// <summary>
                            /// The Alibaba Cloud Resource Name (ARN) of the Resource Access Management (RAM) role used for delegated authorization.
                            /// </summary>
                            [NameInMap("RoleArn")]
                            [Validation(Required=false)]
                            public string RoleArn { get; set; }

                            /// <summary>
                            /// The start point in time of the clip.
                            /// 
                            /// *   Format: `hh:mm:ss[.SSS]` or `sssss[.SSS]`.
                            /// *   Examples: 01:59:59.999 and 32000.23.
                            /// </summary>
                            [NameInMap("Start")]
                            [Validation(Required=false)]
                            public string Start { get; set; }

                        }

                    }

                    /// <summary>
                    /// The information about the high-speed transcoding job. This information is available only for jobs that are submitted by using an MPS queue for high-speed transcoding. This does not support MPS queues for high-speed transcoding of an earlier version.
                    /// </summary>
                    [NameInMap("MultiSpeedInfo")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputMultiSpeedInfo MultiSpeedInfo { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputMultiSpeedInfo : TeaModel {
                        /// <summary>
                        /// The error code returned if high-speed transcoding is not enabled.
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// The downgrade policy if high-speed transcoding is not supported.
                        /// </summary>
                        [NameInMap("DowngradePolicy")]
                        [Validation(Required=false)]
                        public string DowngradePolicy { get; set; }

                        /// <summary>
                        /// The duration of the output video.
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public double? Duration { get; set; }

                        /// <summary>
                        /// Indicates whether high-speed transcoding is enabled.
                        /// </summary>
                        [NameInMap("Enable")]
                        [Validation(Required=false)]
                        public string Enable { get; set; }

                        /// <summary>
                        /// The error message returned if high-speed transcoding is not enabled.
                        /// </summary>
                        [NameInMap("Message")]
                        [Validation(Required=false)]
                        public string Message { get; set; }

                        /// <summary>
                        /// The actual transcoding speed.
                        /// </summary>
                        [NameInMap("RealSpeed")]
                        [Validation(Required=false)]
                        public double? RealSpeed { get; set; }

                        /// <summary>
                        /// The speed setting.
                        /// </summary>
                        [NameInMap("SettingSpeed")]
                        [Validation(Required=false)]
                        public int? SettingSpeed { get; set; }

                        /// <summary>
                        /// The amount of time consumed.
                        /// </summary>
                        [NameInMap("TimeCost")]
                        [Validation(Required=false)]
                        public double? TimeCost { get; set; }

                    }

                    /// <summary>
                    /// The transmuxing configurations. The transmuxing configurations. If this parameter is specified in the request, the corresponding parameters in the specified transcoding template are overwritten.
                    /// </summary>
                    [NameInMap("MuxConfig")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputMuxConfig MuxConfig { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputMuxConfig : TeaModel {
                        /// <summary>
                        /// The transmuxing configurations for GIF.
                        /// </summary>
                        [NameInMap("Gif")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputMuxConfigGif Gif { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputMuxConfigGif : TeaModel {
                            /// <summary>
                            /// The color dithering algorithm of the palette. Valid values: sierra and bayer.
                            /// </summary>
                            [NameInMap("DitherMode")]
                            [Validation(Required=false)]
                            public string DitherMode { get; set; }

                            /// <summary>
                            /// The duration for which the final frame is paused. Unit: centisecond.
                            /// </summary>
                            [NameInMap("FinalDelay")]
                            [Validation(Required=false)]
                            public string FinalDelay { get; set; }

                            /// <summary>
                            /// Indicates whether a custom palette is used. Valid values:
                            /// 
                            /// *   **true**
                            /// *   **false**
                            /// </summary>
                            [NameInMap("IsCustomPalette")]
                            [Validation(Required=false)]
                            public string IsCustomPalette { get; set; }

                            /// <summary>
                            /// The loop count.
                            /// </summary>
                            [NameInMap("Loop")]
                            [Validation(Required=false)]
                            public string Loop { get; set; }

                        }

                        /// <summary>
                        /// The segment configurations. The value is a JSON object.
                        /// </summary>
                        [NameInMap("Segment")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputMuxConfigSegment Segment { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputMuxConfigSegment : TeaModel {
                            /// <summary>
                            /// The segment length. Unit: seconds.
                            /// </summary>
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                        }

                        /// <summary>
                        /// The transmuxing configurations for WebP.
                        /// </summary>
                        [NameInMap("Webp")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputMuxConfigWebp Webp { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputMuxConfigWebp : TeaModel {
                            /// <summary>
                            /// The loop count.
                            /// </summary>
                            [NameInMap("Loop")]
                            [Validation(Required=false)]
                            public string Loop { get; set; }

                        }

                    }

                    /// <summary>
                    /// The opening parts. The value is a JSON object.
                    /// </summary>
                    [NameInMap("OpeningList")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputOpeningList OpeningList { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputOpeningList : TeaModel {
                        [NameInMap("Opening")]
                        [Validation(Required=false)]
                        public List<QueryJobListResponseBodyJobListJobOutputOpeningListOpening> Opening { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputOpeningListOpening : TeaModel {
                            /// <summary>
                            /// The height of the opening part.
                            /// 
                            /// *   Valid values: values in the range of (0,4096), -1, and full.
                            /// *   A value of -1 indicates that the original height of the opening part is retained.
                            /// *   A value of full indicates that the height of the opening part equals the height of the main part.
                            /// *   Default value: **-1**.
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            /// <summary>
                            /// The amount of time after which the opening part is played.
                            /// 
                            /// *   The value starts from 0.
                            /// *   Unit: seconds.
                            /// *   Default value: **0**.
                            /// </summary>
                            [NameInMap("Start")]
                            [Validation(Required=false)]
                            public string Start { get; set; }

                            /// <summary>
                            /// The width of the opening part.
                            /// 
                            /// *   Valid values: values in the range of (0,4096), -1, and full.
                            /// *   A value of -1 indicates that the original width of the opening part is retained.
                            /// *   A value of full indicates that the width of the opening part equals the width of the main part.
                            /// *   Default value: **-1**.
                            /// </summary>
                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                            /// <summary>
                            /// The OSS URL of the opening part.
                            /// </summary>
                            [NameInMap("openUrl")]
                            [Validation(Required=false)]
                            public string OpenUrl { get; set; }

                        }

                    }

                    /// <summary>
                    /// The output captions.
                    /// </summary>
                    [NameInMap("OutSubtitleList")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputOutSubtitleList OutSubtitleList { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputOutSubtitleList : TeaModel {
                        [NameInMap("OutSubtitle")]
                        [Validation(Required=false)]
                        public List<QueryJobListResponseBodyJobListJobOutputOutSubtitleListOutSubtitle> OutSubtitle { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputOutSubtitleListOutSubtitle : TeaModel {
                            /// <summary>
                            /// The video track. Format: `0:{Stream}:{Stream sequence number}`, which is `0:v:{video_index}`. The value of Stream is v, which indicates a video stream. The sequence number is the index of the video stream in the list and starts from 0.
                            /// </summary>
                            [NameInMap("Map")]
                            [Validation(Required=false)]
                            public string Map { get; set; }

                            /// <summary>
                            /// The error message returned if the job failed to be created. This parameter is not returned if the job was created.
                            /// </summary>
                            [NameInMap("Message")]
                            [Validation(Required=false)]
                            public string Message { get; set; }

                            /// <summary>
                            /// The details of the output caption.
                            /// </summary>
                            [NameInMap("OutSubtitleFile")]
                            [Validation(Required=false)]
                            public QueryJobListResponseBodyJobListJobOutputOutSubtitleListOutSubtitleOutSubtitleFile OutSubtitleFile { get; set; }
                            public class QueryJobListResponseBodyJobListJobOutputOutSubtitleListOutSubtitleOutSubtitleFile : TeaModel {
                                /// <summary>
                                /// The name of the OSS bucket in which the output caption is stored.
                                /// </summary>
                                [NameInMap("Bucket")]
                                [Validation(Required=false)]
                                public string Bucket { get; set; }

                                /// <summary>
                                /// The OSS region in which the output caption resides.
                                /// </summary>
                                [NameInMap("Location")]
                                [Validation(Required=false)]
                                public string Location { get; set; }

                                /// <summary>
                                /// The name of the OSS object that is used as the output caption.
                                /// </summary>
                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                                /// <summary>
                                /// The ARN of the RAM role used for delegated authorization.
                                /// </summary>
                                [NameInMap("RoleArn")]
                                [Validation(Required=false)]
                                public string RoleArn { get; set; }

                            }

                            /// <summary>
                            /// Indicates whether the job was successful. Valid values:
                            /// 
                            /// *   **true**: The job was successful.
                            /// *   **false**: The job failed.
                            /// </summary>
                            [NameInMap("Success")]
                            [Validation(Required=false)]
                            public bool? Success { get; set; }

                        }

                    }

                    /// <summary>
                    /// The details of the output file.
                    /// </summary>
                    [NameInMap("OutputFile")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputOutputFile OutputFile { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputOutputFile : TeaModel {
                        /// <summary>
                        /// The name of the OSS bucket in which the output file is stored.
                        /// </summary>
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }

                        /// <summary>
                        /// The OSS region in which the output file resides.
                        /// </summary>
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                        /// <summary>
                        /// The name of the OSS object that is used as the output file.
                        /// </summary>
                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }

                        /// <summary>
                        /// The ARN of the RAM role used for delegated authorization.
                        /// </summary>
                        [NameInMap("RoleArn")]
                        [Validation(Required=false)]
                        public string RoleArn { get; set; }

                    }

                    /// <summary>
                    /// The priority of the job in the ApsaraVideo Media Processing (MPS) queue to which the job is added.
                    /// 
                    /// *   A value of 10 indicates the highest priority.
                    /// *   Default value: **6**.
                    /// </summary>
                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public string Priority { get; set; }

                    /// <summary>
                    /// The media properties.
                    /// </summary>
                    [NameInMap("Properties")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputProperties Properties { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputProperties : TeaModel {
                        /// <summary>
                        /// The video bitrate.
                        /// </summary>
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        /// <summary>
                        /// The video duration.
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        /// <summary>
                        /// The video format.
                        /// </summary>
                        [NameInMap("FileFormat")]
                        [Validation(Required=false)]
                        public string FileFormat { get; set; }

                        /// <summary>
                        /// The size of the media file.
                        /// </summary>
                        [NameInMap("FileSize")]
                        [Validation(Required=false)]
                        public string FileSize { get; set; }

                        /// <summary>
                        /// The format information.
                        /// </summary>
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputPropertiesFormat Format { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputPropertiesFormat : TeaModel {
                            /// <summary>
                            /// The total bitrate.
                            /// </summary>
                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            /// <summary>
                            /// The total duration.
                            /// </summary>
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            /// <summary>
                            /// The full name of the container format.
                            /// </summary>
                            [NameInMap("FormatLongName")]
                            [Validation(Required=false)]
                            public string FormatLongName { get; set; }

                            /// <summary>
                            /// The short name of the container format. Valid values: mov, mp4, m4a, 3gp, 3g2, and mj2.
                            /// </summary>
                            [NameInMap("FormatName")]
                            [Validation(Required=false)]
                            public string FormatName { get; set; }

                            /// <summary>
                            /// The total number of program streams.
                            /// </summary>
                            [NameInMap("NumPrograms")]
                            [Validation(Required=false)]
                            public string NumPrograms { get; set; }

                            /// <summary>
                            /// The total number of media streams.
                            /// </summary>
                            [NameInMap("NumStreams")]
                            [Validation(Required=false)]
                            public string NumStreams { get; set; }

                            /// <summary>
                            /// The size of the media file.
                            /// </summary>
                            [NameInMap("Size")]
                            [Validation(Required=false)]
                            public string Size { get; set; }

                            /// <summary>
                            /// The start time.
                            /// </summary>
                            [NameInMap("StartTime")]
                            [Validation(Required=false)]
                            public string StartTime { get; set; }

                        }

                        /// <summary>
                        /// The frame rate of the video.
                        /// </summary>
                        [NameInMap("Fps")]
                        [Validation(Required=false)]
                        public string Fps { get; set; }

                        /// <summary>
                        /// The video height.
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        /// <summary>
                        /// The non-engine layer keywords.
                        /// </summary>
                        [NameInMap("SourceLogos")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputPropertiesSourceLogos SourceLogos { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputPropertiesSourceLogos : TeaModel {
                            [NameInMap("SourceLogo")]
                            [Validation(Required=false)]
                            public List<QueryJobListResponseBodyJobListJobOutputPropertiesSourceLogosSourceLogo> SourceLogo { get; set; }
                            public class QueryJobListResponseBodyJobListJobOutputPropertiesSourceLogosSourceLogo : TeaModel {
                                /// <summary>
                                /// The keyword.
                                /// </summary>
                                [NameInMap("Source")]
                                [Validation(Required=false)]
                                public string Source { get; set; }

                            }

                        }

                        /// <summary>
                        /// The stream information.
                        /// </summary>
                        [NameInMap("Streams")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputPropertiesStreams Streams { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputPropertiesStreams : TeaModel {
                            /// <summary>
                            /// The audio streams.
                            /// </summary>
                            [NameInMap("AudioStreamList")]
                            [Validation(Required=false)]
                            public QueryJobListResponseBodyJobListJobOutputPropertiesStreamsAudioStreamList AudioStreamList { get; set; }
                            public class QueryJobListResponseBodyJobListJobOutputPropertiesStreamsAudioStreamList : TeaModel {
                                [NameInMap("AudioStream")]
                                [Validation(Required=false)]
                                public List<QueryJobListResponseBodyJobListJobOutputPropertiesStreamsAudioStreamListAudioStream> AudioStream { get; set; }
                                public class QueryJobListResponseBodyJobListJobOutputPropertiesStreamsAudioStreamListAudioStream : TeaModel {
                                    /// <summary>
                                    /// The bitrate of the audio stream.
                                    /// </summary>
                                    [NameInMap("Bitrate")]
                                    [Validation(Required=false)]
                                    public string Bitrate { get; set; }

                                    /// <summary>
                                    /// The output layout of the sound channels.
                                    /// </summary>
                                    [NameInMap("ChannelLayout")]
                                    [Validation(Required=false)]
                                    public string ChannelLayout { get; set; }

                                    /// <summary>
                                    /// The number of sound channels.
                                    /// </summary>
                                    [NameInMap("Channels")]
                                    [Validation(Required=false)]
                                    public string Channels { get; set; }

                                    /// <summary>
                                    /// The full name of the codec.
                                    /// </summary>
                                    [NameInMap("CodecLongName")]
                                    [Validation(Required=false)]
                                    public string CodecLongName { get; set; }

                                    /// <summary>
                                    /// The short name of the codec.
                                    /// </summary>
                                    [NameInMap("CodecName")]
                                    [Validation(Required=false)]
                                    public string CodecName { get; set; }

                                    /// <summary>
                                    /// The tag of the codec.
                                    /// </summary>
                                    [NameInMap("CodecTag")]
                                    [Validation(Required=false)]
                                    public string CodecTag { get; set; }

                                    /// <summary>
                                    /// The tag string of the codec.
                                    /// </summary>
                                    [NameInMap("CodecTagString")]
                                    [Validation(Required=false)]
                                    public string CodecTagString { get; set; }

                                    /// <summary>
                                    /// The codec time base.
                                    /// </summary>
                                    [NameInMap("CodecTimeBase")]
                                    [Validation(Required=false)]
                                    public string CodecTimeBase { get; set; }

                                    /// <summary>
                                    /// The duration of the audio stream.
                                    /// </summary>
                                    [NameInMap("Duration")]
                                    [Validation(Required=false)]
                                    public string Duration { get; set; }

                                    /// <summary>
                                    /// The sequence number of the audio stream. The value indicates the position of the audio stream in all audio streams.
                                    /// </summary>
                                    [NameInMap("Index")]
                                    [Validation(Required=false)]
                                    public string Index { get; set; }

                                    /// <summary>
                                    /// The language of the audio stream. For more information, see [FFmpeg documentation](https://www.ffmpeg.org/ffmpeg-all.html#Metadata) and [ISO 639](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes).
                                    /// </summary>
                                    [NameInMap("Lang")]
                                    [Validation(Required=false)]
                                    public string Lang { get; set; }

                                    /// <summary>
                                    /// The total number of frames.
                                    /// </summary>
                                    [NameInMap("NumFrames")]
                                    [Validation(Required=false)]
                                    public string NumFrames { get; set; }

                                    /// <summary>
                                    /// The sampling format.
                                    /// </summary>
                                    [NameInMap("SampleFmt")]
                                    [Validation(Required=false)]
                                    public string SampleFmt { get; set; }

                                    /// <summary>
                                    /// The sampling rate.
                                    /// </summary>
                                    [NameInMap("Samplerate")]
                                    [Validation(Required=false)]
                                    public string Samplerate { get; set; }

                                    /// <summary>
                                    /// The start time.
                                    /// </summary>
                                    [NameInMap("StartTime")]
                                    [Validation(Required=false)]
                                    public string StartTime { get; set; }

                                    /// <summary>
                                    /// The time base of the audio stream.
                                    /// </summary>
                                    [NameInMap("Timebase")]
                                    [Validation(Required=false)]
                                    public string Timebase { get; set; }

                                }

                            }

                            /// <summary>
                            /// The caption streams.
                            /// </summary>
                            [NameInMap("SubtitleStreamList")]
                            [Validation(Required=false)]
                            public QueryJobListResponseBodyJobListJobOutputPropertiesStreamsSubtitleStreamList SubtitleStreamList { get; set; }
                            public class QueryJobListResponseBodyJobListJobOutputPropertiesStreamsSubtitleStreamList : TeaModel {
                                [NameInMap("SubtitleStream")]
                                [Validation(Required=false)]
                                public List<QueryJobListResponseBodyJobListJobOutputPropertiesStreamsSubtitleStreamListSubtitleStream> SubtitleStream { get; set; }
                                public class QueryJobListResponseBodyJobListJobOutputPropertiesStreamsSubtitleStreamListSubtitleStream : TeaModel {
                                    /// <summary>
                                    /// The sequence number of the caption stream. The value indicates the position of the caption stream in all caption streams.
                                    /// </summary>
                                    [NameInMap("Index")]
                                    [Validation(Required=false)]
                                    public string Index { get; set; }

                                    /// <summary>
                                    /// The language of the caption stream. For more information, see [FFmpeg documentation](https://www.ffmpeg.org/ffmpeg-all.html#Metadata) and [ISO 639](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes).
                                    /// </summary>
                                    [NameInMap("Lang")]
                                    [Validation(Required=false)]
                                    public string Lang { get; set; }

                                }

                            }

                            /// <summary>
                            /// The video streams.
                            /// </summary>
                            [NameInMap("VideoStreamList")]
                            [Validation(Required=false)]
                            public QueryJobListResponseBodyJobListJobOutputPropertiesStreamsVideoStreamList VideoStreamList { get; set; }
                            public class QueryJobListResponseBodyJobListJobOutputPropertiesStreamsVideoStreamList : TeaModel {
                                [NameInMap("VideoStream")]
                                [Validation(Required=false)]
                                public List<QueryJobListResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                                public class QueryJobListResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStream : TeaModel {
                                    /// <summary>
                                    /// The average frame rate of the video stream.
                                    /// </summary>
                                    [NameInMap("AvgFPS")]
                                    [Validation(Required=false)]
                                    public string AvgFPS { get; set; }

                                    /// <summary>
                                    /// The video bitrate.
                                    /// </summary>
                                    [NameInMap("Bitrate")]
                                    [Validation(Required=false)]
                                    public string Bitrate { get; set; }

                                    /// <summary>
                                    /// The full name of the codec.
                                    /// </summary>
                                    [NameInMap("CodecLongName")]
                                    [Validation(Required=false)]
                                    public string CodecLongName { get; set; }

                                    /// <summary>
                                    /// The short name of the codec.
                                    /// </summary>
                                    [NameInMap("CodecName")]
                                    [Validation(Required=false)]
                                    public string CodecName { get; set; }

                                    /// <summary>
                                    /// The tag of the codec.
                                    /// </summary>
                                    [NameInMap("CodecTag")]
                                    [Validation(Required=false)]
                                    public string CodecTag { get; set; }

                                    /// <summary>
                                    /// The tag string of the codec.
                                    /// </summary>
                                    [NameInMap("CodecTagString")]
                                    [Validation(Required=false)]
                                    public string CodecTagString { get; set; }

                                    /// <summary>
                                    /// The codec time base.
                                    /// </summary>
                                    [NameInMap("CodecTimeBase")]
                                    [Validation(Required=false)]
                                    public string CodecTimeBase { get; set; }

                                    /// <summary>
                                    /// The display aspect ratio (DAR) of the video stream.
                                    /// </summary>
                                    [NameInMap("Dar")]
                                    [Validation(Required=false)]
                                    public string Dar { get; set; }

                                    /// <summary>
                                    /// The duration of the video stream.
                                    /// </summary>
                                    [NameInMap("Duration")]
                                    [Validation(Required=false)]
                                    public string Duration { get; set; }

                                    /// <summary>
                                    /// The frame rate of the video stream.
                                    /// </summary>
                                    [NameInMap("Fps")]
                                    [Validation(Required=false)]
                                    public string Fps { get; set; }

                                    /// <summary>
                                    /// Indicates whether the video stream contains bidirectional frames (B-frames).
                                    /// </summary>
                                    [NameInMap("HasBFrames")]
                                    [Validation(Required=false)]
                                    public string HasBFrames { get; set; }

                                    /// <summary>
                                    /// The height of the video stream in pixels.
                                    /// </summary>
                                    [NameInMap("Height")]
                                    [Validation(Required=false)]
                                    public string Height { get; set; }

                                    /// <summary>
                                    /// The sequence number of the video stream. The value indicates the position of the video stream in all video streams.
                                    /// </summary>
                                    [NameInMap("Index")]
                                    [Validation(Required=false)]
                                    public string Index { get; set; }

                                    /// <summary>
                                    /// The language of the video stream. For more information, see [FFmpeg documentation](https://www.ffmpeg.org/ffmpeg-all.html#Metadata) and [ISO 639](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes).
                                    /// </summary>
                                    [NameInMap("Lang")]
                                    [Validation(Required=false)]
                                    public string Lang { get; set; }

                                    /// <summary>
                                    /// The codec level.
                                    /// </summary>
                                    [NameInMap("Level")]
                                    [Validation(Required=false)]
                                    public string Level { get; set; }

                                    /// <summary>
                                    /// The network bandwidth that was consumed.
                                    /// </summary>
                                    [NameInMap("NetworkCost")]
                                    [Validation(Required=false)]
                                    public QueryJobListResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                                    public class QueryJobListResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
                                        /// <summary>
                                        /// The average bitrate.
                                        /// </summary>
                                        [NameInMap("AvgBitrate")]
                                        [Validation(Required=false)]
                                        public string AvgBitrate { get; set; }

                                        /// <summary>
                                        /// The maximum bandwidth that was consumed.
                                        /// </summary>
                                        [NameInMap("CostBandwidth")]
                                        [Validation(Required=false)]
                                        public string CostBandwidth { get; set; }

                                        /// <summary>
                                        /// The amount of time consumed to preload the video stream.
                                        /// </summary>
                                        [NameInMap("PreloadTime")]
                                        [Validation(Required=false)]
                                        public string PreloadTime { get; set; }

                                    }

                                    /// <summary>
                                    /// The total number of frames.
                                    /// </summary>
                                    [NameInMap("NumFrames")]
                                    [Validation(Required=false)]
                                    public string NumFrames { get; set; }

                                    /// <summary>
                                    /// The pixel format of the video stream.
                                    /// </summary>
                                    [NameInMap("PixFmt")]
                                    [Validation(Required=false)]
                                    public string PixFmt { get; set; }

                                    /// <summary>
                                    /// The codec profile.
                                    /// </summary>
                                    [NameInMap("Profile")]
                                    [Validation(Required=false)]
                                    public string Profile { get; set; }

                                    /// <summary>
                                    /// The sample aspect ratio (SAR) of the video stream.
                                    /// </summary>
                                    [NameInMap("Sar")]
                                    [Validation(Required=false)]
                                    public string Sar { get; set; }

                                    /// <summary>
                                    /// The start time.
                                    /// </summary>
                                    [NameInMap("StartTime")]
                                    [Validation(Required=false)]
                                    public string StartTime { get; set; }

                                    /// <summary>
                                    /// The time base of the video stream.
                                    /// </summary>
                                    [NameInMap("Timebase")]
                                    [Validation(Required=false)]
                                    public string Timebase { get; set; }

                                    /// <summary>
                                    /// The width of the video stream in pixels.
                                    /// </summary>
                                    [NameInMap("Width")]
                                    [Validation(Required=false)]
                                    public string Width { get; set; }

                                    /// <summary>
                                    /// The number of binary bits used by each sample or pixel.
                                    /// </summary>
                                    [NameInMap("bitsPerRawSample")]
                                    [Validation(Required=false)]
                                    public string BitsPerRawSample { get; set; }

                                    /// <summary>
                                    /// The primary colors.
                                    /// </summary>
                                    [NameInMap("colorPrimaries")]
                                    [Validation(Required=false)]
                                    public string ColorPrimaries { get; set; }

                                    /// <summary>
                                    /// The color transfer configuration.
                                    /// </summary>
                                    [NameInMap("colorTransfer")]
                                    [Validation(Required=false)]
                                    public string ColorTransfer { get; set; }

                                }

                            }

                        }

                        /// <summary>
                        /// The video width.
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                    }

                    /// <summary>
                    /// The rotation angle of the video.
                    /// </summary>
                    [NameInMap("Rotate")]
                    [Validation(Required=false)]
                    public string Rotate { get; set; }

                    /// <summary>
                    /// The caption configurations.
                    /// </summary>
                    [NameInMap("SubtitleConfig")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputSubtitleConfig SubtitleConfig { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputSubtitleConfig : TeaModel {
                        /// <summary>
                        /// The external captions.
                        /// </summary>
                        [NameInMap("ExtSubtitleList")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputSubtitleConfigExtSubtitleList ExtSubtitleList { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputSubtitleConfigExtSubtitleList : TeaModel {
                            [NameInMap("ExtSubtitle")]
                            [Validation(Required=false)]
                            public List<QueryJobListResponseBodyJobListJobOutputSubtitleConfigExtSubtitleListExtSubtitle> ExtSubtitle { get; set; }
                            public class QueryJobListResponseBodyJobListJobOutputSubtitleConfigExtSubtitleListExtSubtitle : TeaModel {
                                /// <summary>
                                /// The character set used by the external caption.
                                /// 
                                /// *   Valid values: UTF-8, GBK, BIG5, and auto.
                                /// *   Default value: **auto**.
                                /// 
                                /// >  If the value of CharEnc is auto, the detected character set may not be the actual character set. We recommend that you set this parameter to another value.
                                /// </summary>
                                [NameInMap("CharEnc")]
                                [Validation(Required=false)]
                                public string CharEnc { get; set; }

                                /// <summary>
                                /// The font of the hardcoded captions converted from external captions. Default value: SimSum. For more information, see [Fonts](https://help.aliyun.com/document_detail/59950.html).
                                /// </summary>
                                [NameInMap("FontName")]
                                [Validation(Required=false)]
                                public string FontName { get; set; }

                                /// <summary>
                                /// The input caption file.
                                /// 
                                /// *   SRT and ASS files are supported. For more information, see the Input section of the [Parameter details](https://help.aliyun.com/document_detail/29253.html) topic.
                                /// *   Example: `{"Bucket":"example-bucket","Location":"oss-cn-hangzhou","Object":"example.srt"}`.
                                /// </summary>
                                [NameInMap("Input")]
                                [Validation(Required=false)]
                                public QueryJobListResponseBodyJobListJobOutputSubtitleConfigExtSubtitleListExtSubtitleInput Input { get; set; }
                                public class QueryJobListResponseBodyJobListJobOutputSubtitleConfigExtSubtitleListExtSubtitleInput : TeaModel {
                                    /// <summary>
                                    /// The name of the OSS bucket in which the input caption file is stored.
                                    /// </summary>
                                    [NameInMap("Bucket")]
                                    [Validation(Required=false)]
                                    public string Bucket { get; set; }

                                    /// <summary>
                                    /// The OSS region in which the input caption file resides.
                                    /// </summary>
                                    [NameInMap("Location")]
                                    [Validation(Required=false)]
                                    public string Location { get; set; }

                                    /// <summary>
                                    /// The name of the OSS object that is used as the input caption file.
                                    /// </summary>
                                    [NameInMap("Object")]
                                    [Validation(Required=false)]
                                    public string Object { get; set; }

                                }

                            }

                        }

                        /// <summary>
                        /// The captions.
                        /// </summary>
                        [NameInMap("SubtitleList")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputSubtitleConfigSubtitleList SubtitleList { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputSubtitleConfigSubtitleList : TeaModel {
                            [NameInMap("Subtitle")]
                            [Validation(Required=false)]
                            public List<QueryJobListResponseBodyJobListJobOutputSubtitleConfigSubtitleListSubtitle> Subtitle { get; set; }
                            public class QueryJobListResponseBodyJobListJobOutputSubtitleConfigSubtitleListSubtitle : TeaModel {
                                /// <summary>
                                /// The audio track. Format: `0:{Stream}:{Stream sequence number}`, which is `0:a:{audio_index}`. The value of Stream is a, which indicates an audio stream. The sequence number is the index of the audio stream in the list and starts from 0.
                                /// </summary>
                                [NameInMap("Map")]
                                [Validation(Required=false)]
                                public string Map { get; set; }

                            }

                        }

                    }

                    /// <summary>
                    /// The configurations for using the resolution of the source video.
                    /// </summary>
                    [NameInMap("SuperReso")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputSuperReso SuperReso { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputSuperReso : TeaModel {
                        /// <summary>
                        /// Indicates whether parameters related to the sampling rate are obtained. Valid values:
                        /// 
                        /// *   **true**
                        /// *   **false**
                        /// </summary>
                        [NameInMap("IsHalfSample")]
                        [Validation(Required=false)]
                        public string IsHalfSample { get; set; }

                    }

                    /// <summary>
                    /// The ending parts.
                    /// </summary>
                    [NameInMap("TailSlateList")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputTailSlateList TailSlateList { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputTailSlateList : TeaModel {
                        [NameInMap("TailSlate")]
                        [Validation(Required=false)]
                        public List<QueryJobListResponseBodyJobListJobOutputTailSlateListTailSlate> TailSlate { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputTailSlateListTailSlate : TeaModel {
                            /// <summary>
                            /// The color of the bars that are added to the ending part if the size of the ending part is smaller than that of the main part. Default value: White. For more information, see [Parameter details](https://help.aliyun.com/document_detail/29253.html).
                            /// </summary>
                            [NameInMap("BgColor")]
                            [Validation(Required=false)]
                            public string BgColor { get; set; }

                            /// <summary>
                            /// The duration of the transition between the main part and the ending part. A fade transition is used: The last frame of the main part fades out, and the first frame of the ending part fades in. Unit: seconds. Default value: 0.
                            /// </summary>
                            [NameInMap("BlendDuration")]
                            [Validation(Required=false)]
                            public string BlendDuration { get; set; }

                            /// <summary>
                            /// The height of the ending part.
                            /// 
                            /// *   Valid values: values in the range of (0,4096), -1, and full.
                            /// *   A value of -1 indicates that the original height of the ending part is retained.
                            /// *   A value of full indicates that the height of the ending part equals the height of the main part.
                            /// *   Default value: -1.
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            /// <summary>
                            /// Indicates whether the audio content of the ending part is merged. Valid values:
                            /// 
                            /// *   **true**
                            /// *   **false**
                            /// </summary>
                            [NameInMap("IsMergeAudio")]
                            [Validation(Required=false)]
                            public bool? IsMergeAudio { get; set; }

                            /// <summary>
                            /// The time when the ending part is played.
                            /// </summary>
                            [NameInMap("Start")]
                            [Validation(Required=false)]
                            public string Start { get; set; }

                            /// <summary>
                            /// The OSS URL of the ending part.
                            /// </summary>
                            [NameInMap("TailUrl")]
                            [Validation(Required=false)]
                            public string TailUrl { get; set; }

                            /// <summary>
                            /// The width of the ending part. Valid values: values in the range of (0,4096), -1, and full.
                            /// 
                            /// *   A value of -1 indicates that the original width of the ending part is retained.
                            /// *   A value of full indicates that the width of the ending part equals the width of the main part.
                            /// *   Default value: -1.
                            /// </summary>
                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                        }

                    }

                    /// <summary>
                    /// The template ID.
                    /// </summary>
                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                    /// <summary>
                    /// The general transcoding configurations.
                    /// 
                    /// >  If this parameter is specified in the request, the corresponding parameters in the specified transcoding template are overwritten.
                    /// </summary>
                    [NameInMap("TransConfig")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputTransConfig TransConfig { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputTransConfig : TeaModel {
                        /// <summary>
                        /// The method of resolution adjustment. Default value: **none**. Valid values: rescale, crop, pad, and none.
                        /// </summary>
                        [NameInMap("AdjDarMethod")]
                        [Validation(Required=false)]
                        public string AdjDarMethod { get; set; }

                        /// <summary>
                        /// Indicates whether the audio bitrate is checked. If the bitrate of the output audio is higher than that of the input audio, the input bitrate is retained and the specified audio bitrate does not take effect. This parameter has a lower priority than IsCheckAudioBitrateFail. Valid values:
                        /// 
                        /// *   **true**
                        /// 
                        /// *   **false**
                        /// 
                        /// *   Default value:
                        /// 
                        ///     *   If this parameter is empty and the codec of the output audio is different from that of the input audio, the default value is false.
                        ///     *   If this parameter is empty and the codec of the output audio is the same as that of the input audio, the default value is true.
                        /// </summary>
                        [NameInMap("IsCheckAudioBitrate")]
                        [Validation(Required=false)]
                        public string IsCheckAudioBitrate { get; set; }

                        /// <summary>
                        /// Indicates whether the audio bitrate is checked. If the bitrate of the output audio is higher than that of the input audio, the input audio is not transcoded and a transcoding failure is returned. This parameter has a higher priority than IsCheckAudioBitrate. Valid values:
                        /// 
                        /// *   **true**
                        /// *   **false**
                        /// *   Default value: **false**.
                        /// </summary>
                        [NameInMap("IsCheckAudioBitrateFail")]
                        [Validation(Required=false)]
                        public string IsCheckAudioBitrateFail { get; set; }

                        /// <summary>
                        /// Indicates whether the resolution is checked. If the output resolution is higher than the input resolution based on the width or height, the input resolution is retained. Valid values:
                        /// 
                        /// *   **true**:
                        /// *   **false**
                        /// *   Default value: **false**.
                        /// </summary>
                        [NameInMap("IsCheckReso")]
                        [Validation(Required=false)]
                        public string IsCheckReso { get; set; }

                        /// <summary>
                        /// Indicates whether the resolution is checked. If the output resolution is higher than the input resolution based on the width or height, a transcoding failure is returned. Valid values:
                        /// 
                        /// *   **true**
                        /// *   **false**
                        /// *   Default value: **false**.
                        /// </summary>
                        [NameInMap("IsCheckResoFail")]
                        [Validation(Required=false)]
                        public string IsCheckResoFail { get; set; }

                        /// <summary>
                        /// Indicates whether the video bitrate is checked. If the bitrate of the output video is higher than that of the input video, the input bitrate is retained. Valid values:
                        /// 
                        /// *   **true**
                        /// *   **false**
                        /// *   Default value: **false**.
                        /// </summary>
                        [NameInMap("IsCheckVideoBitrate")]
                        [Validation(Required=false)]
                        public string IsCheckVideoBitrate { get; set; }

                        /// <summary>
                        /// Indicates whether the video bitrate is checked. If the bitrate of the output video is higher than that of the input video, the input video is not transcoded and a transcoding failure is returned. This parameter has a higher priority than IsCheckVideoBitrate. Valid values:
                        /// 
                        /// *   **true**
                        /// *   **false**
                        /// *   Default value: **false**.
                        /// </summary>
                        [NameInMap("IsCheckVideoBitrateFail")]
                        [Validation(Required=false)]
                        public string IsCheckVideoBitrateFail { get; set; }

                        /// <summary>
                        /// The transcoding mode.
                        /// 
                        /// *   Valid values: onepass, twopass, and CBR.
                        /// *   Default value: **onepass**.
                        /// </summary>
                        [NameInMap("TransMode")]
                        [Validation(Required=false)]
                        public string TransMode { get; set; }

                    }

                    /// <summary>
                    /// The custom data.
                    /// </summary>
                    [NameInMap("UserData")]
                    [Validation(Required=false)]
                    public string UserData { get; set; }

                    /// <summary>
                    /// The video configurations.
                    /// </summary>
                    [NameInMap("Video")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputVideo Video { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputVideo : TeaModel {
                        /// <summary>
                        /// The average bitrate of the video. Unit: Kbit/s.
                        /// </summary>
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        /// <summary>
                        /// The average bitrate range of the video.
                        /// </summary>
                        [NameInMap("BitrateBnd")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputVideoBitrateBnd BitrateBnd { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputVideoBitrateBnd : TeaModel {
                            /// <summary>
                            /// The maximum bitrate.
                            /// </summary>
                            [NameInMap("Max")]
                            [Validation(Required=false)]
                            public string Max { get; set; }

                            /// <summary>
                            /// The minimum bitrate.
                            /// </summary>
                            [NameInMap("Min")]
                            [Validation(Required=false)]
                            public string Min { get; set; }

                        }

                        /// <summary>
                        /// The buffer size.
                        /// 
                        /// *   Unit: KB.
                        /// *   Default value: **6000**.
                        /// </summary>
                        [NameInMap("Bufsize")]
                        [Validation(Required=false)]
                        public string Bufsize { get; set; }

                        /// <summary>
                        /// The video codec.
                        /// 
                        /// *   Valid values: H.264 and H.265.
                        /// *   Default value: H.264.
                        /// </summary>
                        [NameInMap("Codec")]
                        [Validation(Required=false)]
                        public string Codec { get; set; }

                        /// <summary>
                        /// The constant rate factor.
                        /// 
                        /// *   Default value when the value of Codec is H.264: **23**, default value when the value of Codec is H.265: **26**.
                        /// *   If the value of this parameter is returned, the value of Bitrate becomes invalid.
                        /// </summary>
                        [NameInMap("Crf")]
                        [Validation(Required=false)]
                        public string Crf { get; set; }

                        /// <summary>
                        /// The method of video cropping. Valid values:
                        /// 
                        /// *   **border**: automatically detects and removes borders.
                        /// *   A value in the width:height:left:top format: The video image is cropped based on custom settings.
                        /// </summary>
                        [NameInMap("Crop")]
                        [Validation(Required=false)]
                        public string Crop { get; set; }

                        /// <summary>
                        /// The strength of the independent noise reduction algorithm.
                        /// </summary>
                        [NameInMap("Degrain")]
                        [Validation(Required=false)]
                        public string Degrain { get; set; }

                        /// <summary>
                        /// The frame rate of the video.
                        /// 
                        /// *   Unit: frames per second.
                        /// *   The value is 60 if the frame rate of the input file exceeds 60.
                        /// *   Default value: the frame rate of the input video.
                        /// </summary>
                        [NameInMap("Fps")]
                        [Validation(Required=false)]
                        public string Fps { get; set; }

                        /// <summary>
                        /// The maximum interval between keyframes or the maximum number of frames in a frame group. Unit: seconds.
                        /// 
                        /// *   Default value: **250**.
                        /// *   If the maximum number of frames is returned, the value does not contain a unit.
                        /// </summary>
                        [NameInMap("Gop")]
                        [Validation(Required=false)]
                        public string Gop { get; set; }

                        /// <summary>
                        /// The height of the video.
                        /// 
                        /// *   Unit: pixel.
                        /// *   Default value: the height of the input video.
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        /// <summary>
                        /// The maximum frame rate.
                        /// </summary>
                        [NameInMap("MaxFps")]
                        [Validation(Required=false)]
                        public string MaxFps { get; set; }

                        /// <summary>
                        /// The maximum bitrate of the video. Unit: Kbit/s.
                        /// </summary>
                        [NameInMap("Maxrate")]
                        [Validation(Required=false)]
                        public string Maxrate { get; set; }

                        /// <summary>
                        /// The black bars that are added to the video.
                        /// 
                        /// *   Unit: pixel.
                        /// *   Format: width:height:left:top.
                        /// </summary>
                        [NameInMap("Pad")]
                        [Validation(Required=false)]
                        public string Pad { get; set; }

                        /// <summary>
                        /// The pixel format of the video. Valid values: standard pixel formats such as yuv420p and yuvj420p.
                        /// </summary>
                        [NameInMap("PixFmt")]
                        [Validation(Required=false)]
                        public string PixFmt { get; set; }

                        /// <summary>
                        /// The preset video algorithm. Default value: **medium**. Valid values:
                        /// 
                        /// *   **veryfast**
                        /// *   **fast**
                        /// *   **medium**
                        /// *   **slow**
                        /// *   **slower**
                        /// </summary>
                        [NameInMap("Preset")]
                        [Validation(Required=false)]
                        public string Preset { get; set; }

                        /// <summary>
                        /// The codec profile of the video. Valid values: baseline, main, and high.
                        /// 
                        /// >  If multiple definitions are involved, we recommend that you use baseline for the lowest definition to ensure normal playback on low-end devices, and use main or high for other definitions.
                        /// 
                        /// *   **baseline**: applicable to mobile devices.
                        /// *   **main**: applicable to standard-definition devices.
                        /// *   **high**: applicable to high-definition devices.
                        /// *   Default value: **high**.
                        /// </summary>
                        [NameInMap("Profile")]
                        [Validation(Required=false)]
                        public string Profile { get; set; }

                        /// <summary>
                        /// The level of quality control on the video.
                        /// </summary>
                        [NameInMap("Qscale")]
                        [Validation(Required=false)]
                        public string Qscale { get; set; }

                        /// <summary>
                        /// The resource priority.
                        /// </summary>
                        [NameInMap("ResoPriority")]
                        [Validation(Required=false)]
                        public string ResoPriority { get; set; }

                        /// <summary>
                        /// The scan mode. Valid values:
                        /// 
                        /// *   If this parameter is left **empty**, the scan mode of the input video is used.
                        /// *   **auto**: automatic deinterlacing.
                        /// *   **progressive**: progressive scan.
                        /// *   **interlaced**: interlaced scan.
                        /// *   **By default**, this parameter is left empty.
                        /// 
                        /// **Best practice**: The interlaced scan mode saves data traffic than the progressive scan mode but provides poor image quality. Therefore, the progressive scan mode is commonly used in mainstream video production.
                        /// 
                        /// *   If **progressive** or **interlaced** is used when the scan mode of the input video is neither of them, the transcoding job fails.
                        /// *   We recommend that you use **the scan mode of the input video** or **automatic deinterlacing** for higher compatibility.
                        /// </summary>
                        [NameInMap("ScanMode")]
                        [Validation(Required=false)]
                        public string ScanMode { get; set; }

                        /// <summary>
                        /// The width of the video.
                        /// 
                        /// *   Unit: pixel.
                        /// *   Default value: the width of the input video.
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                    }

                    /// <summary>
                    /// The sequence number of the video stream. The sequence number is the index of the video stream in the list and starts from 0. If no sequence number is specified, the default video stream is used.
                    /// </summary>
                    [NameInMap("VideoStreamMap")]
                    [Validation(Required=false)]
                    public string VideoStreamMap { get; set; }

                    /// <summary>
                    /// The URL of the watermark configuration file.
                    /// </summary>
                    [NameInMap("WaterMarkConfigUrl")]
                    [Validation(Required=false)]
                    public string WaterMarkConfigUrl { get; set; }

                    /// <summary>
                    /// The watermarks.
                    /// </summary>
                    [NameInMap("WaterMarkList")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputWaterMarkList WaterMarkList { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputWaterMarkList : TeaModel {
                        [NameInMap("WaterMark")]
                        [Validation(Required=false)]
                        public List<QueryJobListResponseBodyJobListJobOutputWaterMarkListWaterMark> WaterMark { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputWaterMarkListWaterMark : TeaModel {
                            /// <summary>
                            /// The horizontal offset of the watermark image relative to the output video. If this parameter is specified in the request, the corresponding parameter in the watermark template is overwritten. Default value: 0. The value can be an integer or a decimal number.
                            /// 
                            /// *   An integer indicates the pixel value of the horizontal offset.
                            /// 
                            ///     *   Valid values: **[8,4096]**.
                            ///     *   Unit: pixel.
                            /// 
                            /// *   A decimal number indicates the ratio of the horizontal offset to the width in the output video resolution.
                            /// 
                            ///     *   Valid values: (0,1).
                            ///     *   The decimal number can be accurate to four decimal places, such as 0.9999. Excessive digits are automatically discarded.
                            /// </summary>
                            [NameInMap("Dx")]
                            [Validation(Required=false)]
                            public string Dx { get; set; }

                            /// <summary>
                            /// The vertical offset of the watermark image relative to the output video. If this parameter is specified in the request, the corresponding parameter in the watermark template is overwritten. The value can be an integer or a decimal number.
                            /// 
                            /// *   An integer indicates the pixel value of the vertical offset.
                            /// 
                            ///     *   Valid values: **[8,4096]**.
                            ///     *   Unit: pixel.
                            /// 
                            /// *   A decimal number indicates the ratio of the vertical offset to the height in the output video resolution.
                            /// 
                            ///     *   Valid values: **(0,1)**.
                            ///     *   The decimal number can be accurate to four decimal places, such as 0.9999. Excessive digits are automatically discarded.
                            /// </summary>
                            [NameInMap("Dy")]
                            [Validation(Required=false)]
                            public string Dy { get; set; }

                            /// <summary>
                            /// The height of the watermark image. If this parameter is specified in the request, the corresponding parameter in the watermark template is overwritten. The value can be an integer or a decimal number.
                            /// 
                            /// *   An integer indicates the pixel value of the watermark height.
                            /// 
                            ///     *   Valid values: **[8,4096]**.
                            ///     *   Unit: pixel.
                            /// 
                            /// *   A decimal number indicates the ratio of the watermark height to the height in the output video resolution.
                            /// 
                            ///     *   Valid values: **(0,1)**.
                            ///     *   The decimal number can be accurate to four decimal places, such as 0.9999. Excessive digits are automatically discarded.
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            /// <summary>
                            /// The watermark input file. PNG images and MOV files are supported.
                            /// </summary>
                            [NameInMap("InputFile")]
                            [Validation(Required=false)]
                            public QueryJobListResponseBodyJobListJobOutputWaterMarkListWaterMarkInputFile InputFile { get; set; }
                            public class QueryJobListResponseBodyJobListJobOutputWaterMarkListWaterMarkInputFile : TeaModel {
                                /// <summary>
                                /// The name of the OSS bucket in which the input file is stored.
                                /// </summary>
                                [NameInMap("Bucket")]
                                [Validation(Required=false)]
                                public string Bucket { get; set; }

                                /// <summary>
                                /// The OSS region in which the input file resides.
                                /// </summary>
                                [NameInMap("Location")]
                                [Validation(Required=false)]
                                public string Location { get; set; }

                                /// <summary>
                                /// The name of the Object Storage Service (OSS) object that is used as the input file.
                                /// </summary>
                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                            /// <summary>
                            /// The position of the watermark. If this parameter is specified in the request, the corresponding parameter in the watermark template is overwritten. Valid values:
                            /// 
                            /// *   TopRight
                            /// *   TopLeft
                            /// *   BottomRight
                            /// *   BottomLeft
                            /// </summary>
                            [NameInMap("ReferPos")]
                            [Validation(Required=false)]
                            public string ReferPos { get; set; }

                            /// <summary>
                            /// The type of the watermark. If this parameter is specified in the request, the corresponding parameter in the watermark template is overwritten. For more information, see [Parameter details](https://help.aliyun.com/document_detail/29253.html). Valid values:
                            /// 
                            /// *   Image
                            /// *   Text
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// The ID of the watermark template.
                            /// </summary>
                            [NameInMap("WaterMarkTemplateId")]
                            [Validation(Required=false)]
                            public string WaterMarkTemplateId { get; set; }

                            /// <summary>
                            /// The width of the watermark image. If this parameter is specified in the request, the corresponding parameter in the watermark template is overwritten. The value can be an integer or a decimal number.
                            /// 
                            /// *   An integer indicates the pixel value of the watermark width.
                            /// 
                            ///     *   Valid values: **[8,4096]**.
                            ///     *   Unit: pixel.
                            /// 
                            /// *   A decimal number indicates the ratio of the watermark width to the width in the output video resolution.
                            /// 
                            ///     *   Valid values: **(0,1)**.
                            ///     *   The decimal number can be accurate to four decimal places, such as 0.9999. Excessive digits are automatically discarded.
                            /// </summary>
                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                        }

                    }

                }

                /// <summary>
                /// The transcoding progress.
                /// </summary>
                [NameInMap("Percent")]
                [Validation(Required=false)]
                public long? Percent { get; set; }

                /// <summary>
                /// The ID of the MPS queue that is used to run the job.
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                /// <summary>
                /// The job state. Valid values:
                /// 
                /// *   **Submitted**: The job was submitted.
                /// *   **Transcoding**: Transcoding is in process.
                /// *   **TranscodeSuccess**: The job was successful.
                /// *   **TranscodeFail**: The job failed.
                /// *   **TranscodeCancelled**: The job was canceled.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The time when the job was submitted.
                /// </summary>
                [NameInMap("SubmitTime")]
                [Validation(Required=false)]
                public string SubmitTime { get; set; }

            }

        }

        /// <summary>
        /// The list of nonexistent job IDs. If all queried job IDs exist, the response does not contain this parameter.
        /// </summary>
        [NameInMap("NonExistJobIds")]
        [Validation(Required=false)]
        public QueryJobListResponseBodyNonExistJobIds NonExistJobIds { get; set; }
        public class QueryJobListResponseBodyNonExistJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
