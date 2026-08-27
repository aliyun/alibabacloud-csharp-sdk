// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class GetBillingOverviewShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-08</para>
        /// </summary>
        [NameInMap("billMonth")]
        [Validation(Required=false)]
        public string BillMonth { get; set; }

        [NameInMap("filter")]
        [Validation(Required=false)]
        public string FilterShrink { get; set; }

        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public string GroupByShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("locale")]
        [Validation(Required=false)]
        public string Locale { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("topNum")]
        [Validation(Required=false)]
        public int? TopNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("zeroFilter")]
        [Validation(Required=false)]
        public bool? ZeroFilter { get; set; }

    }

}
