// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetInstanceCountTrendResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("InstanceCounts")]
        [Validation(Required=true)]
        public List<GetInstanceCountTrendResponseInstanceCounts> InstanceCounts { get; set; }
        public class GetInstanceCountTrendResponseInstanceCounts : TeaModel {
            [NameInMap("Date")]
            [Validation(Required=true)]
            public long Date { get; set; }

            [NameInMap("Count")]
            [Validation(Required=true)]
            public int? Count { get; set; }

        }

    }

}
