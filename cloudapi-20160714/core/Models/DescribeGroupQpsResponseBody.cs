// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeGroupQpsResponseBody : TeaModel {
        [NameInMap("GroupQps")]
        [Validation(Required=false)]
        public DescribeGroupQpsResponseBodyGroupQps GroupQps { get; set; }
        public class DescribeGroupQpsResponseBodyGroupQps : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeGroupQpsResponseBodyGroupQpsMonitorItem> MonitorItem { get; set; }
            public class DescribeGroupQpsResponseBodyGroupQpsMonitorItem : TeaModel {
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                [NameInMap("ItemValue")]
                [Validation(Required=false)]
                public string ItemValue { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}