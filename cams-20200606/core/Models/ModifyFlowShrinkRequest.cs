// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ModifyFlowShrinkRequest : TeaModel {
        /// <summary>
        /// The information about the categories of the Flow.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public string CategoriesShrink { get; set; }

        /// <summary>
        /// The space ID of the user within the independent software vendor (ISV) account.
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// The Flow ID.
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        /// <summary>
        /// The name of the Flow.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

    }

}
