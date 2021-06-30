// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20201112.Models
{
    public class CompareFacesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public CompareFacesResponseBodyResultObject ResultObject { get; set; }
        public class CompareFacesResponseBodyResultObject : TeaModel {
            [NameInMap("SimilarityScore")]
            [Validation(Required=false)]
            public float? SimilarityScore { get; set; }
            [NameInMap("ConfidenceThresholds")]
            [Validation(Required=false)]
            public string ConfidenceThresholds { get; set; }
        };

    }

}
