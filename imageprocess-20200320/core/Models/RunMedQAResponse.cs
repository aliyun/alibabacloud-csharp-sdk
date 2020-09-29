// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class RunMedQAResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public RunMedQAResponseData Data { get; set; }
        public class RunMedQAResponseData : TeaModel {
            [NameInMap("Answer")]
            [Validation(Required=true)]
            public string Answer { get; set; }
            [NameInMap("SimilarQuestion")]
            [Validation(Required=true)]
            public List<string> SimilarQuestion { get; set; }
        };

    }

}
