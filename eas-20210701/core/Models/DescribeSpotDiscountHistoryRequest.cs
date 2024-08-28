// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeSpotDiscountHistoryRequest : TeaModel {
        /// <summary>
        /// The type of the Elastic Algorithm Service (EAS) instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Specifies whether the preemptible instance has a protection period. During the 1-hour protection period of the preemptible instance, the preemptible instance will not be released.
        /// </summary>
        [NameInMap("IsProtect")]
        [Validation(Required=false)]
        public bool? IsProtect { get; set; }

    }

}
