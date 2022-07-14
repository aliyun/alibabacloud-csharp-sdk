// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class CreateFpShotDBResponseBody : TeaModel {
        [NameInMap("FpShotDB")]
        [Validation(Required=false)]
        public CreateFpShotDBResponseBodyFpShotDB FpShotDB { get; set; }
        public class CreateFpShotDBResponseBodyFpShotDB : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("FpDBId")]
            [Validation(Required=false)]
            public string FpDBId { get; set; }
            [NameInMap("ModelId")]
            [Validation(Required=false)]
            public int? ModelId { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
