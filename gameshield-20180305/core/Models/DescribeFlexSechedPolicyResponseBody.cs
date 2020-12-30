// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeFlexSechedPolicyResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

        [NameInMap("FlexSechedPolicy")]
        [Validation(Required=false)]
        public DescribeFlexSechedPolicyResponseBodyFlexSechedPolicy FlexSechedPolicy { get; set; }
        public class DescribeFlexSechedPolicyResponseBodyFlexSechedPolicy : TeaModel {
            [NameInMap("GreyGroupPolicy")]
            [Validation(Required=false)]
            public int? GreyGroupPolicy { get; set; }
            [NameInMap("GroupInnerPolicy")]
            [Validation(Required=false)]
            public int? GroupInnerPolicy { get; set; }
            [NameInMap("BackupGroupPolicy")]
            [Validation(Required=false)]
            public int? BackupGroupPolicy { get; set; }
        };

    }

}
