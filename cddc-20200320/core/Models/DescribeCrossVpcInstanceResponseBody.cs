// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeCrossVpcInstanceResponseBody : TeaModel {
        [NameInMap("HasDelInProcessTask")]
        [Validation(Required=false)]
        public bool? HasDelInProcessTask { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HasCreateInProcessTask")]
        [Validation(Required=false)]
        public bool? HasCreateInProcessTask { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeCrossVpcInstanceResponseBodyItems> Items { get; set; }
        public class DescribeCrossVpcInstanceResponseBodyItems : TeaModel {
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

        }

    }

}
