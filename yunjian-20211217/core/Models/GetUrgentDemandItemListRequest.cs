// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yunjian20211217.Models
{
    public class GetUrgentDemandItemListRequest : TeaModel {
        [NameInMap("commodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecs/yundisk</para>
        /// </summary>
        [NameInMap("commodityTypeCode")]
        [Validation(Required=false)]
        public string CommodityTypeCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("current")]
        [Validation(Required=false)]
        public long? Current { get; set; }

        [NameInMap("planId")]
        [Validation(Required=false)]
        public long? PlanId { get; set; }

        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        [NameInMap("zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
