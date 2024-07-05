// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListJobResponseBody : TeaModel {
        /// <summary>
        /// The transcoding jobs.
        /// </summary>
        [NameInMap("JobList")]
        [Validation(Required=false)]
        public ListJobResponseBodyJobList JobList { get; set; }
        public class ListJobResponseBodyJobList : TeaModel {
            [NameInMap("Job")]
            [Validation(Required=false)]
            public List<ListJobResponseBodyJobListJob> Job { get; set; }
            public class ListJobResponseBodyJobListJob : TeaModel {
                /// <summary>
                /// The error code returned if the job failed. This parameter is not returned if the job was successful.
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
                public ListJobResponseBodyJobListJobInput Input { get; set; }
                public class ListJobResponseBodyJobListJobInput : TeaModel {
                    /// <summary>
                    /// The name of the OSS bucket in which the job input is stored.
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// The ID of the OSS region in which the job input is stored.
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// The name of the OSS object that is used as the job input.
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                }

                /// <summary>
                /// The task ID.
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// The message sent by Message Service (MNS) to notify users of the job result.
                /// </summary>
                [NameInMap("MNSMessageResult")]
                [Validation(Required=false)]
                public ListJobResponseBodyJobListJobMNSMessageResult MNSMessageResult { get; set; }
                public class ListJobResponseBodyJobListJobMNSMessageResult : TeaModel {
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
                /// The error message returned if the job failed. This parameter is not returned if the job was successful.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The output of the job.
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public ListJobResponseBodyJobListJobOutput Output { get; set; }
                public class ListJobResponseBodyJobListJobOutput : TeaModel {
                    /// <summary>
                    /// The audio configurations.
                    /// </summary>
                    [NameInMap("Audio")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputAudio Audio { get; set; }
                    public class ListJobResponseBodyJobListJobOutputAudio : TeaModel {
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
                        /// *   If the value of Codec is mp3, the value of this parameter can only be 1 or 2.
                        /// *   If the value of Codec is aac, the value of this parameter can only be 1, 2, 4, 5, 6, or 8.
                        /// *   Default value: 2.
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
                        /// The codec profile of the audio. Valid values if the value of Codec is aac: aaclow, aache, aachev2, aacld, and aaceld.
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
                        /// *   If the video container format is FLV and the audio codec is MP3, the value of this parameter cannot be 32000, 48000, or 96000. If the audio codec is MP3, the value of this parameter cannot be 96000.
                        /// </summary>
                        [NameInMap("Samplerate")]
                        [Validation(Required=false)]
                        public string Samplerate { get; set; }

                        /// <summary>
                        /// The volume configurations.
                        /// </summary>
                        [NameInMap("Volume")]
                        [Validation(Required=false)]
                        public ListJobResponseBodyJobListJobOutputAudioVolume Volume { get; set; }
                        public class ListJobResponseBodyJobListJobOutputAudioVolume : TeaModel {
                            /// <summary>
                            /// The volume adjustment range.
                            /// 
                            /// *   Unit: decibel.
                            /// *   Default value: **-20**.
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
                    /// *   Format: `0:a:{Sequence number}`.
                    /// *   The sequence number is the index of the audio stream in the list and starts from 0. If no sequence number is specified, the default audio stream is used.
                    /// </summary>
                    [NameInMap("AudioStreamMap")]
                    [Validation(Required=false)]
                    public string AudioStreamMap { get; set; }

                    /// <summary>
                    /// The information about the clip.
                    /// </summary>
                    [NameInMap("Clip")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputClip Clip { get; set; }
                    public class ListJobResponseBodyJobListJobOutputClip : TeaModel {
                        /// <summary>
                        /// The time span of the clip.
                        /// </summary>
                        [NameInMap("TimeSpan")]
                        [Validation(Required=false)]
                        public ListJobResponseBodyJobListJobOutputClipTimeSpan TimeSpan { get; set; }
                        public class ListJobResponseBodyJobListJobOutputClipTimeSpan : TeaModel {
                            /// <summary>
                            /// The duration of the clip.
                            /// 
                            /// *   Format: `hh:mm:ss[.SSS]` or `sssss[.SSS]`.
                            /// *   Valid values: `[00:00:00.000,23:59:59.999]` or `[0.000,86399.999]`.
                            /// *   Examples: 01:00:59.999 and 32000.23.
                            /// </summary>
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            /// <summary>
                            /// The point in time when the clip starts.
                            /// 
                            /// *   Format: `hh:mm:ss[.SSS]` or `sssss[.SSS]`.
                            /// *   Valid values: `[00:00:00.000,23:59:59.999]` or `[0.000,86399.999]`.
                            /// *   Examples: 01:59:59.999 and 32000.23.
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
                    public ListJobResponseBodyJobListJobOutputContainer Container { get; set; }
                    public class ListJobResponseBodyJobListJobOutputContainer : TeaModel {
                        /// <summary>
                        /// The container format.
                        /// 
                        /// *   Default value: mp4.
                        /// *   Video formats include FLV, MP4, HLS (M3U8 + TS), and MPEG-DASH (MPD + fMP4).
                        /// *   Audio formats include MP3, MP4, Ogg, FLAC, and M4A.
                        /// *   Image formats include GIF and WebP.
                        /// *   If the container format is GIF, the video codec must be GIF.
                        /// *   If the container format is WebP, the video codec must be WebP.
                        /// *   If the container format is FLV, the video codec cannot be H.265.
                        /// </summary>
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                    }

                    /// <summary>
                    /// The configurations of watermark blurring. The value is a JSON object. For more information, see [Parameter details](https://help.aliyun.com/document_detail/29253.html).
                    /// </summary>
                    [NameInMap("DeWatermark")]
                    [Validation(Required=false)]
                    public string DeWatermark { get; set; }

                    /// <summary>
                    /// The encryption configurations. Only outputs in the M3U8 format are supported.
                    /// </summary>
                    [NameInMap("Encryption")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputEncryption Encryption { get; set; }
                    public class ListJobResponseBodyJobListJobOutputEncryption : TeaModel {
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
                        /// >  For example, if the key is encryptionkey128, you can encrypt the key in the Base64 format or use Key Management Service (KMS) to encrypt the key.``````
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
                        /// The encryption type. Only hls-aes-128 may be returned.
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// The non-standard support configuration for M3U8. The value must be a JSON object. For more information, see [Parameter details](https://help.aliyun.com/document_detail/29253.html).
                    /// </summary>
                    [NameInMap("M3U8NonStandardSupport")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputM3U8NonStandardSupport M3U8NonStandardSupport { get; set; }
                    public class ListJobResponseBodyJobListJobOutputM3U8NonStandardSupport : TeaModel {
                        /// <summary>
                        /// The non-standard support configurations for TS files. The value is a JSON object. For more information, see [Parameter details](https://help.aliyun.com/document_detail/29253.html).
                        /// </summary>
                        [NameInMap("TS")]
                        [Validation(Required=false)]
                        public ListJobResponseBodyJobListJobOutputM3U8NonStandardSupportTS TS { get; set; }
                        public class ListJobResponseBodyJobListJobOutputM3U8NonStandardSupportTS : TeaModel {
                            /// <summary>
                            /// Indicates whether the MD5 value of the TS file is included in the M3U8 file. Valid values:
                            /// 
                            /// *   **true**
                            /// *   **false**
                            /// </summary>
                            [NameInMap("Md5Support")]
                            [Validation(Required=false)]
                            public bool? Md5Support { get; set; }

                            /// <summary>
                            /// Indicates whether the size of the TS file is included in the M3U8 file.
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
                    /// The URL of the merging configuration file. You can specify either MergeList or MergeConfigUrl when you submit the transcoding job.
                    /// 
                    /// *   The configuration file specified by MergeConfigUrl can contain up to 50 clips.
                    /// *   MergeConfigUrl indicates the URL of the configuration file for merging clips.
                    /// *   Make sure that the configuration file is stored as an object in OSS and that MPS can access the OSS object. For information about the file content, see the details of merging parameters.
                    /// *   Example of the content of the merging configuration file: `{"MergeList":[{"MergeURL":"http://exampleBucket****.oss-cn-hangzhou.aliyuncs.com/video_01.mp4"}]}`.
                    /// </summary>
                    [NameInMap("MergeConfigUrl")]
                    [Validation(Required=false)]
                    public string MergeConfigUrl { get; set; }

                    /// <summary>
                    /// The configurations for merging clips.
                    /// </summary>
                    [NameInMap("MergeList")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputMergeList MergeList { get; set; }
                    public class ListJobResponseBodyJobListJobOutputMergeList : TeaModel {
                        [NameInMap("Merge")]
                        [Validation(Required=false)]
                        public List<ListJobResponseBodyJobListJobOutputMergeListMerge> Merge { get; set; }
                        public class ListJobResponseBodyJobListJobOutputMergeListMerge : TeaModel {
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
                            /// *   Example: `http://example-bucket-****.oss-cn-hangzhou.aliyuncs.com/example-object.flv`.
                            /// *   The object must be URL-encoded by using the UTF-8 standard.
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
                    /// The transmuxing configurations.
                    /// </summary>
                    [NameInMap("MuxConfig")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputMuxConfig MuxConfig { get; set; }
                    public class ListJobResponseBodyJobListJobOutputMuxConfig : TeaModel {
                        /// <summary>
                        /// The transmuxing configurations for GIF.
                        /// </summary>
                        [NameInMap("Gif")]
                        [Validation(Required=false)]
                        public ListJobResponseBodyJobListJobOutputMuxConfigGif Gif { get; set; }
                        public class ListJobResponseBodyJobListJobOutputMuxConfigGif : TeaModel {
                            /// <summary>
                            /// The color dithering algorithm of the palette. Valid values: **sierra** and **bayer**.
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
                        public ListJobResponseBodyJobListJobOutputMuxConfigSegment Segment { get; set; }
                        public class ListJobResponseBodyJobListJobOutputMuxConfigSegment : TeaModel {
                            /// <summary>
                            /// The length of the segment. The value must be an integer. Unit: seconds.
                            /// 
                            /// *   Valid values: [1,10].
                            /// *   Default value: 10.
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
                        public ListJobResponseBodyJobListJobOutputMuxConfigWebp Webp { get; set; }
                        public class ListJobResponseBodyJobListJobOutputMuxConfigWebp : TeaModel {
                            /// <summary>
                            /// The loop count.
                            /// </summary>
                            [NameInMap("Loop")]
                            [Validation(Required=false)]
                            public string Loop { get; set; }

                        }

                    }

                    /// <summary>
                    /// The opening parts.
                    /// </summary>
                    [NameInMap("OpeningList")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputOpeningList OpeningList { get; set; }
                    public class ListJobResponseBodyJobListJobOutputOpeningList : TeaModel {
                        [NameInMap("Opening")]
                        [Validation(Required=false)]
                        public List<ListJobResponseBodyJobListJobOutputOpeningListOpening> Opening { get; set; }
                        public class ListJobResponseBodyJobListJobOutputOpeningListOpening : TeaModel {
                            /// <summary>
                            /// The height of the opening part. Valid values: values in the range of (0, 4096), -1, and full.
                            /// 
                            /// *   Default value: **-1**.
                            /// *   A value of -1 indicates that the height of the source of the opening part is retained.
                            /// *   A value of full indicates that the height of the opening part equals the height of the main part.
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            /// <summary>
                            /// The amount of time after which the opening part is played. The value starts from 0.
                            /// 
                            /// *   Unit: seconds.
                            /// *   Default value: **0**.
                            /// </summary>
                            [NameInMap("Start")]
                            [Validation(Required=false)]
                            public string Start { get; set; }

                            /// <summary>
                            /// The width of the opening part. Valid values: values in the range of (0, 4096), -1, and full.
                            /// 
                            /// *   Default value: **-1**.
                            /// *   A value of -1 indicates that the width of the source of the opening part is retained.
                            /// *   A value of full indicates that the width of the opening part equals the width of the main part.
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
                    /// The output subtitles.
                    /// </summary>
                    [NameInMap("OutSubtitleList")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputOutSubtitleList OutSubtitleList { get; set; }
                    public class ListJobResponseBodyJobListJobOutputOutSubtitleList : TeaModel {
                        [NameInMap("OutSubtitle")]
                        [Validation(Required=false)]
                        public List<ListJobResponseBodyJobListJobOutputOutSubtitleListOutSubtitle> OutSubtitle { get; set; }
                        public class ListJobResponseBodyJobListJobOutputOutSubtitleListOutSubtitle : TeaModel {
                            /// <summary>
                            /// The video track. Format: 0:{Stream}:{Stream sequence number}, that is, 0:v:{video_index}. The value of Stream is v, which indicates a video stream. The sequence number is the index of the video stream in the list and starts from 0.
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
                            /// The details of the output file.
                            /// </summary>
                            [NameInMap("OutSubtitleFile")]
                            [Validation(Required=false)]
                            public ListJobResponseBodyJobListJobOutputOutSubtitleListOutSubtitleOutSubtitleFile OutSubtitleFile { get; set; }
                            public class ListJobResponseBodyJobListJobOutputOutSubtitleListOutSubtitleOutSubtitleFile : TeaModel {
                                /// <summary>
                                /// The name of the OSS bucket in which the input file is stored.
                                /// </summary>
                                [NameInMap("Bucket")]
                                [Validation(Required=false)]
                                public string Bucket { get; set; }

                                /// <summary>
                                /// The ID of the OSS region in which the output file is stored.
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
                            /// Indicates whether the job was created. Valid values:
                            /// 
                            /// *   **true**
                            /// *   **false**
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
                    public ListJobResponseBodyJobListJobOutputOutputFile OutputFile { get; set; }
                    public class ListJobResponseBodyJobListJobOutputOutputFile : TeaModel {
                        /// <summary>
                        /// The name of the OSS bucket in which the input file is stored.
                        /// </summary>
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }

                        /// <summary>
                        /// The ID of the OSS region in which the output file is stored.
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
                    /// The priority of the job in the MPS queue to which the job is added.
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
                    public ListJobResponseBodyJobListJobOutputProperties Properties { get; set; }
                    public class ListJobResponseBodyJobListJobOutputProperties : TeaModel {
                        /// <summary>
                        /// The bitrate of the video.
                        /// </summary>
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        /// <summary>
                        /// The duration of the video.
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        /// <summary>
                        /// The format of the video.
                        /// </summary>
                        [NameInMap("FileFormat")]
                        [Validation(Required=false)]
                        public string FileFormat { get; set; }

                        /// <summary>
                        /// The size of the file.
                        /// </summary>
                        [NameInMap("FileSize")]
                        [Validation(Required=false)]
                        public string FileSize { get; set; }

                        /// <summary>
                        /// The format information.
                        /// </summary>
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public ListJobResponseBodyJobListJobOutputPropertiesFormat Format { get; set; }
                        public class ListJobResponseBodyJobListJobOutputPropertiesFormat : TeaModel {
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
                            /// The size of the file.
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
                        /// The height of the video.
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        /// <summary>
                        /// The stream information.
                        /// </summary>
                        [NameInMap("Streams")]
                        [Validation(Required=false)]
                        public ListJobResponseBodyJobListJobOutputPropertiesStreams Streams { get; set; }
                        public class ListJobResponseBodyJobListJobOutputPropertiesStreams : TeaModel {
                            /// <summary>
                            /// The audio streams.
                            /// </summary>
                            [NameInMap("AudioStreamList")]
                            [Validation(Required=false)]
                            public ListJobResponseBodyJobListJobOutputPropertiesStreamsAudioStreamList AudioStreamList { get; set; }
                            public class ListJobResponseBodyJobListJobOutputPropertiesStreamsAudioStreamList : TeaModel {
                                [NameInMap("AudioStream")]
                                [Validation(Required=false)]
                                public List<ListJobResponseBodyJobListJobOutputPropertiesStreamsAudioStreamListAudioStream> AudioStream { get; set; }
                                public class ListJobResponseBodyJobListJobOutputPropertiesStreamsAudioStreamListAudioStream : TeaModel {
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
                                    /// The sampling rate of the audio stream.
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
                            /// The subtitle streams.
                            /// </summary>
                            [NameInMap("SubtitleStreamList")]
                            [Validation(Required=false)]
                            public ListJobResponseBodyJobListJobOutputPropertiesStreamsSubtitleStreamList SubtitleStreamList { get; set; }
                            public class ListJobResponseBodyJobListJobOutputPropertiesStreamsSubtitleStreamList : TeaModel {
                                [NameInMap("SubtitleStream")]
                                [Validation(Required=false)]
                                public List<ListJobResponseBodyJobListJobOutputPropertiesStreamsSubtitleStreamListSubtitleStream> SubtitleStream { get; set; }
                                public class ListJobResponseBodyJobListJobOutputPropertiesStreamsSubtitleStreamListSubtitleStream : TeaModel {
                                    /// <summary>
                                    /// The sequence number of the subtitle stream. The value indicates the position of the subtitle stream in all subtitle streams.
                                    /// </summary>
                                    [NameInMap("Index")]
                                    [Validation(Required=false)]
                                    public string Index { get; set; }

                                    /// <summary>
                                    /// The language of the subtitle stream.
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
                            public ListJobResponseBodyJobListJobOutputPropertiesStreamsVideoStreamList VideoStreamList { get; set; }
                            public class ListJobResponseBodyJobListJobOutputPropertiesStreamsVideoStreamList : TeaModel {
                                [NameInMap("VideoStream")]
                                [Validation(Required=false)]
                                public List<ListJobResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                                public class ListJobResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStream : TeaModel {
                                    /// <summary>
                                    /// The average frame rate of the video stream.
                                    /// </summary>
                                    [NameInMap("AvgFPS")]
                                    [Validation(Required=false)]
                                    public string AvgFPS { get; set; }

                                    /// <summary>
                                    /// The bitrate of the video stream.
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
                                    /// The display aspect ratio (DAR).
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
                                    /// Indicates whether the video stream contains B-frames.
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
                                    public ListJobResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                                    public class ListJobResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
                                        /// <summary>
                                        /// The average bitrate of the video stream.
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
                                    /// The total frame rate.
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

                                }

                            }

                        }

                        /// <summary>
                        /// The width of the video.
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
                    /// The subtitle configurations.
                    /// </summary>
                    [NameInMap("SubtitleConfig")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputSubtitleConfig SubtitleConfig { get; set; }
                    public class ListJobResponseBodyJobListJobOutputSubtitleConfig : TeaModel {
                        /// <summary>
                        /// The external subtitles. The value is a JSON array.
                        /// </summary>
                        [NameInMap("ExtSubtitleList")]
                        [Validation(Required=false)]
                        public ListJobResponseBodyJobListJobOutputSubtitleConfigExtSubtitleList ExtSubtitleList { get; set; }
                        public class ListJobResponseBodyJobListJobOutputSubtitleConfigExtSubtitleList : TeaModel {
                            [NameInMap("ExtSubtitle")]
                            [Validation(Required=false)]
                            public List<ListJobResponseBodyJobListJobOutputSubtitleConfigExtSubtitleListExtSubtitle> ExtSubtitle { get; set; }
                            public class ListJobResponseBodyJobListJobOutputSubtitleConfigExtSubtitleListExtSubtitle : TeaModel {
                                /// <summary>
                                /// The character set used by the external subtitle.
                                /// 
                                /// *   Valid values: UTF-8, GBK, BIG5, and auto.
                                /// *   Default value: **auto**.
                                /// 
                                /// >  If this parameter is set to auto, the detected character set may not be the actual character set. We recommend that you set this parameter to another value.
                                /// </summary>
                                [NameInMap("CharEnc")]
                                [Validation(Required=false)]
                                public string CharEnc { get; set; }

                                /// <summary>
                                /// The font of the hardcoded subtitles converted from external subtitles.
                                /// </summary>
                                [NameInMap("FontName")]
                                [Validation(Required=false)]
                                public string FontName { get; set; }

                                /// <summary>
                                /// The input subtitle file.
                                /// 
                                /// *   Files in the SRT or ASS format are supported. For more information, see [Parameter details](https://help.aliyun.com/document_detail/29253.html).
                                /// *   Example: `{"Bucket":"example-bucket","Location":"oss-cn-hangzhou","Object":"example.srt"}`.
                                /// </summary>
                                [NameInMap("Input")]
                                [Validation(Required=false)]
                                public ListJobResponseBodyJobListJobOutputSubtitleConfigExtSubtitleListExtSubtitleInput Input { get; set; }
                                public class ListJobResponseBodyJobListJobOutputSubtitleConfigExtSubtitleListExtSubtitleInput : TeaModel {
                                    /// <summary>
                                    /// The name of the OSS bucket in which the input file is stored.
                                    /// </summary>
                                    [NameInMap("Bucket")]
                                    [Validation(Required=false)]
                                    public string Bucket { get; set; }

                                    /// <summary>
                                    /// The ID of the OSS region in which the input file is stored.
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

                            }

                        }

                        /// <summary>
                        /// The subtitles.
                        /// </summary>
                        [NameInMap("SubtitleList")]
                        [Validation(Required=false)]
                        public ListJobResponseBodyJobListJobOutputSubtitleConfigSubtitleList SubtitleList { get; set; }
                        public class ListJobResponseBodyJobListJobOutputSubtitleConfigSubtitleList : TeaModel {
                            [NameInMap("Subtitle")]
                            [Validation(Required=false)]
                            public List<ListJobResponseBodyJobListJobOutputSubtitleConfigSubtitleListSubtitle> Subtitle { get; set; }
                            public class ListJobResponseBodyJobListJobOutputSubtitleConfigSubtitleListSubtitle : TeaModel {
                                /// <summary>
                                /// The sequence number of the video stream. The sequence number is the index of the video stream in the list and starts from 0. If you do not set the corresponding parameter in the request, the default video stream is selected.
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
                    public ListJobResponseBodyJobListJobOutputSuperReso SuperReso { get; set; }
                    public class ListJobResponseBodyJobListJobOutputSuperReso : TeaModel {
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
                    public ListJobResponseBodyJobListJobOutputTailSlateList TailSlateList { get; set; }
                    public class ListJobResponseBodyJobListJobOutputTailSlateList : TeaModel {
                        [NameInMap("TailSlate")]
                        [Validation(Required=false)]
                        public List<ListJobResponseBodyJobListJobOutputTailSlateListTailSlate> TailSlate { get; set; }
                        public class ListJobResponseBodyJobListJobOutputTailSlateListTailSlate : TeaModel {
                            /// <summary>
                            /// The color of the bars that are added to the ending part if the size of the ending part is smaller than that of the main part. Default value: **White**. For more information, see [Background colors](https://docs-aliyun.cn-hangzhou.oss.aliyun-inc.com/assets/attach/29253/cn_zh/1502784952344/color.txt?spm=a2c4g.11186623.2.63.1df840f74IH4Eq\\&file=color.txt).
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
                            /// The height of the ending part. Valid values: values in the range of (0, 4096), -1, and full.
                            /// 
                            /// *   A value of -1 indicates that the height of the source of the ending part is retained.
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
                            /// The start time.
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
                            /// The width of the ending part. Valid values: values in the range of (0, 4096), -1, and full.
                            /// 
                            /// *   A value of -1 indicates that the width of the source of the ending part is retained. A value of full indicates that the width of the ending part equals the width of the main part.
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
                    /// The general transcoding configurations. If this parameter is specified in the request, the corresponding parameters in the specified transcoding template are overwritten.
                    /// </summary>
                    [NameInMap("TransConfig")]
                    [Validation(Required=false)]
                    public ListJobResponseBodyJobListJobOutputTransConfig TransConfig { get; set; }
                    public class ListJobResponseBodyJobListJobOutputTransConfig : TeaModel {
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
                        ///     *   If this parameter is empty and the codec of the output audio is different from the codec of the input audio, the default value is false.
                        ///     *   If this parameter is empty and the codec of the output audio is the same as the codec of the input audio, the default value is true.
                        /// </summary>
                        [NameInMap("IsCheckAudioBitrate")]
                        [Validation(Required=false)]
                        public string IsCheckAudioBitrate { get; set; }

                        /// <summary>
                        /// Indicates whether the audio bitrate is checked. If the bitrate of the output audio is higher than that of the input audio, a transcoding failure is returned without transcoding the audio. This parameter has a higher priority than IsCheckAudioBitrate. Valid values:
                        /// 
                        /// *   **false**: The audio bitrate is checked.
                        /// *   **true**: The audio bitrate is not checked.
                        /// </summary>
                        [NameInMap("IsCheckAudioBitrateFail")]
                        [Validation(Required=false)]
                        public string IsCheckAudioBitrateFail { get; set; }

                        /// <summary>
                        /// Indicates whether the resolution is checked. If the output resolution is higher than the input resolution based on the width or height, the input resolution is retained. Valid values:
                        /// 
                        /// *   **true**
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
                        /// Indicates whether the video bitrate is checked. If the bitrate of the output video is higher than that of the input video, a transcoding failure is returned without transcoding the video. This parameter has a higher priority than IsCheckVideoBitrate. Valid values:
                        /// 
                        /// *   **true**
                        /// *   **false**
                        /// *   Default value: false.
                        /// </summary>
                        [NameInMap("IsCheckVideoBitrateFail")]
                        [Validation(Required=false)]
                        public string IsCheckVideoBitrateFail { get; set; }

                        /// <summary>
                        /// The transcoding mode.
                        /// 
                        /// *   Valid values: onepass, twopass, and CBR.
                        /// *   Default value: onepass.
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
                    public ListJobResponseBodyJobListJobOutputVideo Video { get; set; }
                    public class ListJobResponseBodyJobListJobOutputVideo : TeaModel {
                        /// <summary>
                        /// The average bitrate of the video. Unit: Kbit/s.
                        /// </summary>
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        /// <summary>
                        /// The bitrate range of the video.
                        /// </summary>
                        [NameInMap("BitrateBnd")]
                        [Validation(Required=false)]
                        public ListJobResponseBodyJobListJobOutputVideoBitrateBnd BitrateBnd { get; set; }
                        public class ListJobResponseBodyJobListJobOutputVideoBitrateBnd : TeaModel {
                            /// <summary>
                            /// The maximum bitrate. Unit: Kbit/s.
                            /// </summary>
                            [NameInMap("Max")]
                            [Validation(Required=false)]
                            public string Max { get; set; }

                            /// <summary>
                            /// The minimum bitrate. Unit: Kbit/s.
                            /// </summary>
                            [NameInMap("Min")]
                            [Validation(Required=false)]
                            public string Min { get; set; }

                        }

                        /// <summary>
                        /// The size of the buffer.
                        /// </summary>
                        [NameInMap("Bufsize")]
                        [Validation(Required=false)]
                        public string Bufsize { get; set; }

                        /// <summary>
                        /// The video codec. Valid values: **H.264**, **H.265**, **GIF**, and **WEBP**.
                        /// </summary>
                        [NameInMap("Codec")]
                        [Validation(Required=false)]
                        public string Codec { get; set; }

                        /// <summary>
                        /// The constant rate factor. If this parameter is returned, the value of Bitrate is invalid. Default value: **26**.
                        /// </summary>
                        [NameInMap("Crf")]
                        [Validation(Required=false)]
                        public string Crf { get; set; }

                        /// <summary>
                        /// The video cropping mode. Valid values:
                        /// 
                        /// *   **border**: automatically detects and removes black borders.
                        /// *   A value in the width:height:left:top format: crops the videos based on the custom settings. Example: 1280:800:0:140.
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
                        /// The frame rate.
                        /// 
                        /// *   The value is 60 if the frame rate of the input video exceeds 60.
                        /// *   Default value: the frame rate of the input file.
                        /// </summary>
                        [NameInMap("Fps")]
                        [Validation(Required=false)]
                        public string Fps { get; set; }

                        /// <summary>
                        /// The maximum number of frames between two keyframes. Default value: 250.
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
                        /// The black borders that are added to the video. Unit: pixel.
                        /// 
                        /// *   Format: width:height:left:top.
                        /// *   Example: 1280:800:0:140.
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
                        /// The preset video algorithm. Default value: medium. Valid values:
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
                        /// The codec profile. Valid values:
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
                        /// The priority of the resource.
                        /// </summary>
                        [NameInMap("ResoPriority")]
                        [Validation(Required=false)]
                        public string ResoPriority { get; set; }

                        /// <summary>
                        /// The scan mode. Valid values:
                        /// 
                        /// *   If this parameter is **empty**, the scan mode of the input file is used.
                        /// *   **auto**: automatic deinterlacing.
                        /// *   **progressive**: progressive scan.
                        /// *   **interlaced**: interlaced scan.
                        /// *   **By default**, this parameter is empty.
                        /// 
                        /// **Best practice**: Interlaced scan consumes less bandwidth than progressive scan, but the image quality is poor. Therefore, mainstream video production uses progressive scan.
                        /// 
                        /// *   If **progressive scan** or **interlaced scan** is used when the scan mode of the input file is neither of them, the transcoding job fails.
                        /// *   We recommend that you use **the scan mode of the input file** or **automatic deinterlacing** to improve compatibility.
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
                    /// The sequence number of the video stream.
                    /// 
                    /// *   Format: 0:a:{Sequence number}. Example value: 0:a:0.
                    /// *   The sequence number is the index of the video stream in the list and starts from 0.
                    /// *   If no sequence number is specified, the default video stream is used.
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
                    public ListJobResponseBodyJobListJobOutputWaterMarkList WaterMarkList { get; set; }
                    public class ListJobResponseBodyJobListJobOutputWaterMarkList : TeaModel {
                        [NameInMap("WaterMark")]
                        [Validation(Required=false)]
                        public List<ListJobResponseBodyJobListJobOutputWaterMarkListWaterMark> WaterMark { get; set; }
                        public class ListJobResponseBodyJobListJobOutputWaterMarkListWaterMark : TeaModel {
                            /// <summary>
                            /// The horizontal offset of the watermark image relative to the output video. If this parameter is specified in the request, the corresponding parameter in the watermark template is overwritten. Default value: 0. The value can be an integer or a decimal number.
                            /// 
                            /// *   An integer indicates the pixel value of the horizontal offset.
                            /// 
                            ///     *   Valid values: [8,4096].
                            ///     *   Unit: pixel.
                            /// 
                            /// *   A decimal number indicates the ratio of the horizontal offset to the width in the output video resolution.
                            /// 
                            ///     *   Valid values: (0,1).
                            ///     *   The decimal number can be accurate to four decimal places, such as 0.9999. Excess digits are automatically deleted.
                            /// </summary>
                            [NameInMap("Dx")]
                            [Validation(Required=false)]
                            public string Dx { get; set; }

                            /// <summary>
                            /// The vertical offset of the watermark image relative to the output video. If this parameter is specified in the request, the corresponding parameter in the watermark template is overwritten. The value can be an integer or a decimal number.
                            /// 
                            /// *   An integer indicates the pixel value of the vertical offset.
                            /// 
                            ///     *   Valid values: [8,4096].
                            ///     *   Unit: pixel.
                            /// 
                            /// *   A decimal indicates the ratio of the vertical offset to the height in the output video resolution.
                            /// 
                            ///     *   Valid values: (0,1).
                            ///     *   The decimal number can be accurate to four decimal places, such as 0.9999. Excess digits are automatically deleted.
                            /// </summary>
                            [NameInMap("Dy")]
                            [Validation(Required=false)]
                            public string Dy { get; set; }

                            /// <summary>
                            /// The height of the watermark. If this parameter is specified in the request, the corresponding parameter in the specified watermark template is overwritten. The value can be an integer or a decimal number.
                            /// 
                            /// *   An integer indicates the pixel value of the watermark height.
                            /// 
                            ///     *   Valid values: [8,4096].
                            ///     *   Unit: pixel.
                            /// 
                            /// *   A decimal indicates the ratio of the watermark height to the height in the output video resolution.
                            /// 
                            ///     *   Valid values: (0,1).
                            ///     *   The decimal number can be accurate to four decimal places, such as 0.9999. Excess digits are automatically deleted.
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            /// <summary>
                            /// The watermark input file.
                            /// </summary>
                            [NameInMap("InputFile")]
                            [Validation(Required=false)]
                            public ListJobResponseBodyJobListJobOutputWaterMarkListWaterMarkInputFile InputFile { get; set; }
                            public class ListJobResponseBodyJobListJobOutputWaterMarkListWaterMarkInputFile : TeaModel {
                                /// <summary>
                                /// The name of the OSS bucket in which the input file is stored.
                                /// </summary>
                                [NameInMap("Bucket")]
                                [Validation(Required=false)]
                                public string Bucket { get; set; }

                                /// <summary>
                                /// The ID of the OSS region in which the input file is stored.
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
                            /// The position of the watermark.
                            /// 
                            /// *   **TopRight**
                            /// *   **TopLeft**
                            /// *   **BottomRight**
                            /// *   **BottomLeft**
                            /// </summary>
                            [NameInMap("ReferPos")]
                            [Validation(Required=false)]
                            public string ReferPos { get; set; }

                            /// <summary>
                            /// The type of the watermark. If this parameter is specified in the request, the corresponding parameter in the watermark template is overwritten. For more information, see [Parameter details](https://help.aliyun.com/document_detail/29253.html). Valid values:
                            /// 
                            /// *   **Image**
                            /// *   **Text**
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
                            ///     *   Valid values: [8,4096].
                            ///     *   Unit: pixel.
                            /// 
                            /// *   A decimal indicates the ratio of the watermark width to the width in the output video resolution.
                            /// 
                            ///     *   Valid values: (0,1).
                            ///     *   The decimal number can be accurate to four decimal places, such as 0.9999. Excess digits are automatically deleted.
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
                /// The ID of the MPS queue.
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                /// <summary>
                /// The state of the job. Valid values:
                /// 
                /// *   **Submitted**
                /// *   **Transcoding**
                /// *   **TranscodeSuccess**
                /// *   **TranscodeFail**
                /// *   **TranscodeCancelled**
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        /// <summary>
        /// The pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
