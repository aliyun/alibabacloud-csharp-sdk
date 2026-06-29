// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateBizMetricShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Tenant ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>Update request</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateBizMetricCommand")]
        [Validation(Required=false)]
        public string UpdateBizMetricCommandShrink { get; set; }

    }

}
