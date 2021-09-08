// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CompareFacesResponseBodyData Data { get; set; }
        public class CompareFacesResponseBodyData : TeaModel {
            [NameInMap("SimilarityScore")]
            [Validation(Required=false)]
            public float? SimilarityScore { get; set; }
            [NameInMap("ConfidenceThresholds")]
            [Validation(Required=false)]
            public string ConfidenceThresholds { get; set; }
        };

    }

}
