// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListOTATaskByJobResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=true)]
        public int? CurrentPage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=true)]
        public int? PageCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListOTATaskByJobResponseData Data { get; set; }
        public class ListOTATaskByJobResponseData : TeaModel {
            [NameInMap("SimpleOTATaskInfo")]
            [Validation(Required=true)]
            public List<ListOTATaskByJobResponseDataSimpleOTATaskInfo> SimpleOTATaskInfo { get; set; }
            public class ListOTATaskByJobResponseDataSimpleOTATaskInfo : TeaModel {
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

                [NameInMap("ProductKey")]
                [Validation(Required=true)]
                public string ProductKey { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=true)]
                public string ProductName { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=true)]
                public string Progress { get; set; }

                [NameInMap("SrcVersion")]
                [Validation(Required=true)]
                public string SrcVersion { get; set; }

                [NameInMap("TaskDesc")]
                [Validation(Required=true)]
                public string TaskDesc { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=true)]
                public string TaskId { get; set; }

                [NameInMap("TaskStatus")]
                [Validation(Required=true)]
                public string TaskStatus { get; set; }

                [NameInMap("Timeout")]
                [Validation(Required=true)]
                public string Timeout { get; set; }

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
