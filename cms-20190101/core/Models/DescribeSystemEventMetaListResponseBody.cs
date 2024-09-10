// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSystemEventMetaListResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The detailed meta information.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSystemEventMetaListResponseBodyData Data { get; set; }
        public class DescribeSystemEventMetaListResponseBodyData : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeSystemEventMetaListResponseBodyDataResource> Resource { get; set; }
            public class DescribeSystemEventMetaListResponseBodyDataResource : TeaModel {
                /// <summary>
                /// The type of the system event. Valid values:
                /// 
                /// *   StatusNotification
                /// *   Exception
                /// *   Maintenance
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                /// <summary>
                /// The level of the alert. Valid values:
                /// 
                /// *   CRITICAL
                /// *   WARN
                /// *   INFO
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// The name of the system event.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The description of the system event, in Chinese.
                /// </summary>
                [NameInMap("NameDesc")]
                [Validation(Required=false)]
                public string NameDesc { get; set; }

                [NameInMap("NameDesc.En")]
                [Validation(Required=false)]
                public string NameDesc_en { get; set; }

                /// <summary>
                /// The abbreviation of the service name.
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// The status of the system event.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The description of the event status.
                /// </summary>
                [NameInMap("StatusDesc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   true: The call was successful.
        /// *   false: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
