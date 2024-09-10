// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class RemoveCheckResultWhiteListRequest : TeaModel {
        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("CheckGroupId")]
        [Validation(Required=false)]
        public string CheckGroupId { get; set; }

        /// <summary>
        /// The IDs of check items.
        /// </summary>
        [NameInMap("CheckIds")]
        [Validation(Required=false)]
        public List<long?> CheckIds { get; set; }

        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
