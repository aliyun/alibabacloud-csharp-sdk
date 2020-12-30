// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagStaticRouteListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StaticRoutes")]
        [Validation(Required=false)]
        public List<DescribeSagStaticRouteListResponseBodyStaticRoutes> StaticRoutes { get; set; }
        public class DescribeSagStaticRouteListResponseBodyStaticRoutes : TeaModel {
            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

            [NameInMap("DestinationCidr")]
            [Validation(Required=false)]
            public string DestinationCidr { get; set; }

            [NameInMap("PortName")]
            [Validation(Required=false)]
            public string PortName { get; set; }

            [NameInMap("Vlan")]
            [Validation(Required=false)]
            public string Vlan { get; set; }

        }

        [NameInMap("TaskStates")]
        [Validation(Required=false)]
        public List<DescribeSagStaticRouteListResponseBodyTaskStates> TaskStates { get; set; }
        public class DescribeSagStaticRouteListResponseBodyTaskStates : TeaModel {
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

        }

    }

}
