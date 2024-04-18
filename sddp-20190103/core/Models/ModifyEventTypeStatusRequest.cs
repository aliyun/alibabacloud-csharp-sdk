// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ModifyEventTypeStatusRequest : TeaModel {
        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values: **zh** and **en**. The value zh indicates Chinese, and the value en indicates English.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The ID of the anomalous event subtype. Separate multiple IDs with commas (,).
        /// 
        /// > You can call the **DescribeEventTypes** operation to query the ID of anomalous event subtype.
        /// </summary>
        [NameInMap("SubTypeIds")]
        [Validation(Required=false)]
        public string SubTypeIds { get; set; }

    }

}
