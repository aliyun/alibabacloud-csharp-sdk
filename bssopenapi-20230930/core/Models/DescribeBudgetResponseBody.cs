// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class DescribeBudgetResponseBody : TeaModel {
        /// <summary>
        /// <para>Budget name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>department1</para>
        /// </summary>
        [NameInMap("BudgetName")]
        [Validation(Required=false)]
        public string BudgetName { get; set; }

        /// <summary>
        /// <para>Budget type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CONSUME</para>
        /// </summary>
        [NameInMap("BudgetType")]
        [Validation(Required=false)]
        public string BudgetType { get; set; }

        /// <summary>
        /// <para>Remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>End cycle period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-12</para>
        /// </summary>
        [NameInMap("CycleEndPeriod")]
        [Validation(Required=false)]
        public string CycleEndPeriod { get; set; }

        /// <summary>
        /// <para>Quota specified per cycle.</para>
        /// </summary>
        [NameInMap("CycleQuota")]
        [Validation(Required=false)]
        public List<DescribeBudgetResponseBodyCycleQuota> CycleQuota { get; set; }
        public class DescribeBudgetResponseBodyCycleQuota : TeaModel {
            /// <summary>
            /// <para>Cycle period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202601</para>
            /// </summary>
            [NameInMap("CyclePeriod")]
            [Validation(Required=false)]
            public string CyclePeriod { get; set; }

            /// <summary>
            /// <para>Quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Quota")]
            [Validation(Required=false)]
            public string Quota { get; set; }

        }

        /// <summary>
        /// <para>Start cycle period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-10</para>
        /// </summary>
        [NameInMap("CycleStartPeriod")]
        [Validation(Required=false)]
        public string CycleStartPeriod { get; set; }

        /// <summary>
        /// <para>Cycle type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MONTHLY</para>
        /// </summary>
        [NameInMap("CycleType")]
        [Validation(Required=false)]
        public string CycleType { get; set; }

        /// <summary>
        /// <para>Enterprise multi-account filter conditions.</para>
        /// </summary>
        [NameInMap("EcIdAccountIdsFilter")]
        [Validation(Required=false)]
        public DescribeBudgetResponseBodyEcIdAccountIdsFilter EcIdAccountIdsFilter { get; set; }
        public class DescribeBudgetResponseBodyEcIdAccountIdsFilter : TeaModel {
            /// <summary>
            /// <para>Member account IDs.</para>
            /// </summary>
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<long?> AccountIds { get; set; }

            /// <summary>
            /// <para>Enterprise entity ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>E2024112210463400001</para>
            /// </summary>
            [NameInMap("EcId")]
            [Validation(Required=false)]
            public string EcId { get; set; }

        }

        /// <summary>
        /// <para>Response structure metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>Budget metric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REQUIRE_AMOUNT</para>
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>Filter conditions.</para>
        /// </summary>
        [NameInMap("QueryFilter")]
        [Validation(Required=false)]
        public List<DescribeBudgetResponseBodyQueryFilter> QueryFilter { get; set; }
        public class DescribeBudgetResponseBodyQueryFilter : TeaModel {
            /// <summary>
            /// <para>Parameter code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RESOURCE_OWNER_ACCOUNT</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>Selection mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IN</para>
            /// </summary>
            [NameInMap("SelectType")]
            [Validation(Required=false)]
            public string SelectType { get; set; }

            /// <summary>
            /// <para>Filter value list.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>Fixed quota value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public string Quota { get; set; }

        /// <summary>
        /// <para>Quota type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FIXED</para>
        /// </summary>
        [NameInMap("QuotaType")]
        [Validation(Required=false)]
        public string QuotaType { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1B2C3D4-E5F6-7890-ABCD-EF1234567890</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Alert configurations.</para>
        /// </summary>
        [NameInMap("WarnConfs")]
        [Validation(Required=false)]
        public List<DescribeBudgetResponseBodyWarnConfs> WarnConfs { get; set; }
        public class DescribeBudgetResponseBodyWarnConfs : TeaModel {
            /// <summary>
            /// <para>Remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable EventBridge.</para>
            /// </summary>
            [NameInMap("EventBridge")]
            [Validation(Required=false)]
            public bool? EventBridge { get; set; }

            /// <summary>
            /// <para>Message center notification channel list.</para>
            /// </summary>
            [NameInMap("MscChannels")]
            [Validation(Required=false)]
            public List<string> MscChannels { get; set; }

            /// <summary>
            /// <para>Message center contact list.</para>
            /// </summary>
            [NameInMap("MscContacts")]
            [Validation(Required=false)]
            public List<string> MscContacts { get; set; }

            /// <summary>
            /// <para>Alert name. User-defined and optional. If not specified, the backend automatically generates a name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alter-1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Sequence number. Only present in responses. Alerts are numbered in ascending order of alert ID, starting from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// <para>Threshold type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FIXED</para>
            /// </summary>
            [NameInMap("ThresholdType")]
            [Validation(Required=false)]
            public string ThresholdType { get; set; }

            /// <summary>
            /// <para>Threshold value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("ThresholdValue")]
            [Validation(Required=false)]
            public string ThresholdValue { get; set; }

            /// <summary>
            /// <para>Alert target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTUAL</para>
            /// </summary>
            [NameInMap("WarnTarget")]
            [Validation(Required=false)]
            public string WarnTarget { get; set; }

        }

    }

}
