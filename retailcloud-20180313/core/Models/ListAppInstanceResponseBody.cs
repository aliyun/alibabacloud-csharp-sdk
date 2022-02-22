// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class ListAppInstanceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAppInstanceResponseBodyData> Data { get; set; }
        public class ListAppInstanceResponseBodyData : TeaModel {
            [NameInMap("AppInstanceId")]
            [Validation(Required=false)]
            public string AppInstanceId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Health")]
            [Validation(Required=false)]
            public string Health { get; set; }

            [NameInMap("HostIp")]
            [Validation(Required=false)]
            public string HostIp { get; set; }

            [NameInMap("Limits")]
            [Validation(Required=false)]
            public string Limits { get; set; }

            [NameInMap("PodIp")]
            [Validation(Required=false)]
            public string PodIp { get; set; }

            [NameInMap("Requests")]
            [Validation(Required=false)]
            public string Requests { get; set; }

            [NameInMap("RestartCount")]
            [Validation(Required=false)]
            public int? RestartCount { get; set; }

            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("ErrMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

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
