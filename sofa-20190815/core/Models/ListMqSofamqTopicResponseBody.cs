// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListMqSofamqTopicResponseBody : TeaModel {
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
        public ListMqSofamqTopicResponseBodyData Data { get; set; }
        public class ListMqSofamqTopicResponseBodyData : TeaModel {
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
            public List<ListMqSofamqTopicResponseBodyDataContent> Content { get; set; }
            public class ListMqSofamqTopicResponseBodyDataContent : TeaModel {
                public string Cluster { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public long? Id { get; set; }
                public string InstanceId { get; set; }
                public long? MessageType { get; set; }
                public string Operator { get; set; }
                public long? Perm { get; set; }
                public long? ReadQueueNum { get; set; }
                public string Remark { get; set; }
                public string Topic { get; set; }
                public long? WriteQueueNum { get; set; }
            }
        };

    }

}
