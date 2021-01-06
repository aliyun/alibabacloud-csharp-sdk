// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class RunMedQAResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RunMedQAResponseBodyData Data { get; set; }
        public class RunMedQAResponseBodyData : TeaModel {
            [NameInMap("Answer")]
            [Validation(Required=false)]
            public string Answer { get; set; }
            [NameInMap("SimilarQuestion")]
            [Validation(Required=false)]
            public List<string> SimilarQuestion { get; set; }
        };

    }

}
