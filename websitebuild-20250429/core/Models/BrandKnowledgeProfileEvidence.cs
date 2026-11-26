// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class BrandKnowledgeProfileEvidence : TeaModel {
        /// <summary>
        /// <para>The excerpt from the original text used to support brand analysis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Provides enterprise collaboration software and implementation services</para>
        /// </summary>
        [NameInMap("Excerpt")]
        [Validation(Required=false)]
        public string Excerpt { get; set; }

        /// <summary>
        /// <para>The brand profile field corresponding to the evidence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>positioning</para>
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// <para>The ID of the web page in the collection batch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bwp_example001</para>
        /// </summary>
        [NameInMap("PageId")]
        [Validation(Required=false)]
        public string PageId { get; set; }

        /// <summary>
        /// <para>The original web address.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/about">https://example.com/about</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
