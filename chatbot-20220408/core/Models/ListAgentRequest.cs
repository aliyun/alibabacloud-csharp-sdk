// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListAgentRequest : TeaModel {
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        [NameInMap("GoodsCodes")]
        [Validation(Required=false)]
        public string GoodsCodes { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
