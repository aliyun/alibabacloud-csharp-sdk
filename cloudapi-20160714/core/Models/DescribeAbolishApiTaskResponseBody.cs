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
                [NameInMap("AbolishStatus")]
                [Validation(Required=false)]
                public string AbolishStatus { get; set; }

                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                [NameInMap("ApiUid")]
                [Validation(Required=false)]
                public string ApiUid { get; set; }

                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("StageId")]
                [Validation(Required=false)]
                public string StageId { get; set; }

                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
