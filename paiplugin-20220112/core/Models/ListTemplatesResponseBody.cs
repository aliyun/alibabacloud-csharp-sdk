// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class ListTemplatesResponseBody : TeaModel {
        /// <summary>
        /// 返回数据。
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTemplatesResponseBodyData Data { get; set; }
        public class ListTemplatesResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Templates")]
            [Validation(Required=false)]
            public List<ListTemplatesResponseBodyDataTemplates> Templates { get; set; }
            public class ListTemplatesResponseBodyDataTemplates : TeaModel {
                public string Content { get; set; }
                public string CreatedTime { get; set; }
                public string Description { get; set; }
                public string Id { get; set; }
                public string Name { get; set; }
                public string Reason { get; set; }
                public string SignatureId { get; set; }
                public int? Status { get; set; }
                public string TemplateCode { get; set; }
                public int? Type { get; set; }
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
