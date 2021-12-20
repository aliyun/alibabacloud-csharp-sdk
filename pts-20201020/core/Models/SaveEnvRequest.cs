// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class SaveEnvRequest : TeaModel {
        /// <summary>
        /// 环境
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public SaveEnvRequestEnv Env { get; set; }
        public class SaveEnvRequestEnv : TeaModel {
            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }
            [NameInMap("EnvName")]
            [Validation(Required=false)]
            public string EnvName { get; set; }
            [NameInMap("Files")]
            [Validation(Required=false)]
            public List<SaveEnvRequestEnvFiles> Files { get; set; }
            public class SaveEnvRequestEnvFiles : TeaModel {
                public string FileName { get; set; }
                public string FileOssAddress { get; set; }
            }
            [NameInMap("JmeterPluginLabel")]
            [Validation(Required=false)]
            public string JmeterPluginLabel { get; set; }
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public List<SaveEnvRequestEnvProperties> Properties { get; set; }
            public class SaveEnvRequestEnvProperties : TeaModel {
                public string Description { get; set; }
                public string Name { get; set; }
                public string Value { get; set; }
            }
        };

    }

}
