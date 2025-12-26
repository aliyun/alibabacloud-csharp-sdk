// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAILangStudio20240710.Models
{
    public class FlowTemplate : TeaModel {
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("AliyunDocumentId")]
        [Validation(Required=false)]
        public string AliyunDocumentId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DescriptionI18N")]
        [Validation(Required=false)]
        public Dictionary<string, string> DescriptionI18N { get; set; }

        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("DisplayNameI18N")]
        [Validation(Required=false)]
        public Dictionary<string, string> DisplayNameI18N { get; set; }

        [NameInMap("FlowFiles")]
        [Validation(Required=false)]
        public string FlowFiles { get; set; }

        [NameInMap("FlowStoragePath")]
        [Validation(Required=false)]
        public string FlowStoragePath { get; set; }

        [NameInMap("FlowTemplateId")]
        [Validation(Required=false)]
        public string FlowTemplateId { get; set; }

        [NameInMap("FlowType")]
        [Validation(Required=false)]
        public string FlowType { get; set; }

        [NameInMap("Locale")]
        [Validation(Required=false)]
        public string Locale { get; set; }

        [NameInMap("ReferenceCount")]
        [Validation(Required=false)]
        public int? ReferenceCount { get; set; }

        [NameInMap("TemplateGroup")]
        [Validation(Required=false)]
        public string TemplateGroup { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
