// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class GetBillingOverviewRequest : TeaModel {
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
        public GetBillingOverviewRequestFilter Filter { get; set; }
        public class GetBillingOverviewRequestFilter : TeaModel {
            /// <summary>
            /// <para>The list of dimension filters.</para>
            /// </summary>
            [NameInMap("dimensions")]
            [Validation(Required=false)]
            public List<GetBillingOverviewRequestFilterDimensions> Dimensions { get; set; }
            public class GetBillingOverviewRequestFilterDimensions : TeaModel {
                /// <summary>
                /// <para>The filter field. For more information, see the supplementary notes below.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CHARGE_TYPE</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The filter type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IN</para>
                /// </summary>
                [NameInMap("selectType")]
                [Validation(Required=false)]
                public string SelectType { get; set; }

                /// <summary>
                /// <para>The list of filter values.</para>
                /// </summary>
                [NameInMap("values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

        }

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
        /// <para>The list of grouping conditions. Currently, exactly one grouping dimension must be specified.</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public List<GetBillingOverviewRequestGroupBy> GroupBy { get; set; }
        public class GetBillingOverviewRequestGroupBy : TeaModel {
            /// <summary>
            /// <para>The code of the grouping dimension. For more information, see the supplementary notes below.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BASE_MODEL</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

        }

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
        /// <para>The query time range, which includes start and end. Both the start time and end time are included in the query range. The time format must be consistent with granularity, and start cannot be later than end.</para>
        /// </summary>
        [NameInMap("timePeriod")]
        [Validation(Required=false)]
        public GetBillingOverviewRequestTimePeriod TimePeriod { get; set; }
        public class GetBillingOverviewRequestTimePeriod : TeaModel {
            /// <summary>
            /// <para>The end time of the query. This time point is included. The format is determined by <c>granularity</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202609</para>
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <para>The start time of the query. This time point is included. The format is determined by <c>granularity</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202609</para>
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

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
