// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetVideoAnalysisOption : TeaModel {
        /// <summary>
        /// <para>Specifies whether to generate a chapter summary for each segment of the video.</para>
        /// </summary>
        [NameInMap("ChapterSummary")]
        [Validation(Required=false)]
        public bool? ChapterSummary { get; set; }

        /// <summary>
        /// <para>Specifies whether to extract relevant keywords from the video.</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public bool? Keyword { get; set; }

        /// <summary>
        /// <para>Specifies whether to generate a presentation (PPT) file based on the video analysis.</para>
        /// </summary>
        [NameInMap("PPT")]
        [Validation(Required=false)]
        public bool? PPT { get; set; }

        /// <summary>
        /// <para>Specifies whether to generate potential questions about the video.</para>
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public bool? Question { get; set; }

        /// <summary>
        /// <para>Specifies whether to generate a concise video summary.</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public bool? Summary { get; set; }

        /// <summary>
        /// <para>Specifies whether to transcribe the spoken audio in the video to text.</para>
        /// </summary>
        [NameInMap("Transcript")]
        [Validation(Required=false)]
        public bool? Transcript { get; set; }

        /// <summary>
        /// <para>Specifies whether to generate a chapter-based summary from the video transcript.</para>
        /// </summary>
        [NameInMap("TranscriptChapterSummary")]
        [Validation(Required=false)]
        public bool? TranscriptChapterSummary { get; set; }

        /// <summary>
        /// <para>Specifies whether to generate a summary of the video transcript.</para>
        /// </summary>
        [NameInMap("TranscriptSummary")]
        [Validation(Required=false)]
        public bool? TranscriptSummary { get; set; }

    }

}
