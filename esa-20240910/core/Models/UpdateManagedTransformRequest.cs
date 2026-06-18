// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateManagedTransformRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to add a header that contains visitor geolocation information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Add the header.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Do not add the header.</para>
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
        /// <para>Specifies whether to add the <c>ali-real-client-ip</c> header, which contains the real client IP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Add the header.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Do not add the header.</para>
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
        /// <para>The name of the header that contains the real client IP. The name must start with a letter and can contain letters, digits (0-9), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-header</para>
        /// </summary>
        [NameInMap("RealClientIpHeaderName")]
        [Validation(Required=false)]
        public string RealClientIpHeaderName { get; set; }

        /// <summary>
        /// <para>The ID of the site. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The version of the site. For sites with version management enabled, this parameter specifies the version to which the configuration applies. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
