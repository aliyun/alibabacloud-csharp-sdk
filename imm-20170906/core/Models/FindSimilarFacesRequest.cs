// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class FindSimilarFacesRequest : TeaModel {
        [NameInMap("FaceId")]
        [Validation(Required=false)]
        public string FaceId { get; set; }

        [NameInMap("ImageUri")]
        [Validation(Required=false)]
        public string ImageUri { get; set; }

        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("MinSimilarity")]
        [Validation(Required=false)]
        public float? MinSimilarity { get; set; }

        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("ResponseFormat")]
        [Validation(Required=false)]
        public string ResponseFormat { get; set; }

        [NameInMap("SetId")]
        [Validation(Required=false)]
        public string SetId { get; set; }

    }

}
