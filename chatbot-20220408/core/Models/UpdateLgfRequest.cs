// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class UpdateLgfRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("LgfDefinition")]
        [Validation(Required=false)]
        public UpdateLgfRequestLgfDefinition LgfDefinition { get; set; }
        public class UpdateLgfRequestLgfDefinition : TeaModel {
            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public long? IntentId { get; set; }

            [NameInMap("RuleText")]
            [Validation(Required=false)]
            public string RuleText { get; set; }

        }

        /// <summary>
        /// LGF ID
        /// </summary>
        [NameInMap("LgfId")]
        [Validation(Required=false)]
        public long? LgfId { get; set; }

    }

}
