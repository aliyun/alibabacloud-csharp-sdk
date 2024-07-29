// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeAllCallbackResponseBody : TeaModel {
        [NameInMap("Callbacks")]
        [Validation(Required=false)]
        public List<DescribeAllCallbackResponseBodyCallbacks> Callbacks { get; set; }
        public class DescribeAllCallbackResponseBodyCallbacks : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("SubEvent")]
            [Validation(Required=false)]
            public List<DescribeAllCallbackResponseBodyCallbacksSubEvent> SubEvent { get; set; }
            public class DescribeAllCallbackResponseBodyCallbacksSubEvent : TeaModel {
                [NameInMap("Event")]
                [Validation(Required=false)]
                public int? Event { get; set; }

                [NameInMap("EventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
