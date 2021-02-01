// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class RecognizeLogoRequest : TeaModel {
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<RecognizeLogoRequestTasks> Tasks { get; set; }
        public class RecognizeLogoRequestTasks : TeaModel {
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

        }

    }

}
