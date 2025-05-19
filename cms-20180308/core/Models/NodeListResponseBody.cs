// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class NodeListResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public NodeListResponseBodyNodes Nodes { get; set; }
        public class NodeListResponseBodyNodes : TeaModel {
            [NameInMap("Node")]
            [Validation(Required=false)]
            public List<NodeListResponseBodyNodesNode> Node { get; set; }
            public class NodeListResponseBodyNodesNode : TeaModel {
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public long? AliUid { get; set; }

                [NameInMap("AliyunHost")]
                [Validation(Required=false)]
                public bool? AliyunHost { get; set; }

                [NameInMap("EipAddress")]
                [Validation(Required=false)]
                public string EipAddress { get; set; }

                [NameInMap("EipId")]
                [Validation(Required=false)]
                public string EipId { get; set; }

                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                [NameInMap("IpGroup")]
                [Validation(Required=false)]
                public string IpGroup { get; set; }

                [NameInMap("NatIp")]
                [Validation(Required=false)]
                public string NatIp { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("OperatingSystem")]
                [Validation(Required=false)]
                public string OperatingSystem { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                [NameInMap("TianjimonVersion")]
                [Validation(Required=false)]
                public string TianjimonVersion { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageTotal")]
        [Validation(Required=false)]
        public int? PageTotal { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
