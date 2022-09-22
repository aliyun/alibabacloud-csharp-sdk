// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeAccountLimitsResponseBody : TeaModel {
        [NameInMap("AccountLimitTypeSet")]
        [Validation(Required=false)]
        public DescribeAccountLimitsResponseBodyAccountLimitTypeSet AccountLimitTypeSet { get; set; }
        public class DescribeAccountLimitsResponseBodyAccountLimitTypeSet : TeaModel {
            [NameInMap("AccountLimit")]
            [Validation(Required=false)]
            public List<DescribeAccountLimitsResponseBodyAccountLimitTypeSetAccountLimit> AccountLimit { get; set; }
            public class DescribeAccountLimitsResponseBodyAccountLimitTypeSetAccountLimit : TeaModel {
                [NameInMap("LimitName")]
                [Validation(Required=false)]
                public string LimitName { get; set; }

                [NameInMap("LimitValueSet")]
                [Validation(Required=false)]
                public DescribeAccountLimitsResponseBodyAccountLimitTypeSetAccountLimitLimitValueSet LimitValueSet { get; set; }
                public class DescribeAccountLimitsResponseBodyAccountLimitTypeSetAccountLimitLimitValueSet : TeaModel {
                    [NameInMap("LimitValue")]
                    [Validation(Required=false)]
                    public List<string> LimitValue { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
