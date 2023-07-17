// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210422.Models
{
    public class ListRetcodeAppsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RetcodeApps")]
        [Validation(Required=false)]
        public List<ListRetcodeAppsResponseBodyRetcodeApps> RetcodeApps { get; set; }
        public class ListRetcodeAppsResponseBodyRetcodeApps : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

        }

    }

}
