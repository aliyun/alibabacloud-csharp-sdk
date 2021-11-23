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
                public string ApiUid { get; set; }
                public string DeployedStatus { get; set; }
                public string ErrorMsg { get; set; }
                public string GroupId { get; set; }
                public string StageName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
