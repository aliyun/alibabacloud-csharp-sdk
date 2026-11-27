// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class BrandKnowledgeProfileAnalysis : TeaModel {
        /// <summary>
        /// <para>The differentiation advantages of the brand.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Providing implementation support based on business processes</para>
        /// </summary>
        [NameInMap("Advantages")]
        [Validation(Required=false)]
        public string Advantages { get; set; }

        /// <summary>
        /// <para>The knowledge base version at the start of the analysis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BaseVersion")]
        [Validation(Required=false)]
        public long? BaseVersion { get; set; }

        /// <summary>
        /// <para>The profile of the brand or collection object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Providing software services for enterprises</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of source evidence supporting the analysis results.</para>
        /// </summary>
        [NameInMap("Evidence")]
        [Validation(Required=false)]
        public List<BrandKnowledgeProfileEvidence> Evidence { get; set; }

        /// <summary>
        /// <para>The unread materials and reasons for this analysis.</para>
        /// </summary>
        [NameInMap("ExcludedMaterials")]
        [Validation(Required=false)]
        public List<string> ExcludedMaterials { get; set; }

        /// <summary>
        /// <para>The list of brand FAQs with answers.</para>
        /// </summary>
        [NameInMap("Faqs")]
        [Validation(Required=false)]
        public List<BrandKnowledgeProfileFaq> Faqs { get; set; }

        /// <summary>
        /// <para>The list of core brand keywords.</para>
        /// </summary>
        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// <para>The brand name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example Technology</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The one-sentence positioning of the brand.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Software service provider for small and medium-sized enterprises</para>
        /// </summary>
        [NameInMap("Positioning")]
        [Validation(Required=false)]
        public string Positioning { get; set; }

        /// <summary>
        /// <para>The main products and services of the brand.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enterprise collaboration software and implementation services</para>
        /// </summary>
        [NameInMap("Products")]
        [Validation(Required=false)]
        public string Products { get; set; }

        /// <summary>
        /// <para>The list of recommended questions for GEO monitoring.</para>
        /// </summary>
        [NameInMap("Questions")]
        [Validation(Required=false)]
        public List<BrandKnowledgeQuestion> Questions { get; set; }

        /// <summary>
        /// <para>The list of web page IDs successfully read during the analysis.</para>
        /// </summary>
        [NameInMap("ReadPageIds")]
        [Validation(Required=false)]
        public List<string> ReadPageIds { get; set; }

        /// <summary>
        /// <para>The list of source document IDs used for the analysis.</para>
        /// </summary>
        [NameInMap("SourceDocumentIds")]
        [Validation(Required=false)]
        public List<string> SourceDocumentIds { get; set; }

        /// <summary>
        /// <para>The target audience of the brand.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Operations teams of small and medium-sized enterprises</para>
        /// </summary>
        [NameInMap("TargetAudience")]
        [Validation(Required=false)]
        public string TargetAudience { get; set; }

        /// <summary>
        /// <para>The brand analysis batch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bwb_example001</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The list of web page IDs where body text was not read during the analysis.</para>
        /// </summary>
        [NameInMap("UnreadPageIds")]
        [Validation(Required=false)]
        public List<string> UnreadPageIds { get; set; }

        /// <summary>
        /// <para>The tone used in content creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pragmatic and clear</para>
        /// </summary>
        [NameInMap("WritingTone")]
        [Validation(Required=false)]
        public string WritingTone { get; set; }

    }

}
