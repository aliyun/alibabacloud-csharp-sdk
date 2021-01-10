// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class RollbackLinkeBahamutAdminpipelinerollbackexistedRequest : TeaModel {
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        [NameInMap("BahamutTenant")]
        [Validation(Required=false)]
        public string BahamutTenant { get; set; }

        [NameInMap("Iteration")]
        [Validation(Required=false)]
        public string Iteration { get; set; }

    }

}
