// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class RecognizeLogoAdvanceRequest : TeaModel {
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<RecognizeLogoAdvanceRequestTasks> Tasks { get; set; }
        public class RecognizeLogoAdvanceRequestTasks : TeaModel {
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public Stream ImageURLObject { get; set; }

        }

    }

}
