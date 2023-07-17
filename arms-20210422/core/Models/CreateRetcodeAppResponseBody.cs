// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210422.Models
{
    public class CreateRetcodeAppResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RetcodeAppDataBean")]
        [Validation(Required=false)]
        public CreateRetcodeAppResponseBodyRetcodeAppDataBean RetcodeAppDataBean { get; set; }
        public class CreateRetcodeAppResponseBodyRetcodeAppDataBean : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

        }

    }

}
