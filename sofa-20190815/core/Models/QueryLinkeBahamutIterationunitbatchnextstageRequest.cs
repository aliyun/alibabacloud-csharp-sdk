// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutIterationunitbatchnextstageRequest : TeaModel {
        [NameInMap("FromStageIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> FromStageIdsRepeatList { get; set; }

        [NameInMap("IterationUnitIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> IterationUnitIdsRepeatList { get; set; }

        [NameInMap("ToStageIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> ToStageIdsRepeatList { get; set; }

        [NameInMap("UserAccount")]
        [Validation(Required=false)]
        public string UserAccount { get; set; }

    }

}
