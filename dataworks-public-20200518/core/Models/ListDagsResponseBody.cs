// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDagsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDagsResponseBodyData Data { get; set; }
        public class ListDagsResponseBodyData : TeaModel {
            [NameInMap("Dags")]
            [Validation(Required=false)]
            public List<ListDagsResponseBodyDataDags> Dags { get; set; }
            public class ListDagsResponseBodyDataDags : TeaModel {
                public long? Bizdate { get; set; }
                public long? CreateTime { get; set; }
                public string CreateUser { get; set; }
                public long? DagId { get; set; }
                public long? FinishTime { get; set; }
                public long? Gmtdate { get; set; }
                public long? ModifyTime { get; set; }
                public string Name { get; set; }
                public long? OpSeq { get; set; }
                public long? ProjectId { get; set; }
                public long? StartTime { get; set; }
                public string Status { get; set; }
                public string Type { get; set; }
            }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
