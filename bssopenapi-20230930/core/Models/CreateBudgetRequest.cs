// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class CreateBudgetRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Department_dev_budget</para>
        /// </summary>
        [NameInMap("BudgetName")]
        [Validation(Required=false)]
        public string BudgetName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-12</para>
        /// </summary>
        [NameInMap("CycleEndPeriod")]
        [Validation(Required=false)]
        public string CycleEndPeriod { get; set; }

        [NameInMap("CycleQuota")]
        [Validation(Required=false)]
        public List<CreateBudgetRequestCycleQuota> CycleQuota { get; set; }
        public class CreateBudgetRequestCycleQuota : TeaModel {
            [NameInMap("CyclePeriod")]
            [Validation(Required=false)]
            public string CyclePeriod { get; set; }

            [NameInMap("Quota")]
            [Validation(Required=false)]
            public string Quota { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01</para>
        /// </summary>
        [NameInMap("CycleStartPeriod")]
        [Validation(Required=false)]
        public string CycleStartPeriod { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MONTHLY</para>
        /// </summary>
        [NameInMap("CycleType")]
        [Validation(Required=false)]
        public string CycleType { get; set; }

        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public List<CreateBudgetRequestEcIdAccountIds> EcIdAccountIds { get; set; }
        public class CreateBudgetRequestEcIdAccountIds : TeaModel {
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<long?> AccountIds { get; set; }

            [NameInMap("EcId")]
            [Validation(Required=false)]
            public string EcId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REQUIRE_AMOUNT</para>
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        [NameInMap("QueryFilter")]
        [Validation(Required=false)]
        public List<CreateBudgetRequestQueryFilter> QueryFilter { get; set; }
        public class CreateBudgetRequestQueryFilter : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>RESOURCE_OWNER_ACCOUNT</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>IN</para>
            /// </summary>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FIXED</para>
        /// </summary>
        [NameInMap("QuotaType")]
        [Validation(Required=false)]
        public string QuotaType { get; set; }

        [NameInMap("WarnConfs")]
        [Validation(Required=false)]
        public List<CreateBudgetRequestWarnConfs> WarnConfs { get; set; }
        public class CreateBudgetRequestWarnConfs : TeaModel {
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EventBridge")]
            [Validation(Required=false)]
            public bool? EventBridge { get; set; }

            [NameInMap("MscChannels")]
            [Validation(Required=false)]
            public List<string> MscChannels { get; set; }

            [NameInMap("MscContacts")]
            [Validation(Required=false)]
            public List<string> MscContacts { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Alter-1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FIXED</para>
            /// </summary>
            [NameInMap("ThresholdType")]
            [Validation(Required=false)]
            public string ThresholdType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("ThresholdValue")]
            [Validation(Required=false)]
            public string ThresholdValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FORECAST</para>
            /// </summary>
            [NameInMap("WarnTarget")]
            [Validation(Required=false)]
            public string WarnTarget { get; set; }

        }

    }

}
