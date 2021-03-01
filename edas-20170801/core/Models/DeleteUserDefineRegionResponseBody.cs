// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DeleteUserDefineRegionResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RegionDefine")]
        [Validation(Required=false)]
        public DeleteUserDefineRegionResponseBodyRegionDefine RegionDefine { get; set; }
        public class DeleteUserDefineRegionResponseBodyRegionDefine : TeaModel {
            [NameInMap("BelongRegion")]
            [Validation(Required=false)]
            public string BelongRegion { get; set; }
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
