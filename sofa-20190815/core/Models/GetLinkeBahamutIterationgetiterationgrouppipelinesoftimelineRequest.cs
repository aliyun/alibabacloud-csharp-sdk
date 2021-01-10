// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutIterationgetiterationgrouppipelinesoftimelineRequest : TeaModel {
        [NameInMap("Page")]
        [Validation(Required=false)]
        public string Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("PipelineInstanceId")]
        [Validation(Required=false)]
        public string PipelineInstanceId { get; set; }

        [NameInMap("SearchUserAccount")]
        [Validation(Required=false)]
        public string SearchUserAccount { get; set; }

        [NameInMap("StageId")]
        [Validation(Required=false)]
        public string StageId { get; set; }

        [NameInMap("UnitId")]
        [Validation(Required=false)]
        public string UnitId { get; set; }

    }

}
