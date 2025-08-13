// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeVariableBindDetailResponseBody : TeaModel {
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
        /// <para>Return object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeVariableBindDetailResponseBodyResultObject ResultObject { get; set; }
        public class DescribeVariableBindDetailResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Whether modification is allowed, default is false</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("allowModify")]
            [Validation(Required=false)]
            public bool? AllowModify { get; set; }

            /// <summary>
            /// <para>Variable definition ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("defineId")]
            [Validation(Required=false)]
            public long? DefineId { get; set; }

            /// <summary>
            /// <para>Variable definition title</para>
            /// 
            /// <b>Example:</b>
            /// <para>IP所在地_城市Code</para>
            /// </summary>
            [NameInMap("defineTitle")]
            [Validation(Required=false)]
            public string DefineTitle { get; set; }

            /// <summary>
            /// <para>Variable description information</para>
            /// 
            /// <b>Example:</b>
            /// <para>描述</para>
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
            /// <para>Variable ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>497</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Bound parameters.</para>
            /// </summary>
            [NameInMap("params")]
            [Validation(Required=false)]
            public List<DescribeVariableBindDetailResponseBodyResultObjectParams> Params { get; set; }
            public class DescribeVariableBindDetailResponseBodyResultObjectParams : TeaModel {
                /// <summary>
                /// <para>Event field name</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("eventFieldName")]
                [Validation(Required=false)]
                public string EventFieldName { get; set; }

                /// <summary>
                /// <para>Whether it is required, default is false</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                /// <summary>
                /// <para>Bound variable name</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("variableName")]
                [Validation(Required=false)]
                public string VariableName { get; set; }

            }

            /// <summary>
            /// <para>List of associated policies</para>
            /// </summary>
            [NameInMap("relationRules")]
            [Validation(Required=false)]
            public List<DescribeVariableBindDetailResponseBodyResultObjectRelationRules> RelationRules { get; set; }
            public class DescribeVariableBindDetailResponseBodyResultObjectRelationRules : TeaModel {
                /// <summary>
                /// <para>Policy rule ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>104566</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>Policy name</para>
                /// 
                /// <b>Example:</b>
                /// <para>营销风险识别</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>变量title</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
