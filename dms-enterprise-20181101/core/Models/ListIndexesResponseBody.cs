// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListIndexesResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("IndexList")]
        [Validation(Required=false)]
        public ListIndexesResponseBodyIndexList IndexList { get; set; }
        public class ListIndexesResponseBodyIndexList : TeaModel {
            [NameInMap("Index")]
            [Validation(Required=false)]
            public List<ListIndexesResponseBodyIndexListIndex> Index { get; set; }
            public class ListIndexesResponseBodyIndexListIndex : TeaModel {
                public string IndexComment { get; set; }
                public string IndexId { get; set; }
                public string IndexName { get; set; }
                public string IndexType { get; set; }
                public string TableId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
