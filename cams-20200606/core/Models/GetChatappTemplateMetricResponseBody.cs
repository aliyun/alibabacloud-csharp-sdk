// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetChatappTemplateMetricResponseBody : TeaModel {
        /// <summary>
        /// The details about the access denial.
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// 
        /// *   A value of OK indicates that the call is successful.
        /// *   Other values indicate that the call fails. For more information, see [Error codes](~~196974~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetChatappTemplateMetricResponseBodyData> Data { get; set; }
        public class GetChatappTemplateMetricResponseBodyData : TeaModel {
            /// <summary>
            /// Click Statistics
            /// </summary>
            [NameInMap("Cliented")]
            [Validation(Required=false)]
            public List<GetChatappTemplateMetricResponseBodyDataCliented> Cliented { get; set; }
            public class GetChatappTemplateMetricResponseBodyDataCliented : TeaModel {
                /// <summary>
                /// Button name
                /// </summary>
                [NameInMap("ButtonContent")]
                [Validation(Required=false)]
                public string ButtonContent { get; set; }

                /// <summary>
                /// Clicked count
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The type of button.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// Delivered count
            /// </summary>
            [NameInMap("DeliveredCount")]
            [Validation(Required=false)]
            public int? DeliveredCount { get; set; }

            /// <summary>
            /// The end of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public long? End { get; set; }

            /// <summary>
            /// The language that is used in the message template. For more information, see [Language codes](~~463420~~).
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// Read count
            /// </summary>
            [NameInMap("ReadCount")]
            [Validation(Required=false)]
            public int? ReadCount { get; set; }

            /// <summary>
            /// Sent count
            /// </summary>
            [NameInMap("SentCount")]
            [Validation(Required=false)]
            public int? SentCount { get; set; }

            /// <summary>
            /// The beginning of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public long? Start { get; set; }

            /// <summary>
            /// The code of the message template.
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

        }

        /// <summary>
        /// The error message returned.
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

    }

}
