// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class ListSchedulesResponseBody : TeaModel {
        /// <summary>
        /// 返回数据。
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSchedulesResponseBodyData Data { get; set; }
        public class ListSchedulesResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Schedules")]
            [Validation(Required=false)]
            public List<ListSchedulesResponseBodyDataSchedules> Schedules { get; set; }
            public class ListSchedulesResponseBodyDataSchedules : TeaModel {
                public string CreatedTime { get; set; }
                public int? EndTime { get; set; }
                public string ExecuteTime { get; set; }
                public string GroupId { get; set; }
                public string Id { get; set; }
                public string Name { get; set; }
                public int? RepeatCycle { get; set; }
                public int? RepeatCycleUnit { get; set; }
                public int? RepeatTimes { get; set; }
                public string SignName { get; set; }
                public string SignatureId { get; set; }
                public int? Status { get; set; }
                public string TemplateCode { get; set; }
                public string TemplateId { get; set; }
                public string UpdatedTime { get; set; }
            }
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
