// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ltl20190510.Models
{
    public class ListMultiPartyCollaborationChainResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMultiPartyCollaborationChainResponseBodyData Data { get; set; }
        public class ListMultiPartyCollaborationChainResponseBodyData : TeaModel {
            [NameInMap("Num")]
            [Validation(Required=false)]
            public int? Num { get; set; }

            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<ListMultiPartyCollaborationChainResponseBodyDataPageData> PageData { get; set; }
            public class ListMultiPartyCollaborationChainResponseBodyDataPageData : TeaModel {
                [NameInMap("BizChainId")]
                [Validation(Required=false)]
                public string BizChainId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("RoleType")]
                [Validation(Required=false)]
                public string RoleType { get; set; }

            }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
