// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class BrandKnowledgeIntakePreview : TeaModel {
        /// <summary>
        /// <para>The extracted or parsed body text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example Technology provides enterprise software services</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The brand or collection target profile.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Provides software services to enterprises</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of web pages discovered or processed.</para>
        /// </summary>
        [NameInMap("Pages")]
        [Validation(Required=false)]
        public List<BrandKnowledgePageLink> Pages { get; set; }

        /// <summary>
        /// <para>The source web address of the data.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/about">https://example.com/about</a></para>
        /// </summary>
        [NameInMap("SourceUrl")]
        [Validation(Required=false)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// <para>The web page or content title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>About Example Technology</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
