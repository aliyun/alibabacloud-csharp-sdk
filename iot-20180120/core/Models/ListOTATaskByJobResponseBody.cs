// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListOTATaskByJobResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListOTATaskByJobResponseBodyData Data { get; set; }
        public class ListOTATaskByJobResponseBodyData : TeaModel {
            [NameInMap("SimpleOTATaskInfo")]
            [Validation(Required=false)]
            public List<ListOTATaskByJobResponseBodyDataSimpleOTATaskInfo> SimpleOTATaskInfo { get; set; }
            public class ListOTATaskByJobResponseBodyDataSimpleOTATaskInfo : TeaModel {
                public string DestVersion { get; set; }
                public string DeviceName { get; set; }
                public string FirmwareId { get; set; }
                public string IotId { get; set; }
                public string JobId { get; set; }
                public string ProductKey { get; set; }
                public string ProductName { get; set; }
                public string Progress { get; set; }
                public string SrcVersion { get; set; }
                public string TaskDesc { get; set; }
                public string TaskId { get; set; }
                public string TaskStatus { get; set; }
                public string Timeout { get; set; }
                public string UtcCreate { get; set; }
                public string UtcModified { get; set; }
            }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
