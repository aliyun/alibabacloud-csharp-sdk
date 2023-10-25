// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class ListServicesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The applications.
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public ListServicesResponseBodyServices Services { get; set; }
        public class ListServicesResponseBodyServices : TeaModel {
            [NameInMap("Service")]
            [Validation(Required=false)]
            public List<ListServicesResponseBodyServicesService> Service { get; set; }
            public class ListServicesResponseBodyServicesService : TeaModel {
                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("Pid")]
                [Validation(Required=false)]
                public string Pid { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The name of the application.
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

        }

    }

}
