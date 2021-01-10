// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class BatchqueryODPOperationAuditResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchqueryODPOperationAuditResponseBodyData Data { get; set; }
        public class BatchqueryODPOperationAuditResponseBodyData : TeaModel {
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<BatchqueryODPOperationAuditResponseBodyDataContent> Content { get; set; }
            public class BatchqueryODPOperationAuditResponseBodyDataContent : TeaModel {
                public string EnvTenant { get; set; }
                public string UserType { get; set; }
                public string ProductInstanceId { get; set; }
                public string UserId { get; set; }
                public string ResultCode { get; set; }
                public string OperationDescription { get; set; }
                public string GmtModified { get; set; }
                public string OperationType { get; set; }
                public string ResultMsg { get; set; }
                public string Params { get; set; }
                public string RequestId { get; set; }
                public string EnvMode { get; set; }
                public string GmtCreate { get; set; }
                public string InvokeType { get; set; }
                public string OpenApiName { get; set; }
                public string UserName { get; set; }
                public string AliyunMasterId { get; set; }
            }
        };

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
