// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryMessagesResponseBody : TeaModel {
        [NameInMap("BizMessages")]
        [Validation(Required=false)]
        public QueryMessagesResponseBodyBizMessages BizMessages { get; set; }
        public class QueryMessagesResponseBodyBizMessages : TeaModel {
            [NameInMap("BizMessage")]
            [Validation(Required=false)]
            public List<QueryMessagesResponseBodyBizMessagesBizMessage> BizMessage { get; set; }
            public class QueryMessagesResponseBodyBizMessagesBizMessage : TeaModel {
                [NameInMap("ContentMapJson")]
                [Validation(Required=false)]
                public string ContentMapJson { get; set; }

                [NameInMap("DataId")]
                [Validation(Required=false)]
                public long? DataId { get; set; }

                [NameInMap("PubTime")]
                [Validation(Required=false)]
                public string PubTime { get; set; }

                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
