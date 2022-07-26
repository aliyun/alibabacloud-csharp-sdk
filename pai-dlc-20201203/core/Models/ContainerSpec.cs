// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ContainerSpec : TeaModel {
        [NameInMap("Args")]
        [Validation(Required=false)]
        public List<string> Args { get; set; }

        [NameInMap("Command")]
        [Validation(Required=false)]
        public List<string> Command { get; set; }

        [NameInMap("Env")]
        [Validation(Required=false)]
        public List<EnvVar> Env { get; set; }

        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public ResourceRequirements Resources { get; set; }

        [NameInMap("WorkingDir")]
        [Validation(Required=false)]
        public string WorkingDir { get; set; }

    }

}
