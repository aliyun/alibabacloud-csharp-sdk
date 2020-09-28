// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class ListTagValueTrendRequest : TeaModel {
        [NameInMap("PidProjectId")]
        [Validation(Required=true)]
        public string PidProjectId { get; set; }

        [NameInMap("PidTag")]
        [Validation(Required=true)]
        public List<ListTagValueTrendRequestPidTag> PidTag { get; set; }
        public class ListTagValueTrendRequestPidTag : TeaModel {
            [NameInMap("PidTagId")]
            [Validation(Required=true)]
            public string PidTagId { get; set; }

        }

    }

}
