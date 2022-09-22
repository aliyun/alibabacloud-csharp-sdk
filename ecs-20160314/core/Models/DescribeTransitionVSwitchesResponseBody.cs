// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeTransitionVSwitchesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("VSwitchModels")]
        [Validation(Required=false)]
        public DescribeTransitionVSwitchesResponseBodyVSwitchModels VSwitchModels { get; set; }
        public class DescribeTransitionVSwitchesResponseBodyVSwitchModels : TeaModel {
            [NameInMap("Model")]
            [Validation(Required=false)]
            public List<DescribeTransitionVSwitchesResponseBodyVSwitchModelsModel> Model { get; set; }
            public class DescribeTransitionVSwitchesResponseBodyVSwitchModelsModel : TeaModel {
                [NameInMap("CIDR")]
                [Validation(Required=false)]
                public string CIDR { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("IzNo")]
                [Validation(Required=false)]
                public string IzNo { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

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
