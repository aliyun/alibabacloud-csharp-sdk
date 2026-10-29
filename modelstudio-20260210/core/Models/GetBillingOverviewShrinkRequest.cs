// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class GetBillingOverviewShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The billing month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08</para>
        /// </summary>
        [NameInMap("billMonth")]
        [Validation(Required=false)]
        public string BillMonth { get; set; }

        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public string FilterShrink { get; set; }

        /// <summary>
        /// <para>The time granularity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MONTH</para>
        /// </summary>
        [NameInMap("granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>The list of grouping conditions. Currently, you must specify exactly one grouping dimension.</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public string GroupByShrink { get; set; }

        /// <summary>
        /// <para>The language of the response. Default value: en-US.</para>
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
        /// <para>The query time range, which includes the start and end times. Both the start and end times are included in the query range. The time format must be consistent with the granularity, and the start time cannot be later than the end time.</para>
        /// </summary>
        [NameInMap("timePeriod")]
        [Validation(Required=false)]
        public string TimePeriodShrink { get; set; }

        /// <summary>
        /// <para>The number of groups to return. Valid values: 1 to 20. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("topNum")]
        [Validation(Required=false)]
        public int? TopNum { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter out groups with an amount of 0. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("zeroFilter")]
        [Validation(Required=false)]
        public bool? ZeroFilter { get; set; }

    }

}
