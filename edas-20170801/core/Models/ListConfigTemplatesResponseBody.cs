// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListConfigTemplatesResponseBody : TeaModel {
        /// <summary>
        /// 响应码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// 查询结果
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListConfigTemplatesResponseBodyData Data { get; set; }
        public class ListConfigTemplatesResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListConfigTemplatesResponseBodyDataResult> Result { get; set; }
            public class ListConfigTemplatesResponseBodyDataResult : TeaModel {
                public string Content { get; set; }
                public string Description { get; set; }
                public string Format { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public string Id { get; set; }
                public string Name { get; set; }
            }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }
        };

        /// <summary>
        /// 响应码文本描述
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
