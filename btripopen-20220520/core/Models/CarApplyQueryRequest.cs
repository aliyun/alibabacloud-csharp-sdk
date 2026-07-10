// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CarApplyQueryRequest : TeaModel {
        [NameInMap("created_end_at")]
        [Validation(Required=false)]
        public string CreatedEndAt { get; set; }

        [NameInMap("created_start_at")]
        [Validation(Required=false)]
        public string CreatedStartAt { get; set; }

        [NameInMap("page_number")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("third_part_apply_id")]
        [Validation(Required=false)]
        public string ThirdPartApplyId { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
