// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeGroupPageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeGroupPageResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeGroupPageResponseBodyResultObject : TeaModel {
            [NameInMap("communityNo")]
            [Validation(Required=false)]
            public string CommunityNo { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("groupRisk")]
            [Validation(Required=false)]
            public string GroupRisk { get; set; }

            [NameInMap("groupScale")]
            [Validation(Required=false)]
            public string GroupScale { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("sceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
