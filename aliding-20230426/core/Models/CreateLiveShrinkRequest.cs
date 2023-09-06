// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateLiveShrinkRequest : TeaModel {
        [NameInMap("CoverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        [NameInMap("Introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        [NameInMap("PreEndTime")]
        [Validation(Required=false)]
        public long? PreEndTime { get; set; }

        [NameInMap("PreStartTime")]
        [Validation(Required=false)]
        public long? PreStartTime { get; set; }

        [NameInMap("PublicType")]
        [Validation(Required=false)]
        public long? PublicType { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
