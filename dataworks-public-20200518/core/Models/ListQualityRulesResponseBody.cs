// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListQualityRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of rules.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListQualityRulesResponseBodyData Data { get; set; }
        public class ListQualityRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned on each page. Default value: 10. Maximum value: 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The details of the quality rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<ListQualityRulesResponseBodyDataRules> Rules { get; set; }
            public class ListQualityRulesResponseBodyDataRules : TeaModel {
                /// <summary>
                /// <para>The severity of the quality rule, which indicates the importance of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Strong rule.</description></item>
                /// <item><description>0: Weak rule.
                /// You can set important rules as strong rules based on your business requirements. If a strong rule is triggered and a red alert is generated, the scheduled task is blocked.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BlockType")]
                [Validation(Required=false)]
                public int? BlockType { get; set; }

                /// <summary>
                /// <para>The ID of the checker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("CheckerId")]
                [Validation(Required=false)]
                public int? CheckerId { get; set; }

                /// <summary>
                /// <para>The description of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Verify table rules</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The alert threshold for red alerting. This value indicates the deviation from the expected value of the sample. You can customize this threshold based on your business requirements. If a strong rule is triggered and the red alert threshold is reached, the scheduled task is blocked.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("CriticalThreshold")]
                [Validation(Required=false)]
                public string CriticalThreshold { get; set; }

                /// <summary>
                /// <para>The ID of the partition expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public long? EntityId { get; set; }

                /// <summary>
                /// <para>The expected value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("ExpectValue")]
                [Validation(Required=false)]
                public string ExpectValue { get; set; }

                /// <summary>
                /// <para>The fixed value check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FixCheck")]
                [Validation(Required=false)]
                public bool? FixCheck { get; set; }

                /// <summary>
                /// <para>The historical alert threshold for red alerting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>history max:80%,history min:50%</para>
                /// </summary>
                [NameInMap("HistoryCriticalThreshold")]
                [Validation(Required=false)]
                public string HistoryCriticalThreshold { get; set; }

                /// <summary>
                /// <para>The historical alert threshold for orange alerting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>history max:40%,history min:10%</para>
                /// </summary>
                [NameInMap("HistoryWarningThreshold")]
                [Validation(Required=false)]
                public string HistoryWarningThreshold { get; set; }

                /// <summary>
                /// <para>The ID of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The partition expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dt=$[yyyymmdd]</para>
                /// </summary>
                [NameInMap("MatchExpression")]
                [Validation(Required=false)]
                public string MatchExpression { get; set; }

                /// <summary>
                /// <para>The ID of the method used to collect sample data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>21</para>
                /// </summary>
                [NameInMap("MethodId")]
                [Validation(Required=false)]
                public int? MethodId { get; set; }

                /// <summary>
                /// <para>The name of the method used to collect sample data. Valid values include avg, count, sum, min, max, count_distinct, user_defined, table_count, table_size, table_dt_load_count, table_dt_refuseload_count, null_value, null_value/table_count, (table_count-count_distinct)/table_count, and table_count-count_distinct.</para>
                /// 
                /// <b>Example:</b>
                /// <para>count/table_count</para>
                /// </summary>
                [NameInMap("MethodName")]
                [Validation(Required=false)]
                public string MethodName { get; set; }

                /// <summary>
                /// <para>The ID of the account that configured the quality rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1912****</para>
                /// </summary>
                [NameInMap("OnDuty")]
                [Validation(Required=false)]
                public string OnDuty { get; set; }

                /// <summary>
                /// <para>The name of the Alibaba Cloud account that configured the quality rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("OnDutyAccountName")]
                [Validation(Required=false)]
                public string OnDutyAccountName { get; set; }

                /// <summary>
                /// <para>The name of the engine or data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>autotest</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The name of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>id</para>
                /// </summary>
                [NameInMap("Property")]
                [Validation(Required=false)]
                public string Property { get; set; }

                /// <summary>
                /// <para>The property key used for frontend rule linkage in data quality. You can ignore this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table_count</para>
                /// </summary>
                [NameInMap("PropertyKey")]
                [Validation(Required=false)]
                public string PropertyKey { get; set; }

                /// <summary>
                /// <para>The internal association ID of the rule details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>132323</para>
                /// </summary>
                [NameInMap("RuleCheckerRelationId")]
                [Validation(Required=false)]
                public long? RuleCheckerRelationId { get; set; }

                /// <summary>
                /// <para>The name of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The type of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: System template rule.</description></item>
                /// <item><description>1: Custom SQL rule.</description></item>
                /// <item><description>4: Custom template rule.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public int? RuleType { get; set; }

                /// <summary>
                /// <para>The name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dual</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The ID of the quality rule template used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public int? TemplateId { get; set; }

                /// <summary>
                /// <para>The name of the quality rule template used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Number of SQL task table rows, 1, 7, and 30 days wave detection</para>
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
                /// <para>The alert threshold for orange alerting. This value indicates the deviation from the expected value of the sample. You can customize this threshold based on your business requirements.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("WarningThreshold")]
                [Validation(Required=false)]
                public string WarningThreshold { get; set; }

            }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ConnectionNotExists</para>
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
        /// <para>The request ID, which is used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38cbdef0-f6cf-49****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Specifies whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
