// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class BackFillShrinkRequest : TeaModel {
        [NameInMap("Asc")]
        [Validation(Required=false)]
        public bool? Asc { get; set; }

        [NameInMap("BackFillDate")]
        [Validation(Required=false)]
        public string BackFillDate { get; set; }

        [NameInMap("BackFillDateBegin")]
        [Validation(Required=false)]
        public string BackFillDateBegin { get; set; }

        [NameInMap("BackFillDateEnd")]
        [Validation(Required=false)]
        public string BackFillDateEnd { get; set; }

        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        [NameInMap("HistoryDagId")]
        [Validation(Required=false)]
        public long? HistoryDagId { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        [NameInMap("IsTriggerSubTree")]
        [Validation(Required=false)]
        public bool? IsTriggerSubTree { get; set; }

        [NameInMap("StartNodeIds")]
        [Validation(Required=false)]
        public string StartNodeIdsShrink { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
