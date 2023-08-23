// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListCateInfoResponseBody : TeaModel {
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
        public List<ListCateInfoResponseBodyResult> Result { get; set; }
        public class ListCateInfoResponseBodyResult : TeaModel {
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }

            [NameInMap("ParentCateId")]
            [Validation(Required=false)]
            public long? ParentCateId { get; set; }

        }

    }

}
