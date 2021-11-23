// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAbolishApiTaskResponseBody : TeaModel {
        [NameInMap("ApiAbolishResults")]
        [Validation(Required=false)]
        public DescribeAbolishApiTaskResponseBodyApiAbolishResults ApiAbolishResults { get; set; }
        public class DescribeAbolishApiTaskResponseBodyApiAbolishResults : TeaModel {
            [NameInMap("ApiAbolishResult")]
            [Validation(Required=false)]
            public List<DescribeAbolishApiTaskResponseBodyApiAbolishResultsApiAbolishResult> ApiAbolishResult { get; set; }
            public class DescribeAbolishApiTaskResponseBodyApiAbolishResultsApiAbolishResult : TeaModel {
                public string AbolishStatus { get; set; }
                public string ApiName { get; set; }
                public string ApiUid { get; set; }
                public string ErrorMsg { get; set; }
                public string GroupId { get; set; }
                public string GroupName { get; set; }
                public string StageId { get; set; }
                public string StageName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
