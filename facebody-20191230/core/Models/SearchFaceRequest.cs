// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class SearchFaceRequest : TeaModel {
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("DbNames")]
        [Validation(Required=false)]
        public string DbNames { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("MaxFaceNum")]
        [Validation(Required=false)]
        public long? MaxFaceNum { get; set; }

        [NameInMap("QualityScoreThreshold")]
        [Validation(Required=false)]
        public float? QualityScoreThreshold { get; set; }

    }

}
