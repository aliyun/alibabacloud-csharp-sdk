// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeGatewaysTagsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("GatewayTags")]
        [Validation(Required=false)]
        public DescribeGatewaysTagsResponseBodyGatewayTags GatewayTags { get; set; }
        public class DescribeGatewaysTagsResponseBodyGatewayTags : TeaModel {
            [NameInMap("GatewayTag")]
            [Validation(Required=false)]
            public List<DescribeGatewaysTagsResponseBodyGatewayTagsGatewayTag> GatewayTag { get; set; }
            public class DescribeGatewaysTagsResponseBodyGatewayTagsGatewayTag : TeaModel {
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeGatewaysTagsResponseBodyGatewayTagsGatewayTagTags Tags { get; set; }
                public class DescribeGatewaysTagsResponseBodyGatewayTagsGatewayTagTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeGatewaysTagsResponseBodyGatewayTagsGatewayTagTagsTag> Tag { get; set; }
                    public class DescribeGatewaysTagsResponseBodyGatewayTagsGatewayTagTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
