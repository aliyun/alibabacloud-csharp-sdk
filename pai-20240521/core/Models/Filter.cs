// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai20240521.Models
{
    public class Filter : TeaModel {
        [NameInMap("FilterBy")]
        [Validation(Required=false)]
        public string FilterBy { get; set; }

        [NameInMap("FilterCondition")]
        [Validation(Required=false)]
        public string FilterCondition { get; set; }

        [NameInMap("FilterOperation")]
        [Validation(Required=false)]
        public string FilterOperation { get; set; }

    }

}
