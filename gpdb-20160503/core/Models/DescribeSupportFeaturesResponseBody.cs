// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeSupportFeaturesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The features supported by the instance. Valid values:
        /// 
        /// *   sample_data: sample dataset. For more information, see [Sample dataset](~~452278~~).
        /// *   diagnose_and_optimize: diagnostics and optimization. For more information, see [Diagnostics and optimization](~~323453~~).
        /// </summary>
        [NameInMap("SupportFeatureList")]
        [Validation(Required=false)]
        public string SupportFeatureList { get; set; }

    }

}
