// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class BatchApplyAdviceByIdListRequest : TeaModel {
        [NameInMap("AdviceDate")]
        [Validation(Required=false)]
        public long? AdviceDate { get; set; }

        [NameInMap("AdviceIdList")]
        [Validation(Required=false)]
        public string AdviceIdList { get; set; }

        /// <summary>
        /// The message returned for the operation. Valid values:
        /// 
        /// *   **SUCCESS** is returned if the operation is successful.
        /// *   An error message is returned if the operation fails.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
