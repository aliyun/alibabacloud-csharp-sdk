// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListDmsMsgTypeResponseBody : TeaModel {
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
        public ListDmsMsgTypeResponseBodyData Data { get; set; }
        public class ListDmsMsgTypeResponseBodyData : TeaModel {
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
            public List<ListDmsMsgTypeResponseBodyDataContent> Content { get; set; }
            public class ListDmsMsgTypeResponseBodyDataContent : TeaModel {
                public string Desc { get; set; }
                public string Eventcode { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public long? Id { get; set; }
                public string InstanceId { get; set; }
                public string Topic { get; set; }
            }
        };

    }

}
