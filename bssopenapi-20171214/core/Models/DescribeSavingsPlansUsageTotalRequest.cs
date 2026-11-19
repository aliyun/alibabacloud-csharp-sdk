// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeSavingsPlansUsageTotalRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the account with resource ownership, which is the account that actually uses the resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123745698925000</para>
        /// </summary>
        [NameInMap("BillOwnerId")]
        [Validation(Required=false)]
        public long? BillOwnerId { get; set; }

        /// <summary>
        /// <para>The end time of the time range to query. The end time is not included in the time range. If you do not specify this parameter, the end time is the current time. Specify the time in the yyyy-MM-dd HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-02 00:00:00</para>
        /// </summary>
        [NameInMap("EndPeriod")]
        [Validation(Required=false)]
        public string EndPeriod { get; set; }

        /// <summary>
        /// <para>The filter parameters.</para>
        /// </summary>
        [NameInMap("FilterParam")]
        [Validation(Required=false)]
        public DescribeSavingsPlansUsageTotalRequestFilterParam FilterParam { get; set; }
        public class DescribeSavingsPlansUsageTotalRequestFilterParam : TeaModel {
            /// <summary>
            /// <para>The list of dimension filter conditions.</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<DescribeSavingsPlansUsageTotalRequestFilterParamDimensions> Dimensions { get; set; }
            public class DescribeSavingsPlansUsageTotalRequestFilterParamDimensions : TeaModel {
                /// <summary>
                /// <para>The dimension code.</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The selection method for dimension filtering.</para>
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
            public List<DescribeSavingsPlansUsageTotalRequestFilterParamTags> Tags { get; set; }
            public class DescribeSavingsPlansUsageTotalRequestFilterParamTags : TeaModel {
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
        /// <para>The time granularity for querying the usage summary. Valid values: MONTH, DAY, and HOUR.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HOUR</para>
        /// </summary>
        [NameInMap("PeriodType")]
        [Validation(Required=false)]
        public string PeriodType { get; set; }

        /// <summary>
        /// <para>The start time of the time range to query. The start time is included in the time range. Specify the time in the yyyy-MM-dd HH:mm:ss format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartPeriod")]
        [Validation(Required=false)]
        public string StartPeriod { get; set; }

    }

}
