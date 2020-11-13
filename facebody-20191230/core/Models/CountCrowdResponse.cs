// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class CountCrowdResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public CountCrowdResponseData Data { get; set; }
        public class CountCrowdResponseData : TeaModel {
            [NameInMap("PeopleNumber")]
            [Validation(Required=true)]
            public int? PeopleNumber { get; set; }
            [NameInMap("HotMap")]
            [Validation(Required=true)]
            public string HotMap { get; set; }
        };

    }

}
