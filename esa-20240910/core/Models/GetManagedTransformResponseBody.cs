// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetManagedTransformResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether a header that contains the visitor\&quot;s geolocation is added. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>on: Enables this feature.</para>
        /// </description></item>
        /// <item><description><para>off: Disables this feature.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("AddClientGeolocationHeader")]
        [Validation(Required=false)]
        public string AddClientGeolocationHeader { get; set; }

        /// <summary>
        /// <para>Indicates whether the &quot;ali-real-client-ip&quot; header is added to include the real client IP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>on: Enables this feature.</para>
        /// </description></item>
        /// <item><description><para>off: Disables this feature.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("AddRealClientIpHeader")]
        [Validation(Required=false)]
        public string AddRealClientIpHeader { get; set; }

        /// <summary>
        /// <para>The real client IP header name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-header</para>
        /// </summary>
        [NameInMap("RealClientIpHeaderName")]
        [Validation(Required=false)]
        public string RealClientIpHeaderName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The version of the site for which the configuration is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
