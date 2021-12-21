// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class DescribeFlowProjectClusterSettingResponseBody : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("DefaultQueue")]
        [Validation(Required=false)]
        public string DefaultQueue { get; set; }

        [NameInMap("DefaultUser")]
        [Validation(Required=false)]
        public string DefaultUser { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        [NameInMap("HostList")]
        [Validation(Required=false)]
        public DescribeFlowProjectClusterSettingResponseBodyHostList HostList { get; set; }
        public class DescribeFlowProjectClusterSettingResponseBodyHostList : TeaModel {
            [NameInMap("Host")]
            [Validation(Required=false)]
            public List<string> Host { get; set; }
        };

        [NameInMap("K8sClusterId")]
        [Validation(Required=false)]
        public string K8sClusterId { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("QueueList")]
        [Validation(Required=false)]
        public DescribeFlowProjectClusterSettingResponseBodyQueueList QueueList { get; set; }
        public class DescribeFlowProjectClusterSettingResponseBodyQueueList : TeaModel {
            [NameInMap("Queue")]
            [Validation(Required=false)]
            public List<string> Queue { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserList")]
        [Validation(Required=false)]
        public DescribeFlowProjectClusterSettingResponseBodyUserList UserList { get; set; }
        public class DescribeFlowProjectClusterSettingResponseBodyUserList : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<string> User { get; set; }
        };

    }

}
