// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreateSmsSignResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The returned status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0000: The request is successful.</para>
        /// </description></item>
        /// <item><description><para>Other values: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The text message signature creation result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;CalledNoSign&quot;:&quot;sign23343466&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateSmsSignResponseBodyData Data { get; set; }
        public class CreateSmsSignResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The signature string of the recipient number. Append this string to the text message content to parse the actual called number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sign23343466</para>
            /// </summary>
            [NameInMap("CalledNoSign")]
            [Validation(Required=false)]
            public string CalledNoSign { get; set; }

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
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request is successful.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
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
