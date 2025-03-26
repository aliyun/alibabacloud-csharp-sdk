// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class DeleteErAttachmentResponseBody : TeaModel {
        /// <summary>
        /// <para>访问被拒绝的详细原因。</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response content. If a resource has dependent resources, the existing dependent resources are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;ER_RMAP&quot;: [
        ///         {
        ///             &quot;erId&quot;: &quot;er-opy1wrfv&quot;,
        ///             &quot;destinationCidrBlock&quot;: &quot;0.0.0.0/0&quot;,
        ///             &quot;regionId&quot;: &quot;cn-wulanchabu&quot;,
        ///             &quot;routeMapNum&quot;: 3000,
        ///             &quot;erRouteMapId&quot;: &quot;er-rmap-v5lfhmvm&quot;,
        ///             &quot;action&quot;: &quot;permit&quot;,
        ///             &quot;status&quot;: &quot;Available&quot;
        ///         },
        ///         {
        ///             &quot;erId&quot;: &quot;er-opy1wrfv&quot;,
        ///             &quot;destinationCidrBlock&quot;: &quot;0.0.0.0/0&quot;,
        ///             &quot;regionId&quot;: &quot;cn-wulanchabu&quot;,
        ///             &quot;routeMapNum&quot;: 3000,
        ///             &quot;erRouteMapId&quot;: &quot;er-rmap-of3r0ndh&quot;,
        ///             &quot;action&quot;: &quot;permit&quot;,
        ///             &quot;status&quot;: &quot;Available&quot;
        ///         }
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public object Content { get; set; }

        /// <summary>
        /// <para>response message, if the success request is</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID of the current request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A88DFED5-24B7-5A3E-87DE-380BF06F3C90</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
