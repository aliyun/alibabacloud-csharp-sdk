// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class GetBillingOverviewShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The billing month. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08</para>
        /// </summary>
        [NameInMap("billMonth")]
        [Validation(Required=false)]
        public string BillMonth { get; set; }

        /// <summary>
        /// <para>The filter condition.</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public string FilterShrink { get; set; }

        /// <summary>
        /// <para>The list of grouping conditions. Currently, you must specify exactly one grouping dimension.</para>
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
        /// <para>The region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
