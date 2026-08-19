// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetTranscodeTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of transcoding jobs that do not exist.</para>
        /// </summary>
        [NameInMap("NonExistJobIds")]
        [Validation(Required=false)]
        public List<string> NonExistJobIds { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F4C6D5BE-BF13-45*****6C-516EA8906DCD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The transcoding job information.</para>
        /// </summary>
        [NameInMap("TranscodeJobInfoList")]
        [Validation(Required=false)]
        public List<GetTranscodeTaskResponseBodyTranscodeJobInfoList> TranscodeJobInfoList { get; set; }
        public class GetTranscodeTaskResponseBodyTranscodeJobInfoList : TeaModel {
            /// <summary>
            /// <para>The time when the transcoding job was completed. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-02-26T08:30:16Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the transcoding job was created. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-02-26T08:27:16Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The video definition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>LD</b>: fluent.</description></item>
            /// <item><description><b>SD</b>: standard definition.</description></item>
            /// <item><description><b>HD</b>: high definition.</description></item>
            /// <item><description><b>FHD</b>: ultra high definition.</description></item>
            /// <item><description><b>OD</b>: original quality.</description></item>
            /// <item><description><b>2K</b>: 2K.</description></item>
            /// <item><description><b>4K</b>: 4K.</description></item>
            /// <item><description><b>SQ</b>: standard sound quality.</description></item>
            /// <item><description><b>HQ</b>: high sound quality.</description></item>
            /// <item><description><b>AUTO</b>: adaptive bitrate streaming. This definition is available only when packaging is configured in the transcoding template. For more information, see <a href="https://help.aliyun.com/document_detail/52839.html">Transcoding template configuration - PackageSetting</a>.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This value is the definition label configured in the transcoding template and does not indicate the actual resolution range of the transcoded output file.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>LD</para>
            /// </summary>
            [NameInMap("Definition")]
            [Validation(Required=false)]
            public string Definition { get; set; }

            /// <summary>
            /// <para>The error code returned when the transcoding job failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned when the transcoding job failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ErrorMessage</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The OSS URL of the transcoding source file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://outin-40564*****e1403e7.oss-cn-shanghai.aliyuncs.com/customerTrans/5b95e568f8e*****47f38e/31f1184c-*****b2a2-f94-c213f.wmv">http://outin-40564*****e1403e7.oss-cn-shanghai.aliyuncs.com/customerTrans/5b95e568f8e*****47f38e/31f1184c-*****b2a2-f94-c213f.wmv</a></para>
            /// </summary>
            [NameInMap("InputFileUrl")]
            [Validation(Required=false)]
            public string InputFileUrl { get; set; }

            /// <summary>
            /// <para>The information about the transcoding output file.</para>
            /// </summary>
            [NameInMap("OutputFile")]
            [Validation(Required=false)]
            public GetTranscodeTaskResponseBodyTranscodeJobInfoListOutputFile OutputFile { get; set; }
            public class GetTranscodeTaskResponseBodyTranscodeJobInfoListOutputFile : TeaModel {
                /// <summary>
                /// <para>The list of audio streams.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;AudioStreamList&quot;: &quot;[{\&quot;Bitrate\&quot;:\&quot;64.533\&quot;,\&quot;ChannelLayout\&quot;:\&quot;stereo\&quot;,\&quot;Channels\&quot;:\&quot;2\&quot;,\&quot;CodecLongName\&quot;:\&quot;AAC (Advanced Audio Coding)\&quot;,\&quot;CodecName\&quot;:\&quot;aac\&quot;,\&quot;CodecTag\&quot;:\&quot;0x6134706d\&quot;,\&quot;CodecTagString\&quot;:\&quot;mp4a\&quot;,\&quot;CodecTimeBase\&quot;:\&quot;1/44100\&quot;,\&quot;Duration\&quot;:\&quot;12.615533\&quot;,\&quot;Index\&quot;:\&quot;1\&quot;,\&quot;Lang\&quot;:\&quot;und\&quot;,\&quot;SampleFmt\&quot;:\&quot;fltp\&quot;,\&quot;Samplerate\&quot;:\&quot;44100\&quot;,\&quot;StartTime\&quot;:\&quot;-0.046440\&quot;,\&quot;Timebase\&quot;:\&quot;1/44100\&quot;}]</para>
                /// </summary>
                [NameInMap("AudioStreamList")]
                [Validation(Required=false)]
                public string AudioStreamList { get; set; }

                /// <summary>
                /// <para>The average bitrate of the transcoding output file. Unit: Kbps.</para>
                /// 
                /// <b>Example:</b>
                /// <para>964</para>
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// <para>The duration of the transcoding output file. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// <para>The encryption configuration used for the transcoding output file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>AliyunVoDEncryption</b>: Alibaba Cloud video encryption (proprietary encryption).</description></item>
                /// <item><description><b>HLSEncryption</b>: HLS encryption.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;EncryptType\&quot;:\&quot;AliyunVoDEncryption\&quot;}</para>
                /// </summary>
                [NameInMap("Encryption")]
                [Validation(Required=false)]
                public string Encryption { get; set; }

                /// <summary>
                /// <para>The size of the transcoding output file. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>851076</para>
                /// </summary>
                [NameInMap("Filesize")]
                [Validation(Required=false)]
                public long? Filesize { get; set; }

                /// <summary>
                /// <para>The container format of the transcoding output file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m3u8</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The frame rate of the transcoding output file. Unit: frames per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                /// <summary>
                /// <para>The height of the transcoding output video. Unit: px.</para>
                /// 
                /// <b>Example:</b>
                /// <para>360</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// <para>The OSS URL of the transcoding output file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://outin-40564*****e1403e7.oss-cn-shanghai.aliyuncs.com/883f5d*****f20aaa352f/c3be4f073*****7d5193ec8-%7BDestMd5%7D-od-S00000001-200000.mp4">http://outin-40564*****e1403e7.oss-cn-shanghai.aliyuncs.com/883f5d*****f20aaa352f/c3be4f073*****7d5193ec8-{DestMd5}-od-S00000001-200000.mp4</a></para>
                /// </summary>
                [NameInMap("OutputFileUrl")]
                [Validation(Required=false)]
                public string OutputFileUrl { get; set; }

                /// <summary>
                /// <para>The list of subtitle streams.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("SubtitleStreamList")]
                [Validation(Required=false)]
                public string SubtitleStreamList { get; set; }

                /// <summary>
                /// <para>The list of video streams.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;AvgFPS\&quot;:\&quot;30.0\&quot;,\&quot;Bitrate\&quot;:\&quot;933.814\&quot;,\&quot;CodecLongName\&quot;:\&quot;H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10\&quot;,\&quot;CodecName\&quot;:\&quot;h264\&quot;,\&quot;CodecTag\&quot;:\&quot;0x31637661\&quot;,\&quot;CodecTagString\&quot;:\&quot;avc1\&quot;,\&quot;CodecTimeBase\&quot;:\&quot;1/60\&quot;,\&quot;Dar\&quot;:\&quot;9:16\&quot;,\&quot;Duration\&quot;:\&quot;12.033333\&quot;,\&quot;Fps\&quot;:\&quot;30.0\&quot;,\&quot;HasBFrames\&quot;:\&quot;2\&quot;,\&quot;Height\&quot;:\&quot;360\&quot;,\&quot;Index\&quot;:\&quot;0\&quot;,\&quot;Lang\&quot;:\&quot;und\&quot;,\&quot;Level\&quot;:\&quot;30\&quot;,\&quot;PixFmt\&quot;:\&quot;yuv420p\&quot;,\&quot;Profile\&quot;:\&quot;High\&quot;,\&quot;Sar\&quot;:\&quot;81:256\&quot;,\&quot;StartTime\&quot;:\&quot;0.000000\&quot;,\&quot;Timebase\&quot;:\&quot;1/15360\&quot;,\&quot;Width\&quot;:\&quot;640\&quot;}]</para>
                /// </summary>
                [NameInMap("VideoStreamList")]
                [Validation(Required=false)]
                public string VideoStreamList { get; set; }

                /// <summary>
                /// <para>The list of watermarks used for transcoding.</para>
                /// </summary>
                [NameInMap("WatermarkIdList")]
                [Validation(Required=false)]
                public List<string> WatermarkIdList { get; set; }

                /// <summary>
                /// <para>The width of the transcoding output video. Unit: px.</para>
                /// 
                /// <b>Example:</b>
                /// <para>640</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

            /// <summary>
            /// <para>The priority of the transcoding task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The transcoding job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>38f0e513c88*****85515f9d50be188</para>
            /// </summary>
            [NameInMap("TranscodeJobId")]
            [Validation(Required=false)]
            public string TranscodeJobId { get; set; }

            /// <summary>
            /// <para>The status of the transcoding job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Transcoding</b>: transcoding in progress.</description></item>
            /// <item><description><b>TranscodeSuccess</b>: transcoding succeeded.</description></item>
            /// <item><description><b>TranscodeFail</b>: transcoding failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Transcoding</para>
            /// </summary>
            [NameInMap("TranscodeJobStatus")]
            [Validation(Required=false)]
            public string TranscodeJobStatus { get; set; }

            /// <summary>
            /// <para>The transcoding job progress. Value range: <c>[0,100]</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-02-26T08:30:16Z</para>
            /// </summary>
            [NameInMap("TranscodeProgress")]
            [Validation(Required=false)]
            public long? TranscodeProgress { get; set; }

            /// <summary>
            /// <para>The ID of the transcoding template used for transcoding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>174b0534fea3*****b51c8f0ad1374</para>
            /// </summary>
            [NameInMap("TranscodeTemplateId")]
            [Validation(Required=false)]
            public string TranscodeTemplateId { get; set; }

        }

        /// <summary>
        /// <para>The transcoding task information.</para>
        /// </summary>
        [NameInMap("TranscodeTask")]
        [Validation(Required=false)]
        public GetTranscodeTaskResponseBodyTranscodeTask TranscodeTask { get; set; }
        public class GetTranscodeTaskResponseBodyTranscodeTask : TeaModel {
            /// <summary>
            /// <para>The time when the transcoding task was completed. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-23T12:40:12Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the transcoding task was created. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-23T12:35:12Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The status of the transcoding task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Processing</b>: processing in progress.</description></item>
            /// <item><description><b>Partial</b>: partially completed.</description></item>
            /// <item><description><b>CompleteAllSucc</b>: all transcoding jobs are completed and succeeded.</description></item>
            /// <item><description><b>CompleteAllFail</b>: all transcoding jobs are completed but failed. If the source file has issues, no transcoding jobs are initiated and the entire transcoding task fails.</description></item>
            /// <item><description><b>CompletePartialSucc</b>: all transcoding jobs are completed but only some succeeded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Processing</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <para>The transcoding job information.</para>
            /// </summary>
            [NameInMap("TranscodeJobInfoList")]
            [Validation(Required=false)]
            public List<GetTranscodeTaskResponseBodyTranscodeTaskTranscodeJobInfoList> TranscodeJobInfoList { get; set; }
            public class GetTranscodeTaskResponseBodyTranscodeTaskTranscodeJobInfoList : TeaModel {
                /// <summary>
                /// <para>The time when the transcoding job was completed. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-26T08:30:16Z</para>
                /// </summary>
                [NameInMap("CompleteTime")]
                [Validation(Required=false)]
                public string CompleteTime { get; set; }

                /// <summary>
                /// <para>The time when the transcoding job was created. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-26T08:27:16Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The video definition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>LD</b>: fluent.</description></item>
                /// <item><description><b>SD</b>: standard definition.</description></item>
                /// <item><description><b>HD</b>: high definition.</description></item>
                /// <item><description><b>FHD</b>: ultra high definition.</description></item>
                /// <item><description><b>OD</b>: original quality.</description></item>
                /// <item><description><b>2K</b>: 2K.</description></item>
                /// <item><description><b>4K</b>: 4K.</description></item>
                /// <item><description><b>SQ</b>: standard sound quality.</description></item>
                /// <item><description><b>HQ</b>: high sound quality.</description></item>
                /// <item><description><b>AUTO</b>: adaptive bitrate streaming. This definition is available only when packaging is configured in the transcoding template. For more information, see <a href="https://help.aliyun.com/document_detail/52839.html">Transcoding template configuration - PackageSetting</a>.</description></item>
                /// </list>
                /// <remarks>
                /// <para>This value is the definition label configured in the transcoding template and does not indicate the actual resolution range of the transcoded output file.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>LD</para>
                /// </summary>
                [NameInMap("Definition")]
                [Validation(Required=false)]
                public string Definition { get; set; }

                /// <summary>
                /// <para>The error code returned when the transcoding job failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message returned when the transcoding job failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ErrorMessage</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The OSS URL of the transcoding source file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://outin-40564*****e1403e7.oss-cn-shanghai.aliyuncs.com/customerTrans/5b95e568f8e*****47f38e/31f1184c-*****b2a2-f94-c213f.wmv">http://outin-40564*****e1403e7.oss-cn-shanghai.aliyuncs.com/customerTrans/5b95e568f8e*****47f38e/31f1184c-*****b2a2-f94-c213f.wmv</a></para>
                /// </summary>
                [NameInMap("InputFileUrl")]
                [Validation(Required=false)]
                public string InputFileUrl { get; set; }

                /// <summary>
                /// <para>The information about the transcoding output file.</para>
                /// </summary>
                [NameInMap("OutputFile")]
                [Validation(Required=false)]
                public GetTranscodeTaskResponseBodyTranscodeTaskTranscodeJobInfoListOutputFile OutputFile { get; set; }
                public class GetTranscodeTaskResponseBodyTranscodeTaskTranscodeJobInfoListOutputFile : TeaModel {
                    /// <summary>
                    /// <para>The list of audio streams.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;AudioStreamList&quot;: &quot;[{\&quot;Bitrate\&quot;:\&quot;64.533\&quot;,\&quot;ChannelLayout\&quot;:\&quot;stereo\&quot;,\&quot;Channels\&quot;:\&quot;2\&quot;,\&quot;CodecLongName\&quot;:\&quot;AAC (Advanced Audio Coding)\&quot;,\&quot;CodecName\&quot;:\&quot;aac\&quot;,\&quot;CodecTag\&quot;:\&quot;0x6134706d\&quot;,\&quot;CodecTagString\&quot;:\&quot;mp4a\&quot;,\&quot;CodecTimeBase\&quot;:\&quot;1/44100\&quot;,\&quot;Duration\&quot;:\&quot;12.615533\&quot;,\&quot;Index\&quot;:\&quot;1\&quot;,\&quot;Lang\&quot;:\&quot;und\&quot;,\&quot;SampleFmt\&quot;:\&quot;fltp\&quot;,\&quot;Samplerate\&quot;:\&quot;44100\&quot;,\&quot;StartTime\&quot;:\&quot;-0.046440\&quot;,\&quot;Timebase\&quot;:\&quot;1/44100\&quot;}]</para>
                    /// </summary>
                    [NameInMap("AudioStreamList")]
                    [Validation(Required=false)]
                    public string AudioStreamList { get; set; }

                    /// <summary>
                    /// <para>The average bitrate of the transcoding output file. Unit: Kbps.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>964</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <para>The duration of the transcoding output file. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <para>The encryption configuration used for the transcoding output file. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>AliyunVoDEncryption</b>: Alibaba Cloud video encryption (proprietary encryption).</description></item>
                    /// <item><description><b>HLSEncryption</b>: HLS encryption.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\&quot;EncryptType\&quot;:\&quot;AliyunVoDEncryption\&quot;}</para>
                    /// </summary>
                    [NameInMap("Encryption")]
                    [Validation(Required=false)]
                    public string Encryption { get; set; }

                    /// <summary>
                    /// <para>The size of the transcoding output file. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>851076</para>
                    /// </summary>
                    [NameInMap("Filesize")]
                    [Validation(Required=false)]
                    public long? Filesize { get; set; }

                    /// <summary>
                    /// <para>The container format of the transcoding output file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>m3u8</para>
                    /// </summary>
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    /// <summary>
                    /// <para>The frame rate of the transcoding output file. Unit: frames per second.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>25</para>
                    /// </summary>
                    [NameInMap("Fps")]
                    [Validation(Required=false)]
                    public string Fps { get; set; }

                    /// <summary>
                    /// <para>The height of the transcoding output video. Unit: px.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>360</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <para>The OSS URL of the transcoding output file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://outin-40564*****e1403e7.oss-cn-shanghai.aliyuncs.com/883f5d*****f20aaa352f/c3be4f073*****7d5193ec8-%7BDestMd5%7D-od-S00000001-200000.mp4">http://outin-40564*****e1403e7.oss-cn-shanghai.aliyuncs.com/883f5d*****f20aaa352f/c3be4f073*****7d5193ec8-{DestMd5}-od-S00000001-200000.mp4</a></para>
                    /// </summary>
                    [NameInMap("OutputFileUrl")]
                    [Validation(Required=false)]
                    public string OutputFileUrl { get; set; }

                    /// <summary>
                    /// <para>The list of subtitle streams.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[]</para>
                    /// </summary>
                    [NameInMap("SubtitleStreamList")]
                    [Validation(Required=false)]
                    public string SubtitleStreamList { get; set; }

                    /// <summary>
                    /// <para>The list of video streams.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[{\&quot;AvgFPS\&quot;:\&quot;30.0\&quot;,\&quot;Bitrate\&quot;:\&quot;933.814\&quot;,\&quot;CodecLongName\&quot;:\&quot;H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10\&quot;,\&quot;CodecName\&quot;:\&quot;h264\&quot;,\&quot;CodecTag\&quot;:\&quot;0x31637661\&quot;,\&quot;CodecTagString\&quot;:\&quot;avc1\&quot;,\&quot;CodecTimeBase\&quot;:\&quot;1/60\&quot;,\&quot;Dar\&quot;:\&quot;9:16\&quot;,\&quot;Duration\&quot;:\&quot;12.033333\&quot;,\&quot;Fps\&quot;:\&quot;30.0\&quot;,\&quot;HasBFrames\&quot;:\&quot;2\&quot;,\&quot;Height\&quot;:\&quot;360\&quot;,\&quot;Index\&quot;:\&quot;0\&quot;,\&quot;Lang\&quot;:\&quot;und\&quot;,\&quot;Level\&quot;:\&quot;30\&quot;,\&quot;PixFmt\&quot;:\&quot;yuv420p\&quot;,\&quot;Profile\&quot;:\&quot;High\&quot;,\&quot;Sar\&quot;:\&quot;81:256\&quot;,\&quot;StartTime\&quot;:\&quot;0.000000\&quot;,\&quot;Timebase\&quot;:\&quot;1/15360\&quot;,\&quot;Width\&quot;:\&quot;640\&quot;}]</para>
                    /// </summary>
                    [NameInMap("VideoStreamList")]
                    [Validation(Required=false)]
                    public string VideoStreamList { get; set; }

                    /// <summary>
                    /// <para>The list of watermark IDs used for the transcoding output file.</para>
                    /// </summary>
                    [NameInMap("WatermarkIdList")]
                    [Validation(Required=false)]
                    public List<string> WatermarkIdList { get; set; }

                    /// <summary>
                    /// <para>The width of the transcoding output video. Unit: px.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>640</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

                /// <summary>
                /// <para>The priority of the transcoding task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public string Priority { get; set; }

                /// <summary>
                /// <para>The transcoding job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>38f0e513c88*****85515f9d50be188</para>
                /// </summary>
                [NameInMap("TranscodeJobId")]
                [Validation(Required=false)]
                public string TranscodeJobId { get; set; }

                /// <summary>
                /// <para>The status of the transcoding job. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Transcoding</b>: transcoding in progress.</description></item>
                /// <item><description><b>TranscodeSuccess</b>: transcoding succeeded.</description></item>
                /// <item><description><b>TranscodeFail</b>: transcoding failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Transcoding</para>
                /// </summary>
                [NameInMap("TranscodeJobStatus")]
                [Validation(Required=false)]
                public string TranscodeJobStatus { get; set; }

                /// <summary>
                /// <para>The transcoding job progress. Value range: <c>[0,100]</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TranscodeProgress")]
                [Validation(Required=false)]
                public long? TranscodeProgress { get; set; }

                /// <summary>
                /// <para>The ID of the transcoding template used for transcoding.</para>
                /// 
                /// <b>Example:</b>
                /// <para>174b0534fea3*****b51c8f0ad1374</para>
                /// </summary>
                [NameInMap("TranscodeTemplateId")]
                [Validation(Required=false)]
                public string TranscodeTemplateId { get; set; }

            }

            /// <summary>
            /// <para>The transcoding task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b1b65ab107e14*****3dbb900f6c1fe0</para>
            /// </summary>
            [NameInMap("TranscodeTaskId")]
            [Validation(Required=false)]
            public string TranscodeTaskId { get; set; }

            /// <summary>
            /// <para>The ID of the transcoding template group used for transcoding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b500c7094bd241*****3e9900752d7c3</para>
            /// </summary>
            [NameInMap("TranscodeTemplateGroupId")]
            [Validation(Required=false)]
            public string TranscodeTemplateGroupId { get; set; }

            /// <summary>
            /// <para>The trigger type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Auto</b>: automatically triggered after a video is uploaded.</description></item>
            /// <item><description><b>Manual</b>: triggered by calling the SubmitTranscodeJobs operation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Auto</para>
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public string Trigger { get; set; }

            /// <summary>
            /// <para>The audio or video ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>883f5d98107*****b7f20aaa352f</para>
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

    }

}
