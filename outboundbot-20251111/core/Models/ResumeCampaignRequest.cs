// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class ResumeCampaignRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the campaign.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dcee2bca-0fa0-4826-89b8-1f693574023b</para>
        /// </summary>
        [NameInMap("CampaignId")]
        [Validation(Required=false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// <para>The outbound instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33040b9a-b04b-452f-b554-cd6f3a15f850</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
