// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeOutlineBindingResponseBody : TeaModel {
        [NameInMap("OutlineBinding")]
        [Validation(Required=false)]
        public DescribeOutlineBindingResponseBodyOutlineBinding OutlineBinding { get; set; }
        public class DescribeOutlineBindingResponseBodyOutlineBinding : TeaModel {
            [NameInMap("BindIndex")]
            [Validation(Required=false)]
            public string BindIndex { get; set; }

            [NameInMap("BindPlan")]
            [Validation(Required=false)]
            public string BindPlan { get; set; }

            [NameInMap("MaxConcurrent")]
            [Validation(Required=false)]
            public int? MaxConcurrent { get; set; }

            [NameInMap("OutlineId")]
            [Validation(Required=false)]
            public long? OutlineId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
