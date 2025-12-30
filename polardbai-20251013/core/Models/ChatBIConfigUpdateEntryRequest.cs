// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PolardbAI20251013.Models
{
    public class ChatBIConfigUpdateEntryRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db_test</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>若formula_function为总销售额：SUM(销售额)，则在最终处理时，问题中的总销售额将采用SUM(销售额)公式作为附加信息一并进行处理。</para>
        /// </summary>
        [NameInMap("FormulaFunction")]
        [Validation(Required=false)]
        public string FormulaFunction { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public int? Id { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2ze454l20me07****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsFunctional")]
        [Validation(Required=false)]
        public int? IsFunctional { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>若query_function为{&quot;append&quot;:[&quot;一&quot;,&quot;二&quot;],&quot;delete&quot;:[&quot;？&quot;],&quot;replace&quot;:{&quot;张三&quot;:&quot;a&quot;,&quot;李四&quot;:&quot;b&quot;}}，则表示：当text_condition匹配时，在问题的结尾添加一和二，并删除问题中的？。最后，将问题中的张三替换为a，将李四替换为b。</para>
        /// <para>例如：
        /// 问题张三今年总销售额是多少？：在text_condition匹配时，会最终被处理为a今年总销售额是多少一二。
        /// 问题李四今年总销售额多少？：在text_condition匹配时，会最终被处理为b今年总销售额是多少一二。</para>
        /// </summary>
        [NameInMap("QueryFunction")]
        [Validation(Required=false)]
        public string QueryFunction { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>若sql_condition=students||student_courses&amp;&amp;!!courses，则表示：如果表students或表student_courses在SQL中，且表courses不在SQL中，则条件匹配。</para>
        /// <para>例如：
        /// SQL语句SELECT * FROM student_courses：条件匹配。
        /// SQL语句SELECT c.course_name FROM student_courses sc JOIN courses c ON sc.courses_id = c.id;：条件不匹配。</para>
        /// </summary>
        [NameInMap("SqlCondition")]
        [Validation(Required=false)]
        public string SqlCondition { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>若sql_function={&quot;replace&quot;:{&quot;status = &quot;请假&quot;&quot;:&quot;status = 0&quot;,&quot;status = &quot;出勤&quot;&quot;:&quot;status = 1&quot;}}，则表示：在sql_condition匹配的情况下，将SQL中的status = &quot;请假&quot;替换为status = 0，status = &quot;出勤&quot;替换为status = 1。</para>
        /// </summary>
        [NameInMap("SqlFunction")]
        [Validation(Required=false)]
        public string SqlFunction { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>若text_condition为张三||李四&amp;&amp;!!王五，则表示当问题包含张三，或者包含李四且不包含王五时，条件匹配。</para>
        /// <para>例如：
        /// 张三今年总销售额多少？：条件匹配。
        /// 李四今年总销售额多少？：条件匹配。
        /// 李四王五今年总销售额多少？：条件不匹配。</para>
        /// </summary>
        [NameInMap("TextCondition")]
        [Validation(Required=false)]
        public string TextCondition { get; set; }

    }

}
