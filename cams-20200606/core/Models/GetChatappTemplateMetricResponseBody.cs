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
        /// The value OK indicates that the request was successful.
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
            /// The statistics on button clicks.
            /// </summary>
            [NameInMap("Cliented")]
            [Validation(Required=false)]
            public List<GetChatappTemplateMetricResponseBodyDataCliented> Cliented { get; set; }
            public class GetChatappTemplateMetricResponseBodyDataCliented : TeaModel {
                /// <summary>
                /// The text on the button.
                /// </summary>
                [NameInMap("ButtonContent")]
                [Validation(Required=false)]
                public string ButtonContent { get; set; }

                /// <summary>
                /// The number of clicks.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The button type.
                /// 
                /// Valid values:
                /// 
                /// *   phone_number_button
                /// *   url_button
                /// *   quick_relpy_button
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The number of delivered messages.
            /// </summary>
            [NameInMap("DeliveredCount")]
            [Validation(Required=false)]
            public int? DeliveredCount { get; set; }

            /// <summary>
            /// The end of the time range you queried.
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public long? End { get; set; }

            /// <summary>
            /// The template language.
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// The number of read messages.
            /// </summary>
            [NameInMap("ReadCount")]
            [Validation(Required=false)]
            public int? ReadCount { get; set; }

            /// <summary>
            /// The number of sent messages.
            /// </summary>
            [NameInMap("SentCount")]
            [Validation(Required=false)]
            public int? SentCount { get; set; }

            /// <summary>
            /// The beginning of the time range you queried.
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public long? Start { get; set; }

            /// <summary>
            /// The template code.
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

        }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
