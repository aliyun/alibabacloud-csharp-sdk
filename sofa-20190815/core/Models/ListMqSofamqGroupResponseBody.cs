// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListMqSofamqGroupResponseBody : TeaModel {
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
        public ListMqSofamqGroupResponseBodyData Data { get; set; }
        public class ListMqSofamqGroupResponseBodyData : TeaModel {
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
            public List<ListMqSofamqGroupResponseBodyDataContent> Content { get; set; }
            public class ListMqSofamqGroupResponseBodyDataContent : TeaModel {
                public string Cluster { get; set; }
                public string DeleteMark { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public string GroupId { get; set; }
                public string GroupType { get; set; }
                public long? Id { get; set; }
                public string InstanceId { get; set; }
                public string Operator { get; set; }
                public bool? ReadEnable { get; set; }
                public string Remark { get; set; }
                public long? RetryPerm { get; set; }
                public long? RetryReadQueueNum { get; set; }
                public long? RetryWriteQueueNum { get; set; }
                public string Scope { get; set; }
                public long? Version { get; set; }
            }
        };

    }

}
