// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class BrandKnowledgePageLink : TeaModel {
        /// <summary>
        /// <para>The web page or content title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>About Sample Technology</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

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
