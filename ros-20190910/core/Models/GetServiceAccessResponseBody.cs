// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetServiceAccessResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceAccessInfo")]
        [Validation(Required=false)]
        public GetServiceAccessResponseBodyServiceAccessInfo ServiceAccessInfo { get; set; }
        public class GetServiceAccessResponseBodyServiceAccessInfo : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
