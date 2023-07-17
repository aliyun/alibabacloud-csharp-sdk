// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListHotelServiceCategoryRequest : TeaModel {
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public ListHotelServiceCategoryRequestPayload Payload { get; set; }
        public class ListHotelServiceCategoryRequestPayload : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
