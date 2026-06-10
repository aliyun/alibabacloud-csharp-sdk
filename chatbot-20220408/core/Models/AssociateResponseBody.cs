// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class AssociateResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of suggested FAQs.</para>
        /// </summary>
        [NameInMap("Associate")]
        [Validation(Required=false)]
        public List<AssociateResponseBodyAssociate> Associate { get; set; }
        public class AssociateResponseBodyAssociate : TeaModel {
            /// <summary>
            /// <para>Additional information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public string Meta { get; set; }

            /// <summary>
            /// <para>The title of the suggested FAQ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>公积金提取的政策</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The response message ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ADF0EBD-7C50-1922-A28B-43215B47CC1A</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5C20F0D4-9721-178A-8236-3BF990634962</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1531ded6b3df4afca4be63943f708bb7</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
