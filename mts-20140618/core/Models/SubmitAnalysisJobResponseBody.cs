// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitAnalysisJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the preset template analysis job that was submitted.</para>
        /// </summary>
        [NameInMap("AnalysisJob")]
        [Validation(Required=false)]
        public SubmitAnalysisJobResponseBodyAnalysisJob AnalysisJob { get; set; }
        public class SubmitAnalysisJobResponseBodyAnalysisJob : TeaModel {
            /// <summary>
            /// <para>The job configurations.</para>
            /// </summary>
            [NameInMap("AnalysisConfig")]
            [Validation(Required=false)]
            public SubmitAnalysisJobResponseBodyAnalysisJobAnalysisConfig AnalysisConfig { get; set; }
            public class SubmitAnalysisJobResponseBodyAnalysisJobAnalysisConfig : TeaModel {
                /// <summary>
                /// <para>The control on the attributes of the job output.</para>
                /// </summary>
                [NameInMap("PropertiesControl")]
                [Validation(Required=false)]
                public SubmitAnalysisJobResponseBodyAnalysisJobAnalysisConfigPropertiesControl PropertiesControl { get; set; }
                public class SubmitAnalysisJobResponseBodyAnalysisJobAnalysisConfigPropertiesControl : TeaModel {
                    /// <summary>
                    /// <para>The cropping configurations of video images.</para>
                    /// </summary>
                    [NameInMap("Crop")]
                    [Validation(Required=false)]
                    public SubmitAnalysisJobResponseBodyAnalysisJobAnalysisConfigPropertiesControlCrop Crop { get; set; }
                    public class SubmitAnalysisJobResponseBodyAnalysisJobAnalysisConfigPropertiesControlCrop : TeaModel {
                        /// <summary>
                        /// <para>The height of the video after the margins were cropped out.</para>
                        /// <remarks>
                        /// <para>This parameter is invalid if the <b>Mode</b> parameter is set to Auto or None.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        /// <summary>
                        /// <para>The left margin that was cropped out.</para>
                        /// <remarks>
                        /// <para>This parameter is invalid if the <b>Mode</b> parameter is set to Auto or None.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8</para>
                        /// </summary>
                        [NameInMap("Left")]
                        [Validation(Required=false)]
                        public string Left { get; set; }

                        /// <summary>
                        /// <para>The cropping mode. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Auto</b>: Cropping was automatically run. This is the default value.</description></item>
                        /// <item><description><b>Force</b>: Cropping was forced to run.</description></item>
                        /// <item><description><b>None</b>: Cropping was forced not to run.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Auto</para>
                        /// </summary>
                        [NameInMap("Mode")]
                        [Validation(Required=false)]
                        public string Mode { get; set; }

                        /// <summary>
                        /// <para>The top margin that was cropped out.</para>
                        /// <remarks>
                        /// <para>This parameter is invalid if the <b>Mode</b> parameter is set to Auto or None.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8</para>
                        /// </summary>
                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public string Top { get; set; }

                        /// <summary>
                        /// <para>The width of the video after the margins were cropped out.</para>
                        /// <remarks>
                        /// <para>This parameter is invalid if the <b>Mode</b> parameter is set to Auto or None.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                    }

                    /// <summary>
                    /// <para>Indicates whether deinterlacing was forced to run. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Auto</b>: Deinterlacing was automatically run.</description></item>
                    /// <item><description><b>Force</b>: Deinterlacing was forced to run.</description></item>
                    /// <item><description><b>None</b>: Deinterlacing was forced not to run.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Force</para>
                    /// </summary>
                    [NameInMap("Deinterlace")]
                    [Validation(Required=false)]
                    public string Deinterlace { get; set; }

                }

                /// <summary>
                /// <para>The quality control on the job output.</para>
                /// </summary>
                [NameInMap("QualityControl")]
                [Validation(Required=false)]
                public SubmitAnalysisJobResponseBodyAnalysisJobAnalysisConfigQualityControl QualityControl { get; set; }
                public class SubmitAnalysisJobResponseBodyAnalysisJobAnalysisConfigQualityControl : TeaModel {
                    /// <summary>
                    /// <para>The playback mode. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>network</b>: online playback</description></item>
                    /// <item><description><b>local</b>: playback on local devices</description></item>
                    /// <item><description>Default value: <b>network</b>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>network</para>
                    /// </summary>
                    [NameInMap("MethodStreaming")]
                    [Validation(Required=false)]
                    public string MethodStreaming { get; set; }

                    /// <summary>
                    /// <para>The quality level of the output file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("RateQuality")]
                    [Validation(Required=false)]
                    public string RateQuality { get; set; }

                }

            }

            /// <summary>
            /// <para>The error code returned if the job failed. This parameter is not returned if the job was successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidParameter.ResourceNotFound</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The time when the job was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2014-01-10T12:00:00Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the template analysis job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>57f6aa3f84824309bcba67231b40****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The information about the job input.</para>
            /// </summary>
            [NameInMap("InputFile")]
            [Validation(Required=false)]
            public SubmitAnalysisJobResponseBodyAnalysisJobInputFile InputFile { get; set; }
            public class SubmitAnalysisJobResponseBodyAnalysisJobInputFile : TeaModel {
                /// <summary>
                /// <para>The name of the OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-bucket</para>
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <para>The ID of the OSS region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-cn-hangzhou</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <para>The name of the OSS object that is used as the input file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.flv</para>
                /// </summary>
                [NameInMap("Object")]
                [Validation(Required=false)]
                public string Object { get; set; }

            }

            /// <summary>
            /// <para>The message sent by MNS to notify users of the job result.</para>
            /// </summary>
            [NameInMap("MNSMessageResult")]
            [Validation(Required=false)]
            public SubmitAnalysisJobResponseBodyAnalysisJobMNSMessageResult MNSMessageResult { get; set; }
            public class SubmitAnalysisJobResponseBodyAnalysisJobMNSMessageResult : TeaModel {
                /// <summary>
                /// <para>The error code returned if the job failed. This parameter is not returned if the job was successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InvalidParameter.ResourceNotFound</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message returned if the job failed. This parameter is not returned if the job was successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The resource operated \&quot;PipelineId\&quot; cannot be found</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The ID of the message returned if the job was successful. This parameter is not returned if the job failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3ca84a39a9024f19853b21be9cf9****</para>
                /// </summary>
                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

            }

            /// <summary>
            /// <para>The error message returned if the job failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The resource operated \&quot;PipelineId\&quot; cannot be found</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The transcoding progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public long? Percent { get; set; }

            /// <summary>
            /// <para>The ID of the MPS queue to which the analysis job was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bb558c1cc25b45309aab5be44d19****</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The priority of the job in the MPS queue to which the job was submitted.</para>
            /// <list type="bullet">
            /// <item><description>Valid values: <b>1 to 10</b>. A value of 10 indicates the highest priority.</description></item>
            /// <item><description>Default value: <b>10</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The status of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Submitted</b>: The job is submitted.</description></item>
            /// <item><description><b>Analyzing</b>: The job is being run.</description></item>
            /// <item><description><b>Success</b>: The job is successful.</description></item>
            /// <item><description><b>Fail</b>: The job fails.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The matched preset templates.</para>
            /// </summary>
            [NameInMap("TemplateList")]
            [Validation(Required=false)]
            public SubmitAnalysisJobResponseBodyAnalysisJobTemplateList TemplateList { get; set; }
            public class SubmitAnalysisJobResponseBodyAnalysisJobTemplateList : TeaModel {
                [NameInMap("Template")]
                [Validation(Required=false)]
                public List<SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplate> Template { get; set; }
                public class SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplate : TeaModel {
                    /// <summary>
                    /// <para>The audio codec configurations.</para>
                    /// </summary>
                    [NameInMap("Audio")]
                    [Validation(Required=false)]
                    public SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateAudio Audio { get; set; }
                    public class SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateAudio : TeaModel {
                        /// <summary>
                        /// <para>The audio bitrate of the output file.</para>
                        /// <list type="bullet">
                        /// <item><description>Unit: Kbit/s.</description></item>
                        /// <item><description>Default value: <b>128</b>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8</para>
                        /// </summary>
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        /// <summary>
                        /// <para>The number of sound channels. Default value: <b>2</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Channels")]
                        [Validation(Required=false)]
                        public string Channels { get; set; }

                        /// <summary>
                        /// <para>The audio codec format. Default value: <b>acc</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mp3</para>
                        /// </summary>
                        [NameInMap("Codec")]
                        [Validation(Required=false)]
                        public string Codec { get; set; }

                        /// <summary>
                        /// <para>The codec profile of the audio. Valid values if the <b>Codec</b> parameter is set to <b>aac</b>: aac_low, aac_he, aac_he_v2, aac_ld, and aac_eld.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>aac_low</para>
                        /// </summary>
                        [NameInMap("Profile")]
                        [Validation(Required=false)]
                        public string Profile { get; set; }

                        /// <summary>
                        /// <para>The level of quality control on the audio.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Qscale")]
                        [Validation(Required=false)]
                        public string Qscale { get; set; }

                        /// <summary>
                        /// <para>The sampling rate.</para>
                        /// <list type="bullet">
                        /// <item><description>Unit: Hz.</description></item>
                        /// <item><description>Default value: <b>44100</b>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>32000</para>
                        /// </summary>
                        [NameInMap("Samplerate")]
                        [Validation(Required=false)]
                        public string Samplerate { get; set; }

                    }

                    /// <summary>
                    /// <para>The container format configurations.</para>
                    /// </summary>
                    [NameInMap("Container")]
                    [Validation(Required=false)]
                    public SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateContainer Container { get; set; }
                    public class SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateContainer : TeaModel {
                        /// <summary>
                        /// <para>The container format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>flv</para>
                        /// </summary>
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                    }

                    /// <summary>
                    /// <para>The ID of the transcoding template.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>S00000000-00****</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The transmuxing configurations.</para>
                    /// </summary>
                    [NameInMap("MuxConfig")]
                    [Validation(Required=false)]
                    public SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateMuxConfig MuxConfig { get; set; }
                    public class SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateMuxConfig : TeaModel {
                        /// <summary>
                        /// <para>The transmuxing configurations for the GIF format.</para>
                        /// </summary>
                        [NameInMap("Gif")]
                        [Validation(Required=false)]
                        public SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateMuxConfigGif Gif { get; set; }
                        public class SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateMuxConfigGif : TeaModel {
                            /// <summary>
                            /// <para>The interval between two consecutive loops for the GIF format. Unit: 0.01s. For example, a value of 500 indicates 5 seconds.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("FinalDelay")]
                            [Validation(Required=false)]
                            public string FinalDelay { get; set; }

                            /// <summary>
                            /// <para>The number of loops for the GIF or WebP format. Default value: 0.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("Loop")]
                            [Validation(Required=false)]
                            public string Loop { get; set; }

                        }

                        /// <summary>
                        /// <para>The segment configurations.</para>
                        /// </summary>
                        [NameInMap("Segment")]
                        [Validation(Required=false)]
                        public SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateMuxConfigSegment Segment { get; set; }
                        public class SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateMuxConfigSegment : TeaModel {
                            /// <summary>
                            /// <para>The length of the segment. Unit: seconds.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>60</para>
                            /// </summary>
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The name of the template.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FLV-UD</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The status of the template.</para>
                    /// <list type="bullet">
                    /// <item><description><b>Normal</b>: The template is normal.</description></item>
                    /// <item><description><b>Deleted</b>: The template is deleted.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Normal</para>
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                    /// <summary>
                    /// <para>The general transcoding configurations.</para>
                    /// </summary>
                    [NameInMap("TransConfig")]
                    [Validation(Required=false)]
                    public SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateTransConfig TransConfig { get; set; }
                    public class SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateTransConfig : TeaModel {
                        /// <summary>
                        /// <para>The transcoding mode. Valid values: onepass, twopass, and CBR. Default value: <b>onepass</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>onepass</para>
                        /// </summary>
                        [NameInMap("TransMode")]
                        [Validation(Required=false)]
                        public string TransMode { get; set; }

                    }

                    /// <summary>
                    /// <para>The video codec configurations.</para>
                    /// </summary>
                    [NameInMap("Video")]
                    [Validation(Required=false)]
                    public SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateVideo Video { get; set; }
                    public class SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateVideo : TeaModel {
                        /// <summary>
                        /// <para>The average bitrate of the video. Unit: Kbit/s.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        /// <summary>
                        /// <para>The average bitrate range of the video.</para>
                        /// </summary>
                        [NameInMap("BitrateBnd")]
                        [Validation(Required=false)]
                        public SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateVideoBitrateBnd BitrateBnd { get; set; }
                        public class SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateVideoBitrateBnd : TeaModel {
                            /// <summary>
                            /// <para>The upper limit of the total bitrate. Unit: Kbit/s.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>20</para>
                            /// </summary>
                            [NameInMap("Max")]
                            [Validation(Required=false)]
                            public string Max { get; set; }

                            /// <summary>
                            /// <para>The lower limit of the total bitrate. Unit: Kbit/s.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Min")]
                            [Validation(Required=false)]
                            public string Min { get; set; }

                        }

                        /// <summary>
                        /// <para>The size of the buffer.</para>
                        /// <list type="bullet">
                        /// <item><description>Unit: KB.</description></item>
                        /// <item><description>Default value: <b>6000</b>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5000</para>
                        /// </summary>
                        [NameInMap("Bufsize")]
                        [Validation(Required=false)]
                        public string Bufsize { get; set; }

                        /// <summary>
                        /// <para>The video codec. Default value: <b>H.264</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>H.264</para>
                        /// </summary>
                        [NameInMap("Codec")]
                        [Validation(Required=false)]
                        public string Codec { get; set; }

                        /// <summary>
                        /// <para>The constant rate factor.</para>
                        /// <list type="bullet">
                        /// <item><description>Default value if the Codec parameter is set to H.264: <b>23</b>. Default value if the Codec parameter is set to H.265: <b>26</b>.</description></item>
                        /// <item><description>If this parameter is returned, the setting of the Bitrate parameter is invalid.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>27</para>
                        /// </summary>
                        [NameInMap("Crf")]
                        [Validation(Required=false)]
                        public string Crf { get; set; }

                        /// <summary>
                        /// <para>The strength of the independent noise reduction algorithm.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Degrain")]
                        [Validation(Required=false)]
                        public string Degrain { get; set; }

                        /// <summary>
                        /// <para>The frame rate.</para>
                        /// <list type="bullet">
                        /// <item><description>The value is 60 if the frame rate of the input video exceeds 60.</description></item>
                        /// <item><description>Default value: the frame rate of the input video.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("Fps")]
                        [Validation(Required=false)]
                        public string Fps { get; set; }

                        /// <summary>
                        /// <para>The maximum number of frames between two keyframes. Default value: <b>250</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Gop")]
                        [Validation(Required=false)]
                        public string Gop { get; set; }

                        /// <summary>
                        /// <para>The height of the video.</para>
                        /// <list type="bullet">
                        /// <item><description>Unit: pixel.</description></item>
                        /// <item><description>Default value: the height of the input video.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1880</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        /// <summary>
                        /// <para>The maximum bitrate of the video. Unit: Kbit/s.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Maxrate")]
                        [Validation(Required=false)]
                        public string Maxrate { get; set; }

                        /// <summary>
                        /// <para>The pixel format for video color encoding. Valid values: standard pixel formats such as yuv420p and yuvj420p.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>yuvj420p</para>
                        /// </summary>
                        [NameInMap("PixFmt")]
                        [Validation(Required=false)]
                        public string PixFmt { get; set; }

                        /// <summary>
                        /// <para>The preset video algorithm. Valid values: veryfast, fast, medium, slow, and slower. Default value: <b>medium</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>medium</para>
                        /// </summary>
                        [NameInMap("Preset")]
                        [Validation(Required=false)]
                        public string Preset { get; set; }

                        /// <summary>
                        /// <para>The codec profile. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>baseline</b>: applicable to mobile devices.</description></item>
                        /// <item><description><b>main</b>: applicable to standard-definition devices.</description></item>
                        /// <item><description><b>high</b>: applicable to high-definition devices.</description></item>
                        /// <item><description>Default value: <b>high</b>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>baseline</para>
                        /// </summary>
                        [NameInMap("Profile")]
                        [Validation(Required=false)]
                        public string Profile { get; set; }

                        /// <summary>
                        /// <para>The level of quality control on the video.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>15</para>
                        /// </summary>
                        [NameInMap("Qscale")]
                        [Validation(Required=false)]
                        public string Qscale { get; set; }

                        /// <summary>
                        /// <para>The scan mode. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>interlaced</b></description></item>
                        /// <item><description><b>progressive</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>progressive</para>
                        /// </summary>
                        [NameInMap("ScanMode")]
                        [Validation(Required=false)]
                        public string ScanMode { get; set; }

                        /// <summary>
                        /// <para>The width of the video.</para>
                        /// <list type="bullet">
                        /// <item><description>Unit: pixel.</description></item>
                        /// <item><description>Default value: the width of the input video.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1990</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The custom data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testid-001</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B52658D4-07AB-43CD-82B0-210958A65E23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
