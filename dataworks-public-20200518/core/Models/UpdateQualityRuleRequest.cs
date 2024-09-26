// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateQualityRuleRequest : TeaModel {
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
        /// <para>The checker ID. You can call the <a href="https://help.aliyun.com/document_detail/173995.html">ListQualityRules</a> operation to obtain the ID of the checker.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("Checker")]
        [Validation(Required=false)]
        public int? Checker { get; set; }

        /// <summary>
        /// <para>The description of the monitoring rule.</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The threshold for a critical alert. The threshold indicates the deviation of the monitoring result from the expected value. You can specify a custom value for the threshold based on your business requirements. If a monitoring rule is a strong rule and the critical threshold is exceeded, a critical alert is reported and tasks that are associated with the rule are blocked from running.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CriticalThreshold")]
        [Validation(Required=false)]
        public string CriticalThreshold { get; set; }

        /// <summary>
        /// <para>The ID of the partition filter expression. You can call the <a href="https://help.aliyun.com/document_detail/173995.html">ListQualityRules</a> operation to obtain the ID of the partition filter expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        /// <summary>
        /// <para>The expected value of the monitoring rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("ExpectValue")]
        [Validation(Required=false)]
        public string ExpectValue { get; set; }

        /// <summary>
        /// <para>The monitoring rule ID. You can call the <a href="https://help.aliyun.com/document_detail/173995.html">ListQualityRules</a> operation to query the ID of the monitoring rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The method that is used to collect sample data, such as avg, count, sum, min, max, count_distinct, user_defined, table_count, table_size, table_dt_load_count, table_dt_refuseload_count, null_value, null_value/table_count, (table_count-count_distinct)/table_count, or table_count-count_distinct.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table_count</para>
        /// </summary>
        [NameInMap("MethodName")]
        [Validation(Required=false)]
        public string MethodName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the monitoring rule in the production environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The monitoring rule is triggered when the associated auto triggered node that generates the output data starts to run.</description></item>
        /// <item><description>false: The monitoring rule is not triggered when the associated auto triggered node that generates the output data starts to run.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("OpenSwitch")]
        [Validation(Required=false)]
        public bool? OpenSwitch { get; set; }

        /// <summary>
        /// <para>The comparison operator, such as &gt;, &gt;=, =, ≠, &lt;, or &lt;=.</para>
        /// 
        /// <b>Example:</b>
        /// <remarks>
        /// </remarks>
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>Specifies whether the threshold is a dynamic threshold. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The threshold is not a dynamic threshold.</description></item>
        /// <item><description>2: The threshold is a dynamic threshold.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PredictType")]
        [Validation(Required=false)]
        public int? PredictType { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>26</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the compute engine or data source. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to obtain the name of the compute engine or data source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>autotest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The name of the field.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id</para>
        /// </summary>
        [NameInMap("Property")]
        [Validation(Required=false)]
        public string Property { get; set; }

        /// <summary>
        /// <para>The data type of the field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bigint</para>
        /// </summary>
        [NameInMap("PropertyType")]
        [Validation(Required=false)]
        public string PropertyType { get; set; }

        /// <summary>
        /// <para>The name of the monitoring rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
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
        /// <para>The variable settings inserted before the custom rule. Format: x=a,y=b.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x=a,y=b</para>
        /// </summary>
        [NameInMap("TaskSetting")]
        [Validation(Required=false)]
        public string TaskSetting { get; set; }

        /// <summary>
        /// <para>The ID of the monitoring template. You can call the <a href="https://help.aliyun.com/document_detail/173995.html">ListQualityRules</a> operation to obtain the ID of the monitoring template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public int? TemplateId { get; set; }

        /// <summary>
        /// <para>The trend of the monitoring result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>up: increasing</description></item>
        /// <item><description>down: decreasing</description></item>
        /// <item><description>abs: absolute value</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>up</para>
        /// </summary>
        [NameInMap("Trend")]
        [Validation(Required=false)]
        public string Trend { get; set; }

        /// <summary>
        /// <para>The threshold for a warning alert. The threshold specifies the deviation of the monitoring result from the expected value. You can specify a custom value for the threshold based on your business requirements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("WarningThreshold")]
        [Validation(Required=false)]
        public string WarningThreshold { get; set; }

        /// <summary>
        /// <para>The filter condition or custom SQL statement that is used for monitoring.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dt=$[yyyymmdd]</para>
        /// </summary>
        [NameInMap("WhereCondition")]
        [Validation(Required=false)]
        public string WhereCondition { get; set; }

    }

}
