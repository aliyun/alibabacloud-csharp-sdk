// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class UpdateBizTypeTextLibRequest : TeaModel {
        [NameInMap("BizTypeName")]
        [Validation(Required=false)]
        public string BizTypeName { get; set; }

        [NameInMap("Black")]
        [Validation(Required=false)]
        public string Black { get; set; }

        [NameInMap("Ignore")]
        [Validation(Required=false)]
        public string Ignore { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("Review")]
        [Validation(Required=false)]
        public string Review { get; set; }

        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        [NameInMap("White")]
        [Validation(Required=false)]
        public string White { get; set; }

    }

}
