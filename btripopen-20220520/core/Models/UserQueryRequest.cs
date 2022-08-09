// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class UserQueryRequest : TeaModel {
        [NameInMap("modified_time_greater_or_equal_than")]
        [Validation(Required=false)]
        public string ModifiedTimeGreaterOrEqualThan { get; set; }

        [NameInMap("third_part_corp_id")]
        [Validation(Required=false)]
        public string ThirdPartCorpId { get; set; }

        [NameInMap("third_part_job_no")]
        [Validation(Required=false)]
        public string ThirdPartJobNo { get; set; }

    }

}
