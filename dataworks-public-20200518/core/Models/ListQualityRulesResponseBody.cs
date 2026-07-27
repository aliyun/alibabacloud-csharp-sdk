// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListQualityRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The paginated list of quality rules.</para>
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
            /// <para>The number of entries per page. A valid value is 1 to 100. Default value: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The details of the quality rule.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<ListQualityRulesResponseBodyDataRules> Rules { get; set; }
            public class ListQualityRulesResponseBodyDataRules : TeaModel {
                /// <summary>
                /// <para>The strength of the monitoring rule. The strength of a monitoring rule indicates the importance of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>1</c>: The monitoring rule is a strong rule.</para>
                /// </description></item>
                /// <item><description><para><c>0</c>: The monitoring rule is a weak rule.
                /// You can specify a monitoring rule as a strong rule based on your business requirements. If a strong rule is triggered, a critical alert is reported and the scheduling of the task is blocked.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BlockType")]
                [Validation(Required=false)]
                public int? BlockType { get; set; }

                /// <summary>
                /// <para>The checker ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("CheckerId")]
                [Validation(Required=false)]
                public int? CheckerId { get; set; }

                /// <summary>
                /// <para>The description of the monitoring rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Verify table rules</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The threshold for a critical alert. The threshold specifies the deviation of a monitoring result from the expected value. You can customize the threshold based on your business requirements. If a strong rule is used and a critical alert is triggered, the scheduling of the task is blocked.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("CriticalThreshold")]
                [Validation(Required=false)]
                public string CriticalThreshold { get; set; }

                /// <summary>
                /// <para>The ID of the partition filter expression.</para>
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
                /// <para>Indicates whether a fixed value is used for the check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FixCheck")]
                [Validation(Required=false)]
                public bool? FixCheck { get; set; }

                /// <summary>
                /// <para>The historical threshold for a critical alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>history max:80%,history min:50%</para>
                /// </summary>
                [NameInMap("HistoryCriticalThreshold")]
                [Validation(Required=false)]
                public string HistoryCriticalThreshold { get; set; }

                /// <summary>
                /// <para>The historical threshold for a warning alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>history max:40%,history min:10%</para>
                /// </summary>
                [NameInMap("HistoryWarningThreshold")]
                [Validation(Required=false)]
                public string HistoryWarningThreshold { get; set; }

                /// <summary>
                /// <para>The ID of the monitoring rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The partition filter expression.</para>
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
                /// <para>The name of the method used to collect sample data, such as <c>avg</c>, <c>count</c>, <c>sum</c>, <c>min</c>, <c>max</c>, <c>count_distinct</c>, <c>user_defined</c>, <c>table_count</c>, <c>table_size</c>, <c>table_dt_load_count</c>, <c>table_dt_refuseload_count</c>, <c>null_value</c>, <c>null_value/table_count</c>, <c>(table_count-count_distinct)/table_count</c>, or <c>table_count-count_distinct</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>count/table_count</para>
                /// </summary>
                [NameInMap("MethodName")]
                [Validation(Required=false)]
                public string MethodName { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account that is used to configure the monitoring rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1912****</para>
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
                /// <para>The name of the compute engine or data source.</para>
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
                /// <para>This parameter is not used. You can ignore this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table_count</para>
                /// </summary>
                [NameInMap("PropertyKey")]
                [Validation(Required=false)]
                public string PropertyKey { get; set; }

                /// <summary>
                /// <para>The internal association ID for the rule details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>132323</para>
                /// </summary>
                [NameInMap("RuleCheckerRelationId")]
                [Validation(Required=false)]
                public long? RuleCheckerRelationId { get; set; }

                /// <summary>
                /// <para>The name of the monitoring rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The type of the monitoring rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>0</c>: The monitoring rule is created by the system.</para>
                /// </description></item>
                /// <item><description><para><c>1</c>: The monitoring rule is created by a user.</para>
                /// </description></item>
                /// <item><description><para><c>2</c>: The monitoring rule is a workspace-level rule.</para>
                /// </description></item>
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
                /// <para>Number of SQL task table rows, 1, 7, and 30 days wave detection</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// <para>The trend of the monitoring result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abs</para>
                /// </summary>
                [NameInMap("Trend")]
                [Validation(Required=false)]
                public string Trend { get; set; }

                /// <summary>
                /// <para>The threshold for a warning alert. The threshold specifies the deviation of a monitoring result from the expected value. You can customize the threshold based on your business requirements.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("WarningThreshold")]
                [Validation(Required=false)]
                public string WarningThreshold { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38cbdef0-f6cf-49****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
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
