// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetQuotaUsageShrinkRequest : TeaModel {
        [NameInMap("aggMethod")]
        [Validation(Required=false)]
        public string AggMethod { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public long? From { get; set; }

        [NameInMap("plotTypes")]
        [Validation(Required=false)]
        public string PlotTypesShrink { get; set; }

        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("subQuotaNickname")]
        [Validation(Required=false)]
        public string SubQuotaNickname { get; set; }

        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("to")]
        [Validation(Required=false)]
        public long? To { get; set; }

        [NameInMap("yAxisTypes")]
        [Validation(Required=false)]
        public string YAxisTypesShrink { get; set; }

    }

}
