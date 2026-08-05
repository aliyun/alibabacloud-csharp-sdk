// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class CreateFunctionInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The creation parameters.</para>
        /// </summary>
        [NameInMap("createParameters")]
        [Validation(Required=false)]
        public List<CreateFunctionInstanceRequestCreateParameters> CreateParameters { get; set; }
        public class CreateFunctionInstanceRequestCreateParameters : TeaModel {
            /// <summary>
            /// <para>The parameter name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>config</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The parameter value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;DDL\&quot;: [{\&quot;table\&quot;: \&quot;schools\&quot;,\&quot;columns\&quot;: [{\&quot;column\&quot;: \&quot;class\&quot;,\&quot;column_des\&quot;: \&quot;班级\&quot;,\&quot;type\&quot;: \&quot;str\&quot;,\&quot;example\&quot;: [\&quot;高一3班\&quot;,\&quot;火箭班\&quot;],\&quot;value_mapping\&quot;: {}},{\&quot;column\&quot;: \&quot;school\&quot;,\&quot;column_des\&quot;: \&quot;学校\&quot;,\&quot;type\&quot;: \&quot;str\&quot;,\&quot;example\&quot;: [\&quot;清华大学\&quot;,\&quot;北京大学\&quot;],\&quot;value_mapping\&quot;: {}}]},{\&quot;table\&quot;: \&quot;students\&quot;,\&quot;columns\&quot;: [{\&quot;column\&quot;: \&quot;name\&quot;,\&quot;column_des\&quot;: \&quot;姓名\&quot;,\&quot;type\&quot;: \&quot;int\&quot;,\&quot;example\&quot;: [10002,100001],\&quot;value_mapping\&quot;: [[10002,100001],[\&quot;张三\&quot;,\&quot;李四\&quot;]]}]}],\&quot;foreign keys\&quot;:[\&quot;table.column_1=table2.column_2\&quot;,\&quot;table.column_1=table2.column_2\&quot;],\&quot;UDF\&quot;: [[\&quot;初始节点\&quot;,\&quot;aa\&quot;],[\&quot; (sub_action &gt;100095 or action = 0001) and station =100001\&quot;,\&quot;bbb\&quot;]],\&quot;Fewshot\&quot;: [{\&quot;query\&quot;: \&quot;叫张三的学生有多少\&quot;,\&quot;sql\&quot;: \&quot;SELECT COUNT(*) FROM students WHERE name = 10002\&quot;}]}</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The instance description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The configuration type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PAAS</description></item>
        /// <item><description>SAAS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PAAS</para>
        /// </summary>
        [NameInMap("functionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        /// <summary>
        /// <para>The configuration or model name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The service ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ops-query-analyze-nl2sql-001</description></item>
        /// <item><description>ops-embedding-dim-reduction-001: vector dimension reduction.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ops-query-analyze-nl2sql-001</para>
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

    }

}
