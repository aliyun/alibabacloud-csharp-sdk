// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSelectItemResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeSelectItemResponseBodyResultObject ResultObject { get; set; }
        public class DescribeSelectItemResponseBodyResultObject : TeaModel {
            [NameInMap("monitorStatusList")]
            [Validation(Required=false)]
            public List<string> MonitorStatusList { get; set; }

            [NameInMap("taskIdList")]
            [Validation(Required=false)]
            public List<string> TaskIdList { get; set; }

        }

    }

}
