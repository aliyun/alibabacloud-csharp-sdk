// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddCategoryResponseBody : TeaModel {
        [NameInMap("Category")]
        [Validation(Required=false)]
        public AddCategoryResponseBodyCategory Category { get; set; }
        public class AddCategoryResponseBodyCategory : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }
            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }
            [NameInMap("Level")]
            [Validation(Required=false)]
            public long? Level { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
