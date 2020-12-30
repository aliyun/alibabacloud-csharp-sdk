// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeBizSimpleListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

        [NameInMap("BizSimpleList")]
        [Validation(Required=false)]
        public List<DescribeBizSimpleListResponseBodyBizSimpleList> BizSimpleList { get; set; }
        public class DescribeBizSimpleListResponseBodyBizSimpleList : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("NgGroupId")]
            [Validation(Required=false)]
            public string NgGroupId { get; set; }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            [NameInMap("UseCc")]
            [Validation(Required=false)]
            public int? UseCc { get; set; }

            [NameInMap("BizId")]
            [Validation(Required=false)]
            public long? BizId { get; set; }

            [NameInMap("BizName")]
            [Validation(Required=false)]
            public string BizName { get; set; }

            [NameInMap("EsnBizId")]
            [Validation(Required=false)]
            public string EsnBizId { get; set; }

            [NameInMap("CcQps")]
            [Validation(Required=false)]
            public int? CcQps { get; set; }

        }

    }

}
