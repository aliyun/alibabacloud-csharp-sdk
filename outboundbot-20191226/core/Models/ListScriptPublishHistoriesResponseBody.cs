// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListScriptPublishHistoriesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScriptPublishHistories")]
        [Validation(Required=false)]
        public ListScriptPublishHistoriesResponseBodyScriptPublishHistories ScriptPublishHistories { get; set; }
        public class ListScriptPublishHistoriesResponseBodyScriptPublishHistories : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListScriptPublishHistoriesResponseBodyScriptPublishHistoriesList> List { get; set; }
            public class ListScriptPublishHistoriesResponseBodyScriptPublishHistoriesList : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("PublishTime")]
                [Validation(Required=false)]
                public long? PublishTime { get; set; }

                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                [NameInMap("ScriptVersion")]
                [Validation(Required=false)]
                public string ScriptVersion { get; set; }

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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
