// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class ServiceConfig : TeaModel {
        [NameInMap("CodeServerAuth")]
        [Validation(Required=false)]
        public string CodeServerAuth { get; set; }

        [NameInMap("CodeServerPassword")]
        [Validation(Required=false)]
        public string CodeServerPassword { get; set; }

        [NameInMap("JupyterServerAuth")]
        [Validation(Required=false)]
        public string JupyterServerAuth { get; set; }

        [NameInMap("JupyterServerPassword")]
        [Validation(Required=false)]
        public string JupyterServerPassword { get; set; }

    }

}
