// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListMqSofamqWarnHistoryResponseBody : TeaModel {
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
        public ListMqSofamqWarnHistoryResponseBodyData Data { get; set; }
        public class ListMqSofamqWarnHistoryResponseBodyData : TeaModel {
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
            public List<ListMqSofamqWarnHistoryResponseBodyDataContent> Content { get; set; }
            public class ListMqSofamqWarnHistoryResponseBodyDataContent : TeaModel {
                public string Cell { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public string GroupId { get; set; }
                public string InstanceId { get; set; }
                public string Topic { get; set; }
                public long? WarnId { get; set; }
                public string WarnInfo { get; set; }
            }
        };

    }

}
