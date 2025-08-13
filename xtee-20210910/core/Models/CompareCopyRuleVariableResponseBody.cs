// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CompareCopyRuleVariableResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Result object.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public CompareCopyRuleVariableResponseBodyResultObject ResultObject { get; set; }
        public class CompareCopyRuleVariableResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Cumulative variable list</para>
            /// </summary>
            [NameInMap("CustVariableList")]
            [Validation(Required=false)]
            public List<CompareCopyRuleVariableResponseBodyResultObjectCustVariableList> CustVariableList { get; set; }
            public class CompareCopyRuleVariableResponseBodyResultObjectCustVariableList : TeaModel {
                /// <summary>
                /// <para>Description</para>
                /// 
                /// <b>Example:</b>
                /// <para>描述</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Variable ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1483</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Variable name</para>
                /// 
                /// <b>Example:</b>
                /// <para>dxkkLw8fe18</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Variable type</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELF_VELOCITY</para>
                /// </summary>
                [NameInMap("OutType")]
                [Validation(Required=false)]
                public string OutType { get; set; }

                /// <summary>
                /// <para>Title</para>
                /// 
                /// <b>Example:</b>
                /// <para>近1天账户登录设备数_bk4</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>Event field variables</para>
            /// </summary>
            [NameInMap("EventVariableList")]
            [Validation(Required=false)]
            public List<CompareCopyRuleVariableResponseBodyResultObjectEventVariableList> EventVariableList { get; set; }
            public class CompareCopyRuleVariableResponseBodyResultObjectEventVariableList : TeaModel {
                /// <summary>
                /// <para>Description</para>
                /// 
                /// <b>Example:</b>
                /// <para>描述</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Variable id</para>
                /// 
                /// <b>Example:</b>
                /// <para>375</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Variable name</para>
                /// 
                /// <b>Example:</b>
                /// <para>age</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Variable type</para>
                /// 
                /// <b>Example:</b>
                /// <para>NATIVE</para>
                /// </summary>
                [NameInMap("OutType")]
                [Validation(Required=false)]
                public string OutType { get; set; }

                /// <summary>
                /// <para>Title</para>
                /// 
                /// <b>Example:</b>
                /// <para>年龄</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>Custom variable list</para>
            /// </summary>
            [NameInMap("ExpressionVariableList")]
            [Validation(Required=false)]
            public List<CompareCopyRuleVariableResponseBodyResultObjectExpressionVariableList> ExpressionVariableList { get; set; }
            public class CompareCopyRuleVariableResponseBodyResultObjectExpressionVariableList : TeaModel {
                /// <summary>
                /// <para>Description</para>
                /// 
                /// <b>Example:</b>
                /// <para>描述</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Variable ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>2540</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Variable name</para>
                /// 
                /// <b>Example:</b>
                /// <para>ex_XheC9A382fe7</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Variable Type</para>
                /// 
                /// <b>Example:</b>
                /// <para>EXPRESSION</para>
                /// </summary>
                [NameInMap("OutType")]
                [Validation(Required=false)]
                public string OutType { get; set; }

                /// <summary>
                /// <para>Title</para>
                /// 
                /// <b>Example:</b>
                /// <para>手机号前7位</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>Name list variables</para>
            /// </summary>
            [NameInMap("NameListVariableList")]
            [Validation(Required=false)]
            public List<CompareCopyRuleVariableResponseBodyResultObjectNameListVariableList> NameListVariableList { get; set; }
            public class CompareCopyRuleVariableResponseBodyResultObjectNameListVariableList : TeaModel {
                /// <summary>
                /// <para>Description</para>
                /// 
                /// <b>Example:</b>
                /// <para>描述</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Variable id</para>
                /// 
                /// <b>Example:</b>
                /// <para>1987</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Variable name</para>
                /// 
                /// <b>Example:</b>
                /// <para>nl_UN8otElLb490</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Variable type</para>
                /// 
                /// <b>Example:</b>
                /// <para>NAME_LIST</para>
                /// </summary>
                [NameInMap("OutType")]
                [Validation(Required=false)]
                public string OutType { get; set; }

                /// <summary>
                /// <para>Title</para>
                /// 
                /// <b>Example:</b>
                /// <para>白名单</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>Custom Query Variable List</para>
            /// </summary>
            [NameInMap("QueryExpressionVariableList")]
            [Validation(Required=false)]
            public List<CompareCopyRuleVariableResponseBodyResultObjectQueryExpressionVariableList> QueryExpressionVariableList { get; set; }
            public class CompareCopyRuleVariableResponseBodyResultObjectQueryExpressionVariableList : TeaModel {
                /// <summary>
                /// <para>Description</para>
                /// 
                /// <b>Example:</b>
                /// <para>描述</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Variable ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>217</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Variable Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>ex_vcaoii1697</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Variable Type</para>
                /// 
                /// <b>Example:</b>
                /// <para>QUERY_EXPRESSION</para>
                /// </summary>
                [NameInMap("OutType")]
                [Validation(Required=false)]
                public string OutType { get; set; }

                /// <summary>
                /// <para>Title</para>
                /// 
                /// <b>Example:</b>
                /// <para>获取年龄</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>System variable list</para>
            /// </summary>
            [NameInMap("SystemVariableList")]
            [Validation(Required=false)]
            public List<CompareCopyRuleVariableResponseBodyResultObjectSystemVariableList> SystemVariableList { get; set; }
            public class CompareCopyRuleVariableResponseBodyResultObjectSystemVariableList : TeaModel {
                /// <summary>
                /// <para>Description</para>
                /// 
                /// <b>Example:</b>
                /// <para>描述</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Variable ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1003</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Variable name</para>
                /// 
                /// <b>Example:</b>
                /// <para>sl_S02sHLFT7818</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Variable type</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELF_BIND</para>
                /// </summary>
                [NameInMap("OutType")]
                [Validation(Required=false)]
                public string OutType { get; set; }

                /// <summary>
                /// <para>Title</para>
                /// 
                /// <b>Example:</b>
                /// <para>根据ip地址得到评分</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

    }

}
