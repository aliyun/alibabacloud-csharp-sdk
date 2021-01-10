// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class BatchqueryLinkeBahamutCloudtenantResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<BatchqueryLinkeBahamutCloudtenantResponseBodyResult> Result { get; set; }
        public class BatchqueryLinkeBahamutCloudtenantResponseBodyResult : TeaModel {
            [NameInMap("LinkETenant")]
            [Validation(Required=false)]
            public string LinkETenant { get; set; }

            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            [NameInMap("StationName")]
            [Validation(Required=false)]
            public string StationName { get; set; }

            [NameInMap("AccessSecret")]
            [Validation(Required=false)]
            public string AccessSecret { get; set; }

            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public long? LastModified { get; set; }

            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("CustomerId")]
            [Validation(Required=false)]
            public string CustomerId { get; set; }

            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            [NameInMap("EndPoint")]
            [Validation(Required=false)]
            public string EndPoint { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
