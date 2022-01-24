// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeUpdateBackendTaskResponseBody : TeaModel {
        [NameInMap("ApiUpdateBackendResults")]
        [Validation(Required=false)]
        public DescribeUpdateBackendTaskResponseBodyApiUpdateBackendResults ApiUpdateBackendResults { get; set; }
        public class DescribeUpdateBackendTaskResponseBodyApiUpdateBackendResults : TeaModel {
            [NameInMap("ApiUpdateBackendResult")]
            [Validation(Required=false)]
            public List<DescribeUpdateBackendTaskResponseBodyApiUpdateBackendResultsApiUpdateBackendResult> ApiUpdateBackendResult { get; set; }
            public class DescribeUpdateBackendTaskResponseBodyApiUpdateBackendResultsApiUpdateBackendResult : TeaModel {
                public string ApiName { get; set; }
                public string ApiUid { get; set; }
                public string BackendId { get; set; }
                public string ErrorMsg { get; set; }
                public string GroupId { get; set; }
                public string GroupName { get; set; }
                public string StageId { get; set; }
                public string StageName { get; set; }
                public string UpdateStatus { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
