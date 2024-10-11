// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetTranscodeSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the audio or video files that do not exist.</para>
        /// </summary>
        [NameInMap("NonExistVideoIds")]
        [Validation(Required=false)]
        public List<string> NonExistVideoIds { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A*****F6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The transcoding summary of the file.</para>
        /// </summary>
        [NameInMap("TranscodeSummaryList")]
        [Validation(Required=false)]
        public List<GetTranscodeSummaryResponseBodyTranscodeSummaryList> TranscodeSummaryList { get; set; }
        public class GetTranscodeSummaryResponseBodyTranscodeSummaryList : TeaModel {
            /// <summary>
            /// <para>The time when the transcoding task was complete. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-23T12:40:12Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the transcoding task was created. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-23T12:35:12Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The summaries of transcoding jobs.</para>
            /// </summary>
            [NameInMap("TranscodeJobInfoSummaryList")]
            [Validation(Required=false)]
            public List<GetTranscodeSummaryResponseBodyTranscodeSummaryListTranscodeJobInfoSummaryList> TranscodeJobInfoSummaryList { get; set; }
            public class GetTranscodeSummaryResponseBodyTranscodeSummaryListTranscodeJobInfoSummaryList : TeaModel {
                /// <summary>
                /// <para>The average bitrate of the output video. Unit: Kbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>749</para>
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// <para>The time when the transcoding job was complete. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-27T03:40:51Z</para>
                /// </summary>
                [NameInMap("CompleteTime")]
                [Validation(Required=false)]
                public string CompleteTime { get; set; }

                /// <summary>
                /// <para>The time when the transcoding job was created. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-27T03:34:46Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The duration of the output video. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

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
                /// <para>The size of the output video. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1144259</para>
                /// </summary>
                [NameInMap("Filesize")]
                [Validation(Required=false)]
                public long? Filesize { get; set; }

                /// <summary>
                /// <para>The container format of the output video.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mp4</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The frame rate of the output video. Unit: frames per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                /// <summary>
                /// <para>The height of the output video. Unit: pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>960</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// <para>The status of the transcoding job. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Transcoding</b>: Transcoding is in process.</description></item>
                /// <item><description><b>TranscodeSuccess</b>: The job was successful.</description></item>
                /// <item><description><b>TranscodeFail</b>: The job failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Transcoding</para>
                /// </summary>
                [NameInMap("TranscodeJobStatus")]
                [Validation(Required=false)]
                public string TranscodeJobStatus { get; set; }

                /// <summary>
                /// <para>The transcoding progress. Valid values: <c>[0,100]</c>.</para>
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
                /// <para>57496724ae2*****0968d6e08acc8f6</para>
                /// </summary>
                [NameInMap("TranscodeTemplateId")]
                [Validation(Required=false)]
                public string TranscodeTemplateId { get; set; }

                /// <summary>
                /// <para>The IDs of the watermarks that are applied to the output video.</para>
                /// </summary>
                [NameInMap("WatermarkIdList")]
                [Validation(Required=false)]
                public List<string> WatermarkIdList { get; set; }

                /// <summary>
                /// <para>The width of the output video. Unit: pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>544</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

            /// <summary>
            /// <para>The status of the transcoding task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Processing</b>: Transcoding is in process.</description></item>
            /// <item><description><b>Partial</b>: Some transcoding jobs were complete.</description></item>
            /// <item><description><b>CompleteAllSucc</b>: All transcoding jobs were successful.</description></item>
            /// <item><description><b>CompleteAllFail</b>: All transcoding jobs failed. If an exception occurs in the source file, no transcoding job is initiated and the transcoding task fails.</description></item>
            /// <item><description><b>CompletePartialSucc</b>: All transcoding jobs were complete but only some were successful.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Processing</para>
            /// </summary>
            [NameInMap("TranscodeStatus")]
            [Validation(Required=false)]
            public string TranscodeStatus { get; set; }

            /// <summary>
            /// <para>The ID of the transcoding template group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>44f9e406bbb*****736a9abe876ecc0</para>
            /// </summary>
            [NameInMap("TranscodeTemplateGroupId")]
            [Validation(Required=false)]
            public string TranscodeTemplateGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the audio or video file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e1db68cc586644b83e562bcd94****</para>
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

    }

}
