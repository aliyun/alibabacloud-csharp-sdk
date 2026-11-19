// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeSavingsPlansCoverageTotalRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource ownership account. The resource ownership account is the account that actually uses the resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123745698925000</para>
        /// </summary>
        [NameInMap("BillOwnerId")]
        [Validation(Required=false)]
        public long? BillOwnerId { get; set; }

        /// <summary>
        /// <para>The end time of the query. Format: yyyy-MM-dd HH:mm:ss. The specified end time is excluded from the query. If this parameter is left empty, the current time is used as the end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-20 00:00:00</para>
        /// </summary>
        [NameInMap("EndPeriod")]
        [Validation(Required=false)]
        public string EndPeriod { get; set; }

        /// <summary>
        /// <para>The filter parameters.</para>
        /// </summary>
        [NameInMap("FilterParam")]
        [Validation(Required=false)]
        public DescribeSavingsPlansCoverageTotalRequestFilterParam FilterParam { get; set; }
        public class DescribeSavingsPlansCoverageTotalRequestFilterParam : TeaModel {
            /// <summary>
            /// <para>The list of dimension filter conditions.</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<DescribeSavingsPlansCoverageTotalRequestFilterParamDimensions> Dimensions { get; set; }
            public class DescribeSavingsPlansCoverageTotalRequestFilterParamDimensions : TeaModel {
                /// <summary>
                /// <para>The dimension code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>COMMODITY</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The selection method for dimension filtering.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IN</para>
                /// </summary>
                [NameInMap("SelectType")]
                [Validation(Required=false)]
                public string SelectType { get; set; }

                /// <summary>
                /// <para>The list of dimension filter values.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The list of tag filter conditions.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeSavingsPlansCoverageTotalRequestFilterParamTags> Tags { get; set; }
            public class DescribeSavingsPlansCoverageTotalRequestFilterParamTags : TeaModel {
                /// <summary>
                /// <para>The tag code.</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The selection method for tag filtering.</para>
                /// </summary>
                [NameInMap("SelectType")]
                [Validation(Required=false)]
                public string SelectType { get; set; }

                /// <summary>
                /// <para>The list of tag filter values.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

        }

        /// <summary>
        /// <para>The time granularity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MONTH: month</description></item>
        /// <item><description>DAY: day</description></item>
        /// <item><description>HOUR: hour</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HOUR</para>
        /// </summary>
        [NameInMap("PeriodType")]
        [Validation(Required=false)]
        public string PeriodType { get; set; }

        /// <summary>
        /// <para>The start time of the query. Format: yyyy-MM-dd HH:mm:ss. The specified start time is included in the query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-15 00:00:00</para>
        /// </summary>
        [NameInMap("StartPeriod")]
        [Validation(Required=false)]
        public string StartPeriod { get; set; }

    }

}
