// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListMqSofamqDatacenterResponseBody : TeaModel {
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
        public List<ListMqSofamqDatacenterResponseBodyData> Data { get; set; }
        public class ListMqSofamqDatacenterResponseBodyData : TeaModel {
            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }

            [NameInMap("Datacenter")]
            [Validation(Required=false)]
            public string Datacenter { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Room")]
            [Validation(Required=false)]
            public string Room { get; set; }

        }

    }

}
