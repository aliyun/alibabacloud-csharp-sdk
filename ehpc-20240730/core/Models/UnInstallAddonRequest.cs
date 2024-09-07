// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class UnInstallAddonRequest : TeaModel {
        /// <summary>
        /// The addon ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AddonId")]
        [Validation(Required=false)]
        public string AddonId { get; set; }

        /// <summary>
        /// The cluster ID.
        /// 
        /// You can call the [ListClusters](https://help.aliyun.com/document_detail/87116.html) operation to query the cluster ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}
