// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class InitContainerConfig : TeaModel {
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        [NameInMap("CommandArgs")]
        [Validation(Required=false)]
        public string CommandArgs { get; set; }

        [NameInMap("ConfigMapMountDesc")]
        [Validation(Required=false)]
        public string ConfigMapMountDesc { get; set; }

        [NameInMap("Envs")]
        [Validation(Required=false)]
        public string Envs { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
