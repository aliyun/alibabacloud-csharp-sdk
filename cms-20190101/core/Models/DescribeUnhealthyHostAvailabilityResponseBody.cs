// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeUnhealthyHostAvailabilityResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("UnhealthyList")]
        [Validation(Required=false)]
        public DescribeUnhealthyHostAvailabilityResponseBodyUnhealthyList UnhealthyList { get; set; }
        public class DescribeUnhealthyHostAvailabilityResponseBodyUnhealthyList : TeaModel {
            [NameInMap("NodeTaskInstance")]
            [Validation(Required=false)]
            public List<DescribeUnhealthyHostAvailabilityResponseBodyUnhealthyListNodeTaskInstance> NodeTaskInstance { get; set; }
            public class DescribeUnhealthyHostAvailabilityResponseBodyUnhealthyListNodeTaskInstance : TeaModel {
                public long? Id { get; set; }
                public DescribeUnhealthyHostAvailabilityResponseBodyUnhealthyListNodeTaskInstanceInstanceList InstanceList { get; set; }
                public class DescribeUnhealthyHostAvailabilityResponseBodyUnhealthyListNodeTaskInstanceInstanceList : TeaModel {
                    [NameInMap("String")]
                    [Validation(Required=false)]
                    public List<string> String { get; set; }

                }
            }
        };

    }

}
