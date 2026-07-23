// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListTablesResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Response data</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Tables&quot;:[{&quot;Name&quot;:&quot;my_table&quot;,&quot;Comment&quot;:&quot;测试事件表&quot;}],&quot;NextToken&quot;:&quot;10&quot;,&quot;Total&quot;:1}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTablesResponseBodyData Data { get; set; }
        public class ListTablesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Next page token</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>Table entities. Each element represents a specific table, including but not limited to information such as table name and table ID.</para>
            /// </summary>
            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<Table> Tables { get; set; }

            /// <summary>
            /// <para>Total count</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>API response message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>34AD682D-5B91-5773-8132-AA38C130****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether successful</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
