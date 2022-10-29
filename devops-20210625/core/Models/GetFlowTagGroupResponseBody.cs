// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetFlowTagGroupResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("flowTagGroup")]
        [Validation(Required=false)]
        public GetFlowTagGroupResponseBodyFlowTagGroup FlowTagGroup { get; set; }
        public class GetFlowTagGroupResponseBodyFlowTagGroup : TeaModel {
            [NameInMap("creatorAccountId")]
            [Validation(Required=false)]
            public string CreatorAccountId { get; set; }

            [NameInMap("flowTagList")]
            [Validation(Required=false)]
            public List<GetFlowTagGroupResponseBodyFlowTagGroupFlowTagList> FlowTagList { get; set; }
            public class GetFlowTagGroupResponseBodyFlowTagGroupFlowTagList : TeaModel {
                [NameInMap("color")]
                [Validation(Required=false)]
                public string Color { get; set; }

                [NameInMap("creatorAccountId")]
                [Validation(Required=false)]
                public string CreatorAccountId { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("modiferAccountId")]
                [Validation(Required=false)]
                public string ModiferAccountId { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("modiferAccountId")]
            [Validation(Required=false)]
            public string ModiferAccountId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
