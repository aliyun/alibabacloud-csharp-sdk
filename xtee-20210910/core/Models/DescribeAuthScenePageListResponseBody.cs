// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeAuthScenePageListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeAuthScenePageListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeAuthScenePageListResponseBodyResultObject : TeaModel {
            [NameInMap("commonRuleCount")]
            [Validation(Required=false)]
            public long? CommonRuleCount { get; set; }

            [NameInMap("customRuleCount")]
            [Validation(Required=false)]
            public long? CustomRuleCount { get; set; }

            [NameInMap("eventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            [NameInMap("sceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            [NameInMap("serverName")]
            [Validation(Required=false)]
            public string ServerName { get; set; }

        }

        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public long? TotalItem { get; set; }

        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

    }

}
