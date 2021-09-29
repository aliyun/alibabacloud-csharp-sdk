// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListVehicleResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Vehicles")]
        [Validation(Required=false)]
        public ListVehicleResponseBodyVehicles Vehicles { get; set; }
        public class ListVehicleResponseBodyVehicles : TeaModel {
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public ListVehicleResponseBodyVehiclesPagination Pagination { get; set; }
            public class ListVehicleResponseBodyVehiclesPagination : TeaModel {
                [NameInMap("PageIndex")]
                [Validation(Required=false)]
                public int? PageIndex { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListVehicleResponseBodyVehiclesList> List { get; set; }
            public class ListVehicleResponseBodyVehiclesList : TeaModel {
                public string ConnectionStatus { get; set; }
                public long? CreateTime { get; set; }
                public string DeviceId { get; set; }
                public string Vin { get; set; }
            }
        };

    }

}
