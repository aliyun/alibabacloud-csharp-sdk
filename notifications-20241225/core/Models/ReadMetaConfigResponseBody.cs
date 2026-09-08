// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Notifications20241225.Models
{
    public class ReadMetaConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the call fails. For more information, see error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The execution result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;isSubNextUser&quot;: &quot;YES&quot;,
        ///     &quot;IS_INNER_USER&quot;: &quot;NO&quot;,
        ///     &quot;isXsWhite&quot;: &quot;NO&quot;,
        ///     &quot;isXs&quot;: &quot;NO&quot;,
        ///     &quot;SITEID&quot;: &quot;cn&quot;,
        ///     &quot;webhookSignatures&quot;: [
        ///         &quot;Alibaba&quot;,
        ///         &quot;阿里云&quot;
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <para>The message returned if the call fails.</para>
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
        /// <para>A5F62766-1C2F-1F56-A39D-63E3D30F0633</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates that the call is successful. A value of false indicates that the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
