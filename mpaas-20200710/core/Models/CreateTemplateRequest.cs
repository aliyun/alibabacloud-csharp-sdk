// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20200710.Models
{
    public class CreateTemplateRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("DescInfo")]
        [Validation(Required=false)]
        public string DescInfo { get; set; }

        [NameInMap("IconUrls")]
        [Validation(Required=false)]
        public string IconUrls { get; set; }

        [NameInMap("ImageUrls")]
        [Validation(Required=false)]
        public string ImageUrls { get; set; }

        [NameInMap("JumpAction")]
        [Validation(Required=false)]
        public int? JumpAction { get; set; }

        [NameInMap("PushStyle")]
        [Validation(Required=false)]
        public int? PushStyle { get; set; }

        [NameInMap("ShowStyle")]
        [Validation(Required=false)]
        public long? ShowStyle { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

        [NameInMap("Variables")]
        [Validation(Required=false)]
        public string Variables { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
