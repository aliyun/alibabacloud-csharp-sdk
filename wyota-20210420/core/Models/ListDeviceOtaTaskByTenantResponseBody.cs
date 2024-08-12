// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class ListDeviceOtaTaskByTenantResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDeviceOtaTaskByTenantResponseBodyData Data { get; set; }
        public class ListDeviceOtaTaskByTenantResponseBodyData : TeaModel {
            [NameInMap("TenantDeviceOtaTasks")]
            [Validation(Required=false)]
            public List<ListDeviceOtaTaskByTenantResponseBodyDataTenantDeviceOtaTasks> TenantDeviceOtaTasks { get; set; }
            public class ListDeviceOtaTaskByTenantResponseBodyDataTenantDeviceOtaTasks : TeaModel {
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                [NameInMap("OperationStatus")]
                [Validation(Required=false)]
                public int? OperationStatus { get; set; }

                [NameInMap("PublishTime")]
                [Validation(Required=false)]
                public string PublishTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public int? TaskId { get; set; }

                [NameInMap("UpgradeCount")]
                [Validation(Required=false)]
                public long? UpgradeCount { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
