// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SfmMultiModalApp20250909.Models
{
    public class PatchMemoryConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public PatchMemoryConfigResponseBodyData Data { get; set; }
        public class PatchMemoryConfigResponseBodyData : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("AutoUpdate")]
            [Validation(Required=false)]
            public bool? AutoUpdate { get; set; }

            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public int? ExpirationTime { get; set; }

            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public double? Threshold { get; set; }

            [NameInMap("TopK")]
            [Validation(Required=false)]
            public int? TopK { get; set; }

            [NameInMap("UserDefinedId")]
            [Validation(Required=false)]
            public string UserDefinedId { get; set; }

            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
