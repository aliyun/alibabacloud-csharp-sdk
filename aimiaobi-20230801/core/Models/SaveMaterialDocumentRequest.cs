// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SaveMaterialDocumentRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("Author")]
        [Validation(Required=false)]
        public string Author { get; set; }

        [NameInMap("BothSavePrivateAndShare")]
        [Validation(Required=false)]
        public bool? BothSavePrivateAndShare { get; set; }

        [NameInMap("DocKeywords")]
        [Validation(Required=false)]
        public List<string> DocKeywords { get; set; }

        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        [NameInMap("ExternalUrl")]
        [Validation(Required=false)]
        public string ExternalUrl { get; set; }

        [NameInMap("HtmlContent")]
        [Validation(Required=false)]
        public string HtmlContent { get; set; }

        [NameInMap("PubTime")]
        [Validation(Required=false)]
        public string PubTime { get; set; }

        [NameInMap("ShareAttr")]
        [Validation(Required=false)]
        public int? ShareAttr { get; set; }

        [NameInMap("SrcFrom")]
        [Validation(Required=false)]
        public string SrcFrom { get; set; }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("TextContent")]
        [Validation(Required=false)]
        public string TextContent { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
