// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class GetBillingTrendRequest : TeaModel {
        [NameInMap("filter")]
        [Validation(Required=false)]
        public GetBillingTrendRequestFilter Filter { get; set; }
        public class GetBillingTrendRequestFilter : TeaModel {
            [NameInMap("dimensions")]
            [Validation(Required=false)]
            public List<GetBillingTrendRequestFilterDimensions> Dimensions { get; set; }
            public class GetBillingTrendRequestFilterDimensions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>CHARGE_TYPE</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>IN</para>
                /// </summary>
                [NameInMap("selectType")]
                [Validation(Required=false)]
                public string SelectType { get; set; }

                [NameInMap("values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DAY</para>
        /// </summary>
        [NameInMap("granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public List<GetBillingTrendRequestGroupBy> GroupBy { get; set; }
        public class GetBillingTrendRequestGroupBy : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>BASE_MODEL</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

        }

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

        [NameInMap("timePeriod")]
        [Validation(Required=false)]
        public GetBillingTrendRequestTimePeriod TimePeriod { get; set; }
        public class GetBillingTrendRequestTimePeriod : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-08-25</para>
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-08-01</para>
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

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
