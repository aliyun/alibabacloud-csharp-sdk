// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDingTalkRequest : TeaModel {
        /// <summary>
        /// The UID of the user.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The group IDs.
        /// </summary>
        [NameInMap("RuleActionName")]
        [Validation(Required=false)]
        public string RuleActionName { get; set; }

    }

}
