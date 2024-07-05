// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryAnalysisJobListResponseBody : TeaModel {
        /// <summary>
        /// The IDs of template analysis jobs.
        /// </summary>
        [NameInMap("AnalysisJobList")]
        [Validation(Required=false)]
        public QueryAnalysisJobListResponseBodyAnalysisJobList AnalysisJobList { get; set; }
        public class QueryAnalysisJobListResponseBodyAnalysisJobList : TeaModel {
            [NameInMap("AnalysisJob")]
            [Validation(Required=false)]
            public List<QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJob> AnalysisJob { get; set; }
            public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJob : TeaModel {
                /// <summary>
                /// The job configurations.
                /// </summary>
                [NameInMap("AnalysisConfig")]
                [Validation(Required=false)]
                public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobAnalysisConfig AnalysisConfig { get; set; }
                public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobAnalysisConfig : TeaModel {
                    /// <summary>
                    /// The control on the attributes of the job output.
                    /// </summary>
                    [NameInMap("PropertiesControl")]
                    [Validation(Required=false)]
                    public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobAnalysisConfigPropertiesControl PropertiesControl { get; set; }
                    public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobAnalysisConfigPropertiesControl : TeaModel {
                        /// <summary>
                        /// The cropping configuration of the video image.
                        /// </summary>
                        [NameInMap("Crop")]
                        [Validation(Required=false)]
                        public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobAnalysisConfigPropertiesControlCrop Crop { get; set; }
                        public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobAnalysisConfigPropertiesControlCrop : TeaModel {
                            /// <summary>
                            /// The height of the video image after the margins are cropped out.
                            /// 
                            /// >  This parameter is invalid if the Mode parameter is set to Auto or None.
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            /// <summary>
                            /// The left margin to be cropped out.
                            /// 
                            /// >  This parameter is invalid if the Mode parameter is set to Auto or None.
                            /// </summary>
                            [NameInMap("Left")]
                            [Validation(Required=false)]
                            public string Left { get; set; }

                            /// <summary>
                            /// The cropping mode. Valid values:
                            /// 
                            /// *   **Auto**: Cropping was automatically run.
                            /// *   **Force**: Cropping was forced to run.
                            /// *   **None**: Cropping was forced not to run.
                            /// *   This parameter is required if the value of the Crop parameter is not an empty JSON {}.
                            /// </summary>
                            [NameInMap("Mode")]
                            [Validation(Required=false)]
                            public string Mode { get; set; }

                            /// <summary>
                            /// The top margin to be cropped out.
                            /// 
                            /// >  This parameter is invalid if the Mode parameter is set to Auto or None.
                            /// </summary>
                            [NameInMap("Top")]
                            [Validation(Required=false)]
                            public string Top { get; set; }

                            /// <summary>
                            /// The width of the video image after the margins are cropped out.
                            /// 
                            /// >  This parameter is invalid if the Mode parameter is set to Auto or None.
                            /// </summary>
                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                        }

                        /// <summary>
                        /// Specifies whether deinterlacing was forced to run. Valid values:
                        /// 
                        /// *   **Auto**: Deinterlacing was automatically run.
                        /// *   **Force**: Deinterlacing was forced to run.
                        /// *   **None**: Deinterlacing was forced not to run.
                        /// </summary>
                        [NameInMap("Deinterlace")]
                        [Validation(Required=false)]
                        public string Deinterlace { get; set; }

                    }

                    /// <summary>
                    /// The quality control on the job output.
                    /// </summary>
                    [NameInMap("QualityControl")]
                    [Validation(Required=false)]
                    public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobAnalysisConfigQualityControl QualityControl { get; set; }
                    public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobAnalysisConfigQualityControl : TeaModel {
                        /// <summary>
                        /// The playback mode. Valid values:
                        /// 
                        /// *   **network**: online playback.
                        /// *   **local**: playback on on-premises devices.
                        /// *   Default value: **network**.
                        /// </summary>
                        [NameInMap("MethodStreaming")]
                        [Validation(Required=false)]
                        public string MethodStreaming { get; set; }

                        /// <summary>
                        /// The quality level of the job output. Default value: **25**.
                        /// </summary>
                        [NameInMap("RateQuality")]
                        [Validation(Required=false)]
                        public string RateQuality { get; set; }

                    }

                }

                /// <summary>
                /// The error code returned if the job fails.
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
                /// The ID of the template analysis job.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The information about the job input.
                /// </summary>
                [NameInMap("InputFile")]
                [Validation(Required=false)]
                public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobInputFile InputFile { get; set; }
                public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobInputFile : TeaModel {
                    /// <summary>
                    /// The name of the OSS bucket in which the input file is stored.
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// The region in which OSS resides.
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
                /// The message sent by Message Service (MNS) to notify users of the job result.
                /// </summary>
                [NameInMap("MNSMessageResult")]
                [Validation(Required=false)]
                public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobMNSMessageResult MNSMessageResult { get; set; }
                public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobMNSMessageResult : TeaModel {
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
                    /// The ID of the message returned if the job was successful. This parameter is not returned if the job failed.
                    /// </summary>
                    [NameInMap("MessageId")]
                    [Validation(Required=false)]
                    public string MessageId { get; set; }

                }

                /// <summary>
                /// The error message returned if the job failed.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The transcoding progress.
                /// </summary>
                [NameInMap("Percent")]
                [Validation(Required=false)]
                public long? Percent { get; set; }

                /// <summary>
                /// The ID of the MPS queue to which the job was submitted.
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                /// <summary>
                /// The priority of the job in the ApsaraVideo Media Processing (MPS) queue to which the job was submitted.
                /// 
                /// *   Valid values: **1 to 10**. The value 10 indicates the highest priority.
                /// *   Default value: **10**.
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public string Priority { get; set; }

                /// <summary>
                /// The job status.
                /// 
                /// *   **Submitted**: The job was submitted.
                /// *   **Analyzing**: The job is in progress.
                /// *   **Success**: The job was successful.
                /// *   **Fail**: The job failed.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The matched preset templates.
                /// </summary>
                [NameInMap("TemplateList")]
                [Validation(Required=false)]
                public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateList TemplateList { get; set; }
                public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateList : TeaModel {
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public List<QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplate> Template { get; set; }
                    public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplate : TeaModel {
                        /// <summary>
                        /// The audio codec configurations.
                        /// </summary>
                        [NameInMap("Audio")]
                        [Validation(Required=false)]
                        public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateAudio Audio { get; set; }
                        public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateAudio : TeaModel {
                            /// <summary>
                            /// The audio bitrate of the output file.
                            /// 
                            /// *   Valid values: **8 to 1000**.
                            /// *   Unit: Kbit/s.
                            /// *   Default value: **128**.
                            /// </summary>
                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            /// <summary>
                            /// The number of sound channels. Default value: **2**.
                            /// </summary>
                            [NameInMap("Channels")]
                            [Validation(Required=false)]
                            public string Channels { get; set; }

                            /// <summary>
                            /// The audio codec. Default value: **aac**. Valid values:
                            /// 
                            /// *   **aac**
                            /// *   **mp3**
                            /// *   **vorbis**
                            /// *   **flac**
                            /// </summary>
                            [NameInMap("Codec")]
                            [Validation(Required=false)]
                            public string Codec { get; set; }

                            /// <summary>
                            /// The codec profile of the audio. Valid values when the **Codec** parameter is set to **aac**:
                            /// 
                            /// *   **aac_low**
                            /// *   **aac_he**
                            /// *   **aac_he_v2**
                            /// *   **aac_ld**
                            /// *   **aac_eld**
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
                            /// *   Unit: Hz.
                            /// *   Default value: **44100**.
                            /// </summary>
                            [NameInMap("Samplerate")]
                            [Validation(Required=false)]
                            public string Samplerate { get; set; }

                        }

                        /// <summary>
                        /// The container format configurations.
                        /// </summary>
                        [NameInMap("Container")]
                        [Validation(Required=false)]
                        public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateContainer Container { get; set; }
                        public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateContainer : TeaModel {
                            /// <summary>
                            /// The container format.
                            /// </summary>
                            [NameInMap("Format")]
                            [Validation(Required=false)]
                            public string Format { get; set; }

                        }

                        /// <summary>
                        /// The transcoding template ID.
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// The transmuxing configurations.
                        /// </summary>
                        [NameInMap("MuxConfig")]
                        [Validation(Required=false)]
                        public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateMuxConfig MuxConfig { get; set; }
                        public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateMuxConfig : TeaModel {
                            /// <summary>
                            /// The transmuxing configurations for the GIF format.
                            /// </summary>
                            [NameInMap("Gif")]
                            [Validation(Required=false)]
                            public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateMuxConfigGif Gif { get; set; }
                            public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateMuxConfigGif : TeaModel {
                                /// <summary>
                                /// The interval between two consecutive loops for the GIF format. Unit: 0.01 second. For example, a value of 500 indicates 5 seconds.
                                /// </summary>
                                [NameInMap("FinalDelay")]
                                [Validation(Required=false)]
                                public string FinalDelay { get; set; }

                                /// <summary>
                                /// The number of loops for the GIF or WebP format. Default value: 0.
                                /// </summary>
                                [NameInMap("Loop")]
                                [Validation(Required=false)]
                                public string Loop { get; set; }

                            }

                            /// <summary>
                            /// The segment configurations.
                            /// </summary>
                            [NameInMap("Segment")]
                            [Validation(Required=false)]
                            public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateMuxConfigSegment Segment { get; set; }
                            public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateMuxConfigSegment : TeaModel {
                                /// <summary>
                                /// The segment length. Unit: seconds.
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                            }

                        }

                        /// <summary>
                        /// The name of the template.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The state of the template. Valid values:
                        /// 
                        /// *   **Normal**
                        /// *   **Deleted**
                        /// </summary>
                        [NameInMap("State")]
                        [Validation(Required=false)]
                        public string State { get; set; }

                        /// <summary>
                        /// The general transcoding configurations.
                        /// </summary>
                        [NameInMap("TransConfig")]
                        [Validation(Required=false)]
                        public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateTransConfig TransConfig { get; set; }
                        public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateTransConfig : TeaModel {
                            /// <summary>
                            /// The transcoding mode. Default value: **onepass**. Valid values:
                            /// 
                            /// *   **onepass**
                            /// *   **twopass**
                            /// *   **CBR**
                            /// </summary>
                            [NameInMap("TransMode")]
                            [Validation(Required=false)]
                            public string TransMode { get; set; }

                        }

                        /// <summary>
                        /// The video codec configurations.
                        /// </summary>
                        [NameInMap("Video")]
                        [Validation(Required=false)]
                        public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateVideo Video { get; set; }
                        public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateVideo : TeaModel {
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
                            public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateVideoBitrateBnd BitrateBnd { get; set; }
                            public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateVideoBitrateBnd : TeaModel {
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
                            /// The buffer size.
                            /// 
                            /// *   Unit: KB.
                            /// *   Default value: **6000**.
                            /// </summary>
                            [NameInMap("Bufsize")]
                            [Validation(Required=false)]
                            public string Bufsize { get; set; }

                            /// <summary>
                            /// The codec. Valid values: H.264 and H.265. Default value: **H.264**.
                            /// </summary>
                            [NameInMap("Codec")]
                            [Validation(Required=false)]
                            public string Codec { get; set; }

                            /// <summary>
                            /// The constant rate factor.
                            /// 
                            /// *   Default value when the the Codec parameter is set to H.264: **23**, default value when the the Codec parameter is set to H.265: **26**.
                            /// *   If this parameter is specified, the value of the Bitrate parameter becomes invalid.
                            /// </summary>
                            [NameInMap("Crf")]
                            [Validation(Required=false)]
                            public string Crf { get; set; }

                            /// <summary>
                            /// The strength of the independent noise reduction algorithm.
                            /// </summary>
                            [NameInMap("Degrain")]
                            [Validation(Required=false)]
                            public string Degrain { get; set; }

                            /// <summary>
                            /// The frame rate of the video.
                            /// 
                            /// *   The value is 60 if the frame rate of the input file exceeds 60.
                            /// *   Default value: **the frame rate of the input video**.
                            /// </summary>
                            [NameInMap("Fps")]
                            [Validation(Required=false)]
                            public string Fps { get; set; }

                            /// <summary>
                            /// The maximum number of frames between two keyframes. Default value: **250**.
                            /// </summary>
                            [NameInMap("Gop")]
                            [Validation(Required=false)]
                            public string Gop { get; set; }

                            /// <summary>
                            /// The height of the video.
                            /// 
                            /// *   Unit: pixel.
                            /// *   Default value: **the height of the input video**.
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            /// <summary>
                            /// The maximum bitrate of the video.
                            /// 
                            /// *   Valid values: **10 to 50000**.
                            /// *   Unit: Kbit/s.
                            /// </summary>
                            [NameInMap("Maxrate")]
                            [Validation(Required=false)]
                            public string Maxrate { get; set; }

                            /// <summary>
                            /// The pixel format of the video. Valid values: standard pixel formats such as yuv420p and yuvj420p.
                            /// </summary>
                            [NameInMap("PixFmt")]
                            [Validation(Required=false)]
                            public string PixFmt { get; set; }

                            /// <summary>
                            /// The preset video algorithm. Valid values: veryfast, fast, medium, slow, and slower. Default value: **medium**.
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
                            /// The scan mode. Valid values:
                            /// 
                            /// *   **interlaced**
                            /// *   **progressive**
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

                    }

                }

                /// <summary>
                /// The custom data.
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

        }

        /// <summary>
        /// The message sent by Message Service (MNS) to notify the user of the job result.
        /// </summary>
        [NameInMap("NonExistAnalysisJobIds")]
        [Validation(Required=false)]
        public QueryAnalysisJobListResponseBodyNonExistAnalysisJobIds NonExistAnalysisJobIds { get; set; }
        public class QueryAnalysisJobListResponseBodyNonExistAnalysisJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        /// <summary>
        /// The status of the job. Valid values:
        /// 
        /// *   **Submitted**: The job has been submitted.
        /// *   **Analyzing**: The job is being run.
        /// *   **Success**: The job is successful.
        /// *   **Fail**: The job fails.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
