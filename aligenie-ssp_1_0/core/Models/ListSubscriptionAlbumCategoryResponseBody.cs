// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListSubscriptionAlbumCategoryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListSubscriptionAlbumCategoryResponseBodyResult> Result { get; set; }
        public class ListSubscriptionAlbumCategoryResponseBodyResult : TeaModel {
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

        }

    }

}
