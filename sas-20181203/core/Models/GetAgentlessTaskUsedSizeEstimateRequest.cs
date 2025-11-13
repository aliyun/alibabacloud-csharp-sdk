// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAgentlessTaskUsedSizeEstimateRequest : TeaModel {
        /// <summary>
        /// <para>Asset selection identifier.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AGENTLESS_SCAN_ONCE_TASK_1720145******</para>
        /// </summary>
        [NameInMap("AssetSelectionType")]
        [Validation(Required=false)]
        public string AssetSelectionType { get; set; }

    }

}
