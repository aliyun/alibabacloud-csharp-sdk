// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeEventVariableTemplateBindResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeEventVariableTemplateBindResponseBodyResultObject ResultObject { get; set; }
        public class DescribeEventVariableTemplateBindResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The list of paid variables.</para>
            /// </summary>
            [NameInMap("chargeVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableTemplateBindResponseBodyResultObjectChargeVariables> ChargeVariables { get; set; }
            public class DescribeEventVariableTemplateBindResponseBodyResultObjectChargeVariables : TeaModel {
                /// <summary>
                /// <para>The variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The variable description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>描述</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The field type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>456</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NATIVE</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The list of free variables.</para>
            /// </summary>
            [NameInMap("freeVariables")]
            [Validation(Required=false)]
            public List<DescribeEventVariableTemplateBindResponseBodyResultObjectFreeVariables> FreeVariables { get; set; }
            public class DescribeEventVariableTemplateBindResponseBodyResultObjectFreeVariables : TeaModel {
                /// <summary>
                /// <para>The variable code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>age</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The variable description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>描述</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The field type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>234</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>age</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>年龄</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The variable type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NATIVE</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The template code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>register</para>
            /// </summary>
            [NameInMap("templateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>38</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

    }

}
