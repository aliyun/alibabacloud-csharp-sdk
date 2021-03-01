// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetServiceListPageResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServiceListPageResponseBodyData Data { get; set; }
        public class GetServiceListPageResponseBodyData : TeaModel {
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }
            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public int? TotalElements { get; set; }
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<GetServiceListPageResponseBodyDataContent> Content { get; set; }
            public class GetServiceListPageResponseBodyDataContent : TeaModel {
                public string EdasAppName { get; set; }
                public int? InstanceNum { get; set; }
                public string Version { get; set; }
                public string ServiceId { get; set; }
                public string EdasAppId { get; set; }
                public string ServiceName { get; set; }
                public string RegisterType { get; set; }
                public string Group { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
