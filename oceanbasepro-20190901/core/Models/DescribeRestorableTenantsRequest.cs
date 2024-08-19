// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeRestorableTenantsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IsOnline")]
        [Validation(Required=false)]
        public bool? IsOnline { get; set; }

        [NameInMap("IsRemote")]
        [Validation(Required=false)]
        public bool? IsRemote { get; set; }

        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        [NameInMap("RestoreMode")]
        [Validation(Required=false)]
        public string RestoreMode { get; set; }

        [NameInMap("RestoreObjectType")]
        [Validation(Required=false)]
        public string RestoreObjectType { get; set; }

        [NameInMap("SetId")]
        [Validation(Required=false)]
        public string SetId { get; set; }

    }

}
