// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateSitePauseRequest : TeaModel {
        /// <summary>
        /// <para>Indicates whether to pause proxy acceleration for the site. If set to <c>true</c>, DNS queries for the site return the record values directly to the client. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Pauses proxy acceleration for the site.</para>
        /// </description></item>
        /// <item><description><para>false: Resumes proxy acceleration for the site.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Paused")]
        [Validation(Required=false)]
        public bool? Paused { get; set; }

        /// <summary>
        /// <para>The site ID. To obtain this ID, call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
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
