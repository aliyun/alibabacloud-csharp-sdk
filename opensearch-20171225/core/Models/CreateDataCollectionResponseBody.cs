// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateDataCollectionResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateDataCollectionResponseBodyResult Result { get; set; }
        public class CreateDataCollectionResponseBodyResult : TeaModel {
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }
            [NameInMap("dataCollectionType")]
            [Validation(Required=false)]
            public string DataCollectionType { get; set; }
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("industryName")]
            [Validation(Required=false)]
            public string IndustryName { get; set; }
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("sundialId")]
            [Validation(Required=false)]
            public string SundialId { get; set; }
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }
        };

    }

}
