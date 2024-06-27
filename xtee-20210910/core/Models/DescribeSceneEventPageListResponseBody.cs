// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSceneEventPageListResponseBody : TeaModel {
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeSceneEventPageListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeSceneEventPageListResponseBodyResultObject : TeaModel {
            [NameInMap("commonRuleCount")]
            [Validation(Required=false)]
            public string CommonRuleCount { get; set; }

            [NameInMap("customRuleCount")]
            [Validation(Required=false)]
            public string CustomRuleCount { get; set; }

            [NameInMap("eventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            [NameInMap("eventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            [NameInMap("normalRuleCount")]
            [Validation(Required=false)]
            public string NormalRuleCount { get; set; }

            [NameInMap("service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            [NameInMap("useStatus")]
            [Validation(Required=false)]
            public string UseStatus { get; set; }

            [NameInMap("whiteBoxRuleCount")]
            [Validation(Required=false)]
            public string WhiteBoxRuleCount { get; set; }

        }

        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
