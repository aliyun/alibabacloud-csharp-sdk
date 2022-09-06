// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListIntentsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Intents")]
        [Validation(Required=false)]
        public ListIntentsResponseBodyIntents Intents { get; set; }
        public class ListIntentsResponseBodyIntents : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListIntentsResponseBodyIntentsList> List { get; set; }
            public class ListIntentsResponseBodyIntentsList : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("IntentDescription")]
                [Validation(Required=false)]
                public string IntentDescription { get; set; }

                [NameInMap("IntentId")]
                [Validation(Required=false)]
                public string IntentId { get; set; }

                [NameInMap("IntentName")]
                [Validation(Required=false)]
                public string IntentName { get; set; }

                [NameInMap("Keywords")]
                [Validation(Required=false)]
                public string Keywords { get; set; }

                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                [NameInMap("Utterances")]
                [Validation(Required=false)]
                public string Utterances { get; set; }

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
