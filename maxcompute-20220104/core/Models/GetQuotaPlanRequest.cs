// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetQuotaPlanRequest : TeaModel {
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
        /// <para>483212237127906</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
