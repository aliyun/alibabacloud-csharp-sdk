// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CompareFacesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public CompareFacesResponseData Data { get; set; }
        public class CompareFacesResponseData : TeaModel {
            [NameInMap("SimilarityScore")]
            [Validation(Required=true)]
            public float? SimilarityScore { get; set; }
            [NameInMap("ConfidenceThresholds")]
            [Validation(Required=true)]
            public string ConfidenceThresholds { get; set; }
        };

    }

}
