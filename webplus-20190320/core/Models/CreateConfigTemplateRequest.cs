// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class CreateConfigTemplateRequest : TeaModel {
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("TemplateDescription")]
        [Validation(Required=false)]
        public string TemplateDescription { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        [NameInMap("SourceTemplateId")]
        [Validation(Required=false)]
        public string SourceTemplateId { get; set; }

        [NameInMap("SourceEnvId")]
        [Validation(Required=false)]
        public string SourceEnvId { get; set; }

        [NameInMap("ProfileName")]
        [Validation(Required=false)]
        public string ProfileName { get; set; }

        [NameInMap("PkgVersionId")]
        [Validation(Required=false)]
        public string PkgVersionId { get; set; }

        [NameInMap("OptionSettings")]
        [Validation(Required=false)]
        public string OptionSettings { get; set; }

    }

}
