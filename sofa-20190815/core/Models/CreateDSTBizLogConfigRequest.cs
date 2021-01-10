// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateDSTBizLogConfigRequest : TeaModel {
        [NameInMap("AdvSetValid")]
        [Validation(Required=false)]
        public bool? AdvSetValid { get; set; }

        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        [NameInMap("CheckCondition")]
        [Validation(Required=false)]
        public string CheckCondition { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("LogBeginRegex")]
        [Validation(Required=false)]
        public string LogBeginRegex { get; set; }

        [NameInMap("LogPath")]
        [Validation(Required=false)]
        public string LogPath { get; set; }

        [NameInMap("LogSample")]
        [Validation(Required=false)]
        public string LogSample { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
