// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListProjectLogStoresRequest : TeaModel {
        /// <summary>
        /// The region in which the data management center of the threat analysis feature resides. Specify this parameter based on the regions in which your assets reside. Valid values:
        /// 
        /// *   cn-hangzhou: Your assets reside in regions in China.
        /// *   ap-southeast-1: Your assets reside in regions outside China.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The log code.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceLogCode")]
        [Validation(Required=false)]
        public string SourceLogCode { get; set; }

        /// <summary>
        /// The code of the cloud service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceProdCode")]
        [Validation(Required=false)]
        public string SourceProdCode { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SubUserId")]
        [Validation(Required=false)]
        public long? SubUserId { get; set; }

    }

}
