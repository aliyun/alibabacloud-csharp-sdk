// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class TextTask : TeaModel {
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        [NameInMap("agentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        [NameInMap("contentRequirement")]
        [Validation(Required=false)]
        public string ContentRequirement { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("nums")]
        [Validation(Required=false)]
        public int? Nums { get; set; }

        [NameInMap("point")]
        [Validation(Required=false)]
        public string Point { get; set; }

        [NameInMap("referenceTag")]
        [Validation(Required=false)]
        public ReferenceTag ReferenceTag { get; set; }

        [NameInMap("relatedRagId")]
        [Validation(Required=false)]
        public int? RelatedRagId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("style")]
        [Validation(Required=false)]
        public string Style { get; set; }

        [NameInMap("target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        [NameInMap("textIds")]
        [Validation(Required=false)]
        public List<long?> TextIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("textModeType")]
        [Validation(Required=false)]
        public string TextModeType { get; set; }

        [NameInMap("textTaskId")]
        [Validation(Required=false)]
        public long? TextTaskId { get; set; }

        [NameInMap("textTaskStatus")]
        [Validation(Required=false)]
        public string TextTaskStatus { get; set; }

        [NameInMap("texts")]
        [Validation(Required=false)]
        public List<Text> Texts { get; set; }

        [NameInMap("theme")]
        [Validation(Required=false)]
        public string Theme { get; set; }

        [NameInMap("themeDesc")]
        [Validation(Required=false)]
        public string ThemeDesc { get; set; }

    }

}
