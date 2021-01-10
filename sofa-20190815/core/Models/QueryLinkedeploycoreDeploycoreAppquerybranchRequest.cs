// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkedeploycoreDeploycoreAppquerybranchRequest : TeaModel {
        [NameInMap("AppNamesRepeatList")]
        [Validation(Required=false)]
        public List<string> AppNamesRepeatList { get; set; }

        [NameInMap("AppServiceId")]
        [Validation(Required=false)]
        public long? AppServiceId { get; set; }

        [NameInMap("Condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        [NameInMap("EnvNamesRepeatList")]
        [Validation(Required=false)]
        public List<string> EnvNamesRepeatList { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

    }

}
