// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkefabricFabricMsgconfigsystemcloudconfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryLinkefabricFabricMsgconfigsystemcloudconfigResponseBodyData> Data { get; set; }
        public class QueryLinkefabricFabricMsgconfigsystemcloudconfigResponseBodyData : TeaModel {
            [NameInMap("CommonConfig")]
            [Validation(Required=false)]
            public string CommonConfig { get; set; }

            [NameInMap("DevStage")]
            [Validation(Required=false)]
            public string DevStage { get; set; }

            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            [NameInMap("EnvDisplayName")]
            [Validation(Required=false)]
            public string EnvDisplayName { get; set; }

            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public long? EnvId { get; set; }

            [NameInMap("Orders")]
            [Validation(Required=false)]
            public long? Orders { get; set; }

            [NameInMap("SysConfigType")]
            [Validation(Required=false)]
            public string SysConfigType { get; set; }

            [NameInMap("TenangId")]
            [Validation(Required=false)]
            public long? TenangId { get; set; }

            [NameInMap("UniqueConfig")]
            [Validation(Required=false)]
            public string UniqueConfig { get; set; }

        }

    }

}
