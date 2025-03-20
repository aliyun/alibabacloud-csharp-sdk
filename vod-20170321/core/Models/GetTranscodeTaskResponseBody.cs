// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetTranscodeTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The nonexistent job ID.</para>
        /// </summary>
        [NameInMap("NonExistJobIds")]
        [Validation(Required=false)]
        public List<string> NonExistJobIds { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F4C6D5BE-BF13-45*****6C-516EA8906DCD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of transcode job information.</para>
        /// </summary>
        [NameInMap("TranscodeJobInfoList")]
        [Validation(Required=false)]
        public List<GetTranscodeTaskResponseBodyTranscodeJobInfoList> TranscodeJobInfoList { get; set; }
        public class GetTranscodeTaskResponseBodyTranscodeJobInfoList : TeaModel {
            /// <summary>
            /// <para>The complete time of the transcoding job. The format is yyyy-MM-dd\&quot;T\&quot;HH:mm:ssZ (UTC time).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-02-26T08:30:16Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The creation time of the transcoding job. The format is yyyy-MM-dd\&quot;T\&quot;HH:mm:ssZ (UTC time).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-02-26T08:27:16Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The clarity and audio quality types are defined as follows:</para>
            /// <list type="bullet">
            /// <item><description>SD: Standard Definition.</description></item>
            /// <item><description>HD: High Definition.</description></item>
            /// <item><description>FHD: Full High Definition.</description></item>
            /// <item><description>OD: Original Definition.</description></item>
            /// <item><description>2K: 2K.</description></item>
            /// <item><description>4K: 4K.</description></item>
            /// <item><description>SQ: Standard Audio Quality.</description></item>
            /// <item><description>HQ: High Audio Quality.</description></item>
            /// <item><description>AUTO: Adaptive Bitrate.  This is only available when the transcoding template is configured with packaging settings. Please refer to <a href="https://api.aliyun-inc.com/~~52839~~?spm=openapi-amp.newDocPublishment.0.0.65b0281fNUFIXC">the Transcoding Template Configuration - Package Setting</a> for more details.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This value represents the clarity label configured in the transcoding template and does not indicate the actual resolution range of the transcoded output file.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>LD</para>
            /// </summary>
            [NameInMap("Definition")]
            [Validation(Required=false)]
            public string Definition { get; set; }

            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ErrorMessage</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The OSS address of the source file for transcoding.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://outin-40564*****e1403e7.oss-cn-shanghai.aliyuncs.com/customerTrans/5b95e568f8e*****47f38e/31f1184c-*****b2a2-f94-c213f.wmv">http://outin-40564*****e1403e7.oss-cn-shanghai.aliyuncs.com/customerTrans/5b95e568f8e*****47f38e/31f1184c-*****b2a2-f94-c213f.wmv</a></para>
            /// </summary>
            [NameInMap("InputFileUrl")]
            [Validation(Required=false)]
            public string InputFileUrl { get; set; }

            /// <summary>
            /// <para>Information about the transcoded output files.</para>
            /// </summary>
            [NameInMap("OutputFile")]
            [Validation(Required=false)]
            public GetTranscodeTaskResponseBodyTranscodeJobInfoListOutputFile OutputFile { get; set; }
            public class GetTranscodeTaskResponseBodyTranscodeJobInfoListOutputFile : TeaModel {
                /// <summary>
                /// <para>List of audio streams.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;AudioStreamList&quot;: &quot;[{\&quot;Bitrate\&quot;:\&quot;64.533\&quot;,\&quot;ChannelLayout\&quot;:\&quot;stereo\&quot;,\&quot;Channels\&quot;:\&quot;2\&quot;,\&quot;CodecLongName\&quot;:\&quot;AAC (Advanced Audio Coding)\&quot;,\&quot;CodecName\&quot;:\&quot;aac\&quot;,\&quot;CodecTag\&quot;:\&quot;0x6134706d\&quot;,\&quot;CodecTagString\&quot;:\&quot;mp4a\&quot;,\&quot;CodecTimeBase\&quot;:\&quot;1/44100\&quot;,\&quot;Duration\&quot;:\&quot;12.615533\&quot;,\&quot;Index\&quot;:\&quot;1\&quot;,\&quot;Lang\&quot;:\&quot;und\&quot;,\&quot;SampleFmt\&quot;:\&quot;fltp\&quot;,\&quot;Samplerate\&quot;:\&quot;44100\&quot;,\&quot;StartTime\&quot;:\&quot;-0.046440\&quot;,\&quot;Timebase\&quot;:\&quot;1/44100\&quot;}]</para>
                /// </summary>
                [NameInMap("AudioStreamList")]
                [Validation(Required=false)]
                public string AudioStreamList { get; set; }

                /// <summary>
                /// <para>Average bitrate of the transcoded output file. Unit: Kbps.</para>
                /// 
                /// <b>Example:</b>
                /// <para>964</para>
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// <para>Duration of the transcoded output file. Unit: seconds (s).</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// <para>Encryption configuration used for the transcoded output file. Values:</para>
                /// <list type="bullet">
                /// <item><description>AliyunVoDEncryption: Alibaba Cloud Video Encryption (private encryption).</description></item>
                /// <item><description>HLSEncryption: HLS standard encryption.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;EncryptType\&quot;:\&quot;AliyunVoDEncryption\&quot;}</para>
                /// </summary>
                [NameInMap("Encryption")]
                [Validation(Required=false)]
                public string Encryption { get; set; }

                /// <summary>
                /// <para>Size of the transcoded output file. Unit: bytes (B).</para>
                /// 
                /// <b>Example:</b>
                /// <para>851076</para>
                /// </summary>
                [NameInMap("Filesize")]
                [Validation(Required=false)]
                public long? Filesize { get; set; }

                /// <summary>
                /// <para>Container format of the transcoded output file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m3u8</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>Frame rate of the transcoded output file. Unit: frames per second (fps).</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                /// <summary>
                /// <para>Height of the video frame in the transcoded output file. Unit: pixels (px).</para>
                /// 
                /// <b>Example:</b>
                /// <para>360</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// <para>OSS address of the transcoded output file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://outin-40564*****e1403e7.oss-cn-shanghai.aliyuncs.com/883f5d*****f20aaa352f/c3be4f073*****7d5193ec8-%7BDestMd5%7D-od-S00000001-200000.mp4">http://outin-40564*****e1403e7.oss-cn-shanghai.aliyuncs.com/883f5d*****f20aaa352f/c3be4f073*****7d5193ec8-{DestMd5}-od-S00000001-200000.mp4</a></para>
                /// </summary>
                [NameInMap("OutputFileUrl")]
                [Validation(Required=false)]
                public string OutputFileUrl { get; set; }

                /// <summary>
                /// <para>List of subtitle streams.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("SubtitleStreamList")]
                [Validation(Required=false)]
                public string SubtitleStreamList { get; set; }

                /// <summary>
                /// <para>List of video streams.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;AvgFPS\&quot;:\&quot;30.0\&quot;,\&quot;Bitrate\&quot;:\&quot;933.814\&quot;,\&quot;CodecLongName\&quot;:\&quot;H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10\&quot;,\&quot;CodecName\&quot;:\&quot;h264\&quot;,\&quot;CodecTag\&quot;:\&quot;0x31637661\&quot;,\&quot;CodecTagString\&quot;:\&quot;avc1\&quot;,\&quot;CodecTimeBase\&quot;:\&quot;1/60\&quot;,\&quot;Dar\&quot;:\&quot;9:16\&quot;,\&quot;Duration\&quot;:\&quot;12.033333\&quot;,\&quot;Fps\&quot;:\&quot;30.0\&quot;,\&quot;HasBFrames\&quot;:\&quot;2\&quot;,\&quot;Height\&quot;:\&quot;360\&quot;,\&quot;Index\&quot;:\&quot;0\&quot;,\&quot;Lang\&quot;:\&quot;und\&quot;,\&quot;Level\&quot;:\&quot;30\&quot;,\&quot;PixFmt\&quot;:\&quot;yuv420p\&quot;,\&quot;Profile\&quot;:\&quot;High\&quot;,\&quot;Sar\&quot;:\&quot;81:256\&quot;,\&quot;StartTime\&quot;:\&quot;0.000000\&quot;,\&quot;Timebase\&quot;:\&quot;1/15360\&quot;,\&quot;Width\&quot;:\&quot;640\&quot;}]</para>
                /// </summary>
                [NameInMap("VideoStreamList")]
                [Validation(Required=false)]
                public string VideoStreamList { get; set; }

                /// <summary>
                /// <para>List of watermarks used for transcoding.</para>
                /// </summary>
                [NameInMap("WatermarkIdList")]
                [Validation(Required=false)]
                public List<string> WatermarkIdList { get; set; }

                /// <summary>
                /// <para>Width of the video frame in the transcoded output file. Unit: pixels (px).</para>
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
            /// <para>The ID of the transcode job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>38f0e513c88*****85515f9d50be188</para>
            /// </summary>
            [NameInMap("TranscodeJobId")]
            [Validation(Required=false)]
            public string TranscodeJobId { get; set; }

            /// <summary>
            /// <para>The status of the transcoding job:</para>
            /// <para>Transcoding: Transcoding in progress.
            /// TranscodeSuccess: Transcoding successful.
            /// TranscodeFail: Transcoding failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Transcoding</para>
            /// </summary>
            [NameInMap("TranscodeJobStatus")]
            [Validation(Required=false)]
            public string TranscodeJobStatus { get; set; }

            /// <summary>
            /// <para>The processing progress of the transcoding job. The value range is [0, 100].</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("TranscodeProgress")]
            [Validation(Required=false)]
            public long? TranscodeProgress { get; set; }

            /// <summary>
            /// <para>The ID of the template used for the transcode job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>174b0534fea3*****b51c8f0ad1374</para>
            /// </summary>
            [NameInMap("TranscodeTemplateId")]
            [Validation(Required=false)]
            public string TranscodeTemplateId { get; set; }

        }

        /// <summary>
        /// <para>Details about transcoding tasks.</para>
        /// </summary>
        [NameInMap("TranscodeTask")]
        [Validation(Required=false)]
        public GetTranscodeTaskResponseBodyTranscodeTask TranscodeTask { get; set; }
        public class GetTranscodeTaskResponseBodyTranscodeTask : TeaModel {
            /// <summary>
            /// <para>The time when the transcoding task was complete. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-23T12:40:12Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the transcoding task was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
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
            /// <item><description><b>Processing</b>: In progress.</description></item>
            /// <item><description><b>Partial</b>: Some transcoding jobs were complete.</description></item>
            /// <item><description><b>CompleteAllSucc</b>: All transcoding jobs were successful.</description></item>
            /// <item><description><b>CompleteAllFail</b>: All transcoding jobs failed. If an exception occurs in the source file, no transcoding job is initiated and the transcoding task fails.</description></item>
            /// <item><description><b>CompletePartialSucc</b>: All transcoding jobs were complete but only some were successful.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Processing</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <para>Details about transcoding jobs.</para>
            /// </summary>
            [NameInMap("TranscodeJobInfoList")]
            [Validation(Required=false)]
            public List<GetTranscodeTaskResponseBodyTranscodeTaskTranscodeJobInfoList> TranscodeJobInfoList { get; set; }
            public class GetTranscodeTaskResponseBodyTranscodeTaskTranscodeJobInfoList : TeaModel {
                /// <summary>
                /// <para>The time when the transcoding job was complete. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-26T08:30:16Z</para>
                /// </summary>
                [NameInMap("CompleteTime")]
                [Validation(Required=false)]
                public string CompleteTime { get; set; }

                /// <summary>
                /// <para>The time when the transcoding job was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-26T08:27:16Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The video resolution. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>LD</b>: low definition</description></item>
                /// <item><description><b>SD</b>: standard definition</description></item>
                /// <item><description><b>HD</b>: high definition</description></item>
                /// <item><description><b>FHD</b>: ultra high definition</description></item>
                /// <item><description><b>OD</b>: original definition</description></item>
                /// <item><description><b>2K</b>: 2K</description></item>
                /// <item><description><b>4K</b>: 4K</description></item>
                /// <item><description><b>SQ</b>: standard sound quality</description></item>
                /// <item><description><b>HQ</b>: high sound quality</description></item>
                /// <item><description><b>AUTO</b>: adaptive bitrate Adaptive bitrate streams are returned only if PackageSetting is set in the transcoding template. For more information, see <a href="https://help.aliyun.com/document_detail/52839.html">Basic structures</a>.</description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter indicates the definition that is configured in the transcoding template and does not indicate the actual resolution of the output video.</para>
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
                /// <para>The Object Storage Service (OSS) URL of the input file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://outin-40564*****e1403e7.oss-cn-shanghai.aliyuncs.com/customerTrans/5b95e568f8e*****47f38e/31f1184c-*****b2a2-f94-c213f.wmv">http://outin-40564*****e1403e7.oss-cn-shanghai.aliyuncs.com/customerTrans/5b95e568f8e*****47f38e/31f1184c-*****b2a2-f94-c213f.wmv</a></para>
                /// </summary>
                [NameInMap("InputFileUrl")]
                [Validation(Required=false)]
                public string InputFileUrl { get; set; }

                /// <summary>
                /// <para>The information about the output file.</para>
                /// </summary>
                [NameInMap("OutputFile")]
                [Validation(Required=false)]
                public GetTranscodeTaskResponseBodyTranscodeTaskTranscodeJobInfoListOutputFile OutputFile { get; set; }
                public class GetTranscodeTaskResponseBodyTranscodeTaskTranscodeJobInfoListOutputFile : TeaModel {
                    /// <summary>
                    /// <para>The audio streams.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;AudioStreamList&quot;: &quot;[{\&quot;Bitrate\&quot;:\&quot;64.533\&quot;,\&quot;ChannelLayout\&quot;:\&quot;stereo\&quot;,\&quot;Channels\&quot;:\&quot;2\&quot;,\&quot;CodecLongName\&quot;:\&quot;AAC (Advanced Audio Coding)\&quot;,\&quot;CodecName\&quot;:\&quot;aac\&quot;,\&quot;CodecTag\&quot;:\&quot;0x6134706d\&quot;,\&quot;CodecTagString\&quot;:\&quot;mp4a\&quot;,\&quot;CodecTimeBase\&quot;:\&quot;1/44100\&quot;,\&quot;Duration\&quot;:\&quot;12.615533\&quot;,\&quot;Index\&quot;:\&quot;1\&quot;,\&quot;Lang\&quot;:\&quot;und\&quot;,\&quot;SampleFmt\&quot;:\&quot;fltp\&quot;,\&quot;Samplerate\&quot;:\&quot;44100\&quot;,\&quot;StartTime\&quot;:\&quot;-0.046440\&quot;,\&quot;Timebase\&quot;:\&quot;1/44100\&quot;}]</para>
                    /// </summary>
                    [NameInMap("AudioStreamList")]
                    [Validation(Required=false)]
                    public string AudioStreamList { get; set; }

                    /// <summary>
                    /// <para>The average bitrate of the output file. Unit: Kbit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>964</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <para>The length of the output file. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <para>The encryption method of the output file. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>AliyunVoDEncryption</b>: Alibaba Cloud proprietary cryptography</description></item>
                    /// <item><description><b>HLSEncryption</b>: HTTP Live Streaming (HLS) encryption</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\&quot;EncryptType\&quot;:\&quot;AliyunVoDEncryption\&quot;}</para>
                    /// </summary>
                    [NameInMap("Encryption")]
                    [Validation(Required=false)]
                    public string Encryption { get; set; }

                    /// <summary>
                    /// <para>The size of the output file. Unit: byte.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>851076</para>
                    /// </summary>
                    [NameInMap("Filesize")]
                    [Validation(Required=false)]
                    public long? Filesize { get; set; }

                    /// <summary>
                    /// <para>The container format of the output file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>m3u8</para>
                    /// </summary>
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    /// <summary>
                    /// <para>The frame rate of the output file. Unit: frames per second.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>25</para>
                    /// </summary>
                    [NameInMap("Fps")]
                    [Validation(Required=false)]
                    public string Fps { get; set; }

                    /// <summary>
                    /// <para>The height of the output video. Unit: pixels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>360</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <para>The OSS URL of the output file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://outin-40564*****e1403e7.oss-cn-shanghai.aliyuncs.com/883f5d*****f20aaa352f/c3be4f073*****7d5193ec8-%7BDestMd5%7D-od-S00000001-200000.mp4">http://outin-40564*****e1403e7.oss-cn-shanghai.aliyuncs.com/883f5d*****f20aaa352f/c3be4f073*****7d5193ec8-{DestMd5}-od-S00000001-200000.mp4</a></para>
                    /// </summary>
                    [NameInMap("OutputFileUrl")]
                    [Validation(Required=false)]
                    public string OutputFileUrl { get; set; }

                    /// <summary>
                    /// <para>The subtitle streams.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[]</para>
                    /// </summary>
                    [NameInMap("SubtitleStreamList")]
                    [Validation(Required=false)]
                    public string SubtitleStreamList { get; set; }

                    /// <summary>
                    /// <para>The video streams.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[{\&quot;AvgFPS\&quot;:\&quot;30.0\&quot;,\&quot;Bitrate\&quot;:\&quot;933.814\&quot;,\&quot;CodecLongName\&quot;:\&quot;H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10\&quot;,\&quot;CodecName\&quot;:\&quot;h264\&quot;,\&quot;CodecTag\&quot;:\&quot;0x31637661\&quot;,\&quot;CodecTagString\&quot;:\&quot;avc1\&quot;,\&quot;CodecTimeBase\&quot;:\&quot;1/60\&quot;,\&quot;Dar\&quot;:\&quot;9:16\&quot;,\&quot;Duration\&quot;:\&quot;12.033333\&quot;,\&quot;Fps\&quot;:\&quot;30.0\&quot;,\&quot;HasBFrames\&quot;:\&quot;2\&quot;,\&quot;Height\&quot;:\&quot;360\&quot;,\&quot;Index\&quot;:\&quot;0\&quot;,\&quot;Lang\&quot;:\&quot;und\&quot;,\&quot;Level\&quot;:\&quot;30\&quot;,\&quot;PixFmt\&quot;:\&quot;yuv420p\&quot;,\&quot;Profile\&quot;:\&quot;High\&quot;,\&quot;Sar\&quot;:\&quot;81:256\&quot;,\&quot;StartTime\&quot;:\&quot;0.000000\&quot;,\&quot;Timebase\&quot;:\&quot;1/15360\&quot;,\&quot;Width\&quot;:\&quot;640\&quot;}]</para>
                    /// </summary>
                    [NameInMap("VideoStreamList")]
                    [Validation(Required=false)]
                    public string VideoStreamList { get; set; }

                    /// <summary>
                    /// <para>The IDs of the watermarks used by the output file.</para>
                    /// </summary>
                    [NameInMap("WatermarkIdList")]
                    [Validation(Required=false)]
                    public List<string> WatermarkIdList { get; set; }

                    /// <summary>
                    /// <para>The width of the output video. Unit: pixels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>640</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

                /// <summary>
                /// <para>The priority of the transcoding job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public string Priority { get; set; }

                /// <summary>
                /// <para>The ID of the transcoding job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>38f0e513c88*****85515f9d50be188</para>
                /// </summary>
                [NameInMap("TranscodeJobId")]
                [Validation(Required=false)]
                public string TranscodeJobId { get; set; }

                /// <summary>
                /// <para>The status of the transcoding job.</para>
                /// <list type="bullet">
                /// <item><description><b>Transcoding</b></description></item>
                /// <item><description><b>TranscodeSuccess</b></description></item>
                /// <item><description><b>TranscodeFail</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Transcoding</para>
                /// </summary>
                [NameInMap("TranscodeJobStatus")]
                [Validation(Required=false)]
                public string TranscodeJobStatus { get; set; }

                /// <summary>
                /// <para>The progress of the transcoding job. Valid values: <c>[0,100]</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TranscodeProgress")]
                [Validation(Required=false)]
                public long? TranscodeProgress { get; set; }

                /// <summary>
                /// <para>The ID of the transcoding template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>174b0534fea3*****b51c8f0ad1374</para>
                /// </summary>
                [NameInMap("TranscodeTemplateId")]
                [Validation(Required=false)]
                public string TranscodeTemplateId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the transcoding task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b1b65ab107e14*****3dbb900f6c1fe0</para>
            /// </summary>
            [NameInMap("TranscodeTaskId")]
            [Validation(Required=false)]
            public string TranscodeTaskId { get; set; }

            /// <summary>
            /// <para>The ID of the transcoding template group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b500c7094bd241*****3e9900752d7c3</para>
            /// </summary>
            [NameInMap("TranscodeTemplateGroupId")]
            [Validation(Required=false)]
            public string TranscodeTemplateGroupId { get; set; }

            /// <summary>
            /// <para>The mode in which the transcoding task is triggered. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Auto</b>: The transcoding task is automatically triggered when the video is uploaded.</description></item>
            /// <item><description><b>Manual</b>: The transcoding task is triggered by calling the SubmitTranscodeJobs operation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Auto</para>
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public string Trigger { get; set; }

            /// <summary>
            /// <para>The ID of the audio or video file.</para>
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
