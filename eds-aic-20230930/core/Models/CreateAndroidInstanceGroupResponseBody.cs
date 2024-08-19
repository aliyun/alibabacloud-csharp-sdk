// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateAndroidInstanceGroupResponseBody : TeaModel {
        [NameInMap("InstanceGroupIds")]
        [Validation(Required=false)]
        public List<string> InstanceGroupIds { get; set; }

        [NameInMap("InstanceGroupInfos")]
        [Validation(Required=false)]
        public List<CreateAndroidInstanceGroupResponseBodyInstanceGroupInfos> InstanceGroupInfos { get; set; }
        public class CreateAndroidInstanceGroupResponseBodyInstanceGroupInfos : TeaModel {
            [NameInMap("InstanceGroupId")]
            [Validation(Required=false)]
            public string InstanceGroupId { get; set; }

            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

        }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
