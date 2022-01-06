// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListOTAUnfinishedTaskByDeviceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListOTAUnfinishedTaskByDeviceResponseBodyData Data { get; set; }
        public class ListOTAUnfinishedTaskByDeviceResponseBodyData : TeaModel {
            [NameInMap("SimpleOTATaskInfo")]
            [Validation(Required=false)]
            public List<ListOTAUnfinishedTaskByDeviceResponseBodyDataSimpleOTATaskInfo> SimpleOTATaskInfo { get; set; }
            public class ListOTAUnfinishedTaskByDeviceResponseBodyDataSimpleOTATaskInfo : TeaModel {
                public string DestVersion { get; set; }
                public string DeviceName { get; set; }
                public string FirmwareId { get; set; }
                public string IotId { get; set; }
                public string JobId { get; set; }
                public string ModuleName { get; set; }
                public string ProductKey { get; set; }
                public string ProductName { get; set; }
                public string SrcVersion { get; set; }
                public string TaskId { get; set; }
                public string TaskStatus { get; set; }
                public string UtcCreate { get; set; }
                public string UtcModified { get; set; }
            }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
