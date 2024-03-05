// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CustomerService20231228.Models
{
    public class ListServiceApplyRequest : TeaModel {
        [NameInMap("applyType")]
        [Validation(Required=false)]
        public List<string> ApplyType { get; set; }

        [NameInMap("endDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("productCode")]
        [Validation(Required=false)]
        public int? ProductCode { get; set; }

        [NameInMap("startDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
