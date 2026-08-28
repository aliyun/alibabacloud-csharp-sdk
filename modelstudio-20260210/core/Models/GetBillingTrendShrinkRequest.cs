// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class GetBillingTrendShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The dimension filter conditions.</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public string FilterShrink { get; set; }

        /// <summary>
        /// <para>The query granularity. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAY</para>
        /// </summary>
        [NameInMap("granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>The grouping conditions. This parameter must contain one and only one element.</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public string GroupByShrink { get; set; }

        /// <summary>
        /// <para>The response language. Default value: en-US.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("locale")]
        [Validation(Required=false)]
        public string Locale { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The query time range, including the start time and end time. This parameter is required.</para>
        /// </summary>
        [NameInMap("timePeriod")]
        [Validation(Required=false)]
        public string TimePeriodShrink { get; set; }

        /// <summary>
        /// <para>The number of groups to return. Valid values: 1 to 20. Default value: 20. The remaining groups are merged into &quot;Others&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("topNum")]
        [Validation(Required=false)]
        public int? TopNum { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter out groups with a zero amount. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("zeroFilter")]
        [Validation(Required=false)]
        public bool? ZeroFilter { get; set; }

    }

}
