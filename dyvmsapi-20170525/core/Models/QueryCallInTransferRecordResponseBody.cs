// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryCallInTransferRecordResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCallInTransferRecordResponseBodyData Data { get; set; }
        public class QueryCallInTransferRecordResponseBodyData : TeaModel {
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<QueryCallInTransferRecordResponseBodyDataValues> Values { get; set; }
            public class QueryCallInTransferRecordResponseBodyDataValues : TeaModel {
                public string CallInCalled { get; set; }
                public string CallInCaller { get; set; }
                public long? GmtCreate { get; set; }
                public string RecordUrl { get; set; }
                public string TransferCalled { get; set; }
                public string TransferCaller { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
