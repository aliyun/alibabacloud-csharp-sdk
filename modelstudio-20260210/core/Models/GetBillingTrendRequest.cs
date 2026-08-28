// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class GetBillingTrendRequest : TeaModel {
        /// <summary>
        /// <para>The dimension filter conditions.</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public GetBillingTrendRequestFilter Filter { get; set; }
        public class GetBillingTrendRequestFilter : TeaModel {
            /// <summary>
            /// <para>The dimension filter list.</para>
            /// </summary>
            [NameInMap("dimensions")]
            [Validation(Required=false)]
            public List<GetBillingTrendRequestFilterDimensions> Dimensions { get; set; }
            public class GetBillingTrendRequestFilterDimensions : TeaModel {
                /// <summary>
                /// <para>The filter dimension code. For more information, see the &quot;Additional information&quot; section below.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CHARGE_TYPE</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The filter method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IN</para>
                /// </summary>
                [NameInMap("selectType")]
                [Validation(Required=false)]
                public string SelectType { get; set; }

                /// <summary>
                /// <para>The filter value list.</para>
                /// </summary>
                [NameInMap("values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

        }

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
        public List<GetBillingTrendRequestGroupBy> GroupBy { get; set; }
        public class GetBillingTrendRequestGroupBy : TeaModel {
            /// <summary>
            /// <para>The grouping dimension code. For more information, see the &quot;Additional information&quot; section below.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BASE_MODEL</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

        }

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
        public GetBillingTrendRequestTimePeriod TimePeriod { get; set; }
        public class GetBillingTrendRequestTimePeriod : TeaModel {
            /// <summary>
            /// <para>The end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-25</para>
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-01</para>
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

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
