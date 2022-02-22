// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class ListClusterResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListClusterResponseBodyData> Data { get; set; }
        public class ListClusterResponseBodyData : TeaModel {
            [NameInMap("BusinessCode")]
            [Validation(Required=false)]
            public string BusinessCode { get; set; }

            [NameInMap("ClusterTitle")]
            [Validation(Required=false)]
            public string ClusterTitle { get; set; }

            [NameInMap("CreateStatus")]
            [Validation(Required=false)]
            public string CreateStatus { get; set; }

            [NameInMap("EcsIds")]
            [Validation(Required=false)]
            public List<string> EcsIds { get; set; }

            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("KeyPair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            [NameInMap("NetPlug")]
            [Validation(Required=false)]
            public string NetPlug { get; set; }

            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("PodCIDR")]
            [Validation(Required=false)]
            public string PodCIDR { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            [NameInMap("ServiceCIDR")]
            [Validation(Required=false)]
            public string ServiceCIDR { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("VswitchIds")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

            [NameInMap("WorkLoadCpu")]
            [Validation(Required=false)]
            public string WorkLoadCpu { get; set; }

            [NameInMap("WorkLoadMem")]
            [Validation(Required=false)]
            public string WorkLoadMem { get; set; }

        }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
