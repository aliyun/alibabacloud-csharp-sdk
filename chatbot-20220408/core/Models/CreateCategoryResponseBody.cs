// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateCategoryResponseBody : TeaModel {
        /// <summary>
        /// 类目信息
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public CreateCategoryResponseBodyCategory Category { get; set; }
        public class CreateCategoryResponseBodyCategory : TeaModel {
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("ParentCategoryId")]
            [Validation(Required=false)]
            public long? ParentCategoryId { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
