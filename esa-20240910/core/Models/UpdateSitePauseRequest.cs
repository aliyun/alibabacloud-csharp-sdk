// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateSitePauseRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to temporarily pause the proxy acceleration feature for the entire site. After the feature is paused, all DNS records directly return record values to the client. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Pauses site acceleration.</description></item>
        /// <item><description>false: Resumes normal site acceleration.</description></item>
        /// </list>
        /// <para>When site acceleration is paused, only activated sites with NS access mode are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Paused")]
        [Validation(Required=false)]
        public bool? Paused { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the site ID. Check the Status field to confirm the site status and the AccessType field to confirm the access mode of the site.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
