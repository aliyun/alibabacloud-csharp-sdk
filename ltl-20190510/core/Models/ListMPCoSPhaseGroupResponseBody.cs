// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ltl20190510.Models
{
    public class ListMPCoSPhaseGroupResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMPCoSPhaseGroupResponseBodyData Data { get; set; }
        public class ListMPCoSPhaseGroupResponseBodyData : TeaModel {
            [NameInMap("Num")]
            [Validation(Required=false)]
            public int? Num { get; set; }

            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<ListMPCoSPhaseGroupResponseBodyDataPageData> PageData { get; set; }
            public class ListMPCoSPhaseGroupResponseBodyDataPageData : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PhaseGroupId")]
                [Validation(Required=false)]
                public string PhaseGroupId { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

            }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
