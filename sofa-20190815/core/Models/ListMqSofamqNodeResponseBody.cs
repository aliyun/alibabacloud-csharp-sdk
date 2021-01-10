// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListMqSofamqNodeResponseBody : TeaModel {
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
        public List<ListMqSofamqNodeResponseBodyData> Data { get; set; }
        public class ListMqSofamqNodeResponseBodyData : TeaModel {
            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }

            [NameInMap("DataCenter")]
            [Validation(Required=false)]
            public string DataCenter { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("NodeGroup")]
            [Validation(Required=false)]
            public string NodeGroup { get; set; }

            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            [NameInMap("Perm")]
            [Validation(Required=false)]
            public string Perm { get; set; }

            [NameInMap("Rip")]
            [Validation(Required=false)]
            public string Rip { get; set; }

            [NameInMap("Room")]
            [Validation(Required=false)]
            public string Room { get; set; }

            [NameInMap("Vip")]
            [Validation(Required=false)]
            public string Vip { get; set; }

        }

    }

}
