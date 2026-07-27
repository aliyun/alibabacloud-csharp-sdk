// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateQualityRuleRequest : TeaModel {
        /// <summary>
        /// <para>The strength of the quality rule. You can specify a rule as a strong or weak rule based on the importance of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: strong rule</para>
        /// </description></item>
        /// <item><description><para>0: weak rule
        /// If you specify a rule as a strong rule and a critical alert is triggered for the rule, the scheduling of the associated task is blocked.</para>
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
        /// <para>The checker ID. You can call the <a href="https://help.aliyun.com/document_detail/173995.html">ListQualityRules</a> operation to query the checker ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("Checker")]
        [Validation(Required=false)]
        public int? Checker { get; set; }

        /// <summary>
        /// <para>The description of the quality rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Verify the number of table rows</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The threshold for a critical alert. The threshold specifies the deviation of a check result from the expected value. You can customize the threshold based on your business requirements. If you use a strong rule and a critical alert is triggered, the scheduling of the associated task is blocked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CriticalThreshold")]
        [Validation(Required=false)]
        public string CriticalThreshold { get; set; }

        /// <summary>
        /// <para>The ID of the partition filter expression. You can call the <a href="https://help.aliyun.com/document_detail/173995.html">ListQualityRules</a> operation to query the ID of the partition filter expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        /// <summary>
        /// <para>The expected value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("ExpectValue")]
        [Validation(Required=false)]
        public string ExpectValue { get; set; }

        /// <summary>
        /// <para>The rule ID. You can call the <a href="https://help.aliyun.com/document_detail/173995.html">ListQualityRules</a> operation to query the rule ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The name of the method used to collect sample data. Valid values: avg, count, sum, min, max, count_distinct, user_defined, table_count, table_size, table_dt_load_count, table_dt_refuseload_count, null_value, null_value/table_count, (table_count-count_distinct)/table_count, and table_count-count_distinct.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table_count</para>
        /// </summary>
        [NameInMap("MethodName")]
        [Validation(Required=false)]
        public string MethodName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable or disable the quality rule. This parameter specifies whether to run the quality rule in the production environment.</para>
        /// <list type="bullet">
        /// <item><description><para>true: The quality rule is triggered when the scheduling task that is associated with the output table of the rule runs.</para>
        /// </description></item>
        /// <item><description><para>false: The quality rule is not triggered when the scheduling task that is associated with the output table of the rule runs.</para>
        /// </description></item>
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
        /// <para>The comparison operator. Valid values: &gt;, &gt;=, =, !=, &lt;, and &lt;=.</para>
        /// <remarks>
        /// <para>This parameter is required if you set the Checker parameter to 9.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <remarks>
        /// </remarks>
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a dynamic threshold. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: no</para>
        /// </description></item>
        /// <item><description><para>2: yes</para>
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
        /// <para>The DataWorks workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>26</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the engine or data source. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Management page to obtain the name.</para>
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
        /// <para>The name of the quality rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The type of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: system template</para>
        /// </description></item>
        /// <item><description><para>1: custom SQL</para>
        /// </description></item>
        /// <item><description><para>2: custom template</para>
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
        /// <para>The variable settings that are inserted before a custom rule. The settings are in the format of x=a,y=b.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x=a,y=b</para>
        /// </summary>
        [NameInMap("TaskSetting")]
        [Validation(Required=false)]
        public string TaskSetting { get; set; }

        /// <summary>
        /// <para>The ID of the template that is used for the check. You can call the <a href="https://help.aliyun.com/document_detail/173995.html">ListQualityRules</a> operation to query the template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public int? TemplateId { get; set; }

        /// <summary>
        /// <para>The trend of the check result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>up: upward trend</para>
        /// </description></item>
        /// <item><description><para>down: downward trend</para>
        /// </description></item>
        /// <item><description><para>abs: absolute value</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>up</para>
        /// </summary>
        [NameInMap("Trend")]
        [Validation(Required=false)]
        public string Trend { get; set; }

        /// <summary>
        /// <para>The threshold for a warning alert. The threshold specifies the deviation of a check result from the expected value. You can customize the threshold based on your business requirements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("WarningThreshold")]
        [Validation(Required=false)]
        public string WarningThreshold { get; set; }

        /// <summary>
        /// <para>The filter condition or custom SQL statement that is used for the check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dt=$[yyyymmdd]</para>
        /// </summary>
        [NameInMap("WhereCondition")]
        [Validation(Required=false)]
        public string WhereCondition { get; set; }

    }

}
