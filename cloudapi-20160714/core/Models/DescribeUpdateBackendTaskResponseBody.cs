// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeUpdateBackendTaskResponseBody : TeaModel {
        /// <summary>
        /// The update result of the API.
        /// </summary>
        [NameInMap("ApiUpdateBackendResults")]
        [Validation(Required=false)]
        public DescribeUpdateBackendTaskResponseBodyApiUpdateBackendResults ApiUpdateBackendResults { get; set; }
        public class DescribeUpdateBackendTaskResponseBodyApiUpdateBackendResults : TeaModel {
            [NameInMap("ApiUpdateBackendResult")]
            [Validation(Required=false)]
            public List<DescribeUpdateBackendTaskResponseBodyApiUpdateBackendResultsApiUpdateBackendResult> ApiUpdateBackendResult { get; set; }
            public class DescribeUpdateBackendTaskResponseBodyApiUpdateBackendResultsApiUpdateBackendResult : TeaModel {
                /// <summary>
                /// The name of the API.
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// The ID of the API.
                /// </summary>
                [NameInMap("ApiUid")]
                [Validation(Required=false)]
                public string ApiUid { get; set; }

                /// <summary>
                /// The ID of the backend service.
                /// </summary>
                [NameInMap("BackendId")]
                [Validation(Required=false)]
                public string BackendId { get; set; }

                /// <summary>
                /// The information about the rows that fail to be updated.
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// The ID of the API group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The name of the API group.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The ID of the runtime environment.
                /// </summary>
                [NameInMap("StageId")]
                [Validation(Required=false)]
                public string StageId { get; set; }

                /// <summary>
                /// The name of the environment.
                /// </summary>
                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

                /// <summary>
                /// The update result of the API.
                /// </summary>
                [NameInMap("UpdateStatus")]
                [Validation(Required=false)]
                public string UpdateStatus { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
