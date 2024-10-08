// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAvailableSpecRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("UpgradeType")]
        [Validation(Required=false)]
        public string UpgradeType { get; set; }

    }

}
