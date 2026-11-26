// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class BrandKnowledgeSource : TeaModel {
        /// <summary>
        /// <para>The extracted or parsed content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example Technology provides enterprise software services</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The content hash of the material body.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855</para>
        /// </summary>
        [NameInMap("ContentHash")]
        [Validation(Required=false)]
        public string ContentHash { get; set; }

        /// <summary>
        /// <para>The knowledge base document ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bkd_example001</para>
        /// </summary>
        [NameInMap("DocumentId")]
        [Validation(Required=false)]
        public string DocumentId { get; set; }

        /// <summary>
        /// <para>The source web address of the material.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/about">https://example.com/about</a></para>
        /// </summary>
        [NameInMap("SourceUrl")]
        [Validation(Required=false)]
        public string SourceUrl { get; set; }

    }

}
