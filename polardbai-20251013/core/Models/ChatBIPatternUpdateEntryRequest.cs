// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PolardbAI20251013.Models
{
    public class ChatBIPatternUpdateEntryRequest : TeaModel {
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
        /// <b>Example:</b>
        /// <para>1, 2, 3, ...</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>【课程名称】【授课状态】的课程有哪些？</para>
        /// </summary>
        [NameInMap("PatternDescription")]
        [Validation(Required=false)]
        public string PatternDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("PatternParams")]
        [Validation(Required=false)]
        public string PatternParams { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>查询课程名称为#{courseName}授课状态为#{status}的课程</para>
        /// </summary>
        [NameInMap("PatternQuestion")]
        [Validation(Required=false)]
        public string PatternQuestion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT course_name, course_time, course_location 
        /// FROM courses 
        /// WHERE 
        /// course_name=#{courseName} 
        /// AND status=#{statusCode}</para>
        /// </summary>
        [NameInMap("PatternSql")]
        [Validation(Required=false)]
        public string PatternSql { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polar4ai_nl2sql_pattern, polar4ai_nl2sql_pattern_1</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
