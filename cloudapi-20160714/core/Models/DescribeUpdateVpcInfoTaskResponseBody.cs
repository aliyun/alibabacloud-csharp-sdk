// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeUpdateVpcInfoTaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ApiUpdateVpcInfoResults")]
        [Validation(Required=false)]
        public DescribeUpdateVpcInfoTaskResponseBodyApiUpdateVpcInfoResults ApiUpdateVpcInfoResults { get; set; }
        public class DescribeUpdateVpcInfoTaskResponseBodyApiUpdateVpcInfoResults : TeaModel {
            [NameInMap("ApiUpdateVpcInfoResult")]
            [Validation(Required=false)]
            public List<DescribeUpdateVpcInfoTaskResponseBodyApiUpdateVpcInfoResultsApiUpdateVpcInfoResult> ApiUpdateVpcInfoResult { get; set; }
            public class DescribeUpdateVpcInfoTaskResponseBodyApiUpdateVpcInfoResultsApiUpdateVpcInfoResult : TeaModel {
                public string StageId { get; set; }
                public string UpdateStatus { get; set; }
                public string GroupId { get; set; }
                public string GroupName { get; set; }
                public string ApiUid { get; set; }
                public string ErrorMsg { get; set; }
                public string StageName { get; set; }
                public string ApiName { get; set; }
            }
        };

    }

}
