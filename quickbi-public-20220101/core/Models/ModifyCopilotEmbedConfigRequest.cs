// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ModifyCopilotEmbedConfigRequest : TeaModel {
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CopilotId")]
        [Validation(Required=false)]
        public string CopilotId { get; set; }

        [NameInMap("DataRange")]
        [Validation(Required=false)]
        public string DataRange { get; set; }

        [NameInMap("ModuleName")]
        [Validation(Required=false)]
        public string ModuleName { get; set; }

    }

}
