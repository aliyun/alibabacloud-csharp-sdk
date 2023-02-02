// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSQLDetailsResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the SQL statement.
        /// </summary>
        [NameInMap("SQLDetails")]
        [Validation(Required=false)]
        public List<DescribeSQLDetailsResponseBodySQLDetails> SQLDetails { get; set; }
        public class DescribeSQLDetailsResponseBodySQLDetails : TeaModel {
            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// The SQL text.
            /// </summary>
            [NameInMap("SQLText")]
            [Validation(Required=false)]
            public string SQLText { get; set; }

            /// <summary>
            /// The username.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
