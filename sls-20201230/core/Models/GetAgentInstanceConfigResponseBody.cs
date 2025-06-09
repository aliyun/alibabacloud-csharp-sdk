// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetAgentInstanceConfigResponseBody : TeaModel {
        [NameInMap("attributes")]
        [Validation(Required=false)]
        public string Attributes { get; set; }

        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        [NameInMap("configType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("grayConfigs")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> GrayConfigs { get; set; }

        [NameInMap("lastModifyTime")]
        [Validation(Required=false)]
        public long? LastModifyTime { get; set; }

    }

}
