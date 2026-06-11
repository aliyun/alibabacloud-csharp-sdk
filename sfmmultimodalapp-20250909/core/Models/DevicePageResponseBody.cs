// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SfmMultiModalApp20250909.Models
{
    public class DevicePageResponseBody : TeaModel {
        [NameInMap("DeviceList")]
        [Validation(Required=false)]
        public List<DevicePageResponseBodyDeviceList> DeviceList { get; set; }
        public class DevicePageResponseBodyDeviceList : TeaModel {
            [NameInMap("ActiveTime")]
            [Validation(Required=false)]
            public string ActiveTime { get; set; }

            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public string AliyunUid { get; set; }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("DailyCount")]
            [Validation(Required=false)]
            public int? DailyCount { get; set; }

            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public int? OrderType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("SubAliyunUid")]
            [Validation(Required=false)]
            public string SubAliyunUid { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            [NameInMap("UserActiveTime")]
            [Validation(Required=false)]
            public string UserActiveTime { get; set; }

            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

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
        public int? TotalCount { get; set; }

    }

}
