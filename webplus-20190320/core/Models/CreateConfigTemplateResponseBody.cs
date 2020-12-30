// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class CreateConfigTemplateResponseBody : TeaModel {
        [NameInMap("ConfigTemplate")]
        [Validation(Required=false)]
        public CreateConfigTemplateResponseBodyConfigTemplate ConfigTemplate { get; set; }
        public class CreateConfigTemplateResponseBodyConfigTemplate : TeaModel {
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }
            [NameInMap("StackName")]
            [Validation(Required=false)]
            public string StackName { get; set; }
            [NameInMap("PkgVersionId")]
            [Validation(Required=false)]
            public string PkgVersionId { get; set; }
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }
            [NameInMap("TemplateDescription")]
            [Validation(Required=false)]
            public string TemplateDescription { get; set; }
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("StackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }
            [NameInMap("PkgVersionLabel")]
            [Validation(Required=false)]
            public string PkgVersionLabel { get; set; }
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
