// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetSwimLaneGroupListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SwimLaneGroupList")]
        [Validation(Required=false)]
        public List<GetSwimLaneGroupListResponseBodySwimLaneGroupList> SwimLaneGroupList { get; set; }
        public class GetSwimLaneGroupListResponseBodySwimLaneGroupList : TeaModel {
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("IngressGatewayName")]
            [Validation(Required=false)]
            public string IngressGatewayName { get; set; }

            [NameInMap("IngressType")]
            [Validation(Required=false)]
            public string IngressType { get; set; }

            [NameInMap("ServiceList")]
            [Validation(Required=false)]
            public string ServiceList { get; set; }

        }

    }

}
