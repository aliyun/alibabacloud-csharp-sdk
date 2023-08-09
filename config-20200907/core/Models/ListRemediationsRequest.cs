// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListRemediationsRequest : TeaModel {
        /// <summary>
        /// The rule IDs. Separate multiple rule IDs with commas (,).
        /// 
        /// For more information about how to obtain the ID of a rule, see [ListConfigRules](~~169607~~).
        /// </summary>
        [NameInMap("ConfigRuleIds")]
        [Validation(Required=false)]
        public string ConfigRuleIds { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 50.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
