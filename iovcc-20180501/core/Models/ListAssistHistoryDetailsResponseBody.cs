// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListAssistHistoryDetailsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Actions")]
        [Validation(Required=false)]
        public List<ListAssistHistoryDetailsResponseBodyActions> Actions { get; set; }
        public class ListAssistHistoryDetailsResponseBodyActions : TeaModel {
            [NameInMap("AssistId")]
            [Validation(Required=false)]
            public string AssistId { get; set; }

            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public long? UpdatedAt { get; set; }

            [NameInMap("ID")]
            [Validation(Required=false)]
            public string ID { get; set; }

        }

    }

}
