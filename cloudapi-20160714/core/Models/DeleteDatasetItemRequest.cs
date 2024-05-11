// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DeleteDatasetItemRequest : TeaModel {
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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
