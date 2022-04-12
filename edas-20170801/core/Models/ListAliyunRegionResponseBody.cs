// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListAliyunRegionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RegionEntityList")]
        [Validation(Required=false)]
        public ListAliyunRegionResponseBodyRegionEntityList RegionEntityList { get; set; }
        public class ListAliyunRegionResponseBodyRegionEntityList : TeaModel {
            [NameInMap("RegionEntity")]
            [Validation(Required=false)]
            public List<ListAliyunRegionResponseBodyRegionEntityListRegionEntity> RegionEntity { get; set; }
            public class ListAliyunRegionResponseBodyRegionEntityListRegionEntity : TeaModel {
                public string Id { get; set; }
                public string Name { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
