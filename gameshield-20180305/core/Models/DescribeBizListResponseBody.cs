// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeBizListResponseBody : TeaModel {
        [NameInMap("BizList")]
        [Validation(Required=false)]
        public List<DescribeBizListResponseBodyBizList> BizList { get; set; }
        public class DescribeBizListResponseBodyBizList : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("NodeInUseNum")]
            [Validation(Required=false)]
            public int? NodeInUseNum { get; set; }

            [NameInMap("NgGroupId")]
            [Validation(Required=false)]
            public string NgGroupId { get; set; }

            [NameInMap("UseCc")]
            [Validation(Required=false)]
            public int? UseCc { get; set; }

            [NameInMap("BizId")]
            [Validation(Required=false)]
            public long? BizId { get; set; }

            [NameInMap("GroupNum")]
            [Validation(Required=false)]
            public int? GroupNum { get; set; }

            [NameInMap("NodeUnUseNum")]
            [Validation(Required=false)]
            public int? NodeUnUseNum { get; set; }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            [NameInMap("BizName")]
            [Validation(Required=false)]
            public string BizName { get; set; }

            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public int? NodeNum { get; set; }

            [NameInMap("EsnBizId")]
            [Validation(Required=false)]
            public string EsnBizId { get; set; }

            [NameInMap("CcQps")]
            [Validation(Required=false)]
            public int? CcQps { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

    }

}
