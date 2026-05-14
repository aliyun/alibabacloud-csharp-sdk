// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class DescribeBudgetResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>department1</para>
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
        public List<DescribeBudgetResponseBodyCycleQuota> CycleQuota { get; set; }
        public class DescribeBudgetResponseBodyCycleQuota : TeaModel {
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
        public DescribeBudgetResponseBodyEcIdAccountIdsFilter EcIdAccountIdsFilter { get; set; }
        public class DescribeBudgetResponseBodyEcIdAccountIdsFilter : TeaModel {
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<long?> AccountIds { get; set; }

            [NameInMap("EcId")]
            [Validation(Required=false)]
            public string EcId { get; set; }

        }

        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>REQUIRE_AMOUNT</para>
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        [NameInMap("QueryFilter")]
        [Validation(Required=false)]
        public List<DescribeBudgetResponseBodyQueryFilter> QueryFilter { get; set; }
        public class DescribeBudgetResponseBodyQueryFilter : TeaModel {
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
        /// <para>1000</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>A1B2C3D4-E5F6-7890-ABCD-EF1234567890</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WarnConfs")]
        [Validation(Required=false)]
        public List<DescribeBudgetResponseBodyWarnConfs> WarnConfs { get; set; }
        public class DescribeBudgetResponseBodyWarnConfs : TeaModel {
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

}
