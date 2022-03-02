// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class ListGroupsResponseBody : TeaModel {
        /// <summary>
        /// 返回数据
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGroupsResponseBodyData Data { get; set; }
        public class ListGroupsResponseBodyData : TeaModel {
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<ListGroupsResponseBodyDataGroups> Groups { get; set; }
            public class ListGroupsResponseBodyDataGroups : TeaModel {
                public string Algorithm { get; set; }
                public int? Amount { get; set; }
                public string Column { get; set; }
                public string CreatedTime { get; set; }
                public string Filter { get; set; }
                public string Id { get; set; }
                public string InferenceJobId { get; set; }
                public string Name { get; set; }
                public string Project { get; set; }
                public string Remark { get; set; }
                public int? Source { get; set; }
                public int? Status { get; set; }
                public string Table { get; set; }
                public string Text { get; set; }
                public string UpdatedTime { get; set; }
                public string Uri { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        /// <summary>
        /// 错误码。
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
