// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class BrandKnowledgeProfile : TeaModel {
        /// <summary>
        /// <para>The differentiated brand advantages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Implementation support based on business processes</para>
        /// </summary>
        [NameInMap("Advantages")]
        [Validation(Required=false)]
        public string Advantages { get; set; }

        /// <summary>
        /// <para>The list of brand FAQs with answers.</para>
        /// </summary>
        [NameInMap("Faqs")]
        [Validation(Required=false)]
        public List<BrandKnowledgeFaq> Faqs { get; set; }

        /// <summary>
        /// <para>The list of core brand keywords.</para>
        /// </summary>
        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// <para>The one-sentence brand positioning statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Software service provider for small and medium-sized enterprises</para>
        /// </summary>
        [NameInMap("Positioning")]
        [Validation(Required=false)]
        public string Positioning { get; set; }

        /// <summary>
        /// <para>The core brand products and services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enterprise collaboration software and implementation services</para>
        /// </summary>
        [NameInMap("Products")]
        [Validation(Required=false)]
        public string Products { get; set; }

        /// <summary>
        /// <para>The target customer base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Operations teams of small and medium-sized enterprises</para>
        /// </summary>
        [NameInMap("TargetAudience")]
        [Validation(Required=false)]
        public string TargetAudience { get; set; }

        /// <summary>
        /// <para>The writing tone used for content creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pragmatic and clear</para>
        /// </summary>
        [NameInMap("WritingTone")]
        [Validation(Required=false)]
        public string WritingTone { get; set; }

    }

}
