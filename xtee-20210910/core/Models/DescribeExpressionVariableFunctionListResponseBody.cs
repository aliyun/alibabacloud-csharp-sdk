// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeExpressionVariableFunctionListResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6E8817D5-5354-5953-84B1-D98379F036DC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeExpressionVariableFunctionListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeExpressionVariableFunctionListResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Description information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>描述</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Function name</para>
            /// 
            /// <b>Example:</b>
            /// <para>concat</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Maximum number of parameters</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("maxParamSize")]
            [Validation(Required=false)]
            public long? MaxParamSize { get; set; }

            /// <summary>
            /// <para>Minimum number of parameters</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("minParamSize")]
            [Validation(Required=false)]
            public long? MinParamSize { get; set; }

            /// <summary>
            /// <para>Parameter types</para>
            /// 
            /// <b>Example:</b>
            /// <para>*STRING</para>
            /// </summary>
            [NameInMap("paramTypes")]
            [Validation(Required=false)]
            public string ParamTypes { get; set; }

            /// <summary>
            /// <para>Whether it is directly invoked</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("redirect")]
            [Validation(Required=false)]
            public bool? Redirect { get; set; }

            /// <summary>
            /// <para>Method return types</para>
            /// 
            /// <b>Example:</b>
            /// <para>STRING</para>
            /// </summary>
            [NameInMap("returnTypes")]
            [Validation(Required=false)]
            public string ReturnTypes { get; set; }

            /// <summary>
            /// <para>Function value</para>
            /// 
            /// <b>Example:</b>
            /// <para>concat</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
