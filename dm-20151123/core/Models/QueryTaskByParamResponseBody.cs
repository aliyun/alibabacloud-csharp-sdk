// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class QueryTaskByParamResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryTaskByParamResponseBodyData Data { get; set; }
        public class QueryTaskByParamResponseBodyData : TeaModel {
            [NameInMap("task")]
            [Validation(Required=false)]
            public List<QueryTaskByParamResponseBodyDataTask> Task { get; set; }
            public class QueryTaskByParamResponseBodyDataTask : TeaModel {
                public string ReceiversName { get; set; }
                public string TagName { get; set; }
                public string TaskStatus { get; set; }
                public string CreateTime { get; set; }
                public string RequestCount { get; set; }
                public string AddressType { get; set; }
                public long? UtcCreateTime { get; set; }
                public string TemplateName { get; set; }
                public string TaskId { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
