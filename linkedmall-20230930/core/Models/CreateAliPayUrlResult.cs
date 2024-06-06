// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class CreateAliPayUrlResult : TeaModel {
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("memberId")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        [NameInMap("zftWithholdSignUrl")]
        [Validation(Required=false)]
        public string ZftWithholdSignUrl { get; set; }

    }

}
