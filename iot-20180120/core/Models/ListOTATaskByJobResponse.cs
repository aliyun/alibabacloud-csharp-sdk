// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListOTATaskByJobResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=true)]
        public int? PageCount { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=true)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListOTATaskByJobResponseData Data { get; set; }
        public class ListOTATaskByJobResponseData : TeaModel {
            [NameInMap("SimpleOTATaskInfo")]
            [Validation(Required=true)]
            public List<ListOTATaskByJobResponseDataSimpleOTATaskInfo> SimpleOTATaskInfo { get; set; }
            public class ListOTATaskByJobResponseDataSimpleOTATaskInfo : TeaModel {
                public string TaskId { get; set; }
                public string UtcModified { get; set; }
                public string ProductKey { get; set; }
                public string FirmwareId { get; set; }
                public string TaskStatus { get; set; }
                public string JobId { get; set; }
                public string ProductName { get; set; }
                public string DeviceName { get; set; }
                public string SrcVersion { get; set; }
                public string DestVersion { get; set; }
                public string TaskDesc { get; set; }
                public string Progress { get; set; }
                public string IotId { get; set; }
                public string UtcCreate { get; set; }
            }
        };

    }

}
