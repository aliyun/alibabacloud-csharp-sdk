// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateEndpointGroupsResponseBody : TeaModel {
        [NameInMap("EndpointGroupIds")]
        [Validation(Required=false)]
        public List<string> EndpointGroupIds { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
