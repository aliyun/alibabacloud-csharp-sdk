// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeDeployApiTaskResponseBody : TeaModel {
        [NameInMap("DeployedResults")]
        [Validation(Required=false)]
        public DescribeDeployApiTaskResponseBodyDeployedResults DeployedResults { get; set; }
        public class DescribeDeployApiTaskResponseBodyDeployedResults : TeaModel {
            [NameInMap("DeployedResult")]
            [Validation(Required=false)]
            public List<DescribeDeployApiTaskResponseBodyDeployedResultsDeployedResult> DeployedResult { get; set; }
            public class DescribeDeployApiTaskResponseBodyDeployedResultsDeployedResult : TeaModel {
                [NameInMap("ApiUid")]
                [Validation(Required=false)]
                public string ApiUid { get; set; }

                [NameInMap("DeployedStatus")]
                [Validation(Required=false)]
                public string DeployedStatus { get; set; }

                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

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
