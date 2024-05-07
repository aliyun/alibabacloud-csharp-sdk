// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class ListRecordResultsRequest : TeaModel {
        [NameInMap("CreateDateFrom")]
        [Validation(Required=false)]
        public string CreateDateFrom { get; set; }

        [NameInMap("CreateDateTo")]
        [Validation(Required=false)]
        public string CreateDateTo { get; set; }

        [NameInMap("DepartmentId")]
        [Validation(Required=false)]
        public string DepartmentId { get; set; }

        [NameInMap("OuterBusinessId")]
        [Validation(Required=false)]
        public string OuterBusinessId { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public string RecordId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
