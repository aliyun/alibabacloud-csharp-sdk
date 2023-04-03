// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DeleteGtmAccessStrategyRequest : TeaModel {
        /// <summary>
        /// The language used by the user.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The ID of the access policy that you want to delete.
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

    }

}
