// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_finplus20220913.Models
{
    public class CreateKnowLedgeRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateKnowLedgeRequestBody Body { get; set; }
        public class CreateKnowLedgeRequestBody : TeaModel {
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("internalKnowledgeId")]
            [Validation(Required=false)]
            public string InternalKnowledgeId { get; set; }

            [NameInMap("knowledgeName")]
            [Validation(Required=false)]
            public string KnowledgeName { get; set; }

        }

    }

}
