// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CheckSiteProjectNameRequest : TeaModel {
        /// <summary>
        /// <para>The real-time log project name.</para>
        /// <remarks>
        /// <para>Allowed character set (hyphens only, no underscores), length range, and naming rule examples (such as \&quot;ali-dcdn-log-56\&quot;)</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ali-dcdn-log-56</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The site ID. You can call <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> to obtain the site ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12312312213212</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
