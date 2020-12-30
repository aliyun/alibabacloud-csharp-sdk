// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagDropTopNResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DropTopN")]
        [Validation(Required=false)]
        public List<DescribeSagDropTopNResponseBodyDropTopN> DropTopN { get; set; }
        public class DescribeSagDropTopNResponseBodyDropTopN : TeaModel {
            [NameInMap("DropRate")]
            [Validation(Required=false)]
            public string DropRate { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

    }

}
