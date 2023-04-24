// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SearchDataTrackResultShrinkRequest : TeaModel {
        [NameInMap("ColumnFilter")]
        [Validation(Required=false)]
        public string ColumnFilterShrink { get; set; }

        [NameInMap("FilterEndTime")]
        [Validation(Required=false)]
        public string FilterEndTime { get; set; }

        [NameInMap("FilterStartTime")]
        [Validation(Required=false)]
        public string FilterStartTime { get; set; }

        [NameInMap("FilterTableList")]
        [Validation(Required=false)]
        public string FilterTableListShrink { get; set; }

        [NameInMap("FilterTypeList")]
        [Validation(Required=false)]
        public string FilterTypeListShrink { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
