// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetQualityRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The quality rule details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQualityRuleResponseBodyData Data { get; set; }
        public class GetQualityRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The severity of the quality rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>1</c>: Strong Rule. If a Strong Rule triggers a critical Alert, the associated Scheduling Task is blocked.</para>
            /// </description></item>
            /// <item><description><para><c>0</c>: Weak Rule.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BlockType")]
            [Validation(Required=false)]
            public int? BlockType { get; set; }

            /// <summary>
            /// <para>The checker ID, which is derived from a primary key and used for front-end identification.</para>
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
            /// <para>The comment for the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Verify that the primary key is unique</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The threshold for a critical Alert, which defines the maximum acceptable deviation from the Expected Value. If this threshold is met for a Strong Rule, the associated Scheduling Task is blocked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("CriticalThreshold")]
            [Validation(Required=false)]
            public string CriticalThreshold { get; set; }

            /// <summary>
            /// <para>The ID of the partition expression.</para>
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
            /// <para>Indicates whether to validate against a fixed value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FixCheck")]
            [Validation(Required=false)]
            public bool? FixCheck { get; set; }

            /// <summary>
            /// <para>The ID of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123232</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The ID of the method used to collect sample data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("MethodId")]
            [Validation(Required=false)]
            public int? MethodId { get; set; }

            /// <summary>
            /// <para>The name of the method used to collect sample data. Valid values include <c>avg</c>, <c>count</c>, <c>sum</c>, <c>min</c>, <c>max</c>, <c>count_distinct</c>, <c>user_defined</c>, <c>table_count</c>, <c>table_size</c>, <c>table_dt_load_count</c>, <c>table_dt_refuseload_count</c>, <c>null_value</c>, <c>null_value/table_count</c>, <c>(table_count-count_distinct)/table_count</c>, and <c>table_count-count_distinct</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table_count</para>
            /// </summary>
            [NameInMap("MethodName")]
            [Validation(Required=false)]
            public string MethodName { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that configured the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1822931****</para>
            /// </summary>
            [NameInMap("OnDuty")]
            [Validation(Required=false)]
            public string OnDuty { get; set; }

            /// <summary>
            /// <para>The name of the Alibaba Cloud account that configured the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("OnDutyAccountName")]
            [Validation(Required=false)]
            public string OnDutyAccountName { get; set; }

            /// <summary>
            /// <para>Indicates whether the rule is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OpenSwitch")]
            [Validation(Required=false)]
            public bool? OpenSwitch { get; set; }

            /// <summary>
            /// <para>The comparison operator.</para>
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
            /// <para>Indicates whether the threshold is dynamic. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>0</c>: The threshold is static.</para>
            /// </description></item>
            /// <item><description><para><c>1</c>: The threshold is dynamic.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PredictType")]
            [Validation(Required=false)]
            public int? PredictType { get; set; }

            /// <summary>
            /// <para>The column in the data source table to which the rule applies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("Property")]
            [Validation(Required=false)]
            public string Property { get; set; }

            /// <summary>
            /// <para>The name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>View table fluctuations</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The type of the quality rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>0</c>: A rule based on a system template.</para>
            /// </description></item>
            /// <item><description><para><c>1</c>: A rule based on a custom SQL statement.</para>
            /// </description></item>
            /// <item><description><para><c>4</c>: A rule based on a custom template.</para>
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
            /// <para>The variable settings inserted before a custom rule. The format is x=a,y=b.</para>
            /// 
            /// <b>Example:</b>
            /// <para>x=a,y=b</para>
            /// </summary>
            [NameInMap("TaskSetting")]
            [Validation(Required=false)]
            public string TaskSetting { get; set; }

            /// <summary>
            /// <para>The ID of the template used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public int? TemplateId { get; set; }

            /// <summary>
            /// <para>The name of the template used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SQL task table rows, 1,7, 30 days fluctuation test</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The trend of the validation result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abs</para>
            /// </summary>
            [NameInMap("Trend")]
            [Validation(Required=false)]
            public string Trend { get; set; }

            /// <summary>
            /// <para>The threshold for a warning Alert. This value specifies the acceptable deviation from the Expected Value and can be customized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("WarningThreshold")]
            [Validation(Required=false)]
            public string WarningThreshold { get; set; }

            /// <summary>
            /// <para>The filter condition or custom SQL statement used for validation.</para>
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
