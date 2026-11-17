// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ModifyInstanceFeaturesRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID of the plan instance. You can obtain instance ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esa-site-b6ga97vfo64g</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The list of site feature information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SiteFeatures")]
        [Validation(Required=false)]
        public List<ModifyInstanceFeaturesRequestSiteFeatures> SiteFeatures { get; set; }
        public class ModifyInstanceFeaturesRequestSiteFeatures : TeaModel {
            /// <summary>
            /// <para>The site feature information to be modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>network_optimization|smart_routing,loadbalance</para>
            /// </summary>
            [NameInMap("Features")]
            [Validation(Required=false)]
            public string Features { get; set; }

            /// <summary>
            /// <para>The ID of the site. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>151097616427232</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

        }

    }

}
