// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_finplus20220913.Models
{
    public class GetKnowledgeDataRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public GetKnowledgeDataRequestBody Body { get; set; }
        public class GetKnowledgeDataRequestBody : TeaModel {
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("knowledgeIdList")]
            [Validation(Required=false)]
            public List<string> KnowledgeIdList { get; set; }

        }

    }

}
