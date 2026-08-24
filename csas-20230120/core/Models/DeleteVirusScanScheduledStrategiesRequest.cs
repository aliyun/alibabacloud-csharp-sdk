// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class DeleteVirusScanScheduledStrategiesRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the virus scheduled scan policies to delete. The collection must contain at least 1 and at most 100 IDs. Duplicate IDs are not allowed.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StrategyIds")]
        [Validation(Required=false)]
        public List<string> StrategyIds { get; set; }

    }

}
