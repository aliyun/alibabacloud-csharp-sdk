// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeQueryVariableDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeQueryVariableDetailResponseBodyResultObject ResultObject { get; set; }
        public class DescribeQueryVariableDetailResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Data source code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds_vcaoii1697</para>
            /// </summary>
            [NameInMap("dataSourceCode")]
            [Validation(Required=false)]
            public long? DataSourceCode { get; set; }

            /// <summary>
            /// <para>Data source name</para>
            /// 
            /// <b>Example:</b>
            /// <para>名称数据源</para>
            /// </summary>
            [NameInMap("dataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// <para>Description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>变量描述</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Event code</para>
            /// 
            /// <b>Example:</b>
            /// <para>de_aszbjb7236</para>
            /// </summary>
            [NameInMap("eventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            /// <summary>
            /// <para>Expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT  AVG( $source )\nFROM ds_vcaoii1697 \nWHERE  $age &gt; 0</para>
            /// </summary>
            [NameInMap("expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            /// <summary>
            /// <para>Expression title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT  AVG( $source )\nFROM testCase\nWHERE  $age &gt; 0</para>
            /// </summary>
            [NameInMap("expressionTitle")]
            [Validation(Required=false)]
            public string ExpressionTitle { get; set; }

            /// <summary>
            /// <para>Expression variable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[96426]</para>
            /// </summary>
            [NameInMap("expressionVariable")]
            [Validation(Required=false)]
            public string ExpressionVariable { get; set; }

            /// <summary>
            /// <para>Variable ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>355</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Outlier</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("outlier")]
            [Validation(Required=false)]
            public string Outlier { get; set; }

            /// <summary>
            /// <para>Output results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DOUBLE</para>
            /// </summary>
            [NameInMap("outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            /// <summary>
            /// <para>Title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>自定义查询变量标题</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
