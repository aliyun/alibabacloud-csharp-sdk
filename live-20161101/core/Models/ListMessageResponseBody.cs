// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListMessageResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-****-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListMessageResponseBodyResult Result { get; set; }
        public class ListMessageResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether the current page is followed by another page. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The current page is followed by another page.</description></item>
            /// <item><description>false: The current page is not followed by another page.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <para>Details about the messages.</para>
            /// </summary>
            [NameInMap("MessageList")]
            [Validation(Required=false)]
            public List<ListMessageResponseBodyResultMessageList> MessageList { get; set; }
            public class ListMessageResponseBodyResultMessageList : TeaModel {
                /// <summary>
                /// <para>The message body. The value is a JSON string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public string Data { get; set; }

                /// <summary>
                /// <para>The ID of the message group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AE35-****-T95F</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The ID of the message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qt***</para>
                /// </summary>
                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                /// <summary>
                /// <para>The ID of the user who sent the message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yi***</para>
                /// </summary>
                [NameInMap("SenderId")]
                [Validation(Required=false)]
                public string SenderId { get; set; }

                /// <summary>
                /// <para>The type of the message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10002</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

        }

    }

}
