// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class SubmitCampaignRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f295a472-35ee-442a-9013-b13862505a1a</para>
        /// </summary>
        [NameInMap("CampaignId")]
        [Validation(Required=false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// <para>The outbound instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b3dbfb82-1ae6-4e73-b717-f494727d2af3</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
