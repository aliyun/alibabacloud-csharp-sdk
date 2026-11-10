// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateManagedTransformRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to add the visitor geolocation header. Valid values:</para>
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
        /// <para>Specifies whether to add the ali-real-client-ip header that contains the real client IP address. Valid values:</para>
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
        /// <para>The name of the real client IP address header. The name must start with a letter and can contain digits and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-header</para>
        /// </summary>
        [NameInMap("RealClientIpHeaderName")]
        [Validation(Required=false)]
        public string RealClientIpHeaderName { get; set; }

        /// <summary>
        /// <para>The ID of the site. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The version number of the site. For sites with version management enabled, you can use this parameter to specify the site version to which the configuration applies. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
