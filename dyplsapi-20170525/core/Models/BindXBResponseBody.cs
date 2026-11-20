// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindXBResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0000: Success.</description></item>
        /// </list>
        /// <para>Other values indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The work number binding result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AuthId&quot;:&quot;4353453456&quot;,&quot;TelX&quot;:&quot;18640577897&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BindXBResponseBodyData Data { get; set; }
        public class BindXBResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the work number binding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4353453456</para>
            /// </summary>
            [NameInMap("AuthId")]
            [Validation(Required=false)]
            public string AuthId { get; set; }

            /// <summary>
            /// <para>The work number X.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18640577897</para>
            /// </summary>
            [NameInMap("TelX")]
            [Validation(Required=false)]
            public string TelX { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
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
        /// <item><description><para>true: Successful.</para>
        /// </description></item>
        /// <item><description><para>false: Failed.</para>
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
