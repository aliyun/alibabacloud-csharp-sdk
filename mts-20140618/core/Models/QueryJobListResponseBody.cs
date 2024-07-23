// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryJobListResponseBody : TeaModel {
        /// <summary>
        /// <para>The transcoding jobs.</para>
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
                /// <para>The error code returned if the job failed. If the job was successful, this parameter is not returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InvalidParameter.NullValue</para>
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
                /// <para>2014-01-10T12:20:25Z</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The information about the job input.</para>
                /// </summary>
                [NameInMap("Input")]
                [Validation(Required=false)]
                public QueryJobListResponseBodyJobListJobInput Input { get; set; }
                public class QueryJobListResponseBodyJobListJobInput : TeaModel {
                    /// <summary>
                    /// <para>The name of the OSS bucket in which the input file is stored.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>exampleBucket</para>
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// <para>The OSS region in which the input file resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss-cn-shanghai</para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// <para>The name of the OSS object that is used as the input file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>video_01.mp4</para>
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                }

                /// <summary>
                /// <para>The job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>31fa3c9ca8134fb4b0b0f7878301****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The message sent by Message Service (MNS) to notify users of the job result.</para>
                /// </summary>
                [NameInMap("MNSMessageResult")]
                [Validation(Required=false)]
                public QueryJobListResponseBodyJobListJobMNSMessageResult MNSMessageResult { get; set; }
                public class QueryJobListResponseBodyJobListJobMNSMessageResult : TeaModel {
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
                    /// <para>The resource operated “%s” cannot be found.</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <para>The ID of the message returned if the job was successful.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("MessageId")]
                    [Validation(Required=false)]
                    public string MessageId { get; set; }

                }

                /// <summary>
                /// <para>The error message returned if the job failed. If the job was successful, this parameter is not returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The specified parameter &quot;%s&quot; cannot be null.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The job output.</para>
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public QueryJobListResponseBodyJobListJobOutput Output { get; set; }
                public class QueryJobListResponseBodyJobListJobOutput : TeaModel {
                    /// <summary>
                    /// <para>The audio configurations.</para>
                    /// <remarks>
                    /// <para> If this parameter is specified in the request, the corresponding parameters in the specified transcoding template are overwritten.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("Audio")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputAudio Audio { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputAudio : TeaModel {
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
                        /// <item><description>Valid values: 1, 2, 3, 4, 5, 6, 7, and 8.</description></item>
                        /// <item><description>Default value: <b>2</b>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("Channels")]
                        [Validation(Required=false)]
                        public string Channels { get; set; }

                        /// <summary>
                        /// <para>The audio codec.</para>
                        /// <list type="bullet">
                        /// <item><description>Valid values: aac, mp3, vorbis, and flac.</description></item>
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
                        /// <para>The codec profile of the audio. Valid values when the value of Codec is aac: aaclow, aache, aachev2, aacld, and aaceld.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>aaclow</para>
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
                        /// <item><description>Valid values: 22050, 32000, 44100, 48000, and 96000.</description></item>
                        /// <item><description>Unit: Hz.</description></item>
                        /// <item><description>Default value: 44100.</description></item>
                        /// </list>
                        /// <remarks>
                        /// <para> If the video container format is FLV and the audio codec is MP3, the value of this parameter cannot be 32000, 48000, or 96000. If the audio codec is MP3, the value of this parameter cannot be 96000.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>44100</para>
                        /// </summary>
                        [NameInMap("Samplerate")]
                        [Validation(Required=false)]
                        public string Samplerate { get; set; }

                        /// <summary>
                        /// <para>The volume configurations.</para>
                        /// </summary>
                        [NameInMap("Volume")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputAudioVolume Volume { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputAudioVolume : TeaModel {
                            /// <summary>
                            /// <para>The volume adjustment range. Default value: -20. Unit: dB.</para>
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
                    /// <para>The information about clips.</para>
                    /// </summary>
                    [NameInMap("Clip")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputClip Clip { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputClip : TeaModel {
                        /// <summary>
                        /// <para>The time span of the clip.</para>
                        /// </summary>
                        [NameInMap("TimeSpan")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputClipTimeSpan TimeSpan { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputClipTimeSpan : TeaModel {
                            /// <summary>
                            /// <para>The duration of the clip.</para>
                            /// <list type="bullet">
                            /// <item><description>Format: <c>hh:mm:ss[.SSS]</c>.</description></item>
                            /// <item><description>Example: 01:00:59.999.</description></item>
                            /// </list>
                            /// <para>Or</para>
                            /// <list type="bullet">
                            /// <item><description>Format: <c>sssss[.SSS]</c>.</description></item>
                            /// <item><description>Example: 32000.23.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>01:00:59.999</para>
                            /// </summary>
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            /// <summary>
                            /// <para>The point in time when the clip starts.</para>
                            /// <list type="bullet">
                            /// <item><description>Format: <c>hh:mm:ss[.SSS]</c>.</description></item>
                            /// <item><description>Example: 01:59:59.999.</description></item>
                            /// </list>
                            /// <para>Or</para>
                            /// <list type="bullet">
                            /// <item><description>Format: <c>sssss[.SSS]</c>.</description></item>
                            /// <item><description>Example: 32000.23.</description></item>
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
                    public QueryJobListResponseBodyJobListJobOutputContainer Container { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputContainer : TeaModel {
                        /// <summary>
                        /// <para>The container format.</para>
                        /// <list type="bullet">
                        /// <item><description>Default value: mp4.</description></item>
                        /// <item><description>Video formats include FLV, MP4, HLS (M3U8 + TS), and MPEG-DASH (MPD + fMP4).</description></item>
                        /// <item><description>Audio formats include MP3, MP4, Ogg, FLAC, and M4A.</description></item>
                        /// <item><description>Image formats include GIF and WebP. If the container format is GIF, the video codec must be GIF.</description></item>
                        /// <item><description>If the container format is WebP, the video codec must be WebP.</description></item>
                        /// <item><description>If the container format is FLV, the video codec cannot be H.265.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mp4</para>
                        /// </summary>
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                    }

                    /// <summary>
                    /// <para>The configurations of watermark blurring. The value is a JSON object. For more information, see the DeWatermark section of the <a href="https://help.aliyun.com/document_detail/29253.html">Parameter details</a> topic.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;0&quot;:[{&quot;l&quot;:10,&quot;t&quot;:10,&quot;w&quot;:10,&quot;h&quot;:10},{&quot;l&quot;:100,&quot;t&quot;:0.1,&quot;w&quot;:10,&quot;h&quot;:10}],&quot;128000&quot;:[],&quot;250000&quot;:[{&quot;l&quot;:0.2,&quot;t&quot;:0.1,&quot;w&quot;:0.01,&quot;h&quot;:0.05}]}</para>
                    /// </summary>
                    [NameInMap("DeWatermark")]
                    [Validation(Required=false)]
                    public string DeWatermark { get; set; }

                    /// <summary>
                    /// <para>The encryption configurations. The encrypted video file is generated in the M3U8 format.</para>
                    /// </summary>
                    [NameInMap("Encryption")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputEncryption Encryption { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputEncryption : TeaModel {
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
                        /// <para>The key encryption method. Valid values: Base64 and KMS.</para>
                        /// <remarks>
                        /// <para> For example, if the key is <c>encryptionkey128</c>, the key can be encrypted as <c>Base64(&quot;encryptionkey128&quot;)</c> or <c>KMS(Base64(&quot;encryptionkey128&quot;)</c> depending on the encryption method used.</para>
                        /// </remarks>
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
                    /// <para>The custom fields.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testid-002</para>
                    /// </summary>
                    [NameInMap("ExtendData")]
                    [Validation(Required=false)]
                    public string ExtendData { get; set; }

                    /// <summary>
                    /// <para>The non-standard support configurations for M3U8. The value is a JSON object. For more information, see the M3U8NonStandardSupport section of the <a href="https://help.aliyun.com/document_detail/29253.html">Parameter details</a> topic.</para>
                    /// </summary>
                    [NameInMap("M3U8NonStandardSupport")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputM3U8NonStandardSupport M3U8NonStandardSupport { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputM3U8NonStandardSupport : TeaModel {
                        /// <summary>
                        /// <para>The non-standard support configurations for TS files. The value is a JSON object. For more information, see the TS section of the <a href="https://help.aliyun.com/document_detail/29253.html">Parameter details</a> topic.</para>
                        /// </summary>
                        [NameInMap("TS")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputM3U8NonStandardSupportTS TS { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputM3U8NonStandardSupportTS : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether the output of the MD5 value of the TS file is supported in the M3U8 file. Valid values:</para>
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
                            /// <para>Indicates whether the output of the size of the TS file is supported in the M3U8 file. Valid values:</para>
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
                    /// <para>The URL of the merging configuration file. Only one of MergeList and MergeConfigUrl takes effect.</para>
                    /// <list type="bullet">
                    /// <item><description>The configuration file specified by MergeConfigUrl can contain up to 50 clips.</description></item>
                    /// <item><description>MergeConfigUrl indicates the URL of the configuration file for merging clips. Make sure that the configuration file is stored as an object in OSS and that MPS can access the OSS object. For information about the file content, see the details about merging parameters.</description></item>
                    /// <item><description>Example of the content of the merging configuration file: <c>{&quot;MergeList&quot;:[{&quot;MergeURL&quot;:&quot;http://exampleBucket****.oss-cn-hangzhou.aliyuncs.com/video_01.mp4&quot;}]}</c>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://ceshi-***.oss-cn-shanghai.aliyuncs.com/ccc/p0903q9wkkb.m3u8">https://ceshi-***.oss-cn-shanghai.aliyuncs.com/ccc/p0903q9wkkb.m3u8</a></para>
                    /// </summary>
                    [NameInMap("MergeConfigUrl")]
                    [Validation(Required=false)]
                    public string MergeConfigUrl { get; set; }

                    /// <summary>
                    /// <para>The configurations of clip merging. Up to four clips can be merged.</para>
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
                            /// <para>The duration of the clip.</para>
                            /// <list type="bullet">
                            /// <item><description>Format: <c>hh:mm:ss[.SSS]</c> or <c>sssss[.SSS]</c>.</description></item>
                            /// <item><description>Examples: 01:59:59.999 and 32000.23.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>01:59:59.999</para>
                            /// </summary>
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            /// <summary>
                            /// <para>The OSS URL of the clip.</para>
                            /// <list type="bullet">
                            /// <item><description>Example: <c>http://example-bucket-.oss-cn-hangzhou.aliyuncs.com/example-object.flv</c>.</description></item>
                            /// <item><description>The object must be URL-encoded by using the UTF-8 standard. For more information, see <a href="https://help.aliyun.com/document_detail/423796.html">URL encoding</a>.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para><a href="http://example-bucket.oss-cn-hangzhou.aliyuncs.com/example-object.flv">http://example-bucket.oss-cn-hangzhou.aliyuncs.com/example-object.flv</a></para>
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
                            /// <para>01:59:59.999</para>
                            /// </summary>
                            [NameInMap("Start")]
                            [Validation(Required=false)]
                            public string Start { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The information about the high-speed transcoding job. This information is available only for jobs that are submitted by using an MPS queue for high-speed transcoding. This does not support MPS queues for high-speed transcoding of an earlier version.</para>
                    /// </summary>
                    [NameInMap("MultiSpeedInfo")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputMultiSpeedInfo MultiSpeedInfo { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputMultiSpeedInfo : TeaModel {
                        /// <summary>
                        /// <para>The error code returned if high-speed transcoding is not enabled.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Boost.NotNeedSpeed</para>
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// <para>The downgrade policy if high-speed transcoding is not supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NormalSpeed</para>
                        /// </summary>
                        [NameInMap("DowngradePolicy")]
                        [Validation(Required=false)]
                        public string DowngradePolicy { get; set; }

                        /// <summary>
                        /// <para>The duration of the output video.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>21.0</para>
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public double? Duration { get; set; }

                        /// <summary>
                        /// <para>Indicates whether high-speed transcoding is enabled.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Enable")]
                        [Validation(Required=false)]
                        public string Enable { get; set; }

                        /// <summary>
                        /// <para>The error message returned if high-speed transcoding is not enabled.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>success</para>
                        /// </summary>
                        [NameInMap("Message")]
                        [Validation(Required=false)]
                        public string Message { get; set; }

                        /// <summary>
                        /// <para>The actual transcoding speed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>6.576886940181647</para>
                        /// </summary>
                        [NameInMap("RealSpeed")]
                        [Validation(Required=false)]
                        public double? RealSpeed { get; set; }

                        /// <summary>
                        /// <para>The speed setting.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("SettingSpeed")]
                        [Validation(Required=false)]
                        public int? SettingSpeed { get; set; }

                        /// <summary>
                        /// <para>The amount of time consumed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3.193</para>
                        /// </summary>
                        [NameInMap("TimeCost")]
                        [Validation(Required=false)]
                        public double? TimeCost { get; set; }

                    }

                    /// <summary>
                    /// <para>The transmuxing configurations. The transmuxing configurations. If this parameter is specified in the request, the corresponding parameters in the specified transcoding template are overwritten.</para>
                    /// </summary>
                    [NameInMap("MuxConfig")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputMuxConfig MuxConfig { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputMuxConfig : TeaModel {
                        /// <summary>
                        /// <para>The transmuxing configurations for GIF.</para>
                        /// </summary>
                        [NameInMap("Gif")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputMuxConfigGif Gif { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputMuxConfigGif : TeaModel {
                            /// <summary>
                            /// <para>The color dithering algorithm of the palette. Valid values: sierra and bayer.</para>
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
                        /// <para>The segment configurations. The value is a JSON object.</para>
                        /// </summary>
                        [NameInMap("Segment")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputMuxConfigSegment Segment { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputMuxConfigSegment : TeaModel {
                            /// <summary>
                            /// <para>The segment length. Unit: seconds.</para>
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
                        public QueryJobListResponseBodyJobListJobOutputMuxConfigWebp Webp { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputMuxConfigWebp : TeaModel {
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
                    public QueryJobListResponseBodyJobListJobOutputOpeningList OpeningList { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputOpeningList : TeaModel {
                        [NameInMap("Opening")]
                        [Validation(Required=false)]
                        public List<QueryJobListResponseBodyJobListJobOutputOpeningListOpening> Opening { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputOpeningListOpening : TeaModel {
                            /// <summary>
                            /// <para>The height of the opening part.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: values in the range of (0,4096), -1, and full.</description></item>
                            /// <item><description>A value of -1 indicates that the original height of the opening part is retained.</description></item>
                            /// <item><description>A value of full indicates that the height of the opening part equals the height of the main part.</description></item>
                            /// <item><description>Default value: <b>-1</b>.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>-1</para>
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            /// <summary>
                            /// <para>The amount of time after which the opening part is played.</para>
                            /// <list type="bullet">
                            /// <item><description>The value starts from 0.</description></item>
                            /// <item><description>Unit: seconds.</description></item>
                            /// <item><description>Default value: <b>0</b>.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("Start")]
                            [Validation(Required=false)]
                            public string Start { get; set; }

                            /// <summary>
                            /// <para>The width of the opening part.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: values in the range of (0,4096), -1, and full.</description></item>
                            /// <item><description>A value of -1 indicates that the original width of the opening part is retained.</description></item>
                            /// <item><description>A value of full indicates that the width of the opening part equals the width of the main part.</description></item>
                            /// <item><description>Default value: <b>-1</b>.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>-1</para>
                            /// </summary>
                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                            /// <summary>
                            /// <para>The OSS URL of the opening part.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><a href="http://example.oss-cn-shanghai.aliyuncs.com/t5.mp4">http://example.oss-cn-shanghai.aliyuncs.com/t5.mp4</a></para>
                            /// </summary>
                            [NameInMap("openUrl")]
                            [Validation(Required=false)]
                            public string OpenUrl { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The output captions.</para>
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
                            /// <para>The details of the output caption.</para>
                            /// </summary>
                            [NameInMap("OutSubtitleFile")]
                            [Validation(Required=false)]
                            public QueryJobListResponseBodyJobListJobOutputOutSubtitleListOutSubtitleOutSubtitleFile OutSubtitleFile { get; set; }
                            public class QueryJobListResponseBodyJobListJobOutputOutSubtitleListOutSubtitleOutSubtitleFile : TeaModel {
                                /// <summary>
                                /// <para>The name of the OSS bucket in which the output caption is stored.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>exampleBucket</para>
                                /// </summary>
                                [NameInMap("Bucket")]
                                [Validation(Required=false)]
                                public string Bucket { get; set; }

                                /// <summary>
                                /// <para>The OSS region in which the output caption resides.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>oss-cn-hangzhou</para>
                                /// </summary>
                                [NameInMap("Location")]
                                [Validation(Required=false)]
                                public string Location { get; set; }

                                /// <summary>
                                /// <para>The name of the OSS object that is used as the output caption.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>example.flv</para>
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
                            /// <para>Indicates whether the job was successful. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>true</b>: The job was successful.</description></item>
                            /// <item><description><b>false</b>: The job failed.</description></item>
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
                    public QueryJobListResponseBodyJobListJobOutputOutputFile OutputFile { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputOutputFile : TeaModel {
                        /// <summary>
                        /// <para>The name of the OSS bucket in which the output file is stored.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example-bucket</para>
                        /// </summary>
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }

                        /// <summary>
                        /// <para>The OSS region in which the output file resides.</para>
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
                    /// <para>The priority of the job in the ApsaraVideo Media Processing (MPS) queue to which the job is added.</para>
                    /// <list type="bullet">
                    /// <item><description>A value of 10 indicates the highest priority.</description></item>
                    /// <item><description>Default value: <b>6</b>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6</para>
                    /// </summary>
                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public string Priority { get; set; }

                    /// <summary>
                    /// <para>The media properties.</para>
                    /// </summary>
                    [NameInMap("Properties")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputProperties Properties { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputProperties : TeaModel {
                        /// <summary>
                        /// <para>The video bitrate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>490</para>
                        /// </summary>
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        /// <summary>
                        /// <para>The video duration.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>17</para>
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        /// <summary>
                        /// <para>The video format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mp4</para>
                        /// </summary>
                        [NameInMap("FileFormat")]
                        [Validation(Required=false)]
                        public string FileFormat { get; set; }

                        /// <summary>
                        /// <para>The size of the media file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1057273</para>
                        /// </summary>
                        [NameInMap("FileSize")]
                        [Validation(Required=false)]
                        public string FileSize { get; set; }

                        /// <summary>
                        /// <para>The format information.</para>
                        /// </summary>
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputPropertiesFormat Format { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputPropertiesFormat : TeaModel {
                            /// <summary>
                            /// <para>The total bitrate.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>490.784</para>
                            /// </summary>
                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            /// <summary>
                            /// <para>The total duration.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>17.234000</para>
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
                            /// <para>The size of the media file.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1057273</para>
                            /// </summary>
                            [NameInMap("Size")]
                            [Validation(Required=false)]
                            public string Size { get; set; }

                            /// <summary>
                            /// <para>The start time.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>-0.064000</para>
                            /// </summary>
                            [NameInMap("StartTime")]
                            [Validation(Required=false)]
                            public string StartTime { get; set; }

                        }

                        /// <summary>
                        /// <para>The frame rate of the video.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Fps")]
                        [Validation(Required=false)]
                        public string Fps { get; set; }

                        /// <summary>
                        /// <para>The video height.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1280</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        /// <summary>
                        /// <para>The non-engine layer keywords.</para>
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
                                /// <para>The keyword.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>example</para>
                                /// </summary>
                                [NameInMap("Source")]
                                [Validation(Required=false)]
                                public string Source { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The stream information.</para>
                        /// </summary>
                        [NameInMap("Streams")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputPropertiesStreams Streams { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputPropertiesStreams : TeaModel {
                            /// <summary>
                            /// <para>The audio streams.</para>
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
                                    /// <para>The bitrate of the audio stream.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>64.136</para>
                                    /// </summary>
                                    [NameInMap("Bitrate")]
                                    [Validation(Required=false)]
                                    public string Bitrate { get; set; }

                                    /// <summary>
                                    /// <para>The output layout of the sound channels.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>mono</para>
                                    /// </summary>
                                    [NameInMap("ChannelLayout")]
                                    [Validation(Required=false)]
                                    public string ChannelLayout { get; set; }

                                    /// <summary>
                                    /// <para>The number of sound channels.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1</para>
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
                                    /// <para>mp4</para>
                                    /// </summary>
                                    [NameInMap("CodecTagString")]
                                    [Validation(Required=false)]
                                    public string CodecTagString { get; set; }

                                    /// <summary>
                                    /// <para>The codec time base.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1/32000</para>
                                    /// </summary>
                                    [NameInMap("CodecTimeBase")]
                                    [Validation(Required=false)]
                                    public string CodecTimeBase { get; set; }

                                    /// <summary>
                                    /// <para>The duration of the audio stream.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>17.223562</para>
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
                                    /// <para>und</para>
                                    /// </summary>
                                    [NameInMap("Lang")]
                                    [Validation(Required=false)]
                                    public string Lang { get; set; }

                                    /// <summary>
                                    /// <para>The total number of frames.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>50</para>
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
                                    /// <para>The sampling rate.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>32000</para>
                                    /// </summary>
                                    [NameInMap("Samplerate")]
                                    [Validation(Required=false)]
                                    public string Samplerate { get; set; }

                                    /// <summary>
                                    /// <para>The start time.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>0.064000</para>
                                    /// </summary>
                                    [NameInMap("StartTime")]
                                    [Validation(Required=false)]
                                    public string StartTime { get; set; }

                                    /// <summary>
                                    /// <para>The time base of the audio stream.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1/32000</para>
                                    /// </summary>
                                    [NameInMap("Timebase")]
                                    [Validation(Required=false)]
                                    public string Timebase { get; set; }

                                }

                            }

                            /// <summary>
                            /// <para>The caption streams.</para>
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
                                    /// <para>The sequence number of the caption stream. The value indicates the position of the caption stream in all caption streams.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("Index")]
                                    [Validation(Required=false)]
                                    public string Index { get; set; }

                                    /// <summary>
                                    /// <para>The language of the caption stream. For more information, see <a href="https://www.ffmpeg.org/ffmpeg-all.html#Metadata">FFmpeg documentation</a> and <a href="https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes">ISO 639</a>.</para>
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
                            public QueryJobListResponseBodyJobListJobOutputPropertiesStreamsVideoStreamList VideoStreamList { get; set; }
                            public class QueryJobListResponseBodyJobListJobOutputPropertiesStreamsVideoStreamList : TeaModel {
                                [NameInMap("VideoStream")]
                                [Validation(Required=false)]
                                public List<QueryJobListResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                                public class QueryJobListResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStream : TeaModel {
                                    /// <summary>
                                    /// <para>The average frame rate of the video stream.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>30.0</para>
                                    /// </summary>
                                    [NameInMap("AvgFPS")]
                                    [Validation(Required=false)]
                                    public string AvgFPS { get; set; }

                                    /// <summary>
                                    /// <para>The video bitrate.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>421.117</para>
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
                                    /// <para>1/60</para>
                                    /// </summary>
                                    [NameInMap("CodecTimeBase")]
                                    [Validation(Required=false)]
                                    public string CodecTimeBase { get; set; }

                                    /// <summary>
                                    /// <para>The display aspect ratio (DAR) of the video stream.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>9:16</para>
                                    /// </summary>
                                    [NameInMap("Dar")]
                                    [Validation(Required=false)]
                                    public string Dar { get; set; }

                                    /// <summary>
                                    /// <para>The duration of the video stream.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>17.233333</para>
                                    /// </summary>
                                    [NameInMap("Duration")]
                                    [Validation(Required=false)]
                                    public string Duration { get; set; }

                                    /// <summary>
                                    /// <para>The frame rate of the video stream.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>30.0</para>
                                    /// </summary>
                                    [NameInMap("Fps")]
                                    [Validation(Required=false)]
                                    public string Fps { get; set; }

                                    /// <summary>
                                    /// <para>Indicates whether the video stream contains bidirectional frames (B-frames).</para>
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
                                    /// <para>1280</para>
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
                                    /// <para>31</para>
                                    /// </summary>
                                    [NameInMap("Level")]
                                    [Validation(Required=false)]
                                    public string Level { get; set; }

                                    /// <summary>
                                    /// <para>The network bandwidth that was consumed.</para>
                                    /// </summary>
                                    [NameInMap("NetworkCost")]
                                    [Validation(Required=false)]
                                    public QueryJobListResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                                    public class QueryJobListResponseBodyJobListJobOutputPropertiesStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
                                        /// <summary>
                                        /// <para>The average bitrate.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>300</para>
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
                                    /// <para>30</para>
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
                                    /// <para>The start time.</para>
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
                                    /// <para>1/15360</para>
                                    /// </summary>
                                    [NameInMap("Timebase")]
                                    [Validation(Required=false)]
                                    public string Timebase { get; set; }

                                    /// <summary>
                                    /// <para>The width of the video stream in pixels.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>720</para>
                                    /// </summary>
                                    [NameInMap("Width")]
                                    [Validation(Required=false)]
                                    public string Width { get; set; }

                                    /// <summary>
                                    /// <para>The number of binary bits used by each sample or pixel.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>8</para>
                                    /// </summary>
                                    [NameInMap("bitsPerRawSample")]
                                    [Validation(Required=false)]
                                    public string BitsPerRawSample { get; set; }

                                    /// <summary>
                                    /// <para>The primary colors.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>bt709</para>
                                    /// </summary>
                                    [NameInMap("colorPrimaries")]
                                    [Validation(Required=false)]
                                    public string ColorPrimaries { get; set; }

                                    /// <summary>
                                    /// <para>The color transfer configuration.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>bt709</para>
                                    /// </summary>
                                    [NameInMap("colorTransfer")]
                                    [Validation(Required=false)]
                                    public string ColorTransfer { get; set; }

                                }

                            }

                        }

                        /// <summary>
                        /// <para>The video width.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>720</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                    }

                    /// <summary>
                    /// <para>The rotation angle of the video.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>90</para>
                    /// </summary>
                    [NameInMap("Rotate")]
                    [Validation(Required=false)]
                    public string Rotate { get; set; }

                    /// <summary>
                    /// <para>The caption configurations.</para>
                    /// </summary>
                    [NameInMap("SubtitleConfig")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputSubtitleConfig SubtitleConfig { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputSubtitleConfig : TeaModel {
                        /// <summary>
                        /// <para>The external captions.</para>
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
                                /// <para>The character set used by the external caption.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: UTF-8, GBK, BIG5, and auto.</description></item>
                                /// <item><description>Default value: <b>auto</b>.</description></item>
                                /// </list>
                                /// <remarks>
                                /// <para> If the value of CharEnc is auto, the detected character set may not be the actual character set. We recommend that you set this parameter to another value.</para>
                                /// </remarks>
                                /// 
                                /// <b>Example:</b>
                                /// <para>auto</para>
                                /// </summary>
                                [NameInMap("CharEnc")]
                                [Validation(Required=false)]
                                public string CharEnc { get; set; }

                                /// <summary>
                                /// <para>The font of the hardcoded captions converted from external captions. Default value: SimSum. For more information, see <a href="https://help.aliyun.com/document_detail/59950.html">Fonts</a>.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>&quot;WenQuanYi Zen Hei&quot;, &quot;Yuanti SC Regular&quot;, &quot;SimSun&quot;</para>
                                /// </summary>
                                [NameInMap("FontName")]
                                [Validation(Required=false)]
                                public string FontName { get; set; }

                                /// <summary>
                                /// <para>The input caption file.</para>
                                /// <list type="bullet">
                                /// <item><description>SRT and ASS files are supported. For more information, see the Input section of the <a href="https://help.aliyun.com/document_detail/29253.html">Parameter details</a> topic.</description></item>
                                /// <item><description>Example: <c>{&quot;Bucket&quot;:&quot;example-bucket&quot;,&quot;Location&quot;:&quot;oss-cn-hangzhou&quot;,&quot;Object&quot;:&quot;example.srt&quot;}</c>.</description></item>
                                /// </list>
                                /// </summary>
                                [NameInMap("Input")]
                                [Validation(Required=false)]
                                public QueryJobListResponseBodyJobListJobOutputSubtitleConfigExtSubtitleListExtSubtitleInput Input { get; set; }
                                public class QueryJobListResponseBodyJobListJobOutputSubtitleConfigExtSubtitleListExtSubtitleInput : TeaModel {
                                    /// <summary>
                                    /// <para>The name of the OSS bucket in which the input caption file is stored.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>example-bucket-****</para>
                                    /// </summary>
                                    [NameInMap("Bucket")]
                                    [Validation(Required=false)]
                                    public string Bucket { get; set; }

                                    /// <summary>
                                    /// <para>The OSS region in which the input caption file resides.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>oss-cn-hangzhou</para>
                                    /// </summary>
                                    [NameInMap("Location")]
                                    [Validation(Required=false)]
                                    public string Location { get; set; }

                                    /// <summary>
                                    /// <para>The name of the OSS object that is used as the input caption file.</para>
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
                        /// <para>The captions.</para>
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
                    public QueryJobListResponseBodyJobListJobOutputSuperReso SuperReso { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputSuperReso : TeaModel {
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
                    /// <para>The ending parts.</para>
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
                            /// <para>The color of the bars that are added to the ending part if the size of the ending part is smaller than that of the main part. Default value: White. For more information, see <a href="https://help.aliyun.com/document_detail/29253.html">Parameter details</a>.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>White</para>
                            /// </summary>
                            [NameInMap("BgColor")]
                            [Validation(Required=false)]
                            public string BgColor { get; set; }

                            /// <summary>
                            /// <para>The duration of the transition between the main part and the ending part. A fade transition is used: The last frame of the main part fades out, and the first frame of the ending part fades in. Unit: seconds. Default value: 0.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("BlendDuration")]
                            [Validation(Required=false)]
                            public string BlendDuration { get; set; }

                            /// <summary>
                            /// <para>The height of the ending part.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: values in the range of (0,4096), -1, and full.</description></item>
                            /// <item><description>A value of -1 indicates that the original height of the ending part is retained.</description></item>
                            /// <item><description>A value of full indicates that the height of the ending part equals the height of the main part.</description></item>
                            /// <item><description>Default value: -1.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>-1</para>
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
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("IsMergeAudio")]
                            [Validation(Required=false)]
                            public bool? IsMergeAudio { get; set; }

                            /// <summary>
                            /// <para>The time when the ending part is played.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>00000.00</para>
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
                            /// <para>The width of the ending part. Valid values: values in the range of (0,4096), -1, and full.</para>
                            /// <list type="bullet">
                            /// <item><description>A value of -1 indicates that the original width of the ending part is retained.</description></item>
                            /// <item><description>A value of full indicates that the width of the ending part equals the width of the main part.</description></item>
                            /// <item><description>Default value: -1.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>-1</para>
                            /// </summary>
                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The template ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>S00000001-200010</para>
                    /// </summary>
                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                    /// <summary>
                    /// <para>The general transcoding configurations.</para>
                    /// <remarks>
                    /// <para> If this parameter is specified in the request, the corresponding parameters in the specified transcoding template are overwritten.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("TransConfig")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputTransConfig TransConfig { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputTransConfig : TeaModel {
                        /// <summary>
                        /// <para>The method of resolution adjustment. Default value: <b>none</b>. Valid values: rescale, crop, pad, and none.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>none</para>
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
                        /// <item><description>If this parameter is empty and the codec of the output audio is different from that of the input audio, the default value is false.</description></item>
                        /// <item><description>If this parameter is empty and the codec of the output audio is the same as that of the input audio, the default value is true.</description></item>
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
                        /// <para>Indicates whether the audio bitrate is checked. If the bitrate of the output audio is higher than that of the input audio, the input audio is not transcoded and a transcoding failure is returned. This parameter has a higher priority than IsCheckAudioBitrate. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>true</b></description></item>
                        /// <item><description><b>false</b></description></item>
                        /// <item><description>Default value: <b>false</b>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("IsCheckAudioBitrateFail")]
                        [Validation(Required=false)]
                        public string IsCheckAudioBitrateFail { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the resolution is checked. If the output resolution is higher than the input resolution based on the width or height, the input resolution is retained. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>true</b>:</description></item>
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
                        /// <para>Indicates whether the resolution is checked. If the output resolution is higher than the input resolution based on the width or height, a transcoding failure is returned. Valid values:</para>
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
                        /// <para>Indicates whether the video bitrate is checked. If the bitrate of the output video is higher than that of the input video, the input video is not transcoded and a transcoding failure is returned. This parameter has a higher priority than IsCheckVideoBitrate. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>true</b></description></item>
                        /// <item><description><b>false</b></description></item>
                        /// <item><description>Default value: <b>false</b>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("IsCheckVideoBitrateFail")]
                        [Validation(Required=false)]
                        public string IsCheckVideoBitrateFail { get; set; }

                        /// <summary>
                        /// <para>The transcoding mode.</para>
                        /// <list type="bullet">
                        /// <item><description>Valid values: onepass, twopass, and CBR.</description></item>
                        /// <item><description>Default value: <b>onepass</b>.</description></item>
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
                    /// <para>testid-001</para>
                    /// </summary>
                    [NameInMap("UserData")]
                    [Validation(Required=false)]
                    public string UserData { get; set; }

                    /// <summary>
                    /// <para>The video configurations.</para>
                    /// </summary>
                    [NameInMap("Video")]
                    [Validation(Required=false)]
                    public QueryJobListResponseBodyJobListJobOutputVideo Video { get; set; }
                    public class QueryJobListResponseBodyJobListJobOutputVideo : TeaModel {
                        /// <summary>
                        /// <para>The average bitrate of the video. Unit: Kbit/s.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>500</para>
                        /// </summary>
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        /// <summary>
                        /// <para>The average bitrate range of the video.</para>
                        /// </summary>
                        [NameInMap("BitrateBnd")]
                        [Validation(Required=false)]
                        public QueryJobListResponseBodyJobListJobOutputVideoBitrateBnd BitrateBnd { get; set; }
                        public class QueryJobListResponseBodyJobListJobOutputVideoBitrateBnd : TeaModel {
                            /// <summary>
                            /// <para>The maximum bitrate.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1000</para>
                            /// </summary>
                            [NameInMap("Max")]
                            [Validation(Required=false)]
                            public string Max { get; set; }

                            /// <summary>
                            /// <para>The minimum bitrate.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>300</para>
                            /// </summary>
                            [NameInMap("Min")]
                            [Validation(Required=false)]
                            public string Min { get; set; }

                        }

                        /// <summary>
                        /// <para>The buffer size.</para>
                        /// <list type="bullet">
                        /// <item><description>Unit: KB.</description></item>
                        /// <item><description>Default value: <b>6000</b>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>6000</para>
                        /// </summary>
                        [NameInMap("Bufsize")]
                        [Validation(Required=false)]
                        public string Bufsize { get; set; }

                        /// <summary>
                        /// <para>The video codec.</para>
                        /// <list type="bullet">
                        /// <item><description>Valid values: H.264 and H.265.</description></item>
                        /// <item><description>Default value: H.264.</description></item>
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
                        /// <item><description>Default value when the value of Codec is H.264: <b>23</b>, default value when the value of Codec is H.265: <b>26</b>.</description></item>
                        /// <item><description>If the value of this parameter is returned, the value of Bitrate becomes invalid.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>26</para>
                        /// </summary>
                        [NameInMap("Crf")]
                        [Validation(Required=false)]
                        public string Crf { get; set; }

                        /// <summary>
                        /// <para>The method of video cropping. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>border</b>: automatically detects and removes borders.</description></item>
                        /// <item><description>A value in the width:height:left:top format: The video image is cropped based on custom settings.</description></item>
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
                        /// <para>The frame rate of the video.</para>
                        /// <list type="bullet">
                        /// <item><description>Unit: frames per second.</description></item>
                        /// <item><description>The value is 60 if the frame rate of the input file exceeds 60.</description></item>
                        /// <item><description>Default value: the frame rate of the input video.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>25</para>
                        /// </summary>
                        [NameInMap("Fps")]
                        [Validation(Required=false)]
                        public string Fps { get; set; }

                        /// <summary>
                        /// <para>The maximum interval between keyframes or the maximum number of frames in a frame group. Unit: seconds.</para>
                        /// <list type="bullet">
                        /// <item><description>Default value: <b>250</b>.</description></item>
                        /// <item><description>If the maximum number of frames is returned, the value does not contain a unit.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>250</para>
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
                        /// <para>720</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        /// <summary>
                        /// <para>The maximum frame rate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("MaxFps")]
                        [Validation(Required=false)]
                        public string MaxFps { get; set; }

                        /// <summary>
                        /// <para>The maximum bitrate of the video. Unit: Kbit/s.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3000</para>
                        /// </summary>
                        [NameInMap("Maxrate")]
                        [Validation(Required=false)]
                        public string Maxrate { get; set; }

                        /// <summary>
                        /// <para>The black bars that are added to the video.</para>
                        /// <list type="bullet">
                        /// <item><description>Unit: pixel.</description></item>
                        /// <item><description>Format: width:height:left:top.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1280:800:0:140</para>
                        /// </summary>
                        [NameInMap("Pad")]
                        [Validation(Required=false)]
                        public string Pad { get; set; }

                        /// <summary>
                        /// <para>The pixel format of the video. Valid values: standard pixel formats such as yuv420p and yuvj420p.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>yuv420p</para>
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
                        /// <para>medium</para>
                        /// </summary>
                        [NameInMap("Preset")]
                        [Validation(Required=false)]
                        public string Preset { get; set; }

                        /// <summary>
                        /// <para>The codec profile of the video. Valid values: baseline, main, and high.</para>
                        /// <remarks>
                        /// <para> If multiple definitions are involved, we recommend that you use baseline for the lowest definition to ensure normal playback on low-end devices, and use main or high for other definitions.</para>
                        /// </remarks>
                        /// <list type="bullet">
                        /// <item><description><b>baseline</b>: applicable to mobile devices.</description></item>
                        /// <item><description><b>main</b>: applicable to standard-definition devices.</description></item>
                        /// <item><description><b>high</b>: applicable to high-definition devices.</description></item>
                        /// <item><description>Default value: <b>high</b>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>high</para>
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
                        /// <para>The resource priority.</para>
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
                        /// <item><description>If this parameter is left <b>empty</b>, the scan mode of the input video is used.</description></item>
                        /// <item><description><b>auto</b>: automatic deinterlacing.</description></item>
                        /// <item><description><b>progressive</b>: progressive scan.</description></item>
                        /// <item><description><b>interlaced</b>: interlaced scan.</description></item>
                        /// <item><description><b>By default</b>, this parameter is left empty.</description></item>
                        /// </list>
                        /// <para><b>Best practice</b>: The interlaced scan mode saves data traffic than the progressive scan mode but provides poor image quality. Therefore, the progressive scan mode is commonly used in mainstream video production.</para>
                        /// <list type="bullet">
                        /// <item><description>If <b>progressive</b> or <b>interlaced</b> is used when the scan mode of the input video is neither of them, the transcoding job fails.</description></item>
                        /// <item><description>We recommend that you use <b>the scan mode of the input video</b> or <b>automatic deinterlacing</b> for higher compatibility.</description></item>
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
                        /// <item><description>Default value: the width of the input video.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1280</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                    }

                    /// <summary>
                    /// <para>The sequence number of the video stream. The sequence number is the index of the video stream in the list and starts from 0. If no sequence number is specified, the default video stream is used.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
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
                            /// <item><description>The decimal number can be accurate to four decimal places, such as 0.9999. Excessive digits are automatically discarded.</description></item>
                            /// </list>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>100</para>
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
                            /// <item><description>The decimal number can be accurate to four decimal places, such as 0.9999. Excessive digits are automatically discarded.</description></item>
                            /// </list>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("Dy")]
                            [Validation(Required=false)]
                            public string Dy { get; set; }

                            /// <summary>
                            /// <para>The height of the watermark image. If this parameter is specified in the request, the corresponding parameter in the watermark template is overwritten. The value can be an integer or a decimal number.</para>
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
                            /// <item><description>The decimal number can be accurate to four decimal places, such as 0.9999. Excessive digits are automatically discarded.</description></item>
                            /// </list>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>50</para>
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            /// <summary>
                            /// <para>The watermark input file. PNG images and MOV files are supported.</para>
                            /// </summary>
                            [NameInMap("InputFile")]
                            [Validation(Required=false)]
                            public QueryJobListResponseBodyJobListJobOutputWaterMarkListWaterMarkInputFile InputFile { get; set; }
                            public class QueryJobListResponseBodyJobListJobOutputWaterMarkListWaterMarkInputFile : TeaModel {
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
                                /// <para>The OSS region in which the input file resides.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>oss-cn-hangzhou</para>
                                /// </summary>
                                [NameInMap("Location")]
                                [Validation(Required=false)]
                                public string Location { get; set; }

                                /// <summary>
                                /// <para>The name of the Object Storage Service (OSS) object that is used as the input file.</para>
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
                            /// <item><description>TopRight</description></item>
                            /// <item><description>TopLeft</description></item>
                            /// <item><description>BottomRight</description></item>
                            /// <item><description>BottomLeft</description></item>
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
                            /// <item><description>Image</description></item>
                            /// <item><description>Text</description></item>
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
                            /// <item><description>The decimal number can be accurate to four decimal places, such as 0.9999. Excessive digits are automatically discarded.</description></item>
                            /// </list>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>50</para>
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
                /// <para>The ID of the MPS queue that is used to run the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>88c6ca184c0e47b665e2a1267971****</para>
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                /// <summary>
                /// <para>The job state. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Submitted</b>: The job was submitted.</description></item>
                /// <item><description><b>Transcoding</b>: Transcoding is in process.</description></item>
                /// <item><description><b>TranscodeSuccess</b>: The job was successful.</description></item>
                /// <item><description><b>TranscodeFail</b>: The job failed.</description></item>
                /// <item><description><b>TranscodeCancelled</b>: The job was canceled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TranscodeSuccess</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The time when the job was submitted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-04T06:44:43Z</para>
                /// </summary>
                [NameInMap("SubmitTime")]
                [Validation(Required=false)]
                public string SubmitTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The list of nonexistent job IDs. If all queried job IDs exist, the response does not contain this parameter.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>197ADF44-104C-514C-9F92-D8924CB34E2A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
