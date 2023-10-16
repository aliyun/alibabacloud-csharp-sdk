// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryOssResourcesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryOssResourcesResponseBodyData Data { get; set; }
        public class QueryOssResourcesResponseBodyData : TeaModel {
            [NameInMap("TaskList")]
            [Validation(Required=false)]
            public List<QueryOssResourcesResponseBodyDataTaskList> TaskList { get; set; }
            public class QueryOssResourcesResponseBodyDataTaskList : TeaModel {
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OssUrl")]
                [Validation(Required=false)]
                public string OssUrl { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
