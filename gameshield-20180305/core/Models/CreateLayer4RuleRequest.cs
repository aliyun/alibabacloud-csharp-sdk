// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class CreateLayer4RuleRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public long? BizId { get; set; }

        [NameInMap("FrontPort")]
        [Validation(Required=false)]
        public int? FrontPort { get; set; }

        [NameInMap("BackPort")]
        [Validation(Required=false)]
        public int? BackPort { get; set; }

        [NameInMap("Rservers")]
        [Validation(Required=false)]
        public string Rservers { get; set; }

    }

}
