// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeHavsInstanceTypesResponseBody : TeaModel {
        [NameInMap("DescribeHavsInstanceTypesResponse")]
        [Validation(Required=false)]
        public DescribeHavsInstanceTypesResponseBodyDescribeHavsInstanceTypesResponse DescribeHavsInstanceTypesResponse { get; set; }
        public class DescribeHavsInstanceTypesResponseBodyDescribeHavsInstanceTypesResponse : TeaModel {
            [NameInMap("HavsInstanceTypes")]
            [Validation(Required=false)]
            public DescribeHavsInstanceTypesResponseBodyDescribeHavsInstanceTypesResponseHavsInstanceTypes HavsInstanceTypes { get; set; }
            public class DescribeHavsInstanceTypesResponseBodyDescribeHavsInstanceTypesResponseHavsInstanceTypes : TeaModel {
                [NameInMap("HavsInstanceTypes")]
                [Validation(Required=false)]
                public List<string> HavsInstanceTypes { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
