// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryTSExecuteInstanceShardingsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<QueryTSExecuteInstanceShardingsResponseBodyList> List { get; set; }
        public class QueryTSExecuteInstanceShardingsResponseBodyList : TeaModel {
            [NameInMap("Consume")]
            [Validation(Required=false)]
            public long? Consume { get; set; }

            [NameInMap("GmtBegin")]
            [Validation(Required=false)]
            public string GmtBegin { get; set; }

            [NameInMap("GmtEnd")]
            [Validation(Required=false)]
            public string GmtEnd { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("Sharding")]
            [Validation(Required=false)]
            public long? Sharding { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
