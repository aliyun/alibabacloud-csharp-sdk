// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyDatasetItemRequest : TeaModel {
        /// <summary>
        /// The ID of the dataset.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// The ID of the data entry.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DatasetItemId")]
        [Validation(Required=false)]
        public string DatasetItemId { get; set; }

        /// <summary>
        /// The description of the data entry. The description cannot exceed 180 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The time in UTC when the data entry expires. The time is in the **yyyy-MM-ddTHH:mm:ssZ** format.
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
