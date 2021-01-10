// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListMqSofamqWarnResponseBody : TeaModel {
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
        public ListMqSofamqWarnResponseBodyData Data { get; set; }
        public class ListMqSofamqWarnResponseBodyData : TeaModel {
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
            public List<ListMqSofamqWarnResponseBodyDataContent> Content { get; set; }
            public class ListMqSofamqWarnResponseBodyDataContent : TeaModel {
                public string AlertTime { get; set; }
                public string Attribute { get; set; }
                public long? BlockTime { get; set; }
                public string Contacts { get; set; }
                public long? DelayTime { get; set; }
                public long? Frequency { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public string GroupId { get; set; }
                public long? Id { get; set; }
                public string InstanceId { get; set; }
                public string Operator { get; set; }
                public long? Threshold { get; set; }
                public string Topic { get; set; }
                public long? WarnLevel { get; set; }
                public long? WarnStatus { get; set; }
                public long? WarnType { get; set; }
            }
        };

    }

}
