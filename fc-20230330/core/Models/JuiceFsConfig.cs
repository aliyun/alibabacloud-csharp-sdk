// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class JuiceFsConfig : TeaModel {
        [NameInMap("envs")]
        [Validation(Required=false)]
        public Dictionary<string, string> Envs { get; set; }

        [NameInMap("mountPoints")]
        [Validation(Required=false)]
        public List<JuiceFsMountConfig> MountPoints { get; set; }

    }

}
