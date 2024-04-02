// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class UpdateBizTypeSettingRequest : TeaModel {
        [NameInMap("Ad")]
        [Validation(Required=false)]
        public string Ad { get; set; }

        [NameInMap("Antispam")]
        [Validation(Required=false)]
        public string Antispam { get; set; }

        [NameInMap("BizTypeName")]
        [Validation(Required=false)]
        public string BizTypeName { get; set; }

        [NameInMap("Live")]
        [Validation(Required=false)]
        public string Live { get; set; }

        [NameInMap("Porn")]
        [Validation(Required=false)]
        public string Porn { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("Terrorism")]
        [Validation(Required=false)]
        public string Terrorism { get; set; }

    }

}
