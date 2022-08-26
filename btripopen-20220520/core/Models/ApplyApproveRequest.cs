// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyApproveRequest : TeaModel {
        [NameInMap("apply_id")]
        [Validation(Required=false)]
        public string ApplyId { get; set; }

        [NameInMap("note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        [NameInMap("operate_time")]
        [Validation(Required=false)]
        public string OperateTime { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
