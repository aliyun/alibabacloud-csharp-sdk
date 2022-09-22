// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeTransitionVpcsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("VpcModels")]
        [Validation(Required=false)]
        public DescribeTransitionVpcsResponseBodyVpcModels VpcModels { get; set; }
        public class DescribeTransitionVpcsResponseBodyVpcModels : TeaModel {
            [NameInMap("Model")]
            [Validation(Required=false)]
            public List<DescribeTransitionVpcsResponseBodyVpcModelsModel> Model { get; set; }
            public class DescribeTransitionVpcsResponseBodyVpcModelsModel : TeaModel {
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

        }

    }

}
