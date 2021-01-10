// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutIterationRequest : TeaModel {
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("Current")]
        [Validation(Required=false)]
        public string Current { get; set; }

        [NameInMap("ExternalId")]
        [Validation(Required=false)]
        public string ExternalId { get; set; }

        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        [NameInMap("Finished")]
        [Validation(Required=false)]
        public string Finished { get; set; }

        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("Member")]
        [Validation(Required=false)]
        public string Member { get; set; }

        [NameInMap("MostPreUnitFabricStageName")]
        [Validation(Required=false)]
        public string MostPreUnitFabricStageName { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public string Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("Release")]
        [Validation(Required=false)]
        public string Release { get; set; }

        [NameInMap("ReleaseEndDate")]
        [Validation(Required=false)]
        public string ReleaseEndDate { get; set; }

        [NameInMap("ReleaseStartDate")]
        [Validation(Required=false)]
        public string ReleaseStartDate { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("TenantPath")]
        [Validation(Required=false)]
        public string TenantPath { get; set; }

        [NameInMap("WithDeleted")]
        [Validation(Required=false)]
        public string WithDeleted { get; set; }

    }

}
