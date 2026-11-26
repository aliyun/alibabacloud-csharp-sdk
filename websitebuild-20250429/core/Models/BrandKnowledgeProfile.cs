// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class BrandKnowledgeProfile : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>按业务流程提供实施支持</para>
        /// </summary>
        [NameInMap("Advantages")]
        [Validation(Required=false)]
        public string Advantages { get; set; }

        [NameInMap("Faqs")]
        [Validation(Required=false)]
        public List<BrandKnowledgeFaq> Faqs { get; set; }

        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>面向中小企业的软件服务商</para>
        /// </summary>
        [NameInMap("Positioning")]
        [Validation(Required=false)]
        public string Positioning { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>企业协同软件及实施服务</para>
        /// </summary>
        [NameInMap("Products")]
        [Validation(Required=false)]
        public string Products { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>中小企业运营团队</para>
        /// </summary>
        [NameInMap("TargetAudience")]
        [Validation(Required=false)]
        public string TargetAudience { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>务实、清晰</para>
        /// </summary>
        [NameInMap("WritingTone")]
        [Validation(Required=false)]
        public string WritingTone { get; set; }

    }

}
