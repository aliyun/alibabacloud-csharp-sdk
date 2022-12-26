// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLoginSwitchConfigsResponseBody : TeaModel {
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public List<DescribeLoginSwitchConfigsResponseBodyConfigList> ConfigList { get; set; }
        public class DescribeLoginSwitchConfigsResponseBodyConfigList : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public string Item { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
