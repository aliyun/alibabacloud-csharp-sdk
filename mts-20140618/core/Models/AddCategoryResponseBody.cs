// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class AddCategoryResponseBody : TeaModel {
        [NameInMap("Category")]
        [Validation(Required=false)]
        public AddCategoryResponseBodyCategory Category { get; set; }
        public class AddCategoryResponseBodyCategory : TeaModel {
            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public string CateId { get; set; }
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
