// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDatasetDetailInfoRequest : TeaModel {
        /// <summary>
        /// The ID of the training dataset that you want to remove from the specified custom linguistic model.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

    }

}
