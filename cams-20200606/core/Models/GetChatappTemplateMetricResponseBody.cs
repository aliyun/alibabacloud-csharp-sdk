// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetChatappTemplateMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The value OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetChatappTemplateMetricResponseBodyData> Data { get; set; }
        public class GetChatappTemplateMetricResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The statistics on button clicks.</para>
            /// </summary>
            [NameInMap("Cliented")]
            [Validation(Required=false)]
            public List<GetChatappTemplateMetricResponseBodyDataCliented> Cliented { get; set; }
            public class GetChatappTemplateMetricResponseBodyDataCliented : TeaModel {
                /// <summary>
                /// <para>The text on the button.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Open url</para>
                /// </summary>
                [NameInMap("ButtonContent")]
                [Validation(Required=false)]
                public string ButtonContent { get; set; }

                /// <summary>
                /// <para>The number of clicks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The button type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>phone_number_button</description></item>
                /// <item><description>url_button</description></item>
                /// <item><description>quick_relpy_button</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>quick_reply_button</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The number of delivered messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("DeliveredCount")]
            [Validation(Required=false)]
            public int? DeliveredCount { get; set; }

            /// <summary>
            /// <para>The end of the time range you queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1668138331485</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public long? End { get; set; }

            /// <summary>
            /// <para>The template language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>en</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The number of read messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ReadCount")]
            [Validation(Required=false)]
            public int? ReadCount { get; set; }

            /// <summary>
            /// <para>The number of sent messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SentCount")]
            [Validation(Required=false)]
            public int? SentCount { get; set; }

            /// <summary>
            /// <para>The beginning of the time range you queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1673919240001</para>
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public long? Start { get; set; }

            /// <summary>
            /// <para>The template code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>83837774838*****</para>
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A9486641****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
