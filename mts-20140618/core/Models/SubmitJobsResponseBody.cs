// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The transcoding jobs that are generated.</para>
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
                /// <para>The error code returned if the job failed to be created. This parameter is not returned if the job was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InvalidParameter.NullValue</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The details of the job. If the job fails to be submitted, no job ID is generated.</para>
                /// </summary>
                [NameInMap("Job")]
                [Validation(Required=false)]
                public SubmitJobsResponseBodyJobResultListJobResultJob Job { get; set; }
                public class SubmitJobsResponseBodyJobResultListJobResultJob : TeaModel {
                    /// <summary>
                    /// <para>The error code returned if the job failed. This parameter is not returned if the job was successful.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>InternalError</para>
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
                    /// <para>The time when the job was complete.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2014-01-10T12:20:00Z</para>
                    /// </summary>
                    [NameInMap("FinishTime")]
                    [Validation(Required=false)]
                    public string FinishTime { get; set; }

                    /// <summary>
                    /// <para>The information about the job input.</para>
                    /// </summary>
                    [NameInMap("Input")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultJobInput Input { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultJobInput : TeaModel {
                        /// <summary>
                        /// <para>The name of the OSS bucket in which the job input is stored.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example-bucket-****</para>
                        /// </summary>
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }

                        /// <summary>
                        /// <para>The ID of the OSS region in which the job input is stored.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>oss-cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                        /// <summary>
                        /// <para>The name of the OSS object that is used as the job input.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example.flv</para>
                        /// </summary>
                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }

                    }

                    /// <summary>
                    /// <para>The job ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>31fa3c9ca8134f9cec2b4b0b0f78****</para>
                    /// </summary>
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    /// <summary>
                    /// <para>The message sent by MNS to notify users of the job result.</para>
                    /// </summary>
                    [NameInMap("MNSMessageResult")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultJobMNSMessageResult MNSMessageResult { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultJobMNSMessageResult : TeaModel {
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
                        /// <para>The resource operated &quot;%s&quot; cannot be found.</para>
                        /// </summary>
                        [NameInMap("ErrorMessage")]
                        [Validation(Required=false)]
                        public string ErrorMessage { get; set; }

                        /// <summary>
                        /// <para>The ID of the error message returned if the job failed. This parameter is not returned if the job was successful.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("MessageId")]
                        [Validation(Required=false)]
                        public string MessageId { get; set; }

                    }

                    /// <summary>
                    /// <para>The error message returned if the job failed. This parameter is not returned if the job was successful.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The operation has failed due to some unknown error, exception or failure.</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The output of the job.</para>
                    /// </summary>
                    [NameInMap("Output")]
                    [Validation(Required=false)]
                    public SubmitJobsResponseBodyJobResultListJobResultJobOutput Output { get; set; }
                    public class SubmitJobsResponseBodyJobResultListJobResultJobOutput : TeaModel {
                        /// <summary>
                        /// <para>The audio tracks that are mixed.</para>
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
                                /// <para>The URL of the audio track that is mixed as the background music.</para>
                                /// <list type="bullet">
                                /// <item><description>The URL can be an OSS URL or the string <c>input</c>.</description></item>
                                /// <item><description>A value of input indicates that two audio tracks are mixed in a video.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para><a href="https://outpu***.oss-cn-shanghai.aliyuncs.com/mp4-to-mp3%5E1571025263578816%40.mp3">https://outpu***.oss-cn-shanghai.aliyuncs.com/mp4-to-mp3%5E1571025263578816%40.mp3</a></para>
                                /// </summary>
                                [NameInMap("AmixURL")]
                                [Validation(Required=false)]
                                public string AmixURL { get; set; }

                                /// <summary>
                                /// <para>The duration of the mixed audio track. The value is in the number or time format.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>20</para>
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                /// <summary>
                                /// <para>The audio track that is mixed. Format: 0:a:{audio_index}. Example: 0:a:0.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>0:a:0</para>
                                /// </summary>
                                [NameInMap("Map")]
                                [Validation(Required=false)]
                                public string Map { get; set; }

                                /// <summary>
                                /// <para>The mode to specify the mixing duration. Valid values: <b>first</b> and <b>long</b>.</para>
                                /// <list type="bullet">
                                /// <item><description><b>first</b>: The length of the output media equals the length of the input media.</description></item>
                                /// <item><description><b>long</b>: The length of the output media equals the length of the output media or the length of the input media, whichever is longer.</description></item>
                                /// <item><description>Default value: <b>long</b>.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>long</para>
                                /// </summary>
                                [NameInMap("MixDurMode")]
                                [Validation(Required=false)]
                                public string MixDurMode { get; set; }

                                /// <summary>
                                /// <para>The start time. The value is in the number or time format. Examples: 1:25:36.240 and 32000.23.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>0</para>
                                /// </summary>
                                [NameInMap("Start")]
                                [Validation(Required=false)]
                                public string Start { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The audio configurations.</para>
                        /// <remarks>
                        /// <para> If this parameter is specified in the request, the corresponding configurations in the specified transcoding template are overwritten.</para>
                        /// </remarks>
                        /// </summary>
                        [NameInMap("Audio")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputAudio Audio { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputAudio : TeaModel {
                            /// <summary>
                            /// <para>The audio bitrate of the output file.</para>
                            /// <list type="bullet">
                            /// <item><description>Unit: Kbit/s.</description></item>
                            /// <item><description>Default value: <b>128</b>.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>128</para>
                            /// </summary>
                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            /// <summary>
                            /// <para>The number of sound channels.</para>
                            /// <list type="bullet">
                            /// <item><description>If the value of Codec is mp3, the value of this parameter can only be <b>1</b> or <b>2</b>.</description></item>
                            /// <item><description>If the value of Codec is aac, the value of this parameter can only be <b>1</b>, <b>2</b>, <b>4</b>, <b>5</b>, <b>6</b>, or <b>8</b>.</description></item>
                            /// <item><description>Default value: <b>2</b>.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>6</para>
                            /// </summary>
                            [NameInMap("Channels")]
                            [Validation(Required=false)]
                            public string Channels { get; set; }

                            /// <summary>
                            /// <para>The audio codec.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: <b>aac</b>, <b>mp3</b>, <b>vorbis</b>, and <b>flac</b>.</description></item>
                            /// <item><description>Default value: <b>aac</b>.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>aac</para>
                            /// </summary>
                            [NameInMap("Codec")]
                            [Validation(Required=false)]
                            public string Codec { get; set; }

                            /// <summary>
                            /// <para>The codec profile of the audio.</para>
                            /// <remarks>
                            /// <para> Valid values if the value of <b>Codec</b> is <b>aac</b>: <b>aac_low</b>, <b>aac_he</b>, <b>aac_he_v2</b>, <b>aac_ld</b>, and <b>aac_eld</b>.</para>
                            /// </remarks>
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
                            /// <para>15</para>
                            /// </summary>
                            [NameInMap("Qscale")]
                            [Validation(Required=false)]
                            public string Qscale { get; set; }

                            /// <summary>
                            /// <para>The sampling rate.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: <b>22050</b>, <b>32000</b>, <b>44100</b>, <b>48000</b>, and <b>96000</b>.</description></item>
                            /// <item><description>Unit: Hz.</description></item>
                            /// <item><description>Default value: <b>44100</b>.</description></item>
                            /// </list>
                            /// <remarks>
                            /// <para> If the video container format is FLV and the audio codec is MP3, the value of this parameter cannot be 32000, 48000, or 96000. If the audio codec is MP3, the value of this parameter cannot be 96000.</para>
                            /// </remarks>
                            /// 
                            /// <b>Example:</b>
                            /// <para>32000</para>
                            /// </summary>
                            [NameInMap("Samplerate")]
                            [Validation(Required=false)]
                            public string Samplerate { get; set; }

                            /// <summary>
                            /// <para>The volume configurations.</para>
                            /// </summary>
                            [NameInMap("Volume")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputAudioVolume Volume { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputAudioVolume : TeaModel {
                                /// <summary>
                                /// <para>The volume adjustment range.</para>
                                /// <list type="bullet">
                                /// <item><description>Unit: decibel.</description></item>
                                /// <item><description>Default value: <b>-20</b>.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>-20</para>
                                /// </summary>
                                [NameInMap("Level")]
                                [Validation(Required=false)]
                                public string Level { get; set; }

                                /// <summary>
                                /// <para>The method that is used to adjust the volume. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description><b>auto</b></description></item>
                                /// <item><description><b>dynamic</b></description></item>
                                /// <item><description><b>linear</b></description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>auto</para>
                                /// </summary>
                                [NameInMap("Method")]
                                [Validation(Required=false)]
                                public string Method { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The sequence number of the audio stream.</para>
                        /// <list type="bullet">
                        /// <item><description>Format: 0:a:{Sequence number}. Example: 0:a:0.</description></item>
                        /// <item><description>The sequence number is the index of the audio stream in the list and starts from 0.</description></item>
                        /// <item><description>If no sequence number is specified, the default audio stream is used.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0:a:0</para>
                        /// </summary>
                        [NameInMap("AudioStreamMap")]
                        [Validation(Required=false)]
                        public string AudioStreamMap { get; set; }

                        /// <summary>
                        /// <para>The information about the clip.</para>
                        /// </summary>
                        [NameInMap("Clip")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputClip Clip { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputClip : TeaModel {
                            /// <summary>
                            /// <para>The time span of the clip.</para>
                            /// </summary>
                            [NameInMap("TimeSpan")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputClipTimeSpan TimeSpan { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputClipTimeSpan : TeaModel {
                                /// <summary>
                                /// <para>The duration of the clip.</para>
                                /// <list type="bullet">
                                /// <item><description>Format: <c>hh:mm:ss[.SSS]</c> or <c>sssss[.SSS]</c>.</description></item>
                                /// <item><description>Valid values: <c>[00:00:00.000,23:59:59.999]</c> or <c>[0.000,86399.999]</c>.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>01:00:59.999</para>
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                /// <summary>
                                /// <para>The start time.</para>
                                /// <list type="bullet">
                                /// <item><description>Format: <c>hh:mm:ss[.SSS]</c> or <c>sssss[.SSS]</c>.</description></item>
                                /// <item><description>Valid values: <c>[00:00:00.000,23:59:59.999]</c> or <c>[0.000,86399.999]</c>.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>01:59:59.999</para>
                                /// </summary>
                                [NameInMap("Seek")]
                                [Validation(Required=false)]
                                public string Seek { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The container format configurations.</para>
                        /// </summary>
                        [NameInMap("Container")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputContainer Container { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputContainer : TeaModel {
                            /// <summary>
                            /// <para>The container format.</para>
                            /// <list type="bullet">
                            /// <item><description>Default value: <b>mp4</b>.</description></item>
                            /// <item><description>Video formats include FLV, MP4, HLS (M3U8 + TS), and MPEG-DASH (MPD + fMP4).</description></item>
                            /// <item><description>Audio formats include MP3, MP4, Ogg, FLAC, and M4A.</description></item>
                            /// <item><description>Image formats include GIF and WebP.</description></item>
                            /// <item><description>If the container format is GIF, the video codec must be GIF.</description></item>
                            /// <item><description>If the container format is WebP, the video codec must be WebP.</description></item>
                            /// <item><description>If the container format is FLV, the video codec cannot be H.265.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>flv</para>
                            /// </summary>
                            [NameInMap("Format")]
                            [Validation(Required=false)]
                            public string Format { get; set; }

                        }

                        /// <summary>
                        /// <para>The configurations of watermark blurring. The value is a JSON object. For more information, see the <b>DeWatermark</b> section of the <a href="https://help.aliyun.com/document_detail/29253.html">Parameter details</a> topic.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;0&quot;: [{&quot;l&quot;: 10,&quot;t&quot;: 10,&quot;w&quot;: 10,&quot;h&quot;: 10},{&quot;l&quot;: 100,&quot;t&quot;: 0.1,&quot;w&quot;: 10,&quot;h&quot;: 10}],&quot;128000&quot;: [],&quot;250000&quot;: [{&quot;l&quot;: 0.2,&quot;t&quot;: 0.1,&quot;w&quot;: 0.01,&quot;h&quot;: 0.05}]}</para>
                        /// </summary>
                        [NameInMap("DeWatermark")]
                        [Validation(Required=false)]
                        public string DeWatermark { get; set; }

                        /// <summary>
                        /// <para>The digital watermarks.</para>
                        /// </summary>
                        [NameInMap("DigiWaterMark")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputDigiWaterMark DigiWaterMark { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputDigiWaterMark : TeaModel {
                            /// <summary>
                            /// <para>The transparency of the text or image.</para>
                            /// <list type="bullet">
                            /// <item><description>Value values: <b>(0,1]</b>.</description></item>
                            /// <item><description>Default value: <b>1.0</b>.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1.0</para>
                            /// </summary>
                            [NameInMap("Alpha")]
                            [Validation(Required=false)]
                            public string Alpha { get; set; }

                            /// <summary>
                            /// <para>The details of the input file.</para>
                            /// </summary>
                            [NameInMap("InputFile")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputDigiWaterMarkInputFile InputFile { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputDigiWaterMarkInputFile : TeaModel {
                                /// <summary>
                                /// <para>The name of the OSS bucket in which the input file is stored.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>example-bucket-****</para>
                                /// </summary>
                                [NameInMap("Bucket")]
                                [Validation(Required=false)]
                                public string Bucket { get; set; }

                                /// <summary>
                                /// <para>The ID of the OSS region in which the input file is stored.</para>
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
                                /// <para>example-intput.flv</para>
                                /// </summary>
                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                            /// <summary>
                            /// <para>The type of the watermark. If this parameter is specified in the request, the corresponding parameter in the watermark template is overwritten. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>Image</b> (default)</description></item>
                            /// <item><description><b>Text</b></description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Image</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        /// <summary>
                        /// <para>The encryption configurations. Only outputs in the M3U8 format are supported.</para>
                        /// </summary>
                        [NameInMap("Encryption")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputEncryption Encryption { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputEncryption : TeaModel {
                            /// <summary>
                            /// <para>The encryption ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>31fa3c9ca8134f9cec2b4b0b0f78****</para>
                            /// </summary>
                            [NameInMap("Id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

                            /// <summary>
                            /// <para>The key that is used to encrypt the video.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>encryptionkey128</para>
                            /// </summary>
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            /// <summary>
                            /// <para>The key encryption method. Keys cannot be transmitted to MPS in plaintext. Keys must be encrypted by using Base64 or Key Management Service (KMS). For example, if the key is encryptionkey128, you can encrypt the key by using the following method: Base64(&quot;encryptionkey128&quot;) or KMS(Base64(&quot;encryptionkey128&quot;).</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Base64</para>
                            /// </summary>
                            [NameInMap("KeyType")]
                            [Validation(Required=false)]
                            public string KeyType { get; set; }

                            /// <summary>
                            /// <para>The URL that is used to request the key. The URL is Base64-encoded.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><a href="https://1161758785*****.cn-shanghai.fc.aliyuncs.com/2016-08-15/proxy/HLS-decyptServer/decyptServer/">https://1161758785*****.cn-shanghai.fc.aliyuncs.com/2016-08-15/proxy/HLS-decyptServer/decyptServer/</a></para>
                            /// </summary>
                            [NameInMap("KeyUri")]
                            [Validation(Required=false)]
                            public string KeyUri { get; set; }

                            /// <summary>
                            /// <para>The number of unencrypted frames at the beginning of the video. Leaving these frames unencrypted enables video playback to quickly start.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>3</para>
                            /// </summary>
                            [NameInMap("SkipCnt")]
                            [Validation(Required=false)]
                            public string SkipCnt { get; set; }

                            /// <summary>
                            /// <para>The encryption type. Only <b>hls-aes-128</b> may be returned.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>hls-aes-128</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        /// <summary>
                        /// <para>The non-standard support configuration for M3U8. The value is a JSON object. For more information, see the <b>M3U8NonStandardSupport</b> section of the <a href="https://help.aliyun.com/document_detail/29253.html">Parameter details</a> topic.</para>
                        /// </summary>
                        [NameInMap("M3U8NonStandardSupport")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputM3U8NonStandardSupport M3U8NonStandardSupport { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputM3U8NonStandardSupport : TeaModel {
                            /// <summary>
                            /// <para>The non-standard support configurations for TS files. The value is a JSON object. For more information, see the <b>TS</b> section of the <a href="https://help.aliyun.com/document_detail/29253.html">Parameter details</a> topic.</para>
                            /// </summary>
                            [NameInMap("TS")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputM3U8NonStandardSupportTS TS { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputM3U8NonStandardSupportTS : TeaModel {
                                /// <summary>
                                /// <para>Indicates whether the output of the MD5 value of the TS file is supported in the M3U8 video. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description><b>true</b></description></item>
                                /// <item><description><b>false</b></description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("Md5Support")]
                                [Validation(Required=false)]
                                public bool? Md5Support { get; set; }

                                /// <summary>
                                /// <para>Indicates whether the size of the TS file is generated in the output M3U8 video. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description><b>true</b></description></item>
                                /// <item><description><b>false</b></description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("SizeSupport")]
                                [Validation(Required=false)]
                                public bool? SizeSupport { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The URL of the merging configuration file. Only one of <b>MergeList</b> and <b>MergeConfigUrl</b> takes effect.</para>
                        /// <list type="bullet">
                        /// <item><description>The configuration file specified by MergeConfigUrl can contain up to 50 clips.</description></item>
                        /// <item><description>MergeConfigUrl indicates the URL of the configuration file for merging clips.</description></item>
                        /// <item><description>Make sure that the configuration file is stored as an object in OSS and that MPS can access the OSS object. For information about the file content, see the details about merging parameters.</description></item>
                        /// <item><description>Example of the content of the merging configuration file: <c>{&quot;MergeList&quot;:[{&quot;MergeURL&quot;:&quot;http://exampleBucket****.oss-cn-hangzhou.aliyuncs.com/video_01.mp4&quot;}]}</c>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>`{&quot;MergeList&quot;:[{&quot;MergeURL&quot;:&quot;<a href="http://exampleBucket****.oss-cn-hangzhou.aliyuncs.com/video_01.mp4%22%7D%5D%7D">http://exampleBucket****.oss-cn-hangzhou.aliyuncs.com/video_01.mp4&quot;}]}</a></para>
                        /// </summary>
                        [NameInMap("MergeConfigUrl")]
                        [Validation(Required=false)]
                        public string MergeConfigUrl { get; set; }

                        /// <summary>
                        /// <para>The configurations for merging clips.</para>
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
                                /// <para>The duration of the clip.</para>
                                /// <list type="bullet">
                                /// <item><description>Format: <c>hh:mm:ss[.SSS]</c> or <c>sssss[.SSS]</c>.</description></item>
                                /// <item><description>Examples: 01:59:59.999 and 32000.23.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>00000.20</para>
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                /// <summary>
                                /// <para>The OSS URL of the clip.</para>
                                /// <list type="bullet">
                                /// <item><description>Example: <c>http://example-bucket-****.oss-cn-hangzhou.aliyuncs.com/example-object-****.flv</c>.</description></item>
                                /// <item><description>The OSS URL of the object must be URL-encoded by using the UTF-8 standard.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para><a href="http://example-bucket-****.oss-cn-hangzhou.aliyuncs.com/example-object-****.flv">http://example-bucket-****.oss-cn-hangzhou.aliyuncs.com/example-object-****.flv</a></para>
                                /// </summary>
                                [NameInMap("MergeURL")]
                                [Validation(Required=false)]
                                public string MergeURL { get; set; }

                                /// <summary>
                                /// <para>The Alibaba Cloud Resource Name (ARN) of the Resource Access Management (RAM) role used for delegated authorization.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>acs:ram::<your uid>:role/<your role name></para>
                                /// </summary>
                                [NameInMap("RoleArn")]
                                [Validation(Required=false)]
                                public string RoleArn { get; set; }

                                /// <summary>
                                /// <para>The start point in time of the clip.</para>
                                /// <list type="bullet">
                                /// <item><description>Format: <c>hh:mm:ss[.SSS]</c> or <c>sssss[.SSS]</c>.</description></item>
                                /// <item><description>Examples: 01:59:59.999 and 32000.23.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>00000.50</para>
                                /// </summary>
                                [NameInMap("Start")]
                                [Validation(Required=false)]
                                public string Start { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The transmuxing configurations. If this parameter is specified in the request, the corresponding configurations in the specified transcoding template are overwritten.</para>
                        /// </summary>
                        [NameInMap("MuxConfig")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfig MuxConfig { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfig : TeaModel {
                            /// <summary>
                            /// <para>The transmuxing configurations for GIF.</para>
                            /// </summary>
                            [NameInMap("Gif")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfigGif Gif { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfigGif : TeaModel {
                                /// <summary>
                                /// <para>The color dithering algorithm of the palette. Valid values: <b>sierra</b> and <b>bayer</b>.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>bayer</para>
                                /// </summary>
                                [NameInMap("DitherMode")]
                                [Validation(Required=false)]
                                public string DitherMode { get; set; }

                                /// <summary>
                                /// <para>The duration for which the final frame is paused. Unit: centisecond.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>0</para>
                                /// </summary>
                                [NameInMap("FinalDelay")]
                                [Validation(Required=false)]
                                public string FinalDelay { get; set; }

                                /// <summary>
                                /// <para>Indicates whether a custom palette is used. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description><b>true</b></description></item>
                                /// <item><description><b>false</b></description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>false</para>
                                /// </summary>
                                [NameInMap("IsCustomPalette")]
                                [Validation(Required=false)]
                                public string IsCustomPalette { get; set; }

                                /// <summary>
                                /// <para>The loop count.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>0</para>
                                /// </summary>
                                [NameInMap("Loop")]
                                [Validation(Required=false)]
                                public string Loop { get; set; }

                            }

                            /// <summary>
                            /// <para>The segment configuration. The value is a JSON object.</para>
                            /// </summary>
                            [NameInMap("Segment")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfigSegment Segment { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfigSegment : TeaModel {
                                /// <summary>
                                /// <para>The length of the segment. The value is an integer. Unit: seconds.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: <b>[1,10]</b>.</description></item>
                                /// <item><description>Default value: <b>10</b>.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>20</para>
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                            }

                            /// <summary>
                            /// <para>The transmuxing configurations for WebP.</para>
                            /// </summary>
                            [NameInMap("Webp")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfigWebp Webp { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputMuxConfigWebp : TeaModel {
                                /// <summary>
                                /// <para>The loop count.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>0</para>
                                /// </summary>
                                [NameInMap("Loop")]
                                [Validation(Required=false)]
                                public string Loop { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The opening parts. The value is a JSON object.</para>
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
                                /// <para>The height of the opening part.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: values in the range of <b>(0,4096)</b>, <b>-1</b>, and <b>full</b>.</description></item>
                                /// <item><description>Default value: <b>-1</b>.</description></item>
                                /// <item><description>A value of <b>-1</b> indicates that the height of the source of the opening part is retained.</description></item>
                                /// <item><description>A value of <b>full</b> indicates that the height of the main part is used for the opening part.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1080</para>
                                /// </summary>
                                [NameInMap("Height")]
                                [Validation(Required=false)]
                                public string Height { get; set; }

                                /// <summary>
                                /// <para>The amount of time after which the opening part is played. The value starts from 0.</para>
                                /// <list type="bullet">
                                /// <item><description>Unit: seconds.</description></item>
                                /// <item><description>Default value: <b>0</b>.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("Start")]
                                [Validation(Required=false)]
                                public string Start { get; set; }

                                /// <summary>
                                /// <para>The width of the opening part.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: values in the range of <b>(0,4096)</b>, <b>-1</b>, and <b>full</b>.</description></item>
                                /// <item><description>Default value: <b>-1</b>.</description></item>
                                /// <item><description>A value of <b>-1</b> indicates that the width of the source of the opening part is retained.</description></item>
                                /// <item><description>A value of <b>full</b> indicates that the width of the main part is used for the opening part.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1920</para>
                                /// </summary>
                                [NameInMap("Width")]
                                [Validation(Required=false)]
                                public string Width { get; set; }

                                /// <summary>
                                /// <para>The OSS URL of the opening part.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para><a href="http://example-bucket-****.oss-cn-hangzhou.aliyuncs.com/opening_01.flv">http://example-bucket-****.oss-cn-hangzhou.aliyuncs.com/opening_01.flv</a></para>
                                /// </summary>
                                [NameInMap("openUrl")]
                                [Validation(Required=false)]
                                public string OpenUrl { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The output subtitles.</para>
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
                                /// <para>The video track. Format: <c>0:{Stream}:{Stream sequence number}</c>, which is <c>0:v:{video_index}</c>. The value of Stream is v, which indicates a video stream. The sequence number is the index of the video stream in the list and starts from 0.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>0:v:0</para>
                                /// </summary>
                                [NameInMap("Map")]
                                [Validation(Required=false)]
                                public string Map { get; set; }

                                /// <summary>
                                /// <para>The error message returned if the job failed to be created. This parameter is not returned if the job was created.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>The specified parameter “%s” cannot be null.</para>
                                /// </summary>
                                [NameInMap("Message")]
                                [Validation(Required=false)]
                                public string Message { get; set; }

                                /// <summary>
                                /// <para>The details of the output file.</para>
                                /// </summary>
                                [NameInMap("OutSubtitleFile")]
                                [Validation(Required=false)]
                                public SubmitJobsResponseBodyJobResultListJobResultJobOutputOutSubtitleListOutSubtitleOutSubtitleFile OutSubtitleFile { get; set; }
                                public class SubmitJobsResponseBodyJobResultListJobResultJobOutputOutSubtitleListOutSubtitleOutSubtitleFile : TeaModel {
                                    /// <summary>
                                    /// <para>The name of the OSS bucket in which the input file is stored.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>example-bucket-****</para>
                                    /// </summary>
                                    [NameInMap("Bucket")]
                                    [Validation(Required=false)]
                                    public string Bucket { get; set; }

                                    /// <summary>
                                    /// <para>The ID of the OSS region in which the output file is stored.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>oss-cn-hangzhou</para>
                                    /// </summary>
                                    [NameInMap("Location")]
                                    [Validation(Required=false)]
                                    public string Location { get; set; }

                                    /// <summary>
                                    /// <para>The name of the OSS object that is used as the output file.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>example-output.flv</para>
                                    /// </summary>
                                    [NameInMap("Object")]
                                    [Validation(Required=false)]
                                    public string Object { get; set; }

                                    /// <summary>
                                    /// <para>The ARN of the RAM role used for delegated authorization.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>acs:ram::<your uid>:role/<your role name></para>
                                    /// </summary>
                                    [NameInMap("RoleArn")]
                                    [Validation(Required=false)]
                                    public string RoleArn { get; set; }

                                }

                                /// <summary>
                                /// <para>Indicates whether the job was created. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description><b>true</b></description></item>
                                /// <item><description><b>false</b></description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("Success")]
                                [Validation(Required=false)]
                                public bool? Success { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The details of the output file.</para>
                        /// </summary>
                        [NameInMap("OutputFile")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputOutputFile OutputFile { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputOutputFile : TeaModel {
                            /// <summary>
                            /// <para>The name of the OSS bucket in which the input file is stored.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>example-bucket-****</para>
                            /// </summary>
                            [NameInMap("Bucket")]
                            [Validation(Required=false)]
                            public string Bucket { get; set; }

                            /// <summary>
                            /// <para>The ID of the OSS region in which the output file is stored.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>oss-cn-hangzhou</para>
                            /// </summary>
                            [NameInMap("Location")]
                            [Validation(Required=false)]
                            public string Location { get; set; }

                            /// <summary>
                            /// <para>The name of the OSS object that is used as the output file.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>example-output.flv</para>
                            /// </summary>
                            [NameInMap("Object")]
                            [Validation(Required=false)]
                            public string Object { get; set; }

                            /// <summary>
                            /// <para>The ARN of the RAM role used for delegated authorization.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>acs:ram::<your uid>:role/<your role name></para>
                            /// </summary>
                            [NameInMap("RoleArn")]
                            [Validation(Required=false)]
                            public string RoleArn { get; set; }

                        }

                        /// <summary>
                        /// <para>The priority of the job in the MPS queue to which the job is added.</para>
                        /// <list type="bullet">
                        /// <item><description>A value of <b>10</b> indicates the highest priority.</description></item>
                        /// <item><description>Default value: <b>6</b>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Priority")]
                        [Validation(Required=false)]
                        public string Priority { get; set; }

                        /// <summary>
                        /// <para>The media properties.</para>
                        /// </summary>
                        [NameInMap("Properties")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputProperties Properties { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputProperties : TeaModel {
                            /// <summary>
                            /// <para>The bitrate of the video.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1000</para>
                            /// </summary>
                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            /// <summary>
                            /// <para>The duration of the video.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>55</para>
                            /// </summary>
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            /// <summary>
                            /// <para>The format of the video.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>QuickTime / MOV</para>
                            /// </summary>
                            [NameInMap("FileFormat")]
                            [Validation(Required=false)]
                            public string FileFormat { get; set; }

                            /// <summary>
                            /// <para>The size of the file.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>3509895</para>
                            /// </summary>
                            [NameInMap("FileSize")]
                            [Validation(Required=false)]
                            public string FileSize { get; set; }

                            /// <summary>
                            /// <para>The format information.</para>
                            /// </summary>
                            [NameInMap("Format")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesFormat Format { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesFormat : TeaModel {
                                /// <summary>
                                /// <para>The total bitrate.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1000</para>
                                /// </summary>
                                [NameInMap("Bitrate")]
                                [Validation(Required=false)]
                                public string Bitrate { get; set; }

                                /// <summary>
                                /// <para>The total duration.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>55</para>
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                /// <summary>
                                /// <para>The full name of the container format.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>QuickTime / MOV</para>
                                /// </summary>
                                [NameInMap("FormatLongName")]
                                [Validation(Required=false)]
                                public string FormatLongName { get; set; }

                                /// <summary>
                                /// <para>The short name of the container format. Valid values: mov, mp4, m4a, 3gp, 3g2, and mj2.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>mov</para>
                                /// </summary>
                                [NameInMap("FormatName")]
                                [Validation(Required=false)]
                                public string FormatName { get; set; }

                                /// <summary>
                                /// <para>The total number of program streams.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>0</para>
                                /// </summary>
                                [NameInMap("NumPrograms")]
                                [Validation(Required=false)]
                                public string NumPrograms { get; set; }

                                /// <summary>
                                /// <para>The total number of media streams.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>2</para>
                                /// </summary>
                                [NameInMap("NumStreams")]
                                [Validation(Required=false)]
                                public string NumStreams { get; set; }

                                /// <summary>
                                /// <para>The size of the file.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>3509895</para>
                                /// </summary>
                                [NameInMap("Size")]
                                [Validation(Required=false)]
                                public string Size { get; set; }

                                /// <summary>
                                /// <para>The start time.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>0.000000</para>
                                /// </summary>
                                [NameInMap("StartTime")]
                                [Validation(Required=false)]
                                public string StartTime { get; set; }

                            }

                            /// <summary>
                            /// <para>The frame rate of the video. The value is a number.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>25</para>
                            /// </summary>
                            [NameInMap("Fps")]
                            [Validation(Required=false)]
                            public string Fps { get; set; }

                            /// <summary>
                            /// <para>The height of the video.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>720</para>
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            /// <summary>
                            /// <para>The stream information.</para>
                            /// </summary>
                            [NameInMap("Streams")]
                            [Validation(Required=false)]
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreams Streams { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreams : TeaModel {
                                /// <summary>
                                /// <para>The audio streams.</para>
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
                                        /// <para>The bitrate of the audio stream.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>128.806</para>
                                        /// </summary>
                                        [NameInMap("Bitrate")]
                                        [Validation(Required=false)]
                                        public string Bitrate { get; set; }

                                        /// <summary>
                                        /// <para>The output layout of the sound channels.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>stereo</para>
                                        /// </summary>
                                        [NameInMap("ChannelLayout")]
                                        [Validation(Required=false)]
                                        public string ChannelLayout { get; set; }

                                        /// <summary>
                                        /// <para>The number of sound channels.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>2</para>
                                        /// </summary>
                                        [NameInMap("Channels")]
                                        [Validation(Required=false)]
                                        public string Channels { get; set; }

                                        /// <summary>
                                        /// <para>The full name of the codec.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>AAC (Advanced Audio Coding)</para>
                                        /// </summary>
                                        [NameInMap("CodecLongName")]
                                        [Validation(Required=false)]
                                        public string CodecLongName { get; set; }

                                        /// <summary>
                                        /// <para>The short name of the codec.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>aac</para>
                                        /// </summary>
                                        [NameInMap("CodecName")]
                                        [Validation(Required=false)]
                                        public string CodecName { get; set; }

                                        /// <summary>
                                        /// <para>The tag of the codec.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>0x6134706d</para>
                                        /// </summary>
                                        [NameInMap("CodecTag")]
                                        [Validation(Required=false)]
                                        public string CodecTag { get; set; }

                                        /// <summary>
                                        /// <para>The tag string of the codec.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>mp4a</para>
                                        /// </summary>
                                        [NameInMap("CodecTagString")]
                                        [Validation(Required=false)]
                                        public string CodecTagString { get; set; }

                                        /// <summary>
                                        /// <para>The codec time base.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1/44100</para>
                                        /// </summary>
                                        [NameInMap("CodecTimeBase")]
                                        [Validation(Required=false)]
                                        public string CodecTimeBase { get; set; }

                                        /// <summary>
                                        /// <para>The duration of the audio stream.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>17.159546</para>
                                        /// </summary>
                                        [NameInMap("Duration")]
                                        [Validation(Required=false)]
                                        public string Duration { get; set; }

                                        /// <summary>
                                        /// <para>The sequence number of the audio stream. The value indicates the position of the audio stream in all audio streams.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Index")]
                                        [Validation(Required=false)]
                                        public string Index { get; set; }

                                        /// <summary>
                                        /// <para>The language of the audio stream. For more information, see <a href="https://www.ffmpeg.org/ffmpeg-all.html#Metadata">FFmpeg documentation</a> and <a href="https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes">ISO 639</a>.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>eng</para>
                                        /// </summary>
                                        [NameInMap("Lang")]
                                        [Validation(Required=false)]
                                        public string Lang { get; set; }

                                        /// <summary>
                                        /// <para>The total number of frames.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>25</para>
                                        /// </summary>
                                        [NameInMap("NumFrames")]
                                        [Validation(Required=false)]
                                        public string NumFrames { get; set; }

                                        /// <summary>
                                        /// <para>The sampling format.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>fltp</para>
                                        /// </summary>
                                        [NameInMap("SampleFmt")]
                                        [Validation(Required=false)]
                                        public string SampleFmt { get; set; }

                                        /// <summary>
                                        /// <para>The sampling rate of the audio stream.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>44100</para>
                                        /// </summary>
                                        [NameInMap("Samplerate")]
                                        [Validation(Required=false)]
                                        public string Samplerate { get; set; }

                                        /// <summary>
                                        /// <para>The start time of the audio stream.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>0.000000</para>
                                        /// </summary>
                                        [NameInMap("StartTime")]
                                        [Validation(Required=false)]
                                        public string StartTime { get; set; }

                                        /// <summary>
                                        /// <para>The time base of the audio stream.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1/44100</para>
                                        /// </summary>
                                        [NameInMap("Timebase")]
                                        [Validation(Required=false)]
                                        public string Timebase { get; set; }

                                    }

                                }

                                /// <summary>
                                /// <para>The subtitle streams.</para>
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
                                        /// <para>The sequence number of the subtitle stream. The value indicates the position of the subtitle stream in all subtitle streams.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("Index")]
                                        [Validation(Required=false)]
                                        public string Index { get; set; }

                                        /// <summary>
                                        /// <para>The language of the subtitle stream. For more information, see <a href="https://www.ffmpeg.org/ffmpeg-all.html#Metadata">FFmpeg documentation</a> and <a href="https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes">ISO 639</a>.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>eng</para>
                                        /// </summary>
                                        [NameInMap("Lang")]
                                        [Validation(Required=false)]
                                        public string Lang { get; set; }

                                    }

                                }

                                /// <summary>
                                /// <para>The video streams.</para>
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
                                        /// <para>The average frame rate of the video stream.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>23.976025</para>
                                        /// </summary>
                                        [NameInMap("AvgFPS")]
                                        [Validation(Required=false)]
                                        public string AvgFPS { get; set; }

                                        /// <summary>
                                        /// <para>The bitrate of the video stream.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1496.46</para>
                                        /// </summary>
                                        [NameInMap("Bitrate")]
                                        [Validation(Required=false)]
                                        public string Bitrate { get; set; }

                                        /// <summary>
                                        /// <para>The full name of the codec.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10</para>
                                        /// </summary>
                                        [NameInMap("CodecLongName")]
                                        [Validation(Required=false)]
                                        public string CodecLongName { get; set; }

                                        /// <summary>
                                        /// <para>The short name of the codec.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>h264</para>
                                        /// </summary>
                                        [NameInMap("CodecName")]
                                        [Validation(Required=false)]
                                        public string CodecName { get; set; }

                                        /// <summary>
                                        /// <para>The tag of the codec.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>0x31637661</para>
                                        /// </summary>
                                        [NameInMap("CodecTag")]
                                        [Validation(Required=false)]
                                        public string CodecTag { get; set; }

                                        /// <summary>
                                        /// <para>The tag string of the codec.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>avc1</para>
                                        /// </summary>
                                        [NameInMap("CodecTagString")]
                                        [Validation(Required=false)]
                                        public string CodecTagString { get; set; }

                                        /// <summary>
                                        /// <para>The codec time base.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1001/48000</para>
                                        /// </summary>
                                        [NameInMap("CodecTimeBase")]
                                        [Validation(Required=false)]
                                        public string CodecTimeBase { get; set; }

                                        /// <summary>
                                        /// <para>The display aspect ratio (DAR) of the video stream.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>16:9</para>
                                        /// </summary>
                                        [NameInMap("Dar")]
                                        [Validation(Required=false)]
                                        public string Dar { get; set; }

                                        /// <summary>
                                        /// <para>The duration of the video stream.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>17.225542</para>
                                        /// </summary>
                                        [NameInMap("Duration")]
                                        [Validation(Required=false)]
                                        public string Duration { get; set; }

                                        /// <summary>
                                        /// <para>The frame rate of the video stream.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>23.976025</para>
                                        /// </summary>
                                        [NameInMap("Fps")]
                                        [Validation(Required=false)]
                                        public string Fps { get; set; }

                                        /// <summary>
                                        /// <para>Indicates whether the video stream contains B-frames.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>2</para>
                                        /// </summary>
                                        [NameInMap("HasBFrames")]
                                        [Validation(Required=false)]
                                        public string HasBFrames { get; set; }

                                        /// <summary>
                                        /// <para>The height of the video stream in pixels.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>720</para>
                                        /// </summary>
                                        [NameInMap("Height")]
                                        [Validation(Required=false)]
                                        public string Height { get; set; }

                                        /// <summary>
                                        /// <para>The sequence number of the video stream. The value indicates the position of the video stream in all video streams.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>0</para>
                                        /// </summary>
                                        [NameInMap("Index")]
                                        [Validation(Required=false)]
                                        public string Index { get; set; }

                                        /// <summary>
                                        /// <para>The language of the video stream. For more information, see <a href="https://www.ffmpeg.org/ffmpeg-all.html#Metadata">FFmpeg documentation</a> and <a href="https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes">ISO 639</a>.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>eng</para>
                                        /// </summary>
                                        [NameInMap("Lang")]
                                        [Validation(Required=false)]
                                        public string Lang { get; set; }

                                        /// <summary>
                                        /// <para>The codec level.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>51</para>
                                        /// </summary>
                                        [NameInMap("Level")]
                                        [Validation(Required=false)]
                                        public string Level { get; set; }

                                        /// <summary>
                                        /// <para>The network bandwidth that was consumed.</para>
                                        /// </summary>
                                        [NameInMap("NetworkCost")]
                                        [Validation(Required=false)]
                                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
                                            /// <summary>
                                            /// <para>The average bitrate of the video stream.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>100</para>
                                            /// </summary>
                                            [NameInMap("AvgBitrate")]
                                            [Validation(Required=false)]
                                            public string AvgBitrate { get; set; }

                                            /// <summary>
                                            /// <para>The maximum bandwidth that was consumed.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>10</para>
                                            /// </summary>
                                            [NameInMap("CostBandwidth")]
                                            [Validation(Required=false)]
                                            public string CostBandwidth { get; set; }

                                            /// <summary>
                                            /// <para>The amount of time consumed to preload the video stream.</para>
                                            /// 
                                            /// <b>Example:</b>
                                            /// <para>8</para>
                                            /// </summary>
                                            [NameInMap("PreloadTime")]
                                            [Validation(Required=false)]
                                            public string PreloadTime { get; set; }

                                        }

                                        /// <summary>
                                        /// <para>The total number of frames.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>25</para>
                                        /// </summary>
                                        [NameInMap("NumFrames")]
                                        [Validation(Required=false)]
                                        public string NumFrames { get; set; }

                                        /// <summary>
                                        /// <para>The pixel format of the video stream.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>yuv420p</para>
                                        /// </summary>
                                        [NameInMap("PixFmt")]
                                        [Validation(Required=false)]
                                        public string PixFmt { get; set; }

                                        /// <summary>
                                        /// <para>The codec profile.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>high</para>
                                        /// </summary>
                                        [NameInMap("Profile")]
                                        [Validation(Required=false)]
                                        public string Profile { get; set; }

                                        /// <summary>
                                        /// <para>The sample aspect ratio (SAR) of the video stream.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1:1</para>
                                        /// </summary>
                                        [NameInMap("Sar")]
                                        [Validation(Required=false)]
                                        public string Sar { get; set; }

                                        /// <summary>
                                        /// <para>The start time of the video stream.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>0.000000</para>
                                        /// </summary>
                                        [NameInMap("StartTime")]
                                        [Validation(Required=false)]
                                        public string StartTime { get; set; }

                                        /// <summary>
                                        /// <para>The time base of the video stream.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1/24000</para>
                                        /// </summary>
                                        [NameInMap("Timebase")]
                                        [Validation(Required=false)]
                                        public string Timebase { get; set; }

                                        /// <summary>
                                        /// <para>The width of the video stream in pixels.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1280</para>
                                        /// </summary>
                                        [NameInMap("Width")]
                                        [Validation(Required=false)]
                                        public string Width { get; set; }

                                    }

                                }

                            }

                            /// <summary>
                            /// <para>The width of the video.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1280</para>
                            /// </summary>
                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                        }

                        /// <summary>
                        /// <para>The rotation angle of the video, in the clockwise direction.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>180</para>
                        /// </summary>
                        [NameInMap("Rotate")]
                        [Validation(Required=false)]
                        public string Rotate { get; set; }

                        /// <summary>
                        /// <para>The subtitle configurations.</para>
                        /// </summary>
                        [NameInMap("SubtitleConfig")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfig SubtitleConfig { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfig : TeaModel {
                            /// <summary>
                            /// <para>The external subtitles. The value is a JSON array that contains up to <b>four</b> objects.</para>
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
                                    /// <para>The character set used by the external subtitle.</para>
                                    /// <list type="bullet">
                                    /// <item><description>Valid values: <b>UTF-8</b>, <b>GBK</b>, <b>BIG5</b>, and <b>auto</b>.</description></item>
                                    /// <item><description>Default value: <b>auto</b>.</description></item>
                                    /// </list>
                                    /// <remarks>
                                    /// <para> If this parameter is set to <b>auto</b>, the detected character set may not be the actual character set. We recommend that you set this parameter to another value.</para>
                                    /// </remarks>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>UTF-8</para>
                                    /// </summary>
                                    [NameInMap("CharEnc")]
                                    [Validation(Required=false)]
                                    public string CharEnc { get; set; }

                                    /// <summary>
                                    /// <para>The font of the hardcoded subtitles converted from external subtitles. Default value: <b>SimSun</b>. For more information, see <a href="https://help.aliyun.com/document_detail/59950.html">Fonts</a>.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>&quot;WenQuanYi Zen Hei&quot;, &quot;Yuanti SC Regular&quot;, &quot;SimSun&quot;</para>
                                    /// </summary>
                                    [NameInMap("FontName")]
                                    [Validation(Required=false)]
                                    public string FontName { get; set; }

                                    /// <summary>
                                    /// <para>The OSS object that is used as the external subtitle. The value is a JSON object. Files in the <b>SRT</b> or <b>ASS</b> format are supported.</para>
                                    /// </summary>
                                    [NameInMap("Input")]
                                    [Validation(Required=false)]
                                    public SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfigExtSubtitleListExtSubtitleInput Input { get; set; }
                                    public class SubmitJobsResponseBodyJobResultListJobResultJobOutputSubtitleConfigExtSubtitleListExtSubtitleInput : TeaModel {
                                        /// <summary>
                                        /// <para>The name of the OSS bucket in which the input file is stored.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>example-bucket-****</para>
                                        /// </summary>
                                        [NameInMap("Bucket")]
                                        [Validation(Required=false)]
                                        public string Bucket { get; set; }

                                        /// <summary>
                                        /// <para>The ID of the OSS region in which the input file is stored.</para>
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
                                        /// <para>example-output.flv</para>
                                        /// </summary>
                                        [NameInMap("Object")]
                                        [Validation(Required=false)]
                                        public string Object { get; set; }

                                    }

                                }

                            }

                            /// <summary>
                            /// <para>The subtitles.</para>
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
                                    /// <para>The audio track. Format: <c>0:{Stream}:{Stream sequence number}</c>, which is <c>0:a:{audio_index}</c>. The value of Stream is a, which indicates an audio stream. The sequence number is the index of the audio stream in the list and starts from 0.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>0:a:0</para>
                                    /// </summary>
                                    [NameInMap("Map")]
                                    [Validation(Required=false)]
                                    public string Map { get; set; }

                                }

                            }

                        }

                        /// <summary>
                        /// <para>The configurations for using the resolution of the source video.</para>
                        /// </summary>
                        [NameInMap("SuperReso")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputSuperReso SuperReso { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputSuperReso : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether parameters related to the sampling rate are obtained. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>true</b></description></item>
                            /// <item><description><b>false</b></description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("IsHalfSample")]
                            [Validation(Required=false)]
                            public string IsHalfSample { get; set; }

                        }

                        /// <summary>
                        /// <para>The ending parts. The value is a JSON object.</para>
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
                                /// <para>The color of the bars that are added to the ending part if the size of the ending part is smaller than that of the main part. Default value: <b>White</b>. For more information, see <a href="https://docs-aliyun.cn-hangzhou.oss.aliyun-inc.com/assets/attach/29253/cn_zh/1502784952344/color.txt?spm=a2c4g.11186623.2.63.241240f77qp3Yy%5C&file=color.txt">Background colors</a>.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>White</para>
                                /// </summary>
                                [NameInMap("BgColor")]
                                [Validation(Required=false)]
                                public string BgColor { get; set; }

                                /// <summary>
                                /// <para>The duration of the transition between the main part and the ending part. A fade transition is used: The last frame of the main part fades out, and the first frame of the ending part fades in. Unit: seconds. Default value: <b>0</b>.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>2</para>
                                /// </summary>
                                [NameInMap("BlendDuration")]
                                [Validation(Required=false)]
                                public string BlendDuration { get; set; }

                                /// <summary>
                                /// <para>The height of the ending part.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: values in the range of <b>(0,4096)</b>, <b>-1</b>, and <b>full</b>.</description></item>
                                /// <item><description>A value of <b>-1</b> indicates that the height of the source of the ending part is retained. A value of <b>full</b> indicates that the height of the main part is used for the ending part.</description></item>
                                /// <item><description>Default value: -1.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1080</para>
                                /// </summary>
                                [NameInMap("Height")]
                                [Validation(Required=false)]
                                public string Height { get; set; }

                                /// <summary>
                                /// <para>Indicates whether the audio content of the ending part is merged. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description><b>true</b></description></item>
                                /// <item><description><b>false</b></description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>false</para>
                                /// </summary>
                                [NameInMap("IsMergeAudio")]
                                [Validation(Required=false)]
                                public bool? IsMergeAudio { get; set; }

                                /// <summary>
                                /// <para>The start time.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("Start")]
                                [Validation(Required=false)]
                                public string Start { get; set; }

                                /// <summary>
                                /// <para>The OSS URL of the ending part.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para><a href="http://example-bucket-****.oss-cn-hangzhou.aliyuncs.com/opening_01.flv">http://example-bucket-****.oss-cn-hangzhou.aliyuncs.com/opening_01.flv</a></para>
                                /// </summary>
                                [NameInMap("TailUrl")]
                                [Validation(Required=false)]
                                public string TailUrl { get; set; }

                                /// <summary>
                                /// <para>The width of the ending part.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: values in the range of <b>(0,4096)</b>, <b>-1</b>, and <b>full</b>.</description></item>
                                /// <item><description>A value of <b>-1</b> indicates that the width of the source of the ending part is retained. A value of <b>full</b> indicates that the width of the main part is used for the ending part.</description></item>
                                /// <item><description>Default value: -1.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1920</para>
                                /// </summary>
                                [NameInMap("Width")]
                                [Validation(Required=false)]
                                public string Width { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The ID of the transcoding template.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>S00000000-000010</para>
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                        /// <summary>
                        /// <para>The general transcoding configurations.</para>
                        /// <remarks>
                        /// <para> If this parameter is specified in the request, the corresponding parameter in the specified transcoding template are overwritten.</para>
                        /// </remarks>
                        /// </summary>
                        [NameInMap("TransConfig")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputTransConfig TransConfig { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputTransConfig : TeaModel {
                            /// <summary>
                            /// <para>The method of resolution adjustment. Default value: <b>none</b>. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>rescale: The video image is resized.</description></item>
                            /// <item><description>crop: The video image is cropped.</description></item>
                            /// <item><description>pad: The video image is scaled out to fill the view.</description></item>
                            /// <item><description>none: The resolution is not adjusted.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>crop</para>
                            /// </summary>
                            [NameInMap("AdjDarMethod")]
                            [Validation(Required=false)]
                            public string AdjDarMethod { get; set; }

                            /// <summary>
                            /// <para>Indicates whether the audio bitrate is checked. If the bitrate of the output audio is higher than that of the input audio, the input bitrate is retained and the specified audio bitrate does not take effect. This parameter has a lower priority than IsCheckAudioBitrateFail. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><para><b>true</b></para>
                            /// </description></item>
                            /// <item><description><para><b>false</b></para>
                            /// </description></item>
                            /// <item><description><para>Default value:</para>
                            /// <list type="bullet">
                            /// <item><description>If this parameter is empty and the codec of the output audio is different from the codec of the input audio, the default value is false.</description></item>
                            /// <item><description>If this parameter is empty and the codec of the output audio is the same as the codec of the input audio, the default value is true.</description></item>
                            /// </list>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("IsCheckAudioBitrate")]
                            [Validation(Required=false)]
                            public string IsCheckAudioBitrate { get; set; }

                            /// <summary>
                            /// <para>Indicates whether the audio bitrate is checked. This parameter has a higher priority than <b>IsCheckAudioBitrate</b>. If the bitrate of the output audio is higher than that of the input audio, a transcoding failure is returned without transcoding the audio. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>false</b></description></item>
                            /// <item><description><b>true</b></description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("IsCheckAudioBitrateFail")]
                            [Validation(Required=false)]
                            public string IsCheckAudioBitrateFail { get; set; }

                            /// <summary>
                            /// <para>Indicates whether the resolution is checked. If the output resolution is higher than the input resolution based on the width or height, the input resolution is retained. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>true</b></description></item>
                            /// <item><description><b>false</b></description></item>
                            /// <item><description>Default value: <b>false</b>.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("IsCheckReso")]
                            [Validation(Required=false)]
                            public string IsCheckReso { get; set; }

                            /// <summary>
                            /// <para>Indicates whether the resolution is checked. This parameter has a higher priority than IsCheckReso. If the output resolution is higher than the input resolution based on the width or height, a transcoding failure is returned without transcoding the video. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>true</b></description></item>
                            /// <item><description><b>false</b></description></item>
                            /// <item><description>Default value: <b>false</b>.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("IsCheckResoFail")]
                            [Validation(Required=false)]
                            public string IsCheckResoFail { get; set; }

                            /// <summary>
                            /// <para>Indicates whether the video bitrate is checked. If the bitrate of the output video is higher than that of the input video, the input bitrate is retained. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>true</b></description></item>
                            /// <item><description><b>false</b></description></item>
                            /// <item><description>Default value: <b>false</b>.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("IsCheckVideoBitrate")]
                            [Validation(Required=false)]
                            public string IsCheckVideoBitrate { get; set; }

                            /// <summary>
                            /// <para>Indicates whether the video bitrate is checked. If the bitrate of the output video is higher than that of the input video, a transcoding failure is returned without transcoding the video. This parameter has a higher priority than<b>IsCheckVideoBitrate</b>. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>true</b></description></item>
                            /// <item><description><b>false</b></description></item>
                            /// <item><description>Default value: <b>false</b>.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("IsCheckVideoBitrateFail")]
                            [Validation(Required=false)]
                            public string IsCheckVideoBitrateFail { get; set; }

                            /// <summary>
                            /// <para>The transcoding mode. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>onepass</b>: transcoding based on one-pass algorithms, which has higher accuracy.</description></item>
                            /// <item><description><b>twopass</b>: transcoding based on two-pass algorithms, which has lower accuracy.</description></item>
                            /// <item><description><b>CBR</b>: transcoding based on a fixed bitrate.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>onepass</para>
                            /// </summary>
                            [NameInMap("TransMode")]
                            [Validation(Required=false)]
                            public string TransMode { get; set; }

                        }

                        /// <summary>
                        /// <para>The custom data.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example data</para>
                        /// </summary>
                        [NameInMap("UserData")]
                        [Validation(Required=false)]
                        public string UserData { get; set; }

                        /// <summary>
                        /// <para>The video configurations.</para>
                        /// <remarks>
                        /// <para> If this parameter is specified, <b>AliyunVideoCodec</b> in the template specified by <b>TemplateId</b> is overwritten.</para>
                        /// </remarks>
                        /// </summary>
                        [NameInMap("Video")]
                        [Validation(Required=false)]
                        public SubmitJobsResponseBodyJobResultListJobResultJobOutputVideo Video { get; set; }
                        public class SubmitJobsResponseBodyJobResultListJobResultJobOutputVideo : TeaModel {
                            /// <summary>
                            /// <para>The bitrate of the output video. Unit: Kbit/s.</para>
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
                            public SubmitJobsResponseBodyJobResultListJobResultJobOutputVideoBitrateBnd BitrateBnd { get; set; }
                            public class SubmitJobsResponseBodyJobResultListJobResultJobOutputVideoBitrateBnd : TeaModel {
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
                            /// <para>1000</para>
                            /// </summary>
                            [NameInMap("Bufsize")]
                            [Validation(Required=false)]
                            public string Bufsize { get; set; }

                            /// <summary>
                            /// <para>The video codec.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: <b>H.264</b>, <b>H.265</b>, <b>GIF</b>, and <b>WEBP</b>.</description></item>
                            /// <item><description>Default value: <b>H.264</b>.</description></item>
                            /// </list>
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
                            /// <item><description>If <b>Crf</b> is returned, the value of <b>Bitrate</b> is invalid.</description></item>
                            /// <item><description>Default value if the value of Codec is H.264: <b>23</b>. Default value if the value of Codec is H.265: <b>26</b>.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>22</para>
                            /// </summary>
                            [NameInMap("Crf")]
                            [Validation(Required=false)]
                            public string Crf { get; set; }

                            /// <summary>
                            /// <para>The method of video cropping. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>border</b>: Black borders are automatically detected and removed.</description></item>
                            /// <item><description>A value in the format of width:height:left:top: The video is cropped based on the custom settings.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1280:800:0:140</para>
                            /// </summary>
                            [NameInMap("Crop")]
                            [Validation(Required=false)]
                            public string Crop { get; set; }

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
                            /// <item><description>Unit: frames per second.</description></item>
                            /// <item><description>Valid values: 0 to 60. The value is 60 if the frame rate of the input file exceeds 60.</description></item>
                            /// <item><description>Default value: the frame rate of the input file.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>60</para>
                            /// </summary>
                            [NameInMap("Fps")]
                            [Validation(Required=false)]
                            public string Fps { get; set; }

                            /// <summary>
                            /// <para>The maximum interval between keyframes or the maximum number of frames in a frame group. Unit: seconds.</para>
                            /// <list type="bullet">
                            /// <item><description>Default value: 10.</description></item>
                            /// <item><description>If the maximum number of frames is returned, the value does not have a unit.</description></item>
                            /// </list>
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
                            /// <para>1280</para>
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            /// <summary>
                            /// <para>The maximum frame rate.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>15</para>
                            /// </summary>
                            [NameInMap("MaxFps")]
                            [Validation(Required=false)]
                            public string MaxFps { get; set; }

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
                            /// <para>The black borders that are added to the video.</para>
                            /// <list type="bullet">
                            /// <item><description>The value is in the width:height:left:top format.</description></item>
                            /// <item><description>Unit: pixel.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1280:800:0:140</para>
                            /// </summary>
                            [NameInMap("Pad")]
                            [Validation(Required=false)]
                            public string Pad { get; set; }

                            /// <summary>
                            /// <para>The pixel format of the video.</para>
                            /// <list type="bullet">
                            /// <item><description><para>The default pixel format can be <b>yuv420p</b> or the pixel format of the input file.</para>
                            /// </description></item>
                            /// <item><description><para>Valid values: standard pixel formats such as <b>yuv420p</b> and <b>yuvj420p</b>.</para>
                            /// <para>**</para>
                            /// <para><b>Note</b> If a non-standard pixel format such as yuvj420p(pc, bt470bg/bt470bg/smpte170m) is used, compatibility with the pixel format must be configured. Otherwise, the transcoding job fails.</para>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>yuvj420p</para>
                            /// </summary>
                            [NameInMap("PixFmt")]
                            [Validation(Required=false)]
                            public string PixFmt { get; set; }

                            /// <summary>
                            /// <para>The preset video algorithm. Default value: <b>medium</b>. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>veryfast</b></description></item>
                            /// <item><description><b>fast</b></description></item>
                            /// <item><description><b>medium</b></description></item>
                            /// <item><description><b>slow</b></description></item>
                            /// <item><description><b>slower</b></description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>veryfast</para>
                            /// </summary>
                            [NameInMap("Preset")]
                            [Validation(Required=false)]
                            public string Preset { get; set; }

                            /// <summary>
                            /// <para>The encoding profile. This parameter is returned only for the H.264 codec. Default value: <b>high</b>. Valid values:</para>
                            /// <remarks>
                            /// <para> If multiple definitions are involved, we recommend that you use baseline for the lowest definition to ensure normal playback on low-definition devices, and use main or high for other definitions.</para>
                            /// </remarks>
                            /// <list type="bullet">
                            /// <item><description><b>baseline</b>: applicable to mobile devices.</description></item>
                            /// <item><description><b>main</b>: applicable to standard-definition devices.</description></item>
                            /// <item><description><b>high</b>: applicable to high-definition devices.</description></item>
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
                            /// <para>The priority of the resource.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("ResoPriority")]
                            [Validation(Required=false)]
                            public string ResoPriority { get; set; }

                            /// <summary>
                            /// <para>The scan mode. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>If this parameter is <b>empty</b>, the scan mode of the input file is used.</description></item>
                            /// <item><description><b>auto</b>: automatic deinterlacing.</description></item>
                            /// <item><description><b>progressive</b>: progressive scan.</description></item>
                            /// <item><description><b>interlaced</b>: interlaced scan.</description></item>
                            /// <item><description><b>By default</b>, this parameter is empty.</description></item>
                            /// </list>
                            /// <para><b>Best practice</b>: Interlaced scan consumes less bandwidth than progressive scan, but the image quality is poor. Therefore, mainstream video production uses progressive scan.</para>
                            /// <list type="bullet">
                            /// <item><description>If <b>progressive scan</b> or <b>interlaced scan</b> is used when the scan mode of the input file is neither of them, the transcoding job fails.</description></item>
                            /// <item><description>We recommend that you use <b>the scan mode of the input file</b> or <b>automatic deinterlacing</b> to improve compatibility.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>interlaced</para>
                            /// </summary>
                            [NameInMap("ScanMode")]
                            [Validation(Required=false)]
                            public string ScanMode { get; set; }

                            /// <summary>
                            /// <para>The width of the video.</para>
                            /// <list type="bullet">
                            /// <item><description>Unit: pixel.</description></item>
                            /// <item><description>Default value: <b>the width of the input video</b>.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1080</para>
                            /// </summary>
                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                        }

                        /// <summary>
                        /// <para>The sequence number of the video stream.</para>
                        /// <list type="bullet">
                        /// <item><description>Format: 0:a:{Sequence number}. Example: 0:a:0.</description></item>
                        /// <item><description>The sequence number is the index of the video stream in the list and starts from 0.</description></item>
                        /// <item><description>If no sequence number is specified, the default video stream is used.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0:a:0</para>
                        /// </summary>
                        [NameInMap("VideoStreamMap")]
                        [Validation(Required=false)]
                        public string VideoStreamMap { get; set; }

                        /// <summary>
                        /// <para>The URL of the watermark configuration file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="http://example.com/configure">http://example.com/configure</a></para>
                        /// </summary>
                        [NameInMap("WaterMarkConfigUrl")]
                        [Validation(Required=false)]
                        public string WaterMarkConfigUrl { get; set; }

                        /// <summary>
                        /// <para>The watermarks.</para>
                        /// <remarks>
                        /// <para> If watermarks are truncated or fail to be generated, check whether the text watermarks that you add contain special characters. If the text watermarks contain special characters, you must escape the special characters before you add the watermarks. Alternatively, you can <a href="https://workorder-intl.console.aliyun.com/?spm=5176.12246746.top-nav.dticket.68797bbcm8H408#/ticket/add/?productId=1232">submit a ticket</a> to contact Alibaba Cloud customer service for compatibility processing.</para>
                        /// </remarks>
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
                                /// <para>The horizontal offset of the watermark image relative to the output video. If this parameter is specified in the request, the corresponding parameter in the watermark template is overwritten. Default value: 0. The value can be an integer or a decimal number.</para>
                                /// <list type="bullet">
                                /// <item><description><para>An integer indicates the pixel value of the horizontal offset.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: <b>[8,4096]</b>.</description></item>
                                /// <item><description>Unit: pixel.</description></item>
                                /// </list>
                                /// </description></item>
                                /// <item><description><para>A decimal number indicates the ratio of the horizontal offset to the width in the output video resolution.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: (0,1).</description></item>
                                /// <item><description>The decimal number can be accurate to four decimal places, such as 0.9999. Excess digits are automatically deleted.</description></item>
                                /// </list>
                                /// </description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("Dx")]
                                [Validation(Required=false)]
                                public string Dx { get; set; }

                                /// <summary>
                                /// <para>The vertical offset of the watermark image relative to the output video. If this parameter is specified in the request, the corresponding parameter in the watermark template is overwritten. The value can be an integer or a decimal number.</para>
                                /// <list type="bullet">
                                /// <item><description><para>An integer indicates the pixel value of the vertical offset.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: <b>[8,4096]</b>.</description></item>
                                /// <item><description>Unit: pixel.</description></item>
                                /// </list>
                                /// </description></item>
                                /// <item><description><para>A decimal number indicates the ratio of the vertical offset to the height in the output video resolution.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: <b>(0,1)</b>.</description></item>
                                /// <item><description>The decimal number can be accurate to four decimal places, such as 0.9999. Excess digits are automatically deleted.</description></item>
                                /// </list>
                                /// </description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("Dy")]
                                [Validation(Required=false)]
                                public string Dy { get; set; }

                                /// <summary>
                                /// <para>The height of the watermark. If this parameter is specified in the request, the corresponding parameter in the watermark template is overwritten. The value can be an integer or a decimal number.</para>
                                /// <list type="bullet">
                                /// <item><description><para>An integer indicates the pixel value of the watermark height.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: <b>[8,4096]</b>.</description></item>
                                /// <item><description>Unit: pixel.</description></item>
                                /// </list>
                                /// </description></item>
                                /// <item><description><para>A decimal number indicates the ratio of the watermark height to the height in the output video resolution.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: <b>(0,1)</b>.</description></item>
                                /// <item><description>The decimal number can be accurate to four decimal places, such as 0.9999. Excess digits are automatically deleted.</description></item>
                                /// </list>
                                /// </description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1280</para>
                                /// </summary>
                                [NameInMap("Height")]
                                [Validation(Required=false)]
                                public string Height { get; set; }

                                /// <summary>
                                /// <para>The watermark input file. PNG images and MOV files are supported.</para>
                                /// </summary>
                                [NameInMap("InputFile")]
                                [Validation(Required=false)]
                                public SubmitJobsResponseBodyJobResultListJobResultJobOutputWaterMarkListWaterMarkInputFile InputFile { get; set; }
                                public class SubmitJobsResponseBodyJobResultListJobResultJobOutputWaterMarkListWaterMarkInputFile : TeaModel {
                                    /// <summary>
                                    /// <para>The name of the OSS bucket in which the input file is stored.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>example-bucket</para>
                                    /// </summary>
                                    [NameInMap("Bucket")]
                                    [Validation(Required=false)]
                                    public string Bucket { get; set; }

                                    /// <summary>
                                    /// <para>The ID of the OSS region in which the input file is stored.</para>
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
                                    /// <para>example-logo-****.png</para>
                                    /// </summary>
                                    [NameInMap("Object")]
                                    [Validation(Required=false)]
                                    public string Object { get; set; }

                                }

                                /// <summary>
                                /// <para>The position of the watermark. If this parameter is specified in the request, the corresponding parameter in the watermark template is overwritten. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description><b>TopRight</b></description></item>
                                /// <item><description><b>TopLeft</b></description></item>
                                /// <item><description><b>BottomRight</b></description></item>
                                /// <item><description><b>BottomLeft</b></description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>TopRight</para>
                                /// </summary>
                                [NameInMap("ReferPos")]
                                [Validation(Required=false)]
                                public string ReferPos { get; set; }

                                /// <summary>
                                /// <para>The type of the watermark. If this parameter is specified in the request, the corresponding parameter in the watermark template is overwritten. For more information, see <a href="https://help.aliyun.com/document_detail/29253.html">Parameter details</a>. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description><b>Image</b></description></item>
                                /// <item><description><b>Text</b></description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>Image</para>
                                /// </summary>
                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                                /// <summary>
                                /// <para>The ID of the watermark template.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>88c6ca184c0e47098a5b665e2a12****</para>
                                /// </summary>
                                [NameInMap("WaterMarkTemplateId")]
                                [Validation(Required=false)]
                                public string WaterMarkTemplateId { get; set; }

                                /// <summary>
                                /// <para>The width of the watermark image. If this parameter is specified in the request, the corresponding parameter in the watermark template is overwritten. The value can be an integer or a decimal number.</para>
                                /// <list type="bullet">
                                /// <item><description><para>An integer indicates the pixel value of the watermark width.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: <b>[8,4096]</b>.</description></item>
                                /// <item><description>Unit: pixel.</description></item>
                                /// </list>
                                /// </description></item>
                                /// <item><description><para>A decimal number indicates the ratio of the watermark width to the width in the output video resolution.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: <b>(0,1)</b>.</description></item>
                                /// <item><description>The decimal number can be accurate to four decimal places, such as 0.9999. Excess digits are automatically deleted.</description></item>
                                /// </list>
                                /// </description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1080</para>
                                /// </summary>
                                [NameInMap("Width")]
                                [Validation(Required=false)]
                                public string Width { get; set; }

                            }

                        }

                    }

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
                    /// <para>The ID of the MPS queue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>88c6ca184c0e47098a5b665e2a126797</para>
                    /// </summary>
                    [NameInMap("PipelineId")]
                    [Validation(Required=false)]
                    public string PipelineId { get; set; }

                    /// <summary>
                    /// <para>The state of the job. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Submitted</b></description></item>
                    /// <item><description><b>TranscodeFail</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Submitted</para>
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                }

                /// <summary>
                /// <para>The error message returned if the job failed to be created. This parameter is not returned if the job was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The specified parameter &quot;%s&quot; cannot be null.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>Indicates whether the job was successful. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A45S71F6-D73936451234</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
