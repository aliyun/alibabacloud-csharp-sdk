// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class ListDingtalkOpenPlatformConfigsResponseBody : TeaModel {
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListDingtalkOpenPlatformConfigsResponseBodyConfigs> Configs { get; set; }
        public class ListDingtalkOpenPlatformConfigsResponseBodyConfigs : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public string AppSecret { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
