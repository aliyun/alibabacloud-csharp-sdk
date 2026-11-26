// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class BrandKnowledgeProfileFaq : TeaModel {
        /// <summary>
        /// <para>The answer to the FAQ question.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Implementation services can be provided within the agreed scope</para>
        /// </summary>
        [NameInMap("Answer")]
        [Validation(Required=false)]
        public string Answer { get; set; }

        /// <summary>
        /// <para>The text of the FAQ question.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Are implementation services provided?</para>
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public string Question { get; set; }

    }

}
