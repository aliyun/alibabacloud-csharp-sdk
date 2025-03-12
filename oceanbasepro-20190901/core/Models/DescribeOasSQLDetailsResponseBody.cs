// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeOasSQLDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of the SQL execution plan.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeOasSQLDetailsResponseBodyData Data { get; set; }
        public class DescribeOasSQLDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_db</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>SQL text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select a from b</para>
            /// </summary>
            [NameInMap("Fulltext")]
            [Validation(Required=false)]
            public string Fulltext { get; set; }

            /// <summary>
            /// <para>Parameterized text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select a from b</para>
            /// </summary>
            [NameInMap("Statement")]
            [Validation(Required=false)]
            public string Statement { get; set; }

            /// <summary>
            /// <para>The table name related to the SQL.</para>
            /// </summary>
            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<string> Tables { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_user</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-<b><b>-</b></b>-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
