// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeTransitionVpcAndVSwitchResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VmTransitionModels")]
        [Validation(Required=false)]
        public DescribeTransitionVpcAndVSwitchResponseBodyVmTransitionModels VmTransitionModels { get; set; }
        public class DescribeTransitionVpcAndVSwitchResponseBodyVmTransitionModels : TeaModel {
            [NameInMap("Model")]
            [Validation(Required=false)]
            public List<DescribeTransitionVpcAndVSwitchResponseBodyVmTransitionModelsModel> Model { get; set; }
            public class DescribeTransitionVpcAndVSwitchResponseBodyVmTransitionModelsModel : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

    }

}
