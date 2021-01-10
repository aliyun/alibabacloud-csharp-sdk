// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListMqSofamqTraceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMqSofamqTraceResponseBodyData Data { get; set; }
        public class ListMqSofamqTraceResponseBodyData : TeaModel {
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<ListMqSofamqTraceResponseBodyDataContent> Content { get; set; }
            public class ListMqSofamqTraceResponseBodyDataContent : TeaModel {
                public string Cell { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public string InstanceId { get; set; }
                public string MsgId { get; set; }
                public string MsgKey { get; set; }
                public string QueryId { get; set; }
                public string Status { get; set; }
                public string Topic { get; set; }
            }
        };

    }

}
