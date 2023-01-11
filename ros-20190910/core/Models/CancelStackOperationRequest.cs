/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CancelStackOperationRequest : TeaModel {
        [NameInMap("AllowedStackOperations")]
        [Validation(Required=false)]
        public List<string> AllowedStackOperations { get; set; }

        [NameInMap("CancelType")]
        [Validation(Required=false)]
        public string CancelType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}
