// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreatePolicyBindingsShrinkRequest : TeaModel {
        /// <summary>
        /// The data sources that you want to bind to the backup policy.
        /// </summary>
        [NameInMap("PolicyBindingList")]
        [Validation(Required=false)]
        public string PolicyBindingListShrink { get; set; }

        /// <summary>
        /// The ID of the backup policy.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
