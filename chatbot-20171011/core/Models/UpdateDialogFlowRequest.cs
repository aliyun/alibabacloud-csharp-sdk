// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class UpdateDialogFlowRequest : TeaModel {
        [NameInMap("DialogId")]
        [Validation(Required=false)]
        public long? DialogId { get; set; }

        [NameInMap("ModuleDefinition")]
        [Validation(Required=false)]
        public UpdateDialogFlowRequestModuleDefinition ModuleDefinition { get; set; }
        public class UpdateDialogFlowRequestModuleDefinition : TeaModel {
            [NameInMap("GlobalVars")]
            [Validation(Required=false)]
            public Dictionary<string, string> GlobalVars { get; set; }
            [NameInMap("ModuleDefinition")]
            [Validation(Required=false)]
            public PaasProcessData ModuleDefinition { get; set; }
        };

    }

}
