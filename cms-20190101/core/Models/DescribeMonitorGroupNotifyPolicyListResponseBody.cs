// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorGroupNotifyPolicyListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("NotifyPolicyList")]
        [Validation(Required=false)]
        public DescribeMonitorGroupNotifyPolicyListResponseBodyNotifyPolicyList NotifyPolicyList { get; set; }
        public class DescribeMonitorGroupNotifyPolicyListResponseBodyNotifyPolicyList : TeaModel {
            [NameInMap("NotifyPolicy")]
            [Validation(Required=false)]
            public List<DescribeMonitorGroupNotifyPolicyListResponseBodyNotifyPolicyListNotifyPolicy> NotifyPolicy { get; set; }
            public class DescribeMonitorGroupNotifyPolicyListResponseBodyNotifyPolicyListNotifyPolicy : TeaModel {
                public long? EndTime { get; set; }
                public string Type { get; set; }
                public long? StartTime { get; set; }
                public string GroupId { get; set; }
                public string Id { get; set; }
            }
        };

    }

}
