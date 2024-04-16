// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class Configuration : TeaModel {
        [NameInMap("configFileName")]
        [Validation(Required=false)]
        public string ConfigFileName { get; set; }

        [NameInMap("configItemKey")]
        [Validation(Required=false)]
        public string ConfigItemKey { get; set; }

        [NameInMap("configItemValue")]
        [Validation(Required=false)]
        public string ConfigItemValue { get; set; }

    }

}
