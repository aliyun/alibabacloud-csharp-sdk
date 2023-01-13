// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListOTAUnfinishedTaskByDeviceResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListOTAUnfinishedTaskByDeviceResponseData Data { get; set; }
        public class ListOTAUnfinishedTaskByDeviceResponseData : TeaModel {
            [NameInMap("SimpleOTATaskInfo")]
            [Validation(Required=true)]
            public List<ListOTAUnfinishedTaskByDeviceResponseDataSimpleOTATaskInfo> SimpleOTATaskInfo { get; set; }
            public class ListOTAUnfinishedTaskByDeviceResponseDataSimpleOTATaskInfo : TeaModel {
                [NameInMap("DestVersion")]
                [Validation(Required=true)]
                public string DestVersion { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=true)]
                public string DeviceName { get; set; }

                [NameInMap("FirmwareId")]
                [Validation(Required=true)]
                public string FirmwareId { get; set; }

                [NameInMap("IotId")]
                [Validation(Required=true)]
                public string IotId { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=true)]
                public string JobId { get; set; }

                [NameInMap("ModuleName")]
                [Validation(Required=true)]
                public string ModuleName { get; set; }

                [NameInMap("ProductKey")]
                [Validation(Required=true)]
                public string ProductKey { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=true)]
                public string ProductName { get; set; }

                [NameInMap("SrcVersion")]
                [Validation(Required=true)]
                public string SrcVersion { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=true)]
                public string TaskId { get; set; }

                [NameInMap("TaskStatus")]
                [Validation(Required=true)]
                public string TaskStatus { get; set; }

                [NameInMap("UtcCreate")]
                [Validation(Required=true)]
                public string UtcCreate { get; set; }

                [NameInMap("UtcModified")]
                [Validation(Required=true)]
                public string UtcModified { get; set; }

            }

        }

    }

}
