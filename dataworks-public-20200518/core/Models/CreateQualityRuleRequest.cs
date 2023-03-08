// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateQualityRuleRequest : TeaModel {
        /// <summary>
        /// The strength of the monitoring rule. Valid values: 0 and 1. 0 indicates that the monitoring rule is a weak rule. 1 indicates that the monitoring rule is a strong rule.
        /// </summary>
        [NameInMap("BlockType")]
        [Validation(Required=false)]
        public int? BlockType { get; set; }

        /// <summary>
        /// The ID of the checker.
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
        /// The threshold for a critical alert. The threshold indicates the deviation of the monitoring result from the expected value. You can customize this threshold based on your business requirements. If a strong rule is used and a critical alert is reported, nodes are blocked.
        /// </summary>
        [NameInMap("CriticalThreshold")]
        [Validation(Required=false)]
        public string CriticalThreshold { get; set; }

        /// <summary>
        /// The ID of the partition filter expression.
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        /// <summary>
        /// The expected value of the monitoring result.
        /// </summary>
        [NameInMap("ExpectValue")]
        [Validation(Required=false)]
        public string ExpectValue { get; set; }

        /// <summary>
        /// The method used to collect sample data. If you want to use a custom SQL statement as a sampling method, set this parameter to user_defined.
        /// </summary>
        [NameInMap("MethodName")]
        [Validation(Required=false)]
        public string MethodName { get; set; }

        /// <summary>
        /// The comparison operator of the monitoring rule.
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// Specifies whether the monitoring rule is a dynamic threshold rule. Valid values: 0 and 2. 0 indicates that the monitoring rule is not a dynamic threshold rule. 2 indicates that the monitoring rule is a dynamic threshold rule.
        /// </summary>
        [NameInMap("PredictType")]
        [Validation(Required=false)]
        public int? PredictType { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The name of the compute engine instance or data source.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// The fields that you want to monitor. If you want to monitor all fields in a table and check the table rows, set this parameter to table_count. If you want to monitor all fields in a table and check the table size, set this parameter to table_size.
        /// </summary>
        [NameInMap("Property")]
        [Validation(Required=false)]
        public string Property { get; set; }

        /// <summary>
        /// The data type of the fields that you want to monitor. If you want to monitor all fields in a table, set this parameter to table. If you want to monitor only a specific field, set this parameter to bigint.
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
        /// The type of the monitoring rule. Valid values: 0, 1, and 2. 0 indicates that the monitoring rule is created by the system. 1 indicates that the monitoring rule is created by a user. 2 indicates that the monitoring rule is a workspace-level rule.
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        /// <summary>
        /// The ID of the template that is used to create the monitoring rule.
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
        /// The threshold for a warning alert. The threshold indicates the deviation of the monitoring result from the expected value. You can customize this threshold based on your business requirements.
        /// </summary>
        [NameInMap("WarningThreshold")]
        [Validation(Required=false)]
        public string WarningThreshold { get; set; }

        /// <summary>
        /// The filter condition or custom SQL statement.
        /// </summary>
        [NameInMap("WhereCondition")]
        [Validation(Required=false)]
        public string WhereCondition { get; set; }

    }

}
