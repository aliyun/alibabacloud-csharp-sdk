// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeExpressionVariableVersionDetailResponseBody : TeaModel {
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
        /// <para>Returned object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeExpressionVariableVersionDetailResponseBodyResultObject ResultObject { get; set; }
        public class DescribeExpressionVariableVersionDetailResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Creation type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MORMAL</para>
            /// </summary>
            [NameInMap("createType")]
            [Validation(Required=false)]
            public string CreateType { get; set; }

            /// <summary>
            /// <para>Description information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>变量描述</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>@ex_GX9rrlTq4b67 + 1001</para>
            /// </summary>
            [NameInMap("expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            /// <summary>
            /// <para>Expression title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>@selfvariable_02 + 1001</para>
            /// </summary>
            [NameInMap("expressionTitle")]
            [Validation(Required=false)]
            public string ExpressionTitle { get; set; }

            /// <summary>
            /// <para>Expression variable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ex_GX9rrlTq4b67</para>
            /// </summary>
            [NameInMap("expressionVariable")]
            [Validation(Required=false)]
            public string ExpressionVariable { get; set; }

            /// <summary>
            /// <para>Field ranking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("fieldRank")]
            [Validation(Required=false)]
            public int? FieldRank { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1762409015000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>Modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1762409026000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>Custom variable primary key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>397625</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Invoke key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deInvokeSelfVariable_v1</para>
            /// </summary>
            [NameInMap("invokeKey")]
            [Validation(Required=false)]
            public string InvokeKey { get; set; }

            /// <summary>
            /// <para>Variable name, a uniquely generated identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ex_0kWIfZ27c525</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Outlier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SYS_ERROR</para>
            /// </summary>
            [NameInMap("outlier")]
            [Validation(Required=false)]
            public string Outlier { get; set; }

            /// <summary>
            /// <para>Variable return type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EXPRESSION</para>
            /// </summary>
            [NameInMap("outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            /// <summary>
            /// <para>Variable associated event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>de_awkhwh0314</para>
            /// </summary>
            [NameInMap("refObjId")]
            [Validation(Required=false)]
            public string RefObjId { get; set; }

            /// <summary>
            /// <para>Variable association type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EVENT_BY_EXPRESSION</para>
            /// </summary>
            [NameInMap("refObjType")]
            [Validation(Required=false)]
            public string RefObjType { get; set; }

            /// <summary>
            /// <para>Region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>Source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAF</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>Status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ENABLE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Variable title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>年龄</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>Variable type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EXPRESSION</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>User UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>151222xxxxxxxxxx</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            /// <summary>
            /// <para>Variable version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

    }

}
