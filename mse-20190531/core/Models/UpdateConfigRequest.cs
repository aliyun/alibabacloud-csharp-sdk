// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateConfigRequest : TeaModel {
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        [NameInMap("TickTime")]
        [Validation(Required=false)]
        public string TickTime { get; set; }

        [NameInMap("InitLimit")]
        [Validation(Required=false)]
        public string InitLimit { get; set; }

        [NameInMap("SyncLimit")]
        [Validation(Required=false)]
        public string SyncLimit { get; set; }

        [NameInMap("MaxClientCnxns")]
        [Validation(Required=false)]
        public string MaxClientCnxns { get; set; }

        [NameInMap("OpenSuperAcl")]
        [Validation(Required=false)]
        public string OpenSuperAcl { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("PassWord")]
        [Validation(Required=false)]
        public string PassWord { get; set; }

        [NameInMap("JuteMaxbuffer")]
        [Validation(Required=false)]
        public string JuteMaxbuffer { get; set; }

        [NameInMap("AutopurgePurgeInterval")]
        [Validation(Required=false)]
        public string AutopurgePurgeInterval { get; set; }

        [NameInMap("AutopurgeSnapRetainCount")]
        [Validation(Required=false)]
        public string AutopurgeSnapRetainCount { get; set; }

        [NameInMap("ConfigAuthEnabled")]
        [Validation(Required=false)]
        public bool? ConfigAuthEnabled { get; set; }

        [NameInMap("MCPEnabled")]
        [Validation(Required=false)]
        public bool? MCPEnabled { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
