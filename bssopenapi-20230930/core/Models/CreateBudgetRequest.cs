// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class CreateBudgetRequest : TeaModel {
        /// <summary>
        /// <para>The budget name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Department_dev_budget</para>
        /// </summary>
        [NameInMap("BudgetName")]
        [Validation(Required=false)]
        public string BudgetName { get; set; }

        /// <summary>
        /// <para>The budget type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CONSUME</para>
        /// </summary>
        [NameInMap("BudgetType")]
        [Validation(Required=false)]
        public string BudgetType { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The end cycle.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-12</para>
        /// </summary>
        [NameInMap("CycleEndPeriod")]
        [Validation(Required=false)]
        public string CycleEndPeriod { get; set; }

        /// <summary>
        /// <para>The per-cycle specified quota. This parameter is required when QuotaType is set to <c>SPECIFY</c>.</para>
        /// </summary>
        [NameInMap("CycleQuota")]
        [Validation(Required=false)]
        public List<CreateBudgetRequestCycleQuota> CycleQuota { get; set; }
        public class CreateBudgetRequestCycleQuota : TeaModel {
            /// <summary>
            /// <para>The cycle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01</para>
            /// </summary>
            [NameInMap("CyclePeriod")]
            [Validation(Required=false)]
            public string CyclePeriod { get; set; }

            /// <summary>
            /// <para>The quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Quota")]
            [Validation(Required=false)]
            public string Quota { get; set; }

        }

        /// <summary>
        /// <para>The start cycle.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01</para>
        /// </summary>
        [NameInMap("CycleStartPeriod")]
        [Validation(Required=false)]
        public string CycleStartPeriod { get; set; }

        /// <summary>
        /// <para>The cycle type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MONTHLY</para>
        /// </summary>
        [NameInMap("CycleType")]
        [Validation(Required=false)]
        public string CycleType { get; set; }

        /// <summary>
        /// <para>The list of enterprises and accounts. An empty value indicates the current account.</para>
        /// </summary>
        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public List<CreateBudgetRequestEcIdAccountIds> EcIdAccountIds { get; set; }
        public class CreateBudgetRequestEcIdAccountIds : TeaModel {
            /// <summary>
            /// <para>The list of accounts to access. An empty value indicates all accounts under the current entity ID.</para>
            /// </summary>
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<long?> AccountIds { get; set; }

            /// <summary>
            /// <para>The enterprise entity ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EcId")]
            [Validation(Required=false)]
            public string EcId { get; set; }

        }

        /// <summary>
        /// <para>The budget metric.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REQUIRE_AMOUNT</para>
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The level-1 marketplace ID. If empty, the marketplace ID of the current user is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>26842</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("QueryFilter")]
        [Validation(Required=false)]
        public List<CreateBudgetRequestQueryFilter> QueryFilter { get; set; }
        public class CreateBudgetRequestQueryFilter : TeaModel {
            /// <summary>
            /// <para>The parameter code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RESOURCE_OWNER_ACCOUNT</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The selection mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IN</para>
            /// </summary>
            [NameInMap("SelectType")]
            [Validation(Required=false)]
            public string SelectType { get; set; }

            /// <summary>
            /// <para>The list of filter values.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>The fixed quota value. If the type is quota, the unit is percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public string Quota { get; set; }

        /// <summary>
        /// <para>The quota type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FIXED</para>
        /// </summary>
        [NameInMap("QuotaType")]
        [Validation(Required=false)]
        public string QuotaType { get; set; }

        /// <summary>
        /// <para>The alert configurations.</para>
        /// </summary>
        [NameInMap("WarnConfs")]
        [Validation(Required=false)]
        public List<CreateBudgetRequestWarnConfs> WarnConfs { get; set; }
        public class CreateBudgetRequestWarnConfs : TeaModel {
            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable EventBridge.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EventBridge")]
            [Validation(Required=false)]
            public bool? EventBridge { get; set; }

            /// <summary>
            /// <para>The list of Message Center notification channels.</para>
            /// </summary>
            [NameInMap("MscChannels")]
            [Validation(Required=false)]
            public List<string> MscChannels { get; set; }

            /// <summary>
            /// <para>The list of Message Center contacts.</para>
            /// </summary>
            [NameInMap("MscContacts")]
            [Validation(Required=false)]
            public List<string> MscContacts { get; set; }

            /// <summary>
            /// <para>The alert name. This is a user-defined optional field. If not specified, the backend automatically generates a name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alter-1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The threshold type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FIXED</para>
            /// </summary>
            [NameInMap("ThresholdType")]
            [Validation(Required=false)]
            public string ThresholdType { get; set; }

            /// <summary>
            /// <para>The threshold value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("ThresholdValue")]
            [Validation(Required=false)]
            public string ThresholdValue { get; set; }

            /// <summary>
            /// <para>The alert target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FORECAST</para>
            /// </summary>
            [NameInMap("WarnTarget")]
            [Validation(Required=false)]
            public string WarnTarget { get; set; }

        }

    }

}
