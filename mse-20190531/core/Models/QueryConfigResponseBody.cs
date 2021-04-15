// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryConfigResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryConfigResponseBodyData Data { get; set; }
        public class QueryConfigResponseBodyData : TeaModel {
            [NameInMap("MaxClientCnxns")]
            [Validation(Required=false)]
            public string MaxClientCnxns { get; set; }
            [NameInMap("ConfigAuthSupported")]
            [Validation(Required=false)]
            public bool? ConfigAuthSupported { get; set; }
            [NameInMap("InitLimit")]
            [Validation(Required=false)]
            public string InitLimit { get; set; }
            [NameInMap("MCPEnabled")]
            [Validation(Required=false)]
            public bool? MCPEnabled { get; set; }
            [NameInMap("OpenSuperAcl")]
            [Validation(Required=false)]
            public bool? OpenSuperAcl { get; set; }
            [NameInMap("RestartFlag")]
            [Validation(Required=false)]
            public bool? RestartFlag { get; set; }
            [NameInMap("JvmFlagsCustom")]
            [Validation(Required=false)]
            public string JvmFlagsCustom { get; set; }
            [NameInMap("AutopurgePurgeInterval")]
            [Validation(Required=false)]
            public string AutopurgePurgeInterval { get; set; }
            [NameInMap("AutopurgeSnapRetainCount")]
            [Validation(Required=false)]
            public string AutopurgeSnapRetainCount { get; set; }
            [NameInMap("SyncLimit")]
            [Validation(Required=false)]
            public string SyncLimit { get; set; }
            [NameInMap("ConfigAuthEnabled")]
            [Validation(Required=false)]
            public bool? ConfigAuthEnabled { get; set; }
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }
            [NameInMap("MCPSupported")]
            [Validation(Required=false)]
            public bool? MCPSupported { get; set; }
            [NameInMap("JuteMaxbuffer")]
            [Validation(Required=false)]
            public string JuteMaxbuffer { get; set; }
            [NameInMap("TickTime")]
            [Validation(Required=false)]
            public string TickTime { get; set; }
            [NameInMap("PassWord")]
            [Validation(Required=false)]
            public string PassWord { get; set; }
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
