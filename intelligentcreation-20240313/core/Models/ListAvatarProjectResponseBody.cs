// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class ListAvatarProjectResponseBody : TeaModel {
        [NameInMap("queryAvatarProjectResultList")]
        [Validation(Required=false)]
        public List<ListAvatarProjectResponseBodyQueryAvatarProjectResultList> QueryAvatarProjectResultList { get; set; }
        public class ListAvatarProjectResponseBodyQueryAvatarProjectResultList : TeaModel {
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            [NameInMap("errorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("projectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
