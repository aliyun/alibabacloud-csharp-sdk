// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindAXBCallResponseBody : TeaModel {
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
        /// <para>The response status code. Valid values:</para>
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
        /// <para>The AXB call binding result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;BindId&quot;:&quot;476567566&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BindAXBCallResponseBodyData Data { get; set; }
        public class BindAXBCallResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the binding relationship.</para>
            /// 
            /// <b>Example:</b>
            /// <para>476567566</para>
            /// </summary>
            [NameInMap("BindId")]
            [Validation(Required=false)]
            public string BindId { get; set; }

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
