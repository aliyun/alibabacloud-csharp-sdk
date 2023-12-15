// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AppMallsService20180224.Models
{
    public class GetMessagesResponseBody : TeaModel {
        [NameInMap("BizMessages")]
        [Validation(Required=false)]
        public List<GetMessagesResponseBodyBizMessages> BizMessages { get; set; }
        public class GetMessagesResponseBodyBizMessages : TeaModel {
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

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMsg")]
        [Validation(Required=false)]
        public string SubMsg { get; set; }

    }

}
