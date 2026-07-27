// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateQualityRuleRequest : TeaModel {
        /// <summary>
        /// <para>The strength of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: weak rule</para>
        /// </description></item>
        /// <item><description><para>1: strong rule</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BlockType")]
        [Validation(Required=false)]
        public int? BlockType { get; set; }

        /// <summary>
        /// <para>The ID of the checker. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>2: 7-day average fluctuation</para>
        /// </description></item>
        /// <item><description><para>3: 30-day average fluctuation</para>
        /// </description></item>
        /// <item><description><para>4: day-over-day comparison</para>
        /// </description></item>
        /// <item><description><para>5: week-over-week comparison</para>
        /// </description></item>
        /// <item><description><para>6: month-over-month comparison</para>
        /// </description></item>
        /// <item><description><para>7: 7-day variance fluctuation</para>
        /// </description></item>
        /// <item><description><para>8: 30-day variance fluctuation</para>
        /// </description></item>
        /// <item><description><para>9: comparison with a fixed value</para>
        /// </description></item>
        /// <item><description><para>10: fluctuation detection over 1, 7, and 30 days</para>
        /// </description></item>
        /// <item><description><para>11: comparison with the previous cycle</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("Checker")]
        [Validation(Required=false)]
        public int? Checker { get; set; }

        /// <summary>
        /// <para>The comments of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Verification</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The critical threshold. It indicates the deviation of the check result from the expected value. You can customize this threshold based on your business requirements. If a strong rule is used and a critical alert is triggered, the scheduling task is blocked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("CriticalThreshold")]
        [Validation(Required=false)]
        public string CriticalThreshold { get; set; }

        /// <summary>
        /// <para>The ID of the partition filter expression.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15224</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        /// <summary>
        /// <para>The expected value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ExpectValue")]
        [Validation(Required=false)]
        public string ExpectValue { get; set; }

        /// <summary>
        /// <para>The check method. If you use a custom SQL statement, set this parameter to <c>user_defined</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>count/table_count</para>
        /// </summary>
        [NameInMap("MethodName")]
        [Validation(Required=false)]
        public string MethodName { get; set; }

        /// <summary>
        /// <para>The comparison operator. Examples: <c>&gt;</c>, <c>&gt;=</c>, <c>=</c>, <c>&lt;&gt;</c>, <c>&lt;</c>, and <c>&lt;=</c>.</para>
        /// <remarks>
        /// <para>If you set the Checker parameter to 9, you must specify the Operator parameter.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PredictType")]
        [Validation(Required=false)]
        public int? PredictType { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Management page to obtain the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the compute engine or data source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>autotest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The field that is monitored by the rule. To perform a table-level check, set this parameter to <c>table_count</c> for the number of rows or <c>table_size</c> for the table size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table_id</para>
        /// </summary>
        [NameInMap("Property")]
        [Validation(Required=false)]
        public string Property { get; set; }

        /// <summary>
        /// <para>The data type of the field. For a table-level check, set this parameter to <c>table</c>. For a field-level check, set this parameter to a specific data type, such as <c>bigint</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bigint</para>
        /// </summary>
        [NameInMap("PropertyType")]
        [Validation(Required=false)]
        public string PropertyType { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        /// <summary>
        /// <para>The variable settings that are inserted before the custom rule. Format: x=a,y=b.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x=a,y=b</para>
        /// </summary>
        [NameInMap("TaskSetting")]
        [Validation(Required=false)]
        public string TaskSetting { get; set; }

        /// <summary>
        /// <para>The ID of the template.</para>
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
        /// <item><description><para><c>up</c>: upward trend</para>
        /// </description></item>
        /// <item><description><para><c>down</c>: downward trend</para>
        /// </description></item>
        /// <item><description><para><c>abs</c>: absolute value</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>abs</para>
        /// </summary>
        [NameInMap("Trend")]
        [Validation(Required=false)]
        public string Trend { get; set; }

        /// <summary>
        /// <para>The warning threshold. It indicates the deviation of the check result from the expected value. You can customize this threshold based on your business requirements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("WarningThreshold")]
        [Validation(Required=false)]
        public string WarningThreshold { get; set; }

        /// <summary>
        /// <para>The filter condition or custom SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table_id&gt;1</para>
        /// </summary>
        [NameInMap("WhereCondition")]
        [Validation(Required=false)]
        public string WhereCondition { get; set; }

    }

}
