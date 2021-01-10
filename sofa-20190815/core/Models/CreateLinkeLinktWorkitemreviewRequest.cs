// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkeLinktWorkitemreviewRequest : TeaModel {
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        [NameInMap("Theme")]
        [Validation(Required=false)]
        public string Theme { get; set; }

        [NameInMap("WorkItemSign")]
        [Validation(Required=false)]
        public string WorkItemSign { get; set; }

        [NameInMap("ReviewersRepeatList")]
        [Validation(Required=false)]
        public List<string> ReviewersRepeatList { get; set; }

    }

}
