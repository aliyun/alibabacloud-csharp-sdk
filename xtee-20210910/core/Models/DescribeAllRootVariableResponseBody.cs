// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeAllRootVariableResponseBody : TeaModel {
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
        /// <para>The returned object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeAllRootVariableResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeAllRootVariableResponseBodyResultObject : TeaModel {
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
            /// <para>年龄</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display type and group label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NATIVE</para>
            /// </summary>
            [NameInMap("displayType")]
            [Validation(Required=false)]
            public string DisplayType { get; set; }

            /// <summary>
            /// <para>The favorite flag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("favoriteFlag")]
            [Validation(Required=false)]
            public bool? FavoriteFlag { get; set; }

            /// <summary>
            /// <para>The field sorting order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("fieldRank")]
            [Validation(Required=false)]
            public long? FieldRank { get; set; }

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
            /// <para>The variable ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>497</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The input type of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STRING</para>
            /// </summary>
            [NameInMap("inputFieldType")]
            [Validation(Required=false)]
            public string InputFieldType { get; set; }

            /// <summary>
            /// <para>The inputs of the variable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>age</para>
            /// </summary>
            [NameInMap("inputs")]
            [Validation(Required=false)]
            public string Inputs { get; set; }

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
            /// <para>The maximum cross-sectional area of the check box.</para>
            /// </summary>
            [NameInMap("outputThreshold")]
            [Validation(Required=false)]
            public DescribeAllRootVariableResponseBodyResultObjectOutputThreshold OutputThreshold { get; set; }
            public class DescribeAllRootVariableResponseBodyResultObjectOutputThreshold : TeaModel {
                /// <summary>
                /// <para>The maximum value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("maxValue")]
                [Validation(Required=false)]
                public double? MaxValue { get; set; }

                /// <summary>
                /// <para>The minimum value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("minValue")]
                [Validation(Required=false)]
                public double? MinValue { get; set; }

            }

            /// <summary>
            /// <para>The data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAF</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

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

    }

}
