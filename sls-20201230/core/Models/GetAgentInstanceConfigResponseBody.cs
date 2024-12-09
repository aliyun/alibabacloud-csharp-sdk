// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetAgentInstanceConfigResponseBody : TeaModel {
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        [NameInMap("configMatcher")]
        [Validation(Required=false)]
        public string ConfigMatcher { get; set; }

        [NameInMap("configName")]
        [Validation(Required=false)]
        public string ConfigName { get; set; }

        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("isGray")]
        [Validation(Required=false)]
        public bool? IsGray { get; set; }

        [NameInMap("lastModifyTime")]
        [Validation(Required=false)]
        public long? LastModifyTime { get; set; }

    }

}
