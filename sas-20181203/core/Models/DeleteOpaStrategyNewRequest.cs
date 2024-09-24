// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteOpaStrategyNewRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of rules.</para>
        /// </summary>
        [NameInMap("StrategyIds")]
        [Validation(Required=false)]
        public List<long?> StrategyIds { get; set; }

    }

}
