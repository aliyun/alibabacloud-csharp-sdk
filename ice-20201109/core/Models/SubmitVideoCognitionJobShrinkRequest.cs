// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitVideoCognitionJobShrinkRequest : TeaModel {
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string InputShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;nlpParams&quot;: {
        ///         &quot;sourceLanguage&quot;: &quot;cn&quot;,
        ///         &quot;diarizationEnabled&quot;: true,
        ///         &quot;speakerCount&quot;: 2,
        ///         &quot;summarizationEnabled&quot;: true,
        ///         &quot;summarizationTypes&quot;: &quot;Paragraph,Conversational,QuestionsAnswering,MindMap&quot;,
        ///         &quot;translationEnabled&quot;: true,
        ///         &quot;targetLanguages&quot;: &quot;en&quot;,
        ///         &quot;autoChaptersEnabled&quot;: true,
        ///         &quot;meetingAssistanceEnabled&quot;: true
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>39f8e0bc00***************</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example-title-****</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;test&quot;:1}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
