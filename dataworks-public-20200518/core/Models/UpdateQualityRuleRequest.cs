// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateQualityRuleRequest : TeaModel {
        /// <summary>
        /// The strength of the monitoring rule. The strength of a monitoring rule indicates the importance of the rule. Valid values:
        /// 
        /// *   1: The monitoring rule is a strong rule.
        /// *   0: The monitoring rule is a weak rule. You can specify the strength of a monitoring rule based on your business requirements. If a monitoring rule is a strong rule and the critical threshold is exceeded, a critical alert is reported and tasks that are associated with the rule are blocked from running.
        /// </summary>
        [NameInMap("BlockType")]
        [Validation(Required=false)]
        public int? BlockType { get; set; }

        /// <summary>
        /// The checker ID. You can call the [ListQualityRules](https://help.aliyun.com/document_detail/173995.html) operation to obtain the ID of the checker.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Checker")]
        [Validation(Required=false)]
        public int? Checker { get; set; }

        /// <summary>
        /// The description of the monitoring rule.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The threshold for a critical alert. The threshold indicates the deviation of the monitoring result from the expected value. You can specify a custom value for the threshold based on your business requirements. If a monitoring rule is a strong rule and the critical threshold is exceeded, a critical alert is reported and tasks that are associated with the rule are blocked from running.
        /// </summary>
        [NameInMap("CriticalThreshold")]
        [Validation(Required=false)]
        public string CriticalThreshold { get; set; }

        /// <summary>
        /// The ID of the partition filter expression. You can call the [ListQualityRules](https://help.aliyun.com/document_detail/173995.html) operation to obtain the ID of the partition filter expression.
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        /// <summary>
        /// The expected value of the monitoring rule.
        /// </summary>
        [NameInMap("ExpectValue")]
        [Validation(Required=false)]
        public string ExpectValue { get; set; }

        /// <summary>
        /// The monitoring rule ID. You can call the [ListQualityRules](https://help.aliyun.com/document_detail/173995.html) operation to query the ID of the monitoring rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The method that is used to collect sample data, such as avg, count, sum, min, max, count_distinct, user_defined, table_count, table_size, table_dt_load_count, table_dt_refuseload_count, null_value, null_value/table_count, (table_count-count_distinct)/table_count, or table_count-count_distinct.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MethodName")]
        [Validation(Required=false)]
        public string MethodName { get; set; }

        /// <summary>
        /// Specifies whether to enable the monitoring rule in the production environment. Valid values:
        /// 
        /// *   true: The monitoring rule is triggered when the associated auto triggered node that generates the output data starts to run.
        /// *   false: The monitoring rule is not triggered when the associated auto triggered node that generates the output data starts to run.
        /// </summary>
        [NameInMap("OpenSwitch")]
        [Validation(Required=false)]
        public bool? OpenSwitch { get; set; }

        /// <summary>
        /// The comparison operator, such as >, >=, =, ≠, <, or <=.
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// Specifies whether the threshold is a dynamic threshold. Valid values:
        /// 
        /// *   0: The threshold is not a dynamic threshold.
        /// *   2: The threshold is a dynamic threshold.
        /// </summary>
        [NameInMap("PredictType")]
        [Validation(Required=false)]
        public int? PredictType { get; set; }

        /// <summary>
        /// The DataWorks workspace ID.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The name of the compute engine or data source. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace page to obtain the name of the compute engine or data source.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// The name of the field.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Property")]
        [Validation(Required=false)]
        public string Property { get; set; }

        /// <summary>
        /// The data type of the field.
        /// </summary>
        [NameInMap("PropertyType")]
        [Validation(Required=false)]
        public string PropertyType { get; set; }

        /// <summary>
        /// The name of the monitoring rule.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The type of the monitoring rule. Valid values:
        /// 
        /// *   0: The monitoring rule is created by the system.
        /// *   1: The monitoring rule is created by a user.
        /// *   2: The monitoring rule is a workspace-level rule.
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        /// <summary>
        /// The variable settings inserted before the custom rule. Format: x=a,y=b.
        /// </summary>
        [NameInMap("TaskSetting")]
        [Validation(Required=false)]
        public string TaskSetting { get; set; }

        /// <summary>
        /// The ID of the monitoring template. You can call the [ListQualityRules](https://help.aliyun.com/document_detail/173995.html) operation to obtain the ID of the monitoring template.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public int? TemplateId { get; set; }

        /// <summary>
        /// The trend of the monitoring result. Valid values:
        /// 
        /// *   up: increasing
        /// *   down: decreasing
        /// *   abs: absolute value
        /// </summary>
        [NameInMap("Trend")]
        [Validation(Required=false)]
        public string Trend { get; set; }

        /// <summary>
        /// The threshold for a warning alert. The threshold specifies the deviation of the monitoring result from the expected value. You can specify a custom value for the threshold based on your business requirements.
        /// </summary>
        [NameInMap("WarningThreshold")]
        [Validation(Required=false)]
        public string WarningThreshold { get; set; }

        /// <summary>
        /// The filter condition or custom SQL statement that is used for monitoring.
        /// </summary>
        [NameInMap("WhereCondition")]
        [Validation(Required=false)]
        public string WhereCondition { get; set; }

    }

}
