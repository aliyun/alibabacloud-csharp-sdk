// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeCloudNotesResponseBody : TeaModel {
        /// <summary>
        /// <para>List of meeting summary results.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeCloudNotesResponseBodyItems> Items { get; set; }
        public class DescribeCloudNotesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>Path where the chapter overview result file is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloudNote/ksvxxppi/88_12/autoChapters_1724914365173.json</para>
            /// </summary>
            [NameInMap("AutoChaptersFilePath")]
            [Validation(Required=false)]
            public string AutoChaptersFilePath { get; set; }

            /// <summary>
            /// <para>The user-defined bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sample-bucket</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>Channel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testchannelId</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <para>The path where the custom prompt result file is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloudNote/ksvxxppi/88_12/customPrompt_1724914365173.json</para>
            /// </summary>
            [NameInMap("CustomPromptFilePath")]
            [Validation(Required=false)]
            public string CustomPromptFilePath { get; set; }

            /// <summary>
            /// <para>The path where the key points extraction result file is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloudNote/ksvxxppi/88_12/meetingAssistance_1724914365173.json</para>
            /// </summary>
            [NameInMap("MeetingAssistanceFilePath")]
            [Validation(Required=false)]
            public string MeetingAssistanceFilePath { get; set; }

            /// <summary>
            /// <para>Reference job region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public int? Region { get; set; }

            /// <summary>
            /// <para>The path where the service quality inspection result file is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloudNote/ksvxxppi/88_12/serviceInspection_1724914365173.json</para>
            /// </summary>
            [NameInMap("ServiceInspectionFilePath")]
            [Validation(Required=false)]
            public string ServiceInspectionFilePath { get; set; }

            /// <summary>
            /// <para>Start Time of the meeting summary job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1731939816837</para>
            /// </summary>
            [NameInMap("StartTs")]
            [Validation(Required=false)]
            public long? StartTs { get; set; }

            /// <summary>
            /// <para>Path where the summary result file is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloudNote/ksvxxppi/88_12/summarization_1724914365173.json</para>
            /// </summary>
            [NameInMap("SummarizationFilePath")]
            [Validation(Required=false)]
            public string SummarizationFilePath { get; set; }

            /// <summary>
            /// <para>Job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test001</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The path where the spoken-to-written text result file is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloudNote/ksvxxppi/88_12/textPolish_1724914365173.json</para>
            /// </summary>
            [NameInMap("TextPolishFilePath")]
            [Validation(Required=false)]
            public string TextPolishFilePath { get; set; }

            /// <summary>
            /// <para>Path where the transcription result file is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloudNote/ksvxxppi/88_12/transcription_1724914365173.json</para>
            /// </summary>
            [NameInMap("TranscriptionFilePath")]
            [Validation(Required=false)]
            public string TranscriptionFilePath { get; set; }

            /// <summary>
            /// <para>The vendor referenced when enabling the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

        /// <summary>
        /// <para>Page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>Quantity per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>154EF5DE-3D08-1F2C-A482-281F78D74B7C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total quantity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCnt")]
        [Validation(Required=false)]
        public int? TotalCnt { get; set; }

    }

}
