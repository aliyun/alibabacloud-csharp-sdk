// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetServiceListPageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServiceListPageResponseBodyData Data { get; set; }
        public class GetServiceListPageResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<GetServiceListPageResponseBodyDataResult> Result { get; set; }
            public class GetServiceListPageResponseBodyDataResult : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("GmtModifyTime")]
                [Validation(Required=false)]
                public string GmtModifyTime { get; set; }

                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                [NameInMap("InstanceNum")]
                [Validation(Required=false)]
                public int? InstanceNum { get; set; }

                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public string TotalSize { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
