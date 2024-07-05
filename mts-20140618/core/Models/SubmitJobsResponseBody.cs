// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitJobsResponseBody : TeaModel {
        /// <summary>
        /// The transcoding jobs that are generated.
        /// </summary>
        [NameInMap("JobResultList")]
        [Validation(Required=false)]
        public SubmitJobsResponseBodyJobResultList JobResultList { get; set; }
        public class SubmitJobsResponseBodyJobResultList : TeaModel {
            [NameInMap("JobResult")]
            [Validation(Required=false)]
            public List<SubmitJobsResponseBodyJobResultListJobResult> JobResult { get; set; }
            public class SubmitJobsResponseBodyJobResultListJobResult : TeaModel {
                /// <summary>
                /// The error code returned if the job failed to be created. This parameter is not returned if the job was created.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The details of the job. If the job fails to be submitted, no job ID is generated.
                /// </summary>
                [NameInMap("Job")]
                [Validation(Required=false)]
                public SubmitJobsResponseBodyJobResultListJobResultJob Job { get; set; }
                public class SubmitJobsResponseBodyJobResultListJobResultJob : TeaModel {
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
                    public SubmitJobsResponseBodyJobResultListJobResultJobInput Input { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultJobInput : TeaModel {
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
                    /// The job ID.
                    /// </summary>
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    /// <summary>
                    /// The message sent by MNS to notify users of the job result.
                    /// </summary>
                    [NameInMap("MNSMessageResult")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultJobMNSMessageResult MNSMessageResult { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultJobMNSMessageResult : TeaModel {
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
                        /// The ID of the error message returned if the job failed. This parameter is not returned if the job was successful.
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
                    public SubmitJobsResponseBodyJobResultListJobResultJobOutput Output { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultJobOutput : TeaModel {
                        /// <summary>
                        /// The audio tracks that are mixed.
                        /// </summary>
                        [NameInMap("AmixList")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputAmixList AmixList { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputAmixList : TeaModel {
                            [NameInMap("Amix")]
                            [Validation(Required=false)]
                            public List<SubmitJobsResponseBodyJobResultListJobResultJobOutputAmixListAmix> Amix { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputAmixListAmix : TeaModel {
                                /// <summary>
                                /// The URL of the audio track that is mixed as the background music.
                                /// 
                                /// *   The URL can be an OSS URL or the string `input`.
                                /// *   A value of input indicates that two audio tracks are mixed in a video.
                                /// </summary>
                                [NameInMap("AmixURL")]
                                [Validation(Required=false)]
                                public string AmixURL { get; set; }

                                /// <summary>
                                /// The duration of the mixed audio track. The value is in the number or time format.
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                /// <summary>
                                /// The audio track that is mixed. Format: 0:a:{audio_index}. Example: 0:a:0.
                                /// </summary>
                                [NameInMap("Map")]
                                [Validation(Required=false)]
                                public string Map { get; set; }

                                /// <summary>
                                /// The mode to specify the mixing duration. Valid values: **first** and **long**.
                                /// 
                                /// *   **first**: The length of the output media equals the length of the input media.
                                /// *   **long**: The length of the output media equals the length of the output media or the length of the input media, whichever is longer.
                                /// *   Default value: **long**.
                                /// </summary>
                                [NameInMap("MixDurMode")]
                                [Validation(Required=false)]
                                public string MixDurMode { get; set; }

                                /// <summary>
                                /// The start time. The value is in the number or time format. Examples: 1:25:36.240 and 32000.23.
                                /// </summary>
                                [NameInMap("Start")]
                                [Validation(Required=false)]
                                public string Start { get; set; }

                            }

                        }

                        /// <summary>
                        /// The audio configurations.
                        /// 
                        /// >  If this parameter is specified in the request, the corresponding configurations in the specified transcoding template are overwritten.
                        /// </summary>
                        [NameInMap("Audio")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputAudio Audio { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputAudio : TeaModel {
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
                            /// *   If the value of Codec is mp3, the value of this parameter can only be **1** or **2**.
                            /// *   If the value of Codec is aac, the value of this parameter can only be **1**, **2**, **4**, **5**, **6**, or **8**.
                            /// *   Default value: **2**.
                            /// </summary>
                            [NameInMap("Channels")]
                            [Validation(Required=false)]
                            public string Channels { get; set; }

                            /// <summary>
                            /// The audio codec.
                            /// 
                            /// *   Valid values: **aac**, **mp3**, **vorbis**, and **flac**.
                            /// *   Default value: **aac**.
                            /// </summary>
                            [NameInMap("Codec")]
                            [Validation(Required=false)]
                            public string Codec { get; set; }

                            /// <summary>
                            /// The codec profile of the audio.
                            /// 
                            /// >  Valid values if the value of **Codec** is **aac**: **aac_low**, **aac_he**, **aac_he_v2**, **aac_ld**, and **aac_eld**.
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
                            /// *   Valid values: **22050**, **32000**, **44100**, **48000**, and **96000**.
                            /// *   Unit: Hz.
                            /// *   Default value: **44100**.
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
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputAudioVolume Volume { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputAudioVolume : TeaModel {
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
                        /// *   Format: 0:a:{Sequence number}. Example: 0:a:0.
                        /// *   The sequence number is the index of the audio stream in the list and starts from 0.
                        /// *   If no sequence number is specified, the default audio stream is used.
                        /// </summary>
                        [NameInMap("AudioStreamMap")]
                        [Validation(Required=false)]
                        public string AudioStreamMap { get; set; }

                        /// <summary>
                        /// The information about the clip.
                        /// </summary>
                        [NameInMap("Clip")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputClip Clip { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputClip : TeaModel {
                            /// <summary>
                            /// The time span of the clip.
                            /// </summary>
                            [NameInMap("TimeSpan")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputClipTimeSpan TimeSpan { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputClipTimeSpan : TeaModel {
                                /// <summary>
                                /// The duration of the clip.
                                /// 
                                /// *   Format: `hh:mm:ss[.SSS]` or `sssss[.SSS]`.
                                /// *   Valid values: `[00:00:00.000,23:59:59.999]` or `[0.000,86399.999]`.
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                /// <summary>
                                /// The start time.
                                /// 
                                /// *   Format: `hh:mm:ss[.SSS]` or `sssss[.SSS]`.
                                /// *   Valid values: `[00:00:00.000,23:59:59.999]` or `[0.000,86399.999]`.
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
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputContainer Container { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputContainer : TeaModel {
                            /// <summary>
                            /// The container format.
                            /// 
                            /// *   Default value: **mp4**.
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
                        /// The configurations of watermark blurring. The value is a JSON object. For more information, see the **DeWatermark** section of the [Parameter details](https://help.aliyun.com/document_detail/29253.html) topic.
                        /// </summary>
                        [NameInMap("DeWatermark")]
                        [Validation(Required=false)]
                        public string DeWatermark { get; set; }

                        /// <summary>
                        /// The digital watermarks.
                        /// </summary>
                        [NameInMap("DigiWaterMark")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputDigiWaterMark DigiWaterMark { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputDigiWaterMark : TeaModel {
                            /// <summary>
                            /// The transparency of the text or image.
                            /// 
                            /// *   Value values: **(0,1]**.
                            /// *   Default value: **1.0**.
                            /// </summary>
                            [NameInMap("Alpha")]
                            [Validation(Required=false)]
                            public string Alpha { get; set; }

                            /// <summary>
                            /// The details of the input file.
                            /// </summary>
                            [NameInMap("InputFile")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputDigiWaterMarkInputFile InputFile { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputDigiWaterMarkInputFile : TeaModel {
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

                            /// <summary>
                            /// The type of the watermark. If this parameter is specified in the request, the corresponding parameter in the watermark template is overwritten. Valid values:
                            /// 
                            /// *   **Image** (default)
                            /// *   **Text**
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        /// <summary>
                        /// The encryption configurations. Only outputs in the M3U8 format are supported.
                        /// </summary>
                        [NameInMap("Encryption")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputEncryption Encryption { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputEncryption : TeaModel {
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
                            /// The key encryption method. Keys cannot be transmitted to MPS in plaintext. Keys must be encrypted by using Base64 or Key Management Service (KMS). For example, if the key is encryptionkey128, you can encrypt the key by using the following method: Base64("encryptionkey128") or KMS(Base64("encryptionkey128").
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
                        /// The non-standard support configuration for M3U8. The value is a JSON object. For more information, see the **M3U8NonStandardSupport** section of the [Parameter details](https://help.aliyun.com/document_detail/29253.html) topic.
                        /// </summary>
                        [NameInMap("M3U8NonStandardSupport")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputM3U8NonStandardSupport M3U8NonStandardSupport { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputM3U8NonStandardSupport : TeaModel {
                            /// <summary>
                            /// The non-standard support configurations for TS files. The value is a JSON object. For more information, see the **TS** section of the [Parameter details](https://help.aliyun.com/document_detail/29253.html) topic.
                            /// </summary>
                            [NameInMap("TS")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputM3U8NonStandardSupportTS TS { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputM3U8NonStandardSupportTS : TeaModel {
                                /// <summary>
                                /// Indicates whether the output of the MD5 value of the TS file is supported in the M3U8 video. Valid values:
                                /// 
                                /// *   **true**
                                /// *   **false**
                                /// </summary>
                                [NameInMap("Md5Support")]
                                [Validation(Required=false)]
                                public bool? Md5Support { get; set; }

                                /// <summary>
                                /// Indicates whether the size of the TS file is generated in the output M3U8 video. Valid values:
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
                        /// The URL of the merging configuration file. Only one of **MergeList** and **MergeConfigUrl** takes effect.
                        /// 
                        /// *   The configuration file specified by MergeConfigUrl can contain up to 50 clips.
                        /// *   MergeConfigUrl indicates the URL of the configuration file for merging clips.
                        /// *   Make sure that the configuration file is stored as an object in OSS and that MPS can access the OSS object. For information about the file content, see the details about merging parameters.
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
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputMergeList MergeList { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputMergeList : TeaModel {
                            [NameInMap("Merge")]
                            [Validation(Required=false)]
                            public List<SubmitJobsResponseBodyJobResultListJobResultJobOutputMergeListMerge> Merge { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputMergeListMerge : TeaModel {
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
                                /// *   Example: `http://example-bucket-****.oss-cn-hangzhou.aliyuncs.com/example-object-****.flv`.
                                /// *   The OSS URL of the object must be URL-encoded by using the UTF-8 standard.
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
                        /// The transmuxing configurations. If this parameter is specified in the request, the corresponding configurations in the specified transcoding template are overwritten.
                        /// </summary>
                        [NameInMap("MuxConfig")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfig MuxConfig { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfig : TeaModel {
                            /// <summary>
                            /// The transmuxing configurations for GIF.
                            /// </summary>
                            [NameInMap("Gif")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfigGif Gif { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfigGif : TeaModel {
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
                            /// The segment configuration. The value is a JSON object.
                            /// </summary>
                            [NameInMap("Segment")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfigSegment Segment { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfigSegment : TeaModel {
                                /// <summary>
                                /// The length of the segment. The value is an integer. Unit: seconds.
                                /// 
                                /// *   Valid values: **[1,10]**.
                                /// *   Default value: **10**.
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
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfigWebp Webp { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfigWebp : TeaModel {
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
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputOpeningList OpeningList { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputOpeningList : TeaModel {
                            [NameInMap("Opening")]
                            [Validation(Required=false)]
                            public List<SubmitJobsResponseBodyJobResultListJobResultJobOutputOpeningListOpening> Opening { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputOpeningListOpening : TeaModel {
                                /// <summary>
                                /// The height of the opening part.
                                /// 
                                /// *   Valid values: values in the range of **(0,4096)**, **-1**, and **full**.
                                /// *   Default value: **-1**.
                                /// *   A value of **-1** indicates that the height of the source of the opening part is retained.
                                /// *   A value of **full** indicates that the height of the main part is used for the opening part.
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
                                /// The width of the opening part.
                                /// 
                                /// *   Valid values: values in the range of **(0,4096)**, **-1**, and **full**.
                                /// *   Default value: **-1**.
                                /// *   A value of **-1** indicates that the width of the source of the opening part is retained.
                                /// *   A value of **full** indicates that the width of the main part is used for the opening part.
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
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputOutSubtitleList OutSubtitleList { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputOutSubtitleList : TeaModel {
                            [NameInMap("OutSubtitle")]
                            [Validation(Required=false)]
                            public List<SubmitJobsResponseBodyJobResultListJobResultJobOutputOutSubtitleListOutSubtitle> OutSubtitle { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputOutSubtitleListOutSubtitle : TeaModel {
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
                                /// The details of the output file.
                                /// </summary>
                                [NameInMap("OutSubtitleFile")]
                                [Validation(Required=false)]
                                public SubmitJobsResponseBodyJobResultListJobResultJobOutputOutSubtitleListOutSubtitleOutSubtitleFile OutSubtitleFile { get; set; }
                                public class SubmitJobsResponseBodyJobResultListJobResultJobOutputOutSubtitleListOutSubtitleOutSubtitleFile : TeaModel {
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
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputOutputFile OutputFile { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputOutputFile : TeaModel {
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
                        /// *   A value of **10** indicates the highest priority.
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
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputProperties Properties { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputProperties : TeaModel {
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
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesFormat Format { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesFormat : TeaModel {
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
                            /// The frame rate of the video. The value is a number.
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
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreams Streams { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreams : TeaModel {
                                /// <summary>
                                /// The audio streams.
                                /// </summary>
                                [NameInMap("AudioStreamList")]
                                [Validation(Required=false)]
                                public SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsAudioStreamList AudioStreamList { get; set; }
                                public class SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsAudioStreamList : TeaModel {
                                    [NameInMap("AudioStream")]
                                    [Validation(Required=false)]
                                    public List<SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsAudioStreamListAudioStream> AudioStream { get; set; }
                                    public class SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsAudioStreamListAudioStream : TeaModel {
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
                                        /// The start time of the audio stream.
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
                                public SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsSubtitleStreamList SubtitleStreamList { get; set; }
                                public class SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsSubtitleStreamList : TeaModel {
                                    [NameInMap("SubtitleStream")]
                                    [Validation(Required=false)]
                                    public List<SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsSubtitleStreamListSubtitleStream> SubtitleStream { get; set; }
                                    public class SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsSubtitleStreamListSubtitleStream : TeaModel {
                                        /// <summary>
                                        /// The sequence number of the subtitle stream. The value indicates the position of the subtitle stream in all subtitle streams.
                                        /// </summary>
                                        [NameInMap("Index")]
                                        [Validation(Required=false)]
                                        public string Index { get; set; }

                                        /// <summary>
                                        /// The language of the subtitle stream. For more information, see [FFmpeg documentation](https://www.ffmpeg.org/ffmpeg-all.html#Metadata) and [ISO 639](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes).
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
                                public SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsVideoStreamList VideoStreamList { get; set; }
                                public class SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsVideoStreamList : TeaModel {
                                    [NameInMap("VideoStream")]
                                    [Validation(Required=false)]
                                    public List<SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                                    public class SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsVideoStreamListVideoStream : TeaModel {
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
                                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
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
                                        /// The start time of the video stream.
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
                        /// The rotation angle of the video, in the clockwise direction.
                        /// </summary>
                        [NameInMap("Rotate")]
                        [Validation(Required=false)]
                        public string Rotate { get; set; }

                        /// <summary>
                        /// The subtitle configurations.
                        /// </summary>
                        [NameInMap("SubtitleConfig")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfig SubtitleConfig { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfig : TeaModel {
                            /// <summary>
                            /// The external subtitles. The value is a JSON array that contains up to **four** objects.
                            /// </summary>
                            [NameInMap("ExtSubtitleList")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfigExtSubtitleList ExtSubtitleList { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfigExtSubtitleList : TeaModel {
                                [NameInMap("ExtSubtitle")]
                                [Validation(Required=false)]
                                public List<SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfigExtSubtitleListExtSubtitle> ExtSubtitle { get; set; }
                                public class SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfigExtSubtitleListExtSubtitle : TeaModel {
                                    /// <summary>
                                    /// The character set used by the external subtitle.
                                    /// 
                                    /// *   Valid values: **UTF-8**, **GBK**, **BIG5**, and **auto**.
                                    /// *   Default value: **auto**.
                                    /// 
                                    /// >  If this parameter is set to **auto**, the detected character set may not be the actual character set. We recommend that you set this parameter to another value.
                                    /// </summary>
                                    [NameInMap("CharEnc")]
                                    [Validation(Required=false)]
                                    public string CharEnc { get; set; }

                                    /// <summary>
                                    /// The font of the hardcoded subtitles converted from external subtitles. Default value: **SimSun**. For more information, see [Fonts](https://help.aliyun.com/document_detail/59950.html).
                                    /// </summary>
                                    [NameInMap("FontName")]
                                    [Validation(Required=false)]
                                    public string FontName { get; set; }

                                    /// <summary>
                                    /// The OSS object that is used as the external subtitle. The value is a JSON object. Files in the **SRT** or **ASS** format are supported.
                                    /// </summary>
                                    [NameInMap("Input")]
                                    [Validation(Required=false)]
                                    public SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfigExtSubtitleListExtSubtitleInput Input { get; set; }
                                    public class SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfigExtSubtitleListExtSubtitleInput : TeaModel {
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
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfigSubtitleList SubtitleList { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfigSubtitleList : TeaModel {
                                [NameInMap("Subtitle")]
                                [Validation(Required=false)]
                                public List<SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfigSubtitleListSubtitle> Subtitle { get; set; }
                                public class SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfigSubtitleListSubtitle : TeaModel {
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
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputSuperReso SuperReso { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputSuperReso : TeaModel {
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
                        /// The ending parts. The value is a JSON object.
                        /// </summary>
                        [NameInMap("TailSlateList")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputTailSlateList TailSlateList { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputTailSlateList : TeaModel {
                            [NameInMap("TailSlate")]
                            [Validation(Required=false)]
                            public List<SubmitJobsResponseBodyJobResultListJobResultJobOutputTailSlateListTailSlate> TailSlate { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputTailSlateListTailSlate : TeaModel {
                                /// <summary>
                                /// The color of the bars that are added to the ending part if the size of the ending part is smaller than that of the main part. Default value: **White**. For more information, see [Background colors](https://docs-aliyun.cn-hangzhou.oss.aliyun-inc.com/assets/attach/29253/cn_zh/1502784952344/color.txt?spm=a2c4g.11186623.2.63.241240f77qp3Yy\\&file=color.txt).
                                /// </summary>
                                [NameInMap("BgColor")]
                                [Validation(Required=false)]
                                public string BgColor { get; set; }

                                /// <summary>
                                /// The duration of the transition between the main part and the ending part. A fade transition is used: The last frame of the main part fades out, and the first frame of the ending part fades in. Unit: seconds. Default value: **0**.
                                /// </summary>
                                [NameInMap("BlendDuration")]
                                [Validation(Required=false)]
                                public string BlendDuration { get; set; }

                                /// <summary>
                                /// The height of the ending part.
                                /// 
                                /// *   Valid values: values in the range of **(0,4096)**, **-1**, and **full**.
                                /// *   A value of **-1** indicates that the height of the source of the ending part is retained. A value of **full** indicates that the height of the main part is used for the ending part.
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
                                /// The width of the ending part.
                                /// 
                                /// *   Valid values: values in the range of **(0,4096)**, **-1**, and **full**.
                                /// *   A value of **-1** indicates that the width of the source of the ending part is retained. A value of **full** indicates that the width of the main part is used for the ending part.
                                /// *   Default value: -1.
                                /// </summary>
                                [NameInMap("Width")]
                                [Validation(Required=false)]
                                public string Width { get; set; }

                            }

                        }

                        /// <summary>
                        /// The ID of the transcoding template.
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                        /// <summary>
                        /// The general transcoding configurations.
                        /// 
                        /// >  If this parameter is specified in the request, the corresponding parameter in the specified transcoding template are overwritten.
                        /// </summary>
                        [NameInMap("TransConfig")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputTransConfig TransConfig { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputTransConfig : TeaModel {
                            /// <summary>
                            /// The method of resolution adjustment. Default value: **none**. Valid values:
                            /// 
                            /// *   rescale: The video image is resized.
                            /// *   crop: The video image is cropped.
                            /// *   pad: The video image is scaled out to fill the view.
                            /// *   none: The resolution is not adjusted.
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
                            /// Indicates whether the audio bitrate is checked. This parameter has a higher priority than **IsCheckAudioBitrate**. If the bitrate of the output audio is higher than that of the input audio, a transcoding failure is returned without transcoding the audio. Valid values:
                            /// 
                            /// *   **false**
                            /// *   **true**
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
                            /// Indicates whether the resolution is checked. This parameter has a higher priority than IsCheckReso. If the output resolution is higher than the input resolution based on the width or height, a transcoding failure is returned without transcoding the video. Valid values:
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
                            /// Indicates whether the video bitrate is checked. If the bitrate of the output video is higher than that of the input video, a transcoding failure is returned without transcoding the video. This parameter has a higher priority than**IsCheckVideoBitrate**. Valid values:
                            /// 
                            /// *   **true**
                            /// *   **false**
                            /// *   Default value: **false**.
                            /// </summary>
                            [NameInMap("IsCheckVideoBitrateFail")]
                            [Validation(Required=false)]
                            public string IsCheckVideoBitrateFail { get; set; }

                            /// <summary>
                            /// The transcoding mode. Valid values:
                            /// 
                            /// *   **onepass**: transcoding based on one-pass algorithms, which has higher accuracy.
                            /// *   **twopass**: transcoding based on two-pass algorithms, which has lower accuracy.
                            /// *   **CBR**: transcoding based on a fixed bitrate.
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
                        /// 
                        /// >  If this parameter is specified, **AliyunVideoCodec** in the template specified by **TemplateId** is overwritten.
                        /// </summary>
                        [NameInMap("Video")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputVideo Video { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputVideo : TeaModel {
                            /// <summary>
                            /// The bitrate of the output video. Unit: Kbit/s.
                            /// </summary>
                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            /// <summary>
                            /// The average bitrate range of the video.
                            /// </summary>
                            [NameInMap("BitrateBnd")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputVideoBitrateBnd BitrateBnd { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputVideoBitrateBnd : TeaModel {
                                /// <summary>
                                /// The upper limit of the total bitrate. Unit: Kbit/s.
                                /// </summary>
                                [NameInMap("Max")]
                                [Validation(Required=false)]
                                public string Max { get; set; }

                                /// <summary>
                                /// The lower limit of the total bitrate. Unit: Kbit/s.
                                /// </summary>
                                [NameInMap("Min")]
                                [Validation(Required=false)]
                                public string Min { get; set; }

                            }

                            /// <summary>
                            /// The size of the buffer.
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
                            /// *   Valid values: **H.264**, **H.265**, **GIF**, and **WEBP**.
                            /// *   Default value: **H.264**.
                            /// </summary>
                            [NameInMap("Codec")]
                            [Validation(Required=false)]
                            public string Codec { get; set; }

                            /// <summary>
                            /// The constant rate factor.
                            /// 
                            /// *   If **Crf** is returned, the value of **Bitrate** is invalid.
                            /// *   Default value if the value of Codec is H.264: **23**. Default value if the value of Codec is H.265: **26**.
                            /// </summary>
                            [NameInMap("Crf")]
                            [Validation(Required=false)]
                            public string Crf { get; set; }

                            /// <summary>
                            /// The method of video cropping. Valid values:
                            /// 
                            /// *   **border**: Black borders are automatically detected and removed.
                            /// *   A value in the format of width:height:left:top: The video is cropped based on the custom settings.
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
                            /// *   Unit: frames per second.
                            /// *   Valid values: 0 to 60. The value is 60 if the frame rate of the input file exceeds 60.
                            /// *   Default value: the frame rate of the input file.
                            /// </summary>
                            [NameInMap("Fps")]
                            [Validation(Required=false)]
                            public string Fps { get; set; }

                            /// <summary>
                            /// The maximum interval between keyframes or the maximum number of frames in a frame group. Unit: seconds.
                            /// 
                            /// *   Default value: 10.
                            /// *   If the maximum number of frames is returned, the value does not have a unit.
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
                            /// The black borders that are added to the video.
                            /// 
                            /// *   The value is in the width:height:left:top format.
                            /// *   Unit: pixel.
                            /// </summary>
                            [NameInMap("Pad")]
                            [Validation(Required=false)]
                            public string Pad { get; set; }

                            /// <summary>
                            /// The pixel format of the video.
                            /// 
                            /// *   The default pixel format can be **yuv420p** or the pixel format of the input file.
                            /// 
                            /// *   Valid values: standard pixel formats such as **yuv420p** and **yuvj420p**.
                            /// 
                            ///     **
                            /// 
                            ///     **Note** If a non-standard pixel format such as yuvj420p(pc, bt470bg/bt470bg/smpte170m) is used, compatibility with the pixel format must be configured. Otherwise, the transcoding job fails.
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
                            /// The encoding profile. This parameter is returned only for the H.264 codec. Default value: **high**. Valid values:
                            /// 
                            /// >  If multiple definitions are involved, we recommend that you use baseline for the lowest definition to ensure normal playback on low-definition devices, and use main or high for other definitions.
                            /// 
                            /// *   **baseline**: applicable to mobile devices.
                            /// *   **main**: applicable to standard-definition devices.
                            /// *   **high**: applicable to high-definition devices.
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
                            /// *   Default value: **the width of the input video**.
                            /// </summary>
                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                        }

                        /// <summary>
                        /// The sequence number of the video stream.
                        /// 
                        /// *   Format: 0:a:{Sequence number}. Example: 0:a:0.
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
                        /// 
                        /// >  If watermarks are truncated or fail to be generated, check whether the text watermarks that you add contain special characters. If the text watermarks contain special characters, you must escape the special characters before you add the watermarks. Alternatively, you can [submit a ticket](https://workorder-intl.console.aliyun.com/?spm=5176.12246746.top-nav.dticket.68797bbcm8H408#/ticket/add/?productId=1232) to contact Alibaba Cloud customer service for compatibility processing.
                        /// </summary>
                        [NameInMap("WaterMarkList")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputWaterMarkList WaterMarkList { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputWaterMarkList : TeaModel {
                            [NameInMap("WaterMark")]
                            [Validation(Required=false)]
                            public List<SubmitJobsResponseBodyJobResultListJobResultJobOutputWaterMarkListWaterMark> WaterMark { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputWaterMarkListWaterMark : TeaModel {
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
                                ///     *   Valid values: **[8,4096]**.
                                ///     *   Unit: pixel.
                                /// 
                                /// *   A decimal number indicates the ratio of the vertical offset to the height in the output video resolution.
                                /// 
                                ///     *   Valid values: **(0,1)**.
                                ///     *   The decimal number can be accurate to four decimal places, such as 0.9999. Excess digits are automatically deleted.
                                /// </summary>
                                [NameInMap("Dy")]
                                [Validation(Required=false)]
                                public string Dy { get; set; }

                                /// <summary>
                                /// The height of the watermark. If this parameter is specified in the request, the corresponding parameter in the watermark template is overwritten. The value can be an integer or a decimal number.
                                /// 
                                /// *   An integer indicates the pixel value of the watermark height.
                                /// 
                                ///     *   Valid values: **[8,4096]**.
                                ///     *   Unit: pixel.
                                /// 
                                /// *   A decimal number indicates the ratio of the watermark height to the height in the output video resolution.
                                /// 
                                ///     *   Valid values: **(0,1)**.
                                ///     *   The decimal number can be accurate to four decimal places, such as 0.9999. Excess digits are automatically deleted.
                                /// </summary>
                                [NameInMap("Height")]
                                [Validation(Required=false)]
                                public string Height { get; set; }

                                /// <summary>
                                /// The watermark input file. PNG images and MOV files are supported.
                                /// </summary>
                                [NameInMap("InputFile")]
                                [Validation(Required=false)]
                                public SubmitJobsResponseBodyJobResultListJobResultJobOutputWaterMarkListWaterMarkInputFile InputFile { get; set; }
                                public class SubmitJobsResponseBodyJobResultListJobResultJobOutputWaterMarkListWaterMarkInputFile : TeaModel {
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

                                /// <summary>
                                /// The position of the watermark. If this parameter is specified in the request, the corresponding parameter in the watermark template is overwritten. Valid values:
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
                                ///     *   Valid values: **[8,4096]**.
                                ///     *   Unit: pixel.
                                /// 
                                /// *   A decimal number indicates the ratio of the watermark width to the width in the output video resolution.
                                /// 
                                ///     *   Valid values: **(0,1)**.
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
                    /// *   **TranscodeFail**
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                }

                /// <summary>
                /// The error message returned if the job failed to be created. This parameter is not returned if the job was created.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// Indicates whether the job was successful. Valid values:
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
