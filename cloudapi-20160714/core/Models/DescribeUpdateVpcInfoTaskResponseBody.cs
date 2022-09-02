// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeUpdateVpcInfoTaskResponseBody : TeaModel {
        [NameInMap("ApiUpdateVpcInfoResults")]
        [Validation(Required=false)]
        public DescribeUpdateVpcInfoTaskResponseBodyApiUpdateVpcInfoResults ApiUpdateVpcInfoResults { get; set; }
        public class DescribeUpdateVpcInfoTaskResponseBodyApiUpdateVpcInfoResults : TeaModel {
            [NameInMap("ApiUpdateVpcInfoResult")]
            [Validation(Required=false)]
            public List<DescribeUpdateVpcInfoTaskResponseBodyApiUpdateVpcInfoResultsApiUpdateVpcInfoResult> ApiUpdateVpcInfoResult { get; set; }
            public class DescribeUpdateVpcInfoTaskResponseBodyApiUpdateVpcInfoResultsApiUpdateVpcInfoResult : TeaModel {
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

                [NameInMap("UpdateStatus")]
                [Validation(Required=false)]
                public string UpdateStatus { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
