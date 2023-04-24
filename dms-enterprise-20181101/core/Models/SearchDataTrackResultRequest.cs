// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SearchDataTrackResultRequest : TeaModel {
        [NameInMap("ColumnFilter")]
        [Validation(Required=false)]
        public SearchDataTrackResultRequestColumnFilter ColumnFilter { get; set; }
        public class SearchDataTrackResultRequestColumnFilter : TeaModel {
            [NameInMap("BetweenEnd")]
            [Validation(Required=false)]
            public string BetweenEnd { get; set; }

            [NameInMap("BetweenStart")]
            [Validation(Required=false)]
            public string BetweenStart { get; set; }

            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            [NameInMap("InList")]
            [Validation(Required=false)]
            public List<string> InList { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("FilterEndTime")]
        [Validation(Required=false)]
        public string FilterEndTime { get; set; }

        [NameInMap("FilterStartTime")]
        [Validation(Required=false)]
        public string FilterStartTime { get; set; }

        [NameInMap("FilterTableList")]
        [Validation(Required=false)]
        public List<string> FilterTableList { get; set; }

        [NameInMap("FilterTypeList")]
        [Validation(Required=false)]
        public List<string> FilterTypeList { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
