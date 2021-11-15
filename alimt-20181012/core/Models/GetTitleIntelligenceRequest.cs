// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class GetTitleIntelligenceRequest : TeaModel {
        [NameInMap("CatLevelThreeId")]
        [Validation(Required=false)]
        public long? CatLevelThreeId { get; set; }

        [NameInMap("CatLevelTwoId")]
        [Validation(Required=false)]
        public long? CatLevelTwoId { get; set; }

        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public string Keywords { get; set; }

        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

    }

}
