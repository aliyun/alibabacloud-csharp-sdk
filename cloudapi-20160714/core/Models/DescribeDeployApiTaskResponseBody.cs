// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeDeployApiTaskResponseBody : TeaModel {
        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("DeployedResults")]
        [Validation(Required=false)]
        public DescribeDeployApiTaskResponseBodyDeployedResults DeployedResults { get; set; }
        public class DescribeDeployApiTaskResponseBodyDeployedResults : TeaModel {
            [NameInMap("DeployedResult")]
            [Validation(Required=false)]
            public List<DescribeDeployApiTaskResponseBodyDeployedResultsDeployedResult> DeployedResult { get; set; }
            public class DescribeDeployApiTaskResponseBodyDeployedResultsDeployedResult : TeaModel {
                /// <summary>
                /// The ID of the API.
                /// </summary>
                [NameInMap("ApiUid")]
                [Validation(Required=false)]
                public string ApiUid { get; set; }

                /// <summary>
                /// The deployment status of the API.
                /// </summary>
                [NameInMap("DeployedStatus")]
                [Validation(Required=false)]
                public string DeployedStatus { get; set; }

                /// <summary>
                /// The error message.
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
                /// The runtime environment of the API. Valid values:
                /// 
                /// *   **RELEASE**
                /// *   **TEST**
                /// </summary>
                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

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
