// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListQualityRulesResponseBody : TeaModel {
        /// <summary>
        /// The list of monitoring rules.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListQualityRulesResponseBodyData Data { get; set; }
        public class ListQualityRulesResponseBodyData : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page. Default value: 10. Maximum value: 100.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The details of the monitoring rule.
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<ListQualityRulesResponseBodyDataRules> Rules { get; set; }
            public class ListQualityRulesResponseBodyDataRules : TeaModel {
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
                /// The checker ID.
                /// </summary>
                [NameInMap("CheckerId")]
                [Validation(Required=false)]
                public int? CheckerId { get; set; }

                /// <summary>
                /// The description of the system defense rule.
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
                /// The historical threshold for a critical alert.
                /// </summary>
                [NameInMap("HistoryCriticalThreshold")]
                [Validation(Required=false)]
                public string HistoryCriticalThreshold { get; set; }

                /// <summary>
                /// The historical threshold for a warning alert.
                /// </summary>
                [NameInMap("HistoryWarningThreshold")]
                [Validation(Required=false)]
                public string HistoryWarningThreshold { get; set; }

                /// <summary>
                /// The monitoring rule ID.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The partition filter expression.
                /// </summary>
                [NameInMap("MatchExpression")]
                [Validation(Required=false)]
                public string MatchExpression { get; set; }

                /// <summary>
                /// The ID of the task that is associated with the partition filter expression.
                /// </summary>
                [NameInMap("MethodId")]
                [Validation(Required=false)]
                public int? MethodId { get; set; }

                /// <summary>
                /// The method that is used to collect sample data, such as avg, count, sum, min, max, count_distinct, user_defined, table_count, table_size, table_dt_load_count, table_dt_refuseload_count, null_value, null_value/table_count, (table_count-count_distinct)/table_count, or table_count-count_distinct.
                /// </summary>
                [NameInMap("MethodName")]
                [Validation(Required=false)]
                public string MethodName { get; set; }

                /// <summary>
                /// The name of the Alibaba Cloud account that is used to configure the monitoring rule.
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

                /// <summary>
                /// The name of the compute engine or data source.
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// The name of the field.
                /// </summary>
                [NameInMap("Property")]
                [Validation(Required=false)]
                public string Property { get; set; }

                /// <summary>
                /// The field that is used to associate with monitoring rules at the frontend. This parameter can be ignored.
                /// </summary>
                [NameInMap("PropertyKey")]
                [Validation(Required=false)]
                public string PropertyKey { get; set; }

                /// <summary>
                /// The ID of the task that is associated with the partition filter expression.
                /// </summary>
                [NameInMap("RuleCheckerRelationId")]
                [Validation(Required=false)]
                public long? RuleCheckerRelationId { get; set; }

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
                /// The name of the table.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

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
                /// The threshold for a warning alert. The threshold specifies the deviation of the monitoring result from the expected value. You can specify a custom value for the threshold based on your business requirements.
                /// </summary>
                [NameInMap("WarningThreshold")]
                [Validation(Required=false)]
                public string WarningThreshold { get; set; }

            }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The request ID. You can troubleshoot errors based on the ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
