// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CustomerService20231228.Models
{
    public class ListYunQiTaskByUidResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListYunQiTaskByUidResponseBodyData Data { get; set; }
        public class ListYunQiTaskByUidResponseBodyData : TeaModel {
            [NameInMap("extend")]
            [Validation(Required=false)]
            public object Extend { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListYunQiTaskByUidResponseBodyDataList> List { get; set; }
            public class ListYunQiTaskByUidResponseBodyDataList : TeaModel {
                [NameInMap("chatId")]
                [Validation(Required=false)]
                public string ChatId { get; set; }

                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("creatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("evaluationStar")]
                [Validation(Required=false)]
                public int? EvaluationStar { get; set; }

                [NameInMap("important")]
                [Validation(Required=false)]
                public string Important { get; set; }

                [NameInMap("mainDingDepartmentId")]
                [Validation(Required=false)]
                public string MainDingDepartmentId { get; set; }

                [NameInMap("mainDingGroupId")]
                [Validation(Required=false)]
                public string MainDingGroupId { get; set; }

                [NameInMap("mainDingGroupName")]
                [Validation(Required=false)]
                public string MainDingGroupName { get; set; }

                [NameInMap("productName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                [NameInMap("recordId")]
                [Validation(Required=false)]
                public string RecordId { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("subDingDepartmentId")]
                [Validation(Required=false)]
                public string SubDingDepartmentId { get; set; }

                [NameInMap("subDingGroupId")]
                [Validation(Required=false)]
                public string SubDingGroupId { get; set; }

                [NameInMap("subDingGroupName")]
                [Validation(Required=false)]
                public string SubDingGroupName { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("pageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
