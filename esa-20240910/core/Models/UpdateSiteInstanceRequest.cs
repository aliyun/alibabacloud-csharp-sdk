// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateSiteInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The target instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esa-site-bckh96ri1eyo</para>
        /// </summary>
        [NameInMap("NewInstanceId")]
        [Validation(Required=false)]
        public string NewInstanceId { get; set; }

        [NameInMap("ResourceOwner")]
        [Validation(Required=false)]
        public long? ResourceOwner { get; set; }

        /// <summary>
        /// <para>The site ID. You can call <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>901109460617712</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
