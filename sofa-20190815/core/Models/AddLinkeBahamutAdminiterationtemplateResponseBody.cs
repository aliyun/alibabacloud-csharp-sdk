// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddLinkeBahamutAdminiterationtemplateResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public AddLinkeBahamutAdminiterationtemplateResponseBodyResult Result { get; set; }
        public class AddLinkeBahamutAdminiterationtemplateResponseBodyResult : TeaModel {
            [NameInMap("PreSetStageTemplateIds")]
            [Validation(Required=false)]
            public List<string> PreSetStageTemplateIds { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("TemplateGroup")]
            [Validation(Required=false)]
            public string TemplateGroup { get; set; }
            [NameInMap("NeedProject")]
            [Validation(Required=false)]
            public bool? NeedProject { get; set; }
            [NameInMap("XflushCheckEnable")]
            [Validation(Required=false)]
            public bool? XflushCheckEnable { get; set; }
            [NameInMap("FabricBizType")]
            [Validation(Required=false)]
            public string FabricBizType { get; set; }
            [NameInMap("NeedWorkItem")]
            [Validation(Required=false)]
            public bool? NeedWorkItem { get; set; }
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public long? LastModified { get; set; }
            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<string> Tasks { get; set; }
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }
            [NameInMap("Tenant")]
            [Validation(Required=false)]
            public string Tenant { get; set; }
            [NameInMap("StageTemplates")]
            [Validation(Required=false)]
            public List<string> StageTemplates { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }
            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("IndependentComplete")]
            [Validation(Required=false)]
            public bool? IndependentComplete { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }
        };

    }

}
