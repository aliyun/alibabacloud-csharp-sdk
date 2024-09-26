// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetQualityRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the monitoring rule.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQualityRuleResponseBodyData Data { get; set; }
        public class GetQualityRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The strength of the monitoring rule. The strength of a monitoring rule indicates the importance of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: the monitoring rule is a strong rule.</description></item>
            /// <item><description>0: the monitoring rule is a weak rule. You can specify whether a monitoring rule is a strong rule based on your business requirements. If a monitoring rule is a strong rule and the critical threshold is exceeded, a critical alert is reported and tasks that are associated with the rule are blocked from running.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BlockType")]
            [Validation(Required=false)]
            public int? BlockType { get; set; }

            /// <summary>
            /// <para>The checker ID. The value of this parameter corresponds to the ID at the frontend and is converted from the ID of the primary key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("Checker")]
            [Validation(Required=false)]
            public int? Checker { get; set; }

            /// <summary>
            /// <para>The name of the checker.</para>
            /// 
            /// <b>Example:</b>
            /// <para>compared with a fixed value</para>
            /// </summary>
            [NameInMap("CheckerName")]
            [Validation(Required=false)]
            public string CheckerName { get; set; }

            /// <summary>
            /// <para>The description of the monitoring rule.</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The threshold for a critical alert. The threshold indicates the deviation of the check result from the expected value. You can specify a value for the threshold based on your business requirements. If a monitoring rule is a strong rule and the critical threshold is exceeded, a critical alert is reported and tasks that are associated with the rule are blocked from running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("CriticalThreshold")]
            [Validation(Required=false)]
            public string CriticalThreshold { get; set; }

            /// <summary>
            /// <para>The ID of the partition filter expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>165523</para>
            /// </summary>
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public long? EntityId { get; set; }

            /// <summary>
            /// <para>The expected value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("ExpectValue")]
            [Validation(Required=false)]
            public string ExpectValue { get; set; }

            /// <summary>
            /// <para>Indicates whether the monitoring is performed based on a fixed value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FixCheck")]
            [Validation(Required=false)]
            public bool? FixCheck { get; set; }

            /// <summary>
            /// <para>The monitoring rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123232</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The ID of the task that is associated with the partition filter expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("MethodId")]
            [Validation(Required=false)]
            public int? MethodId { get; set; }

            /// <summary>
            /// <para>The method that is used to collect sample data, such as avg, count, sum, min, max, count_distinct, user_defined, table_count, table_size, table_dt_load_count, table_dt_refuseload_count, null_value, null_value/table_count, (table_count-count_distinct)/table_count, or table_count-count_distinct.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table_count</para>
            /// </summary>
            [NameInMap("MethodName")]
            [Validation(Required=false)]
            public string MethodName { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that is used to configure the monitoring rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1822931****</para>
            /// </summary>
            [NameInMap("OnDuty")]
            [Validation(Required=false)]
            public string OnDuty { get; set; }

            /// <summary>
            /// <para>The name of the Alibaba Cloud account that is used to configure the monitoring rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("OnDutyAccountName")]
            [Validation(Required=false)]
            public string OnDutyAccountName { get; set; }

            /// <summary>
            /// <para>Indicates whether the monitoring rule is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OpenSwitch")]
            [Validation(Required=false)]
            public bool? OpenSwitch { get; set; }

            /// <summary>
            /// <para>The comparison operator of the monitoring rule.</para>
            /// 
            /// <b>Example:</b>
            /// <remarks>
            /// <para>=</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>Indicates whether the threshold is a dynamic threshold. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The threshold is not a dynamic threshold.</description></item>
            /// <item><description>1: The threshold is a dynamic threshold.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PredictType")]
            [Validation(Required=false)]
            public int? PredictType { get; set; }

            /// <summary>
            /// <para>The field whose data quality is checked based on the monitoring rule. This field is a column in the data source table that is monitored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("Property")]
            [Validation(Required=false)]
            public string Property { get; set; }

            /// <summary>
            /// <para>The name of the monitoring rule.</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The type of the monitoring rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public int? RuleType { get; set; }

            [NameInMap("TaskSetting")]
            [Validation(Required=false)]
            public string TaskSetting { get; set; }

            /// <summary>
            /// <para>The ID of the monitoring template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public int? TemplateId { get; set; }

            /// <summary>
            /// <para>The name of the monitoring template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SQL task table rows, 1,7, 30 days fluctuation test</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The trend of the check result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abs</para>
            /// </summary>
            [NameInMap("Trend")]
            [Validation(Required=false)]
            public string Trend { get; set; }

            /// <summary>
            /// <para>The threshold for a warning alert. The threshold indicates the deviation of the check result from the expected value. You can customize this threshold based on your business requirements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("WarningThreshold")]
            [Validation(Required=false)]
            public string WarningThreshold { get; set; }

            /// <summary>
            /// <para>The filter condition or custom SQL statement that is used for monitoring.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id&gt;10</para>
            /// </summary>
            [NameInMap("WhereCondition")]
            [Validation(Required=false)]
            public string WhereCondition { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>401</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You have no permission.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>576b9457-2cf5-4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
