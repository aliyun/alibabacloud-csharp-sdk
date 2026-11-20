// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class ConfigXResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denied error.</para>
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
        /// <item><description><para>0000: Success.</para>
        /// </description></item>
        /// <item><description><para>Other values: Failure.</para>
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
        /// <para>The configuration result of the work number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Code&quot;:&quot;0000&quot;,&quot;Message&quot;:&quot;Success&quot;,&quot;Success&quot;:true}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ConfigXResponseBodyData Data { get; set; }
        public class ConfigXResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The returned status code. A value of 0000 indicates success. Other values indicate failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0000</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

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
            /// <para>Indicates whether the request is successful. A value of true indicates success. A value of false indicates failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

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
        /// <para>4A2568E1-7D83-5491-8DEF-600D8AFF97E7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Success.</para>
        /// </description></item>
        /// <item><description><para>false: Failure.</para>
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
