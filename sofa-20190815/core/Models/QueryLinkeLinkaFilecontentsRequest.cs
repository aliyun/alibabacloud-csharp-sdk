// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeLinkaFilecontentsRequest : TeaModel {
        [NameInMap("FilenamesRepeatList")]
        [Validation(Required=false)]
        public List<string> FilenamesRepeatList { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
