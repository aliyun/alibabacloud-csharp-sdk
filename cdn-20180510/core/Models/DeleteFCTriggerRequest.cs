// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DeleteFCTriggerRequest : TeaModel {
        /// <summary>
        /// <para>The trigger that corresponds to the Function Compute service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:cdn:{RegionID}:{AccountID}:{Filter}</para>
        /// </summary>
        [NameInMap("TriggerARN")]
        [Validation(Required=false)]
        public string TriggerARN { get; set; }

    }

}
