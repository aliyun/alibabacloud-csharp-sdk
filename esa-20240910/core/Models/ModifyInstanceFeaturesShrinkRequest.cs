// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ModifyInstanceFeaturesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The plan instance ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esa-site-b6ga97vfo64g</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The list of site feature configurations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SiteFeatures")]
        [Validation(Required=false)]
        public string SiteFeaturesShrink { get; set; }

    }

}
