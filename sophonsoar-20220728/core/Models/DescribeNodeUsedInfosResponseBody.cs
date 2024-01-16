// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeNodeUsedInfosResponseBody : TeaModel {
        /// <summary>
        /// The node reference information. The value is in the JSON format and contains the following fields:
        /// 
        /// *   **action**: the referencing action. This field contains the following information:
        /// 
        ///     *   **name**: the name of the referencing node.
        ///     *   **inputParams**: the parameter settings of the referencing node.
        /// </summary>
        [NameInMap("NodeUsedInfos")]
        [Validation(Required=false)]
        public string NodeUsedInfos { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
