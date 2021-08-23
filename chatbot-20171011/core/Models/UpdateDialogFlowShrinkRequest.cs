// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class UpdateDialogFlowShrinkRequest : TeaModel {
        [NameInMap("DialogId")]
        [Validation(Required=false)]
        public long? DialogId { get; set; }

        [NameInMap("ModuleDefinition")]
        [Validation(Required=false)]
        public string ModuleDefinitionShrink { get; set; }

    }

}
