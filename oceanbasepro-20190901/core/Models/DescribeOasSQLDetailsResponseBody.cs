// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeOasSQLDetailsResponseBody : TeaModel {
        /// <summary>
        /// The list of the SQL execution plan.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeOasSQLDetailsResponseBodyData Data { get; set; }
        public class DescribeOasSQLDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// SQL text.
            /// </summary>
            [NameInMap("Fulltext")]
            [Validation(Required=false)]
            public string Fulltext { get; set; }

            /// <summary>
            /// Parameterized text.
            /// </summary>
            [NameInMap("Statement")]
            [Validation(Required=false)]
            public string Statement { get; set; }

            /// <summary>
            /// The table name related to the SQL.
            /// </summary>
            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<string> Tables { get; set; }

            /// <summary>
            /// The username.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
