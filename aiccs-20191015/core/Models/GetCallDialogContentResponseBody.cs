// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetCallDialogContentResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the access denial. Returned only when RAM authentication fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Access Denied</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCallDialogContentResponseBodyData Data { get; set; }
        public class GetCallDialogContentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The call ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456^123478</para>
            /// </summary>
            [NameInMap("CallId")]
            [Validation(Required=false)]
            public string CallId { get; set; }

            /// <summary>
            /// <para>The call status.</para>
            /// <remarks>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>0</c>: Not connected</para>
            /// </description></item>
            /// <item><description><para><c>1</c>: Connected</para>
            /// </description></item>
            /// <item><description><para><c>2</c>: Disconnected</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CallStatus")]
            [Validation(Required=false)]
            public long? CallStatus { get; set; }

            /// <summary>
            /// <para>The dialog content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;content\&quot;:\&quot;您好。\&quot;,\&quot;role\&quot;:\&quot;assistant\&quot;},{\&quot;content\&quot;:\&quot;不用了。\&quot;,\&quot;role\&quot;:\&quot;user\&quot;},{\&quot;content\&quot;:\&quot;呃，不用了，再见，谢谢。\&quot;,\&quot;role\&quot;:\&quot;user\&quot;}]</para>
            /// </summary>
            [NameInMap("DialogContent")]
            [Validation(Required=false)]
            public string DialogContent { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FB0B0481-F13E-16E0-8A7A-1AD2FXXXEF55</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
