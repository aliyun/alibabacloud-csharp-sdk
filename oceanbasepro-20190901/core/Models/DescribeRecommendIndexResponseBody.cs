// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeRecommendIndexResponseBody : TeaModel {
        [NameInMap("RecommendIndex")]
        [Validation(Required=false)]
        public DescribeRecommendIndexResponseBodyRecommendIndex RecommendIndex { get; set; }
        public class DescribeRecommendIndexResponseBodyRecommendIndex : TeaModel {
            [NameInMap("SuggestIndex")]
            [Validation(Required=false)]
            public string SuggestIndex { get; set; }

            [NameInMap("TableList")]
            [Validation(Required=false)]
            public string TableList { get; set; }

            [NameInMap("TenantMode")]
            [Validation(Required=false)]
            public string TenantMode { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
