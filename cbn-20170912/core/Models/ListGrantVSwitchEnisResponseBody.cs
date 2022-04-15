// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListGrantVSwitchEnisResponseBody : TeaModel {
        [NameInMap("GrantVSwitchEnis")]
        [Validation(Required=false)]
        public List<ListGrantVSwitchEnisResponseBodyGrantVSwitchEnis> GrantVSwitchEnis { get; set; }
        public class ListGrantVSwitchEnisResponseBodyGrantVSwitchEnis : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            [NameInMap("TransitRouterFlag")]
            [Validation(Required=false)]
            public bool? TransitRouterFlag { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
