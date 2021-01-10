// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DescribeDSTTraceTreeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TreeItems")]
        [Validation(Required=false)]
        public List<DescribeDSTTraceTreeResponseBodyTreeItems> TreeItems { get; set; }
        public class DescribeDSTTraceTreeResponseBodyTreeItems : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("BasicInfo")]
            [Validation(Required=false)]
            public string BasicInfo { get; set; }

            [NameInMap("ItemParentId")]
            [Validation(Required=false)]
            public string ItemParentId { get; set; }

            [NameInMap("HasLog")]
            [Validation(Required=false)]
            public bool? HasLog { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            [NameInMap("SpanId")]
            [Validation(Required=false)]
            public string SpanId { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<DescribeDSTTraceTreeResponseBodyTreeItemsDetails> Details { get; set; }
            public class DescribeDSTTraceTreeResponseBodyTreeItemsDetails : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("App")]
            [Validation(Required=false)]
            public string App { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
