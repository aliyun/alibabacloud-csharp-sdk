// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class DescribeBudgetsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeBudgetsResponseBodyData> Data { get; set; }
        public class DescribeBudgetsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>department1-test</para>
            /// </summary>
            [NameInMap("BudgetName")]
            [Validation(Required=false)]
            public string BudgetName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CONSUME</para>
            /// </summary>
            [NameInMap("BudgetType")]
            [Validation(Required=false)]
            public string BudgetType { get; set; }

            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-12</para>
            /// </summary>
            [NameInMap("CycleEndPeriod")]
            [Validation(Required=false)]
            public string CycleEndPeriod { get; set; }

            [NameInMap("CycleQuota")]
            [Validation(Required=false)]
            public List<DescribeBudgetsResponseBodyDataCycleQuota> CycleQuota { get; set; }
            public class DescribeBudgetsResponseBodyDataCycleQuota : TeaModel {
                [NameInMap("CyclePeriod")]
                [Validation(Required=false)]
                public string CyclePeriod { get; set; }

                [NameInMap("Quota")]
                [Validation(Required=false)]
                public string Quota { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-10</para>
            /// </summary>
            [NameInMap("CycleStartPeriod")]
            [Validation(Required=false)]
            public string CycleStartPeriod { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MONTHLY</para>
            /// </summary>
            [NameInMap("CycleType")]
            [Validation(Required=false)]
            public string CycleType { get; set; }

            [NameInMap("EcIdAccountIdsFilter")]
            [Validation(Required=false)]
            public DescribeBudgetsResponseBodyDataEcIdAccountIdsFilter EcIdAccountIdsFilter { get; set; }
            public class DescribeBudgetsResponseBodyDataEcIdAccountIdsFilter : TeaModel {
                [NameInMap("AccountIds")]
                [Validation(Required=false)]
                public List<long?> AccountIds { get; set; }

                [NameInMap("EcId")]
                [Validation(Required=false)]
                public string EcId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NOT_EXPIRED</para>
            /// </summary>
            [NameInMap("ExpireStatus")]
            [Validation(Required=false)]
            public string ExpireStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>REQUIRE_AMOUNT</para>
            /// </summary>
            [NameInMap("Metric")]
            [Validation(Required=false)]
            public string Metric { get; set; }

            [NameInMap("QueryFilter")]
            [Validation(Required=false)]
            public List<DescribeBudgetsResponseBodyDataQueryFilter> QueryFilter { get; set; }
            public class DescribeBudgetsResponseBodyDataQueryFilter : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("SelectType")]
                [Validation(Required=false)]
                public string SelectType { get; set; }

                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("Quota")]
            [Validation(Required=false)]
            public string Quota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FIXED</para>
            /// </summary>
            [NameInMap("QuotaType")]
            [Validation(Required=false)]
            public string QuotaType { get; set; }

            [NameInMap("WarnConfs")]
            [Validation(Required=false)]
            public List<DescribeBudgetsResponseBodyDataWarnConfs> WarnConfs { get; set; }
            public class DescribeBudgetsResponseBodyDataWarnConfs : TeaModel {
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                [NameInMap("EventBridge")]
                [Validation(Required=false)]
                public bool? EventBridge { get; set; }

                [NameInMap("MscChannels")]
                [Validation(Required=false)]
                public List<string> MscChannels { get; set; }

                [NameInMap("MscContacts")]
                [Validation(Required=false)]
                public List<string> MscContacts { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public int? Sequence { get; set; }

                [NameInMap("ThresholdType")]
                [Validation(Required=false)]
                public string ThresholdType { get; set; }

                [NameInMap("ThresholdValue")]
                [Validation(Required=false)]
                public string ThresholdValue { get; set; }

                [NameInMap("WarnTarget")]
                [Validation(Required=false)]
                public string WarnTarget { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DB2A9097-289C-11CE-AA74-235FCFD39204</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
