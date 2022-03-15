// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListAppServicesPageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAppServicesPageResponseBodyData> Data { get; set; }
        public class ListAppServicesPageResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public string CurrentPage { get; set; }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListAppServicesPageResponseBodyDataResult> Result { get; set; }
            public class ListAppServicesPageResponseBodyDataResult : TeaModel {
                [NameInMap("EdasAppId")]
                [Validation(Required=false)]
                public string EdasAppId { get; set; }

                [NameInMap("EdasAppName")]
                [Validation(Required=false)]
                public string EdasAppName { get; set; }

                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                [NameInMap("InstanceNum")]
                [Validation(Required=false)]
                public long? InstanceNum { get; set; }

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

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
