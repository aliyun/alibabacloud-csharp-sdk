// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class BeeBotAssociateResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denied for detailed information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>If OK is returned, the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BeeBotAssociateResponseBodyData Data { get; set; }
        public class BeeBotAssociateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of associated recommendations.</para>
            /// </summary>
            [NameInMap("Associate")]
            [Validation(Required=false)]
            public List<BeeBotAssociateResponseBodyDataAssociate> Associate { get; set; }
            public class BeeBotAssociateResponseBodyDataAssociate : TeaModel {
                /// <summary>
                /// <para>The metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Meta")]
                [Validation(Required=false)]
                public string Meta { get; set; }

                /// <summary>
                /// <para>The title of the related question.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Policy on Withdrawal of Housing Provident Fund</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The ID of the response message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1eb47d7a1706429081e90c83c62c2f00</para>
            /// </summary>
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <para>The ID of the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>93f11165a2a24289a6f869760e8cb3f3</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A9486641****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
