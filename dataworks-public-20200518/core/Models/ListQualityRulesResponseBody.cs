// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListQualityRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of monitoring rules.</para>
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
            /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The details of the monitoring rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<ListQualityRulesResponseBodyDataRules> Rules { get; set; }
            public class ListQualityRulesResponseBodyDataRules : TeaModel {
                /// <summary>
                /// <para>The strength of the monitoring rule. The strength of a monitoring rule indicates the importance of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: The monitoring rule is a strong rule.</description></item>
                /// <item><description>0: The monitoring rule is a weak rule. You can specify the strength of a monitoring rule based on your business requirements. If a monitoring rule is a strong rule and the critical threshold is exceeded, a critical alert is reported and tasks that are associated with the rule are blocked from running.</description></item>
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
                /// <para>The threshold for a critical alert. The threshold indicates the deviation of the monitoring result from the expected value. You can specify a custom value for the threshold based on your business requirements. If a monitoring rule is a strong rule and the critical threshold is exceeded, a critical alert is reported and tasks that are associated with the rule are blocked from running.</para>
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
                /// <para>Indicates whether the monitoring is performed based on a fixed value.</para>
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
                /// <para>The monitoring rule ID.</para>
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
                /// <para>The ID of the task that is associated with the partition filter expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>21</para>
                /// </summary>
                [NameInMap("MethodId")]
                [Validation(Required=false)]
                public int? MethodId { get; set; }

                /// <summary>
                /// <para>The method that is used to collect sample data, such as avg, count, sum, min, max, count_distinct, user_defined, table_count, table_size, table_dt_load_count, table_dt_refuseload_count, null_value, null_value/table_count, (table_count-count_distinct)/table_count, or table_count-count_distinct.</para>
                /// 
                /// <b>Example:</b>
                /// <para>count/table_count</para>
                /// </summary>
                [NameInMap("MethodName")]
                [Validation(Required=false)]
                public string MethodName { get; set; }

                /// <summary>
                /// <para>The name of the Alibaba Cloud account that is used to configure the monitoring rule.</para>
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
                /// <para>The field that is used to associate with monitoring rules at the frontend. This parameter can be ignored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table_count</para>
                /// </summary>
                [NameInMap("PropertyKey")]
                [Validation(Required=false)]
                public string PropertyKey { get; set; }

                /// <summary>
                /// <para>The ID of the task that is associated with the partition filter expression.</para>
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
                /// <item><description>0: The monitoring rule is created by the system.</description></item>
                /// <item><description>1: The monitoring rule is created by a user.</description></item>
                /// <item><description>2: The monitoring rule is a workspace-level rule.</description></item>
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
                /// <para>The threshold for a warning alert. The threshold specifies the deviation of the monitoring result from the expected value. You can specify a custom value for the threshold based on your business requirements.</para>
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
        /// <para>The request ID. You can troubleshoot errors based on the ID.</para>
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
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
