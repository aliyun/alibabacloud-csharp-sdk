// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAbolishApiTaskResponseBody : TeaModel {
        /// <summary>
        /// The result returned.
        /// </summary>
        [NameInMap("ApiAbolishResults")]
        [Validation(Required=false)]
        public DescribeAbolishApiTaskResponseBodyApiAbolishResults ApiAbolishResults { get; set; }
        public class DescribeAbolishApiTaskResponseBodyApiAbolishResults : TeaModel {
            [NameInMap("ApiAbolishResult")]
            [Validation(Required=false)]
            public List<DescribeAbolishApiTaskResponseBodyApiAbolishResultsApiAbolishResult> ApiAbolishResult { get; set; }
            public class DescribeAbolishApiTaskResponseBodyApiAbolishResultsApiAbolishResult : TeaModel {
                /// <summary>
                /// The ID of the API group.
                /// </summary>
                [NameInMap("AbolishStatus")]
                [Validation(Required=false)]
                public string AbolishStatus { get; set; }

                /// <summary>
                /// auditing
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// The error message.
                /// </summary>
                [NameInMap("ApiUid")]
                [Validation(Required=false)]
                public string ApiUid { get; set; }

                /// <summary>
                /// The name of the runtime environment. Valid values:
                /// 
                /// *   **RELEASE**
                /// *   **TEST**
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// The name of the API group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The ID of the API.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The unpublishing status.
                /// </summary>
                [NameInMap("StageId")]
                [Validation(Required=false)]
                public string StageId { get; set; }

                /// <summary>
                /// The name of the API.
                /// </summary>
                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

            }

        }

        /// <summary>
        /// The result returned.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
