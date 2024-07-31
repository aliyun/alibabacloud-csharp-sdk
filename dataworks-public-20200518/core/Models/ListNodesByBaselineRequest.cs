// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListNodesByBaselineRequest : TeaModel {
        /// <summary>
        /// The baseline ID. You can call the [ListBaselineConfigs](https://help.aliyun.com/document_detail/173964.html) operation to query the baseline ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public long? BaselineId { get; set; }

    }

}
