// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ModifySiteFeaturesRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esa-site-bl39ryjtineo</para>
        /// </summary>
        [NameInMap("NewInstanceId")]
        [Validation(Required=false)]
        public string NewInstanceId { get; set; }

        /// <summary>
        /// <para>The site feature information to be cleared.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>network_optimization|smart_routing,loadbalance</para>
        /// </summary>
        [NameInMap("SiteFeatures")]
        [Validation(Required=false)]
        public string SiteFeatures { get; set; }

        /// <summary>
        /// <para>The site ID. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1067072706415168</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
