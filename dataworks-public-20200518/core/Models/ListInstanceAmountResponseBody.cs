// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListInstanceAmountResponseBody : TeaModel {
        [NameInMap("InstanceCounts")]
        [Validation(Required=false)]
        public List<ListInstanceAmountResponseBodyInstanceCounts> InstanceCounts { get; set; }
        public class ListInstanceAmountResponseBodyInstanceCounts : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("Date")]
            [Validation(Required=false)]
            public long? Date { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
