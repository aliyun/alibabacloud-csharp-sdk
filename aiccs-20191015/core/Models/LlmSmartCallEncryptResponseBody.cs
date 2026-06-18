// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class LlmSmartCallEncryptResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the access denied error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The request status code. A value of \&quot;ok\&quot; indicates that the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public LlmSmartCallEncryptResponseBodyData Data { get; set; }
        public class LlmSmartCallEncryptResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The call ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>149******206</para>
            /// </summary>
            [NameInMap("CallId")]
            [Validation(Required=false)]
            public string CallId { get; set; }

        }

        /// <summary>
        /// <para>A description of the status code.</para>
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
        /// <para>F92F9749-105E-518F-8B08-CF16EF36A0E2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The API call was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The API call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
