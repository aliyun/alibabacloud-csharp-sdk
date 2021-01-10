// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateDSTBizLogConfigRequest : TeaModel {
        [NameInMap("AdvSetValid")]
        [Validation(Required=false)]
        public bool? AdvSetValid { get; set; }

        [NameInMap("BizLogConfigId")]
        [Validation(Required=false)]
        public long? BizLogConfigId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("LogBeginRegex")]
        [Validation(Required=false)]
        public string LogBeginRegex { get; set; }

        [NameInMap("LogPath")]
        [Validation(Required=false)]
        public string LogPath { get; set; }

    }

}
