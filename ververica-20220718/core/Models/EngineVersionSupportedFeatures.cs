// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class EngineVersionSupportedFeatures : TeaModel {
        [NameInMap("supportNativeSavepoint")]
        [Validation(Required=false)]
        public bool? SupportNativeSavepoint { get; set; }

        [NameInMap("useForSqlDeployments")]
        [Validation(Required=false)]
        public bool? UseForSqlDeployments { get; set; }

    }

}
