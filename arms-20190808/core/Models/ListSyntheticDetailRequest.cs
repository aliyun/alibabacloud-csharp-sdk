// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListSyntheticDetailRequest : TeaModel {
        [NameInMap("AdvancedFilters")]
        [Validation(Required=false)]
        public List<ListSyntheticDetailRequestAdvancedFilters> AdvancedFilters { get; set; }
        public class ListSyntheticDetailRequestAdvancedFilters : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("OpType")]
            [Validation(Required=false)]
            public string OpType { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public object Value { get; set; }

        }

        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("ExactFilters")]
        [Validation(Required=false)]
        public List<ListSyntheticDetailRequestExactFilters> ExactFilters { get; set; }
        public class ListSyntheticDetailRequestExactFilters : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("OpType")]
            [Validation(Required=false)]
            public string OpType { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public object Value { get; set; }

        }

        [NameInMap("Filters")]
        [Validation(Required=false)]
        public Dictionary<string, string> Filters { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("SyntheticType")]
        [Validation(Required=false)]
        public int? SyntheticType { get; set; }

    }

}
