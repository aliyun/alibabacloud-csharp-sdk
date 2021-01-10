// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryDTXTransactionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryDTXTransactionsResponseBodyData> Data { get; set; }
        public class QueryDTXTransactionsResponseBodyData : TeaModel {
            [NameInMap("ActionMode")]
            [Validation(Required=false)]
            public long? ActionMode { get; set; }

            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("BusinessId")]
            [Validation(Required=false)]
            public string BusinessId { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("InitiatorIp")]
            [Validation(Required=false)]
            public string InitiatorIp { get; set; }

            [NameInMap("InitiatorName")]
            [Validation(Required=false)]
            public string InitiatorName { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TxId")]
            [Validation(Required=false)]
            public string TxId { get; set; }

            [NameInMap("ParticipatorIds")]
            [Validation(Required=false)]
            public List<string> ParticipatorIds { get; set; }

        }

    }

}
