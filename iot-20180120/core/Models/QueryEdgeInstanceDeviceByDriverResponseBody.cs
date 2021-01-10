// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeInstanceDeviceByDriverResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryEdgeInstanceDeviceByDriverResponseBodyData Data { get; set; }
        public class QueryEdgeInstanceDeviceByDriverResponseBodyData : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("DeviceList")]
            [Validation(Required=false)]
            public List<QueryEdgeInstanceDeviceByDriverResponseBodyDataDeviceList> DeviceList { get; set; }
            public class QueryEdgeInstanceDeviceByDriverResponseBodyDataDeviceList : TeaModel {
                public string IotId { get; set; }
            }
        };

    }

}
