// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Support_plan20210706.Models
{
    public class DeleteEnterpriseDingtalkGroupCustomerMemberRequest : TeaModel {
        [NameInMap("OpenGroupId")]
        [Validation(Required=false)]
        public string OpenGroupId { get; set; }

        [NameInMap("Mobiles")]
        [Validation(Required=false)]
        public List<string> Mobiles { get; set; }

    }

}
