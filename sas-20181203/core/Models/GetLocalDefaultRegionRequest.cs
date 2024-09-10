// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetLocalDefaultRegionRequest : TeaModel {
        /// <summary>
        /// The cloud service provider. Valid values:
        /// 
        /// *   **Tencent**: Tencent Cloud.
        /// *   **HUAWEICLOUD**: Huawei Cloud.
        /// *   **Azure**: Microsoft Azure.
        /// *   **AWS**: Amazon Web Services (AWS).
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
