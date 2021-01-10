// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryTSOperationRecordsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<QueryTSOperationRecordsResponseBodyList> List { get; set; }
        public class QueryTSOperationRecordsResponseBodyList : TeaModel {
            [NameInMap("GmtOperate")]
            [Validation(Required=false)]
            public string GmtOperate { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            [NameInMap("OperateTime")]
            [Validation(Required=false)]
            public string OperateTime { get; set; }

            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            [NameInMap("OperationResult")]
            [Validation(Required=false)]
            public bool? OperationResult { get; set; }

            [NameInMap("OperationTarget")]
            [Validation(Required=false)]
            public string OperationTarget { get; set; }

            [NameInMap("OperationValue")]
            [Validation(Required=false)]
            public string OperationValue { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

        }

    }

}
