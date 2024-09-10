// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SetSyncRefreshRegionRequest : TeaModel {
        /// <summary>
        /// The access type of the multi-cloud site. Valid values:
        /// 
        /// *   **0**: The current site is not the default site of multi-cloud site. You can specify the current site as the default site of the multi-cloud site.
        /// *   **1**: The current site is the default site of multi-cloud site.
        /// </summary>
        [NameInMap("DefaultRegion")]
        [Validation(Required=false)]
        public int? DefaultRegion { get; set; }

        /// <summary>
        /// The regions from which you want to synchronize assets at the current site.
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public List<string> RegionIds { get; set; }

        /// <summary>
        /// The cloud service provider. Valid values:
        /// 
        /// *   **Tencent**: Tencent Cloud
        /// *   **HUAWEICLOUD**: Huawei Cloud
        /// *   **Azure**: Microsoft Azure
        /// *   **AWS**: Amazon Web Services (AWS)
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
