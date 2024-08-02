// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateAppInstanceGroupResponseBody : TeaModel {
        [NameInMap("AppInstanceGroupModel")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupResponseBodyAppInstanceGroupModel AppInstanceGroupModel { get; set; }
        public class CreateAppInstanceGroupResponseBodyAppInstanceGroupModel : TeaModel {
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            [NameInMap("NodePoolId")]
            [Validation(Required=false)]
            public string NodePoolId { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
