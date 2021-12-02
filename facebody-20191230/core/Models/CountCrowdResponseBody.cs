// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class CountCrowdResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CountCrowdResponseBodyData Data { get; set; }
        public class CountCrowdResponseBodyData : TeaModel {
            [NameInMap("HotMap")]
            [Validation(Required=false)]
            public string HotMap { get; set; }
            [NameInMap("PeopleNumber")]
            [Validation(Required=false)]
            public int? PeopleNumber { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
