// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qianzhou20211111.Models
{
    public class ListClusterImagesRequest : TeaModel {
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("image_hash")]
        [Validation(Required=false)]
        public string ImageHash { get; set; }

        [NameInMap("image_name")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        [NameInMap("page_no")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
