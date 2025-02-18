// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreateQuotaPlanRequest : TeaModel {
        /// <summary>
        /// <para>The request body parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;name&quot;: &quot;planA&quot;, // The quota is a level-1 quota. You can select only the fields that are related to the quota plan. &quot;quota&quot;: { &quot;name&quot;: &quot;a&quot;, &quot;nickName&quot;: &quot;aaa_nick&quot;, &quot;tenantId&quot;: &quot;10001&quot;, &quot;regionId&quot;: &quot;cn-hangzhou&quot;, &quot;parentId&quot;: &quot;0&quot;, &quot;cluster&quot;: &quot;AT-ODPS-TEST3&quot;, &quot;parameter&quot;: { &quot;minCU&quot;: 40, &quot;maxCU&quot;: 40, &quot;adhocCU&quot;: 0, &quot;elasticMinCU&quot;: 40, &quot;elasticMaxCU&quot;: 40, &quot;enablePreemptiveScheduling&quot;: false, &quot;forceReservedMin&quot;:true, &quot;enablePriority&quot;:false, &quot;singleJobCULimit&quot;:100, &quot;adhocQuotaBeginTimeInSec&quot;: 1345, &quot;adhocQuotaEndTimeInSec&quot;: 1234, &quot;ignoreAdhocQuota&quot;:false }, &quot;subQuotaInfoList&quot;: [ { &quot;nickName&quot;: &quot;WlmFuxiSecondaryOnlineQuotaTest&quot;, &quot;name&quot;: &quot;WlmFuxiSecondaryOnlineQuotaTest&quot;, &quot;type&quot;: &quot;FUXI_ONLINE&quot;, &quot;tenantId&quot;: &quot;10001&quot;, &quot;regionId&quot;: &quot;cn-hangzhou&quot;, &quot;cluster&quot;: &quot;AT-ODPS-TEST3&quot;, &quot;parameter&quot;: { &quot;minCU&quot;: 40, &quot;maxCU&quot;: 40, &quot;adhocCU&quot;: 0, &quot;elasticMinCU&quot;: 40, &quot;elasticMaxCU&quot;: 40, &quot;enablePreemptiveScheduling&quot;: false, &quot;forceReservedMin&quot;:true, &quot;enablePriority&quot;:false, &quot;singleJobCULimit&quot;:100, &quot;adhocQuotaBeginTimeInSec&quot;: 1345, &quot;adhocQuotaEndTimeInSec&quot;: 1234, &quot;ignoreAdhocQuota&quot;:false } } ] } }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>228451885265153</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
