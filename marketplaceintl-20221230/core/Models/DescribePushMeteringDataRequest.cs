// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MarketplaceIntl20221230.Models
{
    public class DescribePushMeteringDataRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pushData123456</para>
        /// </summary>
        [NameInMap("PushOrderBizId")]
        [Validation(Required=false)]
        public string PushOrderBizId { get; set; }

    }

}
