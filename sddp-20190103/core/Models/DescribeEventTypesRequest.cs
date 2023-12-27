// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeEventTypesRequest : TeaModel {
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The type of anomalous event for which you want to query the anomalous events of subtypes. Valid values:
        /// 
        /// *   **01**: anomalous permission usage
        /// *   **02**: anomalous data flow
        /// *   **03**: anomalous data operation
        /// </summary>
        [NameInMap("ParentTypeId")]
        [Validation(Required=false)]
        public long? ParentTypeId { get; set; }

        /// <summary>
        /// The type of the resource. Valid values include **1**, **2**, **3**, **4**, and **5**. The value 1 indicates MaxCompute. The value 2 indicates Object Storage Service (OSS). The value 3 indicates AnalyticDB for MySQL. The value 4 indicates Tablestore. The value 5 indicates ApsaraDB RDS.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public int? ResourceId { get; set; }

        /// <summary>
        /// The status of the anomalous event. Valid values:
        /// 
        /// *   **1**: enabled
        /// *   **2**: disabled
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
