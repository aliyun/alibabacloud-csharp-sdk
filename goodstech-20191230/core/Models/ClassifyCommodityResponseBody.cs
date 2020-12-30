// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Goodstech20191230.Models
{
    public class ClassifyCommodityResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ClassifyCommodityResponseBodyData Data { get; set; }
        public class ClassifyCommodityResponseBodyData : TeaModel {
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<ClassifyCommodityResponseBodyDataCategories> Categories { get; set; }
            public class ClassifyCommodityResponseBodyDataCategories : TeaModel {
                public float? Score { get; set; }
                public string CategoryId { get; set; }
                public string CategoryName { get; set; }
            }
        };

    }

}
