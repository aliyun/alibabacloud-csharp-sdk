// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class ListEndpointsResponseBody : TeaModel {
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<ListEndpointsResponseBodyEndpoints> Endpoints { get; set; }
        public class ListEndpointsResponseBodyEndpoints : TeaModel {
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// 所属加速实例的ID。
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public EndpointStatus Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
