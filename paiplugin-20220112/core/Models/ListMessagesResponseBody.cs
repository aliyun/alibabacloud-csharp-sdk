// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class ListMessagesResponseBody : TeaModel {
        /// <summary>
        /// 返回数据。
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMessagesResponseBodyData Data { get; set; }
        public class ListMessagesResponseBodyData : TeaModel {
            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<ListMessagesResponseBodyDataMessages> Messages { get; set; }
            public class ListMessagesResponseBodyDataMessages : TeaModel {
                public string ErrorCode { get; set; }
                public string GroupId { get; set; }
                public string Id { get; set; }
                public string OutId { get; set; }
                public string PhoneNumber { get; set; }
                public string ScheduleId { get; set; }
                public string Signature { get; set; }
                public int? Status { get; set; }
                public string TemplateCode { get; set; }
                public string TemplateParams { get; set; }
                public int? TemplateType { get; set; }
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
