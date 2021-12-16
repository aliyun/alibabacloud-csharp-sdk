// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateSlrAndSlsProjectResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SlsInfo")]
        [Validation(Required=false)]
        public CreateSlrAndSlsProjectResponseBodySlsInfo SlsInfo { get; set; }
        public class CreateSlrAndSlsProjectResponseBodySlsInfo : TeaModel {
            [NameInMap("EndPoint")]
            [Validation(Required=false)]
            public string EndPoint { get; set; }
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
        };

    }

}
