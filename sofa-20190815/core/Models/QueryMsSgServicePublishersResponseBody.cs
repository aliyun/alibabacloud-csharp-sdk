// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMsSgServicePublishersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("StartIndex")]
        [Validation(Required=false)]
        public long? StartIndex { get; set; }

        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

        [NameInMap("Publishers")]
        [Validation(Required=false)]
        public List<QueryMsSgServicePublishersResponseBodyPublishers> Publishers { get; set; }
        public class QueryMsSgServicePublishersResponseBodyPublishers : TeaModel {
            [NameInMap("Alive")]
            [Validation(Required=false)]
            public bool? Alive { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            [NameInMap("CheckSum")]
            [Validation(Required=false)]
            public string CheckSum { get; set; }

            [NameInMap("ConfigWeight")]
            [Validation(Required=false)]
            public string ConfigWeight { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("HostIp")]
            [Validation(Required=false)]
            public string HostIp { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Mosn")]
            [Validation(Required=false)]
            public bool? Mosn { get; set; }

            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("ServiceIp")]
            [Validation(Required=false)]
            public string ServiceIp { get; set; }

            [NameInMap("ServicePort")]
            [Validation(Required=false)]
            public long? ServicePort { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public long? Timeout { get; set; }

            [NameInMap("VmMode")]
            [Validation(Required=false)]
            public bool? VmMode { get; set; }

            [NameInMap("Weight")]
            [Validation(Required=false)]
            public long? Weight { get; set; }

            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

        }

    }

}
