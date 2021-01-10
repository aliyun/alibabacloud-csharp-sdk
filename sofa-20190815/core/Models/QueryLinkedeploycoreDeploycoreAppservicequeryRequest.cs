// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkedeploycoreDeploycoreAppservicequeryRequest : TeaModel {
        [NameInMap("AppNamesRepeatList")]
        [Validation(Required=false)]
        public List<string> AppNamesRepeatList { get; set; }

        [NameInMap("AppServiceIdsRepeatList")]
        [Validation(Required=false)]
        public List<long?> AppServiceIdsRepeatList { get; set; }

        [NameInMap("Condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        [NameInMap("CurrentUser")]
        [Validation(Required=false)]
        public string CurrentUser { get; set; }

        [NameInMap("EnvName")]
        [Validation(Required=false)]
        public string EnvName { get; set; }

        [NameInMap("ExcludeFromAppsRepeatList")]
        [Validation(Required=false)]
        public List<string> ExcludeFromAppsRepeatList { get; set; }

        [NameInMap("FromAppsRepeatList")]
        [Validation(Required=false)]
        public List<string> FromAppsRepeatList { get; set; }

        [NameInMap("FuzzyAppName")]
        [Validation(Required=false)]
        public string FuzzyAppName { get; set; }

        [NameInMap("FuzzyName")]
        [Validation(Required=false)]
        public string FuzzyName { get; set; }

        [NameInMap("FuzzyProjectId")]
        [Validation(Required=false)]
        public string FuzzyProjectId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("ProjectIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> ProjectIdsRepeatList { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

        [NameInMap("UsersRepeatList")]
        [Validation(Required=false)]
        public List<string> UsersRepeatList { get; set; }

    }

}
