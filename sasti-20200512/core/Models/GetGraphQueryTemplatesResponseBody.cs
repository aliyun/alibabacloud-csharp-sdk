// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sasti20200512.Models
{
    public class GetGraphQueryTemplatesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetGraphQueryTemplatesResponseBodyData> Data { get; set; }
        public class GetGraphQueryTemplatesResponseBodyData : TeaModel {
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("GremlinTemplate")]
            [Validation(Required=false)]
            public string GremlinTemplate { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("LastModifier")]
            [Validation(Required=false)]
            public string LastModifier { get; set; }

            [NameInMap("Scenario")]
            [Validation(Required=false)]
            public string Scenario { get; set; }

            [NameInMap("ScenarioDesc")]
            [Validation(Required=false)]
            public string ScenarioDesc { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
