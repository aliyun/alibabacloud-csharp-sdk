// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListLinkeBahamutAdminpipelineRequest : TeaModel {
        [NameInMap("IsReleased")]
        [Validation(Required=false)]
        public string IsReleased { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public string Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("StageType")]
        [Validation(Required=false)]
        public string StageType { get; set; }

        [NameInMap("TagsRepeatList")]
        [Validation(Required=false)]
        public List<string> TagsRepeatList { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
