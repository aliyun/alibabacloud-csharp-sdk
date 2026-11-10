// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetManagedTransformResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the visitor geolocation header is added. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("AddClientGeolocationHeader")]
        [Validation(Required=false)]
        public string AddClientGeolocationHeader { get; set; }

        /// <summary>
        /// <para>Indicates whether the ali-real-client-ip header containing the real client IP address is added. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("AddRealClientIpHeader")]
        [Validation(Required=false)]
        public string AddRealClientIpHeader { get; set; }

        /// <summary>
        /// <para>The name of the real client IP address header.</para>
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
        /// <para>The site version number. For sites with version management enabled, you can use this parameter to specify the site version to which the configuration applies. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
