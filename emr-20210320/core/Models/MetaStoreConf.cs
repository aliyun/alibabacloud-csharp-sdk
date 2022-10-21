// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class MetaStoreConf : TeaModel {
        [NameInMap("DbPassword")]
        [Validation(Required=false)]
        public string DbPassword { get; set; }

        [NameInMap("DbUrl")]
        [Validation(Required=false)]
        public string DbUrl { get; set; }

        [NameInMap("DbUserName")]
        [Validation(Required=false)]
        public string DbUserName { get; set; }

    }

}
