// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryConfigResponseBodyData Data { get; set; }
        public class QueryConfigResponseBodyData : TeaModel {
            [NameInMap("AutopurgePurgeInterval")]
            [Validation(Required=false)]
            public string AutopurgePurgeInterval { get; set; }
            [NameInMap("AutopurgeSnapRetainCount")]
            [Validation(Required=false)]
            public string AutopurgeSnapRetainCount { get; set; }
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }
            [NameInMap("ConfigAuthEnabled")]
            [Validation(Required=false)]
            public bool? ConfigAuthEnabled { get; set; }
            [NameInMap("ConfigAuthSupported")]
            [Validation(Required=false)]
            public bool? ConfigAuthSupported { get; set; }
            [NameInMap("ConfigSecretEnabled")]
            [Validation(Required=false)]
            public bool? ConfigSecretEnabled { get; set; }
            [NameInMap("ConfigSecretSupported")]
            [Validation(Required=false)]
            public bool? ConfigSecretSupported { get; set; }
            [NameInMap("InitLimit")]
            [Validation(Required=false)]
            public string InitLimit { get; set; }
            [NameInMap("JuteMaxbuffer")]
            [Validation(Required=false)]
            public string JuteMaxbuffer { get; set; }
            [NameInMap("JvmFlagsCustom")]
            [Validation(Required=false)]
            public string JvmFlagsCustom { get; set; }
            [NameInMap("MCPEnabled")]
            [Validation(Required=false)]
            public bool? MCPEnabled { get; set; }
            [NameInMap("MCPSupported")]
            [Validation(Required=false)]
            public bool? MCPSupported { get; set; }
            [NameInMap("MaxClientCnxns")]
            [Validation(Required=false)]
            public string MaxClientCnxns { get; set; }
            [NameInMap("MaxSessionTimeout")]
            [Validation(Required=false)]
            public string MaxSessionTimeout { get; set; }
            [NameInMap("MinSessionTimeout")]
            [Validation(Required=false)]
            public string MinSessionTimeout { get; set; }
            [NameInMap("NamingCreateServiceSupported")]
            [Validation(Required=false)]
            public bool? NamingCreateServiceSupported { get; set; }
            [NameInMap("OpenSuperAcl")]
            [Validation(Required=false)]
            public bool? OpenSuperAcl { get; set; }
            [NameInMap("PassWord")]
            [Validation(Required=false)]
            public string PassWord { get; set; }
            [NameInMap("RestartFlag")]
            [Validation(Required=false)]
            public bool? RestartFlag { get; set; }
            [NameInMap("SyncLimit")]
            [Validation(Required=false)]
            public string SyncLimit { get; set; }
            [NameInMap("TickTime")]
            [Validation(Required=false)]
            public string TickTime { get; set; }
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
        };

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
