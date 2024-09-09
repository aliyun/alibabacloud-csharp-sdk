// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class TextTaskCreateCmd : TeaModel {
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        [NameInMap("contentRequirement")]
        [Validation(Required=false)]
        public string ContentRequirement { get; set; }

        [NameInMap("idempotentId")]
        [Validation(Required=false)]
        public string IdempotentId { get; set; }

        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        [NameInMap("introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("number")]
        [Validation(Required=false)]
        public int? Number { get; set; }

        [NameInMap("point")]
        [Validation(Required=false)]
        public string Point { get; set; }

        [NameInMap("referenceTag")]
        [Validation(Required=false)]
        public ReferenceTag ReferenceTag { get; set; }

        [NameInMap("relatedRagIds")]
        [Validation(Required=false)]
        public List<long?> RelatedRagIds { get; set; }

        [NameInMap("streamApi")]
        [Validation(Required=false)]
        public bool? StreamApi { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("style")]
        [Validation(Required=false)]
        public string Style { get; set; }

        [NameInMap("target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("textModeType")]
        [Validation(Required=false)]
        public string TextModeType { get; set; }

        [NameInMap("theme")]
        [Validation(Required=false)]
        public string Theme { get; set; }

        [NameInMap("themes")]
        [Validation(Required=false)]
        public List<string> Themes { get; set; }

    }

}
