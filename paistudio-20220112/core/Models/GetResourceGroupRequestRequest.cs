// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetResourceGroupRequestRequest : TeaModel {
        [NameInMap("PodStatus")]
        [Validation(Required=false)]
        public string PodStatus { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

    }

}
