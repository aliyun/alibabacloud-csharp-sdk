// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateQualityRuleRequest : TeaModel {
        /// <summary>
        /// <para>The strength of the quality check rule. The strength indicates the importance of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: strong rule.</description></item>
        /// <item><description>0: weak rule.
        /// You can set important rules as strong rules based on your business requirements. If a strong rule is used and a red alert is triggered, the scheduling task is blocked.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BlockType")]
        [Validation(Required=false)]
        public int? BlockType { get; set; }

        /// <summary>
        /// <para>The checker ID.
        /// 2: 7-day average fluctuation.
        /// 3: 30-day average fluctuation.
        /// 4: 1-day cycle comparison.
        /// 5: 7-day cycle comparison.
        /// 6: 30-day cycle comparison.
        /// 7: 7-day variance fluctuation.
        /// 8: 30-day variance fluctuation.
        /// 9: comparison with a fixed value.
        /// 10: 1-, 7-, and 30-day fluctuation detection.
        /// 11: previous cycle comparison.
        /// You can call the <a href="https://help.aliyun.com/document_detail/173995.html">ListQualityRules</a> operation to obtain the checker ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("Checker")]
        [Validation(Required=false)]
        public int? Checker { get; set; }

        /// <summary>
        /// <para>The description of the quality check rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Verify the number of table rows</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The red alert threshold. This value indicates the degree of deviation from the expected sample value. You can customize this threshold based on your business requirements. If a strong rule is used and the red threshold is triggered, the scheduling task is blocked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CriticalThreshold")]
        [Validation(Required=false)]
        public string CriticalThreshold { get; set; }

        /// <summary>
        /// <para>The ID of the partition expression. You can call the <a href="https://help.aliyun.com/document_detail/173995.html">ListQualityRules</a> operation to obtain the partition expression ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        /// <summary>
        /// <para>The expected value of the check result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("ExpectValue")]
        [Validation(Required=false)]
        public string ExpectValue { get; set; }

        /// <summary>
        /// <para>The ID of the quality check rule. You can call the <a href="https://help.aliyun.com/document_detail/173995.html">ListQualityRules</a> operation to obtain the rule ID.</para>
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
        /// <para>The enabled or disabled status of the rule, which controls whether the quality rule runs in the production environment.</para>
        /// <list type="bullet">
        /// <item><description><para>true: When the scheduling task associated with the output table data of the data quality rule is executed, the quality rule check is triggered.</para>
        /// </description></item>
        /// <item><description><para>false: When the scheduling task associated with the output table data of the data quality rule is executed, the quality rule check is not triggered.</para>
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
        /// <para>The comparison operator. Valid values: &gt;, &gt;=, =, ≠, &lt;, and &lt;=.</para>
        /// <remarks>
        /// <para>When Checker is set to 9, Operator is a required parameter.</para>
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
        /// <para>Specifies whether the threshold is dynamic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: non-dynamic threshold.</description></item>
        /// <item><description>2: dynamic threshold.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PredictType")]
        [Validation(Required=false)]
        public int? PredictType { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>26</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the engine or data source. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the workspace management page to obtain the name.</para>
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
        /// <para>The type of the field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bigint</para>
        /// </summary>
        [NameInMap("PropertyType")]
        [Validation(Required=false)]
        public string PropertyType { get; set; }

        /// <summary>
        /// <para>The name of the quality check rule.</para>
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
        /// <item><description>0: system template rule.</description></item>
        /// <item><description>1: custom SQL rule.</description></item>
        /// <item><description>4: custom template rule.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        /// <summary>
        /// <para>The variable settings inserted before the custom rule, in the format of x=a,y=b.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x=a,y=b</para>
        /// </summary>
        [NameInMap("TaskSetting")]
        [Validation(Required=false)]
        public string TaskSetting { get; set; }

        /// <summary>
        /// <para>The ID of the check template. You can call the <a href="https://help.aliyun.com/document_detail/173995.html">ListQualityRules</a> operation to obtain the check template ID.</para>
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
        /// <item><description>up: upward trend.</description></item>
        /// <item><description>down: downward trend.</description></item>
        /// <item><description>abs: absolute value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>up</para>
        /// </summary>
        [NameInMap("Trend")]
        [Validation(Required=false)]
        public string Trend { get; set; }

        /// <summary>
        /// <para>The orange alert threshold. This value indicates the degree of deviation from the expected sample value. You can customize this threshold based on your business requirements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("WarningThreshold")]
        [Validation(Required=false)]
        public string WarningThreshold { get; set; }

        /// <summary>
        /// <para>The filter condition or custom SQL statement used by the check task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dt=$[yyyymmdd]</para>
        /// </summary>
        [NameInMap("WhereCondition")]
        [Validation(Required=false)]
        public string WhereCondition { get; set; }

    }

}
