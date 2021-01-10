// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class ListDetectionsRequest : TeaModel {
        [NameInMap("CreateDateFrom")]
        [Validation(Required=false)]
        public string CreateDateFrom { get; set; }

        [NameInMap("CreateDateTo")]
        [Validation(Required=false)]
        public string CreateDateTo { get; set; }

        [NameInMap("DepartmentId")]
        [Validation(Required=false)]
        public string DepartmentId { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RecordingType")]
        [Validation(Required=false)]
        public string RecordingType { get; set; }

        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

    }

}
