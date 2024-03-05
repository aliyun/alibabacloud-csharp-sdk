// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CustomerService20231228.Models
{
    public class ListYunQiTaskByUidRequest : TeaModel {
        [NameInMap("createTimeEnd")]
        [Validation(Required=false)]
        public long? CreateTimeEnd { get; set; }

        [NameInMap("createTimeStart")]
        [Validation(Required=false)]
        public long? CreateTimeStart { get; set; }

        [NameInMap("freeOrderApplyCodes")]
        [Validation(Required=false)]
        public List<string> FreeOrderApplyCodes { get; set; }

        [NameInMap("freeOrderApplyIds")]
        [Validation(Required=false)]
        public List<long?> FreeOrderApplyIds { get; set; }

        [NameInMap("orderIds")]
        [Validation(Required=false)]
        public List<long?> OrderIds { get; set; }

        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("statusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

    }

}
