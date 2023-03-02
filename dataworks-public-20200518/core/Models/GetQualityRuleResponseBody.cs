// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetQualityRuleResponseBody : TeaModel {
        /// <summary>
        /// The information of the monitoring rule.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQualityRuleResponseBodyData Data { get; set; }
        public class GetQualityRuleResponseBodyData : TeaModel {
            /// <summary>
            /// The strength of the monitoring rule. The strength of a monitoring rule indicates the importance of the rule. Valid values:
            /// 
            /// *   1: indicates that the monitoring rule is a strong rule.
            /// 
            /// *   0: indicates that the monitoring rule is a weak rule.
            /// 
            ///     You can specify whether a monitoring rule is a strong rule based on your business requirements. If a strong rule is used and an error alert is triggered, nodes are blocked.
            /// </summary>
            [NameInMap("BlockType")]
            [Validation(Required=false)]
            public int? BlockType { get; set; }

            /// <summary>
            /// The ID of the checker. The value of this parameter corresponds to the ID at the frontend and is converted from the ID of the primary key.
            /// </summary>
            [NameInMap("Checker")]
            [Validation(Required=false)]
            public int? Checker { get; set; }

            /// <summary>
            /// The name of the checker.
            /// </summary>
            [NameInMap("CheckerName")]
            [Validation(Required=false)]
            public string CheckerName { get; set; }

            /// <summary>
            /// The description of the monitoring rule.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The threshold for an error alert. The threshold indicates the deviation of the monitoring result from the expected value. You can customize this threshold based on your business requirements. If a strong rule is used and an error alert is triggered, nodes are blocked.
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
            /// The expected value.
            /// </summary>
            [NameInMap("ExpectValue")]
            [Validation(Required=false)]
            public string ExpectValue { get; set; }

            /// <summary>
            /// Indicates whether the monitoring is performed based on a fixed value.
            /// </summary>
            [NameInMap("FixCheck")]
            [Validation(Required=false)]
            public bool? FixCheck { get; set; }

            /// <summary>
            /// The ID of the monitoring rule.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The ID of the sampling method of the monitoring rule.
            /// </summary>
            [NameInMap("MethodId")]
            [Validation(Required=false)]
            public int? MethodId { get; set; }

            /// <summary>
            /// The name of the method that is used to collect sample data, such as avg, count, sum, min, max, count_distinct, user_defined, table_count, table_size, table_dt_load_count, table_dt_refuseload_count, null_value, null_value/table_count, (table_count-count_distinct)/table_count, or table_count-count_distinct.
            /// </summary>
            [NameInMap("MethodName")]
            [Validation(Required=false)]
            public string MethodName { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that is used to configure the monitoring rule.
            /// </summary>
            [NameInMap("OnDuty")]
            [Validation(Required=false)]
            public string OnDuty { get; set; }

            /// <summary>
            /// The name of the Alibaba Cloud account that is used to configure the monitoring rule.
            /// </summary>
            [NameInMap("OnDutyAccountName")]
            [Validation(Required=false)]
            public string OnDutyAccountName { get; set; }

            [NameInMap("OpenSwitch")]
            [Validation(Required=false)]
            public bool? OpenSwitch { get; set; }

            /// <summary>
            /// The comparison operator of the monitoring rule.
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// Indicates whether the threshold is a dynamic threshold. Valid values:
            /// 
            /// *   0: The threshold is not a dynamic threshold.
            /// *   1: The threshold is a dynamic threshold.
            /// </summary>
            [NameInMap("PredictType")]
            [Validation(Required=false)]
            public int? PredictType { get; set; }

            /// <summary>
            /// The field that is monitored. This field is a column name in the data source table that is monitored.
            /// </summary>
            [NameInMap("Property")]
            [Validation(Required=false)]
            public string Property { get; set; }

            /// <summary>
            /// The name of the monitoring rule.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The type of the monitoring rule.
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public int? RuleType { get; set; }

            /// <summary>
            /// The ID of the monitoring template.
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public int? TemplateId { get; set; }

            /// <summary>
            /// The name of the monitoring template.
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// The trend of the monitoring result.
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
            /// The filter condition or custom SQL statement that is used for monitoring.
            /// </summary>
            [NameInMap("WhereCondition")]
            [Validation(Required=false)]
            public string WhereCondition { get; set; }

        }

        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
