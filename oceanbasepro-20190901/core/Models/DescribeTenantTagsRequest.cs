// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantTagsRequest : TeaModel {
        /// <summary>
        /// The ID of the OceanBase cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// The JSON string of the tenant ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TenantIds")]
        [Validation(Required=false)]
        public string TenantIds { get; set; }

    }

}
