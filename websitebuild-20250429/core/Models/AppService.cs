// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class AppService : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("Deleted")]
        [Validation(Required=false)]
        public int? Deleted { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("EspBizId")]
        [Validation(Required=false)]
        public string EspBizId { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("InstanceBizId")]
        [Validation(Required=false)]
        public string InstanceBizId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Profile")]
        [Validation(Required=false)]
        public AppServiceProfile Profile { get; set; }

        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("ServiceTypeText")]
        [Validation(Required=false)]
        public string ServiceTypeText { get; set; }

        [NameInMap("Slug")]
        [Validation(Required=false)]
        public string Slug { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
