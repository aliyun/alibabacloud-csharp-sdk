// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class GetTemplateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{     &quot;metadata&quot;: {       &quot;name&quot;: &quot;实验名称&quot;,       &quot;id&quot;: &quot;pai_exp_xxxdfafafasfa&quot;,       &quot;desc&quot;: &quot;实验描述&quot;,     },     &quot;nodes&quot;: [     ],     &quot;edges&quot;: [     ],     &quot;globalParams&quot;: [     ],     &quot;globalSettings&quot;:[     ]  }</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>URL://xxx</para>
        /// </summary>
        [NameInMap("DocLink")]
        [Validation(Required=false)]
        public string DocLink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>URL://xxx</para>
        /// </summary>
        [NameInMap("ImageLink")]
        [Validation(Required=false)]
        public string ImageLink { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Labels { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>template-12345</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
