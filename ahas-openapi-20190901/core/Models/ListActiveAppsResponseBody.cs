// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class ListActiveAppsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListActiveAppsResponseBodyData> Data { get; set; }
        public class ListActiveAppsResponseBodyData : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("LastHealthPingTime")]
            [Validation(Required=false)]
            public long? LastHealthPingTime { get; set; }

            [NameInMap("CurrentLevel")]
            [Validation(Required=false)]
            public int? CurrentLevel { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("AppType")]
            [Validation(Required=false)]
            public int? AppType { get; set; }

            [NameInMap("DirtyLevel")]
            [Validation(Required=false)]
            public int? DirtyLevel { get; set; }

            [NameInMap("AhasAppName")]
            [Validation(Required=false)]
            public string AhasAppName { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
