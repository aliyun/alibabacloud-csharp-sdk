// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class GetSmsAuthTokensResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>If OK is returned, the request is successful.</description></item>
        /// <item><description>For more information about other error codes, see <a href="https://help.aliyun.com/document_detail/85198.html">API response codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSmsAuthTokensResponseBodyData Data { get; set; }
        public class GetSmsAuthTokensResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The business token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FZSMeRbLCiapIBo65NXNHvGbkGDmhs23XWTZDOtZN0g5n/kqSc2FU27Gc9YhGb6dNn9/L9ZXSYiIB6C6LMLQJjyXjRzt5v6pzZXqnjO4cSuPWYUxJvdc8l8OpucEYe8Mx17HxsHDzj0VC4D5+atcrTpJE6jQ7e2QVNjZIPMwsfxELjQS7c****</para>
            /// </summary>
            [NameInMap("BizToken")]
            [Validation(Required=false)]
            public string BizToken { get; set; }

            /// <summary>
            /// <para>The time when the token expired. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1631526326000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The AccessKey ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STS.NSqC****</para>
            /// </summary>
            [NameInMap("StsAccessKeyId")]
            [Validation(Required=false)]
            public string StsAccessKeyId { get; set; }

            /// <summary>
            /// <para>The AccessKey secret.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VboZ4xbZ****</para>
            /// </summary>
            [NameInMap("StsAccessKeySecret")]
            [Validation(Required=false)]
            public string StsAccessKeySecret { get; set; }

            /// <summary>
            /// <para>The security token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CAISiQJ1q6Ft5B2yfSjIr5DEDP/BurtW9PemMEfBrEpsOr5K17XjuDz2IHtLfXFsBusYt/U2nWpX5v4clrxIToR7SFbFY9pb6ZhazBisebDGv8HtR3TcFEjiSwapEBfe8JL4QYeQFaHwGJqEb1TDiVUAo9/TfimjWFqIKICAjYUdAP0cQgi/a0gtZr4UXHwAzvUXLnzML/2gHwf3i27LdipStxF7lHl05NbUoKTeyGKH3AGqlLVF9tite8f9NpczBvolDYfpht4RX7HazStd5yJN8KpLl6Fe8V/FxIrGXAAJv0rdbbOFq4Q1c18hOLJHAKtfsvXmlPNpsevfmpnsx****</para>
            /// </summary>
            [NameInMap("StsToken")]
            [Validation(Required=false)]
            public string StsToken { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
