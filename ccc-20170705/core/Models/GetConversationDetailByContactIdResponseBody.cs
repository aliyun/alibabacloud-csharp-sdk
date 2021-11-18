// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetConversationDetailByContactIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=false)]
        public GetConversationDetailByContactIdResponseBodyDataList DataList { get; set; }
        public class GetConversationDetailByContactIdResponseBodyDataList : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public GetConversationDetailByContactIdResponseBodyDataListList List { get; set; }
            public class GetConversationDetailByContactIdResponseBodyDataListList : TeaModel {
                [NameInMap("QualityCheckPhrase")]
                [Validation(Required=false)]
                public List<GetConversationDetailByContactIdResponseBodyDataListListQualityCheckPhrase> QualityCheckPhrase { get; set; }
                public class GetConversationDetailByContactIdResponseBodyDataListListQualityCheckPhrase : TeaModel {
                    [NameInMap("Begin")]
                    [Validation(Required=false)]
                    public long? Begin { get; set; }

                    [NameInMap("End")]
                    [Validation(Required=false)]
                    public long? End { get; set; }

                    [NameInMap("Identity")]
                    [Validation(Required=false)]
                    public string Identity { get; set; }

                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                    [NameInMap("Words")]
                    [Validation(Required=false)]
                    public string Words { get; set; }

                }

            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
