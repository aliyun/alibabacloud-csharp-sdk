// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Apds20220331.Models
{
    public class CreateSurveyJobRequest : TeaModel {
        [NameInMap("ak")]
        [Validation(Required=false)]
        public string Ak { get; set; }

        [NameInMap("autoConfirm")]
        [Validation(Required=false)]
        public bool? AutoConfirm { get; set; }

        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        [NameInMap("cloudType")]
        [Validation(Required=false)]
        public string CloudType { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ossObjectName")]
        [Validation(Required=false)]
        public string OssObjectName { get; set; }

        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("region")]
        [Validation(Required=false)]
        public List<string> Region { get; set; }

        [NameInMap("resourceTypeList")]
        [Validation(Required=false)]
        public List<string> ResourceTypeList { get; set; }

        [NameInMap("sk")]
        [Validation(Required=false)]
        public string Sk { get; set; }

        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("zone")]
        [Validation(Required=false)]
        public List<string> Zone { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
