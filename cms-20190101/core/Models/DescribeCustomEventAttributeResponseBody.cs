// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeCustomEventAttributeResponseBody : TeaModel {
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
        public string Success { get; set; }

        [NameInMap("CustomEvents")]
        [Validation(Required=false)]
        public DescribeCustomEventAttributeResponseBodyCustomEvents CustomEvents { get; set; }
        public class DescribeCustomEventAttributeResponseBodyCustomEvents : TeaModel {
            [NameInMap("CustomEvent")]
            [Validation(Required=false)]
            public List<DescribeCustomEventAttributeResponseBodyCustomEventsCustomEvent> CustomEvent { get; set; }
            public class DescribeCustomEventAttributeResponseBodyCustomEventsCustomEvent : TeaModel {
                public string Time { get; set; }
                public string Name { get; set; }
                public string GroupId { get; set; }
                public string Content { get; set; }
                public string Id { get; set; }
            }
        };

    }

}
