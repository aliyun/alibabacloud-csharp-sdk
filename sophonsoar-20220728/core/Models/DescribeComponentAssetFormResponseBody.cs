// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeComponentAssetFormResponseBody : TeaModel {
        /// <summary>
        /// The metadata of the asset in the component. The value is a JSON array and contains the following fields:
        /// 
        /// *   **name**: the parameter name.
        /// *   **defaultValue**: the default parameter value.
        /// *   **description**: the parameter description.
        /// *   **required**: indicates whether the parameter is required. Valid values: **true** and **false**.
        /// </summary>
        [NameInMap("ComponentAssetForm")]
        [Validation(Required=false)]
        public string ComponentAssetForm { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
