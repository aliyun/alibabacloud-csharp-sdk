// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class UpdateDialogFlowModuleDefinition : TeaModel {
        [NameInMap("Edges")]
        [Validation(Required=false)]
        public List<PaasEdgeDTO> Edges { get; set; }

        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<PaasNodeDTO> Nodes { get; set; }

    }

}
