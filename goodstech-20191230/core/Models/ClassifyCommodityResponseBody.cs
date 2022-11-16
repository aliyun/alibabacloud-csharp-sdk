// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Goodstech20191230.Models
{
    public class ClassifyCommodityResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ClassifyCommodityResponseBodyData Data { get; set; }
        public class ClassifyCommodityResponseBodyData : TeaModel {
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<ClassifyCommodityResponseBodyDataCategories> Categories { get; set; }
            public class ClassifyCommodityResponseBodyDataCategories : TeaModel {
                [NameInMap("CategoryId")]
                [Validation(Required=false)]
                public string CategoryId { get; set; }

                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
