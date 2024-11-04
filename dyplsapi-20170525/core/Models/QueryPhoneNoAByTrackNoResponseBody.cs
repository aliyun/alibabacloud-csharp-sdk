// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QueryPhoneNoAByTrackNoResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>Other status codes indicate that the request failed. For more information, see <a href="https://help.aliyun.com/document_detail/109196.html">Error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The information returned after the phone numbers were bound.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public List<QueryPhoneNoAByTrackNoResponseBodyModule> Module { get; set; }
        public class QueryPhoneNoAByTrackNoResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The extension of phone number X.</para>
            /// 
            /// <b>Example:</b>
            /// <para>130</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            /// <summary>
            /// <para>Phone number A.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1310000****</para>
            /// </summary>
            [NameInMap("PhoneNoA")]
            [Validation(Required=false)]
            public string PhoneNoA { get; set; }

            /// <summary>
            /// <para>The private number, that is, phone number X.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710000****</para>
            /// </summary>
            [NameInMap("PhoneNoX")]
            [Validation(Required=false)]
            public string PhoneNoX { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8906582E-6722</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
