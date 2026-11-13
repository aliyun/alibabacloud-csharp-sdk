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
        /// <item><description>0: weak rule</description></item>
        /// <item><description>1: strong rule</description></item>
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
        /// <item><description>2: 7-day average fluctuation</description></item>
        /// <item><description>3: 30-day average fluctuation</description></item>
        /// <item><description>4: 1-day cycle comparison</description></item>
        /// <item><description>5: 7-day cycle comparison</description></item>
        /// <item><description>6: 30-day cycle comparison</description></item>
        /// <item><description>7: 7-day variance fluctuation</description></item>
        /// <item><description>8: 30-day variance fluctuation</description></item>
        /// <item><description>9: comparison with a fixed value</description></item>
        /// <item><description>10: 1-day, 7-day, and 30-day fluctuation detection</description></item>
        /// <item><description>11: previous cycle comparison</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("Checker")]
        [Validation(Required=false)]
        public int? Checker { get; set; }

        /// <summary>
        /// <para>The description of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Verification</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The threshold for a critical alert, which indicates the degree of deviation from the expected sample value. You can customize this threshold based on your business requirements. If a strong rule is used and the critical threshold is triggered, the scheduling task is blocked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("CriticalThreshold")]
        [Validation(Required=false)]
        public string CriticalThreshold { get; set; }

        /// <summary>
        /// <para>The ID of the partition expression.</para>
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
        /// <para>The sampling method. If custom SQL is used, the value of this parameter is user_defined.</para>
        /// 
        /// <b>Example:</b>
        /// <para>count/table_count</para>
        /// </summary>
        [NameInMap("MethodName")]
        [Validation(Required=false)]
        public string MethodName { get; set; }

        /// <summary>
        /// <para>The comparison operator. Valid values include &gt;, &gt;=, =, ≠, &lt;, and &lt;=.</para>
        /// <remarks>
        /// <para>When Checker is set to 9, Operator is required.</para>
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
        /// <item><description>0: non-dynamic threshold</description></item>
        /// <item><description>2: dynamic threshold</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PredictType")]
        [Validation(Required=false)]
        public int? PredictType { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the workspace configuration page to obtain the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the engine or data source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>autotest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The column to which the rule applies. For table-level checks, the columns are table_count for the number of rows and table_size for the table size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table_id</para>
        /// </summary>
        [NameInMap("Property")]
        [Validation(Required=false)]
        public string Property { get; set; }

        /// <summary>
        /// <para>The type of the column. Enter table for table-level checks, or a data type such as bigint for column-level checks.</para>
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
        /// <item><description>0: system template rule</description></item>
        /// <item><description>1: custom SQL rule</description></item>
        /// <item><description>4: custom template rule</description></item>
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
        /// <para>The variable settings inserted before the custom rule. Format: x=a,y=b.</para>
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
        /// <item><description>up: upward trend</description></item>
        /// <item><description>down: downward trend</description></item>
        /// <item><description>abs: absolute value</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>abs</para>
        /// </summary>
        [NameInMap("Trend")]
        [Validation(Required=false)]
        public string Trend { get; set; }

        /// <summary>
        /// <para>The threshold for a warning alert, which indicates the degree of deviation from the expected sample value. You can customize this threshold based on your business requirements.</para>
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
