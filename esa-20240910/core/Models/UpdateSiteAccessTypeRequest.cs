// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateSiteAccessTypeRequest : TeaModel {
        /// <summary>
        /// <para>The new DNS setup of the website. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NS</b></description></item>
        /// <item><description><b>CNAME</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NS</para>
        /// </summary>
        [NameInMap("AccessType")]
        [Validation(Required=false)]
        public string AccessType { get; set; }

        /// <summary>
        /// <para>The website ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
