// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yuqing20220301.Models
{
    public class ConsoleBody : TeaModel {
        [NameInMap("appCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        [NameInMap("interfaceName")]
        [Validation(Required=false)]
        public string InterfaceName { get; set; }

        [NameInMap("paramJson")]
        [Validation(Required=false)]
        public string ParamJson { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("teamHashId")]
        [Validation(Required=false)]
        public string TeamHashId { get; set; }

    }

}
