// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetVideoAnalysisOption : TeaModel {
        /// <summary>
        /// <para>Specifies whether to retrieve the chapter-based summary of the video.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ChapterSummary")]
        [Validation(Required=false)]
        public bool? ChapterSummary { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve keywords.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public bool? Keyword { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve the PPT from the video. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PPT")]
        [Validation(Required=false)]
        public bool? PPT { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve the generated questions and corresponding answers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public bool? Question { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve the full-text summary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public bool? Summary { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve the dialogue in the video. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Transcript")]
        [Validation(Required=false)]
        public bool? Transcript { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve the segmented summary generated from the dialogue in the video. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TranscriptChapterSummary")]
        [Validation(Required=false)]
        public bool? TranscriptChapterSummary { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve the summary generated from the dialogue in the video. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TranscriptSummary")]
        [Validation(Required=false)]
        public bool? TranscriptSummary { get; set; }

    }

}
